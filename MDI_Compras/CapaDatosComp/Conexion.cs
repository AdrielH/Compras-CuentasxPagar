﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaDatosComp
{
    public class Conexion
    {
        OdbcConnection conexion;

        public Tuple<OdbcConnection, OdbcTransaction> iniciarConexion()
        {
            conexion = new OdbcConnection("Dsn=Navegador");
            conexion.Open();

            OdbcTransaction transaccion = conexion.BeginTransaction();

            return Tuple.Create(conexion, transaccion);
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }
    }
}
