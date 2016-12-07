using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_eveh.BD
{
    public class Consultas
    {
        public static USUARIOS autentificarUsuario(string usuario, string contrasena)
        {
            try
            {
                Cliente.RutaConexion();
                Cliente.Bdconexion.Open();

                OracleCommand Buscar = new OracleCommand();


                Buscar.Connection = Cliente.Bdconexion;

                USUARIOS usu = new USUARIOS();
                //crear piloto con contraseña conocida para ingresar
               Buscar.CommandText = "SELECT * FROM usuarios where pass like '" + contrasena + "' and cuenta like '" + usuario + "' and PERFILES_USUARIOS_ID > 2 and ESTADO_CUENTA ='activado'";

                //Buscar.CommandText = "SELECT * FROM usuarios where cuenta like '" + usuario + "' and PERFILES_USUARIOS_ID > 2 and ESTADO_CUENTA ='activado'";


                OracleDataReader LEER = Buscar.ExecuteReader();

                if (LEER.HasRows)
                {

                    
                    LEER.Read();
                    usu.CUENTA = LEER["CUENTA"]+"";
                    usu.PASS = LEER["PASS"]+"";
                    usu.ID = Decimal.Parse( LEER["ID"]+"");
                    
                    

                    Cliente.Bdconexion.Close();

                    return usu;
                }
                else
                {

                    Cliente.Bdconexion.Close();
                    return null;

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