using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_eveh.BD
{
    public class Consultas
    {
        public static void autentificarEnfermera(string usuario, string contrasena)
        {
            try
            {
                Cliente.RutaConexion();
                Cliente.Bdconexion.Open();

                OracleCommand Buscar = new OracleCommand();


                Buscar.Connection = Cliente.Bdconexion;

                PILOTOS piloto = new PILOTOS();

                Buscar.CommandText = "SELECT * FROM HR.enfermeras_agendamiento where contrasena like '" + contrasena + "' and usuario like '" + usuario + "'";
                OracleDataReader LEER = Buscar.ExecuteReader();

                if (LEER.HasRows)
                {



                    LEER.Read();
                    //Enfermera_agendamiento.Nom_usuario = LEER["NOM_USUARIO"] + "";
                    //Enfermera_agendamiento.Usuario = LEER["USUARIO"] + "";
                    //Enfermera_agendamiento.Contrasena = LEER["CONTRASENA"] + "";
                    //Enfermera_agendamiento.Usuario_admin = LEER["USUARIO_ADMIN"] + "";

                    Cliente.Bdconexion.Close();


                }
                else
                {
                    Cliente.Bdconexion.Close();


                }
            }
            catch (Exception)
            {
                Cliente.Bdconexion.Close();

                throw new System.ArgumentException("Ha ocurrido un Problema en la conexion con la Base de Datos");
            }


        }



        public static void autentificarAdministrador(string usu, string contra)
        {
            try
            {
                Cliente.RutaConexion();
                Cliente.Bdconexion.Open();

                OracleCommand Buscar = new OracleCommand();


                Buscar.Connection = Cliente.Bdconexion;



                Buscar.CommandText = "SELECT * FROM ADMINISTRADORES where CONTRASENA_ADMIN like '" + contra + "' and USUARIO_ADMIN like '" + usu + "'";
                OracleDataReader LEER = Buscar.ExecuteReader();

                if (LEER.HasRows)
                {



                    LEER.Read();
                    //Administrador.NombreAdministrador = LEER["NOMBRE_ADMIN"] + "";
                    //Administrador.Usuario_administrador = LEER["USUARIO_ADMIN"] + "";
                    //Administrador.ContraAdmin = LEER["CONTRASENA_ADMIN"] + "";

                    Cliente.Bdconexion.Close();


                }
                else
                {
                    Cliente.Bdconexion.Close();


                }
            }
            catch (Exception)
            {
                Cliente.Bdconexion.Close();

                throw new System.ArgumentException("Ha ocurrido un Problema en la conexion con la Base de Datos");
            }


        }



        public static string buscarPiloto(string id)
        {
            PILOTOS piloto = new PILOTOS();

            try
            {
                Cliente.RutaConexion();
                Cliente.Bdconexion.Open();

                OracleCommand Buscar = new OracleCommand();



                Buscar.Connection = Cliente.Bdconexion;
                Buscar.CommandText = "SELECT * FROM PILOTOS where id = '"+id+"'";
                OracleDataReader LEER = Buscar.ExecuteReader();
                if (LEER.HasRows)
                {


                    LEER.Read();

                    piloto.HORAS_VUELO = Decimal.Parse( LEER["HORAS_VUELO"] +"");
                    



                    Cliente.Bdconexion.Close();
                    return "horas de vuelo = "+ piloto.HORAS_VUELO;


                }
                else
                {

                    
                    Cliente.Bdconexion.Close();
                    return "no se encuentra";

                }
            }
            catch (Exception ex)
            {

                Cliente.Bdconexion.Close();
                return ex.Message;
                throw new Exception(ex.Message);
                
            }






            


        }



        //public static bool agregarCirugia(Cirugia newcirugia)
        //{
        //    Pabellon pabe = new Pabellon();




        //    // OracleConnection conne = new OracleConnection();

        //    // Conexion n = new Conexion();
        //    Conexion.abrirConexion();



        //    try
        //    {


        //        String sql = "";

        //        OracleCommand query;
        //        //conne = new OracleConnection("Data Source=" + "diego" + "; User Id=" + "hr" + "; Password=" + "hr" + ";");
        //        //conne.Open();

        //        sql = "INSERT INTO CIRUGIAS VALUES(";
        //        sql = sql + "'" + newcirugia.Num_cirugia + "','" + newcirugia.Descrip_cir + "','" + newcirugia.Tipo_ciru + "','" + newcirugia.Inter_quir + "','" + newcirugia.Estado_cir + "','" + newcirugia.Estado_desc + "',to_date('" + newcirugia.Fecha.ToShortDateString() + "','DD/MM/YYYY'),'" + Enfermera_agendamiento.Usuario + "'," + newcirugia.Cod_pab + ",'" + newcirugia.Rut + "','" + newcirugia.Hora + "') ";


        //        query = new OracleCommand(sql, Conexion.conn);
        //        query.ExecuteNonQuery();
        //        Conexion.cerrarConexion();
        //        return true;


        //    }
        //    catch (Exception)
        //    {


        //        Conexion.cerrarConexion();
        //        return false;
        //    }
        //}



        //public static bool agregarEnfermera_agendamiento()
        //{


        //    //OracleConnection conne = new OracleConnection();

        //    //Conexion n = new Conexion();



        //    try
        //    {


        //        String sql = "";

        //        OracleCommand query;
        //        //conne = new OracleConnection("Data Source=" + "diego" + "; User Id=" + "hr" + "; Password=" + "hr" + ";");
        //        //conne.Open();
        //        Conexion.abrirConexion();
        //        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! NO RECONOCE LOS ATRIBUTOS DE ENFERMERA!!!!!!!!!!!!!!!!!!!!!
        //        sql = "INSERT INTO Enfermeras_agendamiento VALUES(";

        //        sql = sql + "'" + Enfermera_agendamiento.Usuario + "','" + Enfermera_agendamiento.Contrasena + "','" + Enfermera_agendamiento.Nom_usuario + "','" + Enfermera_agendamiento.Usuario_admin + "') ";

        //        query = new OracleCommand(sql, Conexion.conn);
        //        query.ExecuteNonQuery();
        //        Conexion.cerrarConexion();
        //        return true;


        //    }
        //    catch (Exception)
        //    {


        //        Conexion.cerrarConexion();
        //        return false;
        //    }
        //}



        //public static List<Trabajador> buscarEquipoMedico(string num_cirugia)
        //{
        //    Trabajador trabajador = new Trabajador();
        //    List<Trabajador> lista = new List<Trabajador>();

        //    try
        //    {
        //        Cliente.RutaConexion();
        //        Cliente.Bdconexion.Open();

        //        OracleCommand Buscar = new OracleCommand();



        //        Buscar.Connection = Cliente.Bdconexion;
        //        Buscar.CommandText = "SELECT * FROM HR.equipo_medico where num_cirugia like '" + num_cirugia + "'";
        //        OracleDataReader LEER = Buscar.ExecuteReader();
        //        if (LEER.HasRows)
        //        {
        //            while (LEER.Read() == true)
        //            {
        //                LEER.Read();

        //                trabajador.Nom_trabajador = LEER["NOM_TRABAJADOR"] + "";
        //                trabajador.Cod_trabajador = int.Parse(LEER["COD_TRABAJADOR"] + "");

        //                lista.Add(trabajador);



        //                Cliente.Bdconexion.Close();
        //            }





        //        }
        //        else
        //        {

        //            Cliente.Bdconexion.Close();

        //        }
        //    }
        //    catch (Exception)
        //    {

        //        Cliente.Bdconexion.Close();

        //        throw new System.ArgumentException("Ha ocurrido un Problema en la conexion con la Base de Datos");
        //    }






        //    return lista;


        //}
    }
}