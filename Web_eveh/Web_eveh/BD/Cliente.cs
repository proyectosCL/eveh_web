using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_eveh.BD
{
     public class Cliente
    {
        /*Para Buscar*/
        private static OracleConnection bdconexion = new OracleConnection();

        public static OracleConnection Bdconexion
        {
            get { return Cliente.bdconexion; }
            set { Cliente.bdconexion = value; }
        }




        //LA RUTA DE LA CONEXION HACIA LA BASE DE DATOS DESDE EL METODO
        public static void RutaConexion()
        {

            Bdconexion.ConnectionString = "Data Source=" + "escuela; User Id=escuela; Password=87654321" + "; PERSIST SECURITY INFO = True; ";

            
        }
    }
}