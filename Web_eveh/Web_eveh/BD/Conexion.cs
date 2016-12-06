using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;

namespace Web_eveh.BD
{
    public class Conexion
    {

        public static OracleConnection conn;
        // Metodo para realizar la conexion a la base de datos */
        public static bool abrirConexion()
        {
            try
            {

                conn = new OracleConnection("Data Source=" + "escuela; User Id=escuela; Password=87654321" + "; PERSIST SECURITY INFO = True; ");
                //       abrimos la conexion */
                conn.Open();
                return true;

            }
            catch (Exception)//Si ocurre algun error
            {
                return false;
            }
        }

        // metodo para cerrar la conexion
        public static bool cerrarConexion()
        {
            try
            {
                conn.Close();
                return true;

            }
            catch (Exception)//Si se produjo algun error xd
            {

                return false;

            }
        }
    }
}
