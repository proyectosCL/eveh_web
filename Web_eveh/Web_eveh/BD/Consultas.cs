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
        public static string mostrar_horas_piloto_avion(string cuenta)
        {
            PILOTOS piloto = new PILOTOS();
            PERSONAS person = new PERSONAS();
            USUARIOS usu = new USUARIOS();
            LICENCIAS licen = new LICENCIAS();
            string nombre;
            string apellidos;
            string rut;
            string horas_vuelo;

            try
            {
                Cliente.RutaConexion();
                Cliente.Bdconexion.Open();

                OracleCommand Buscar = new OracleCommand();



                Buscar.Connection = Cliente.Bdconexion;
                Buscar.CommandText = "Select  personas.NOMBRE, personas.APELLIDOS, personas.RUT, licencias.HORAS_VUELO from usuarios join personas on usuarios.id = personas.usuarios_id join pilotos on personas.ID = pilotos.PERSONAS_ID join licencias on pilotos.ID=licencias.PILOTOS_ID where usuarios.CUENTA = '"+cuenta+"'";
                OracleDataReader LEER = Buscar.ExecuteReader();
                if (LEER.HasRows)
                {


                    LEER.Read();
                    
                    nombre = "Nombre: "+LEER["NOMBRE"] + " ";
                    apellidos = LEER["APELLIDOS"] + " ";
                    rut = "Rut: "+LEER["RUT"] + " ";
                    horas_vuelo = "Horas de vuelo: "+LEER["HORAS_VUELO"] + "";
                    Cliente.Bdconexion.Close();
                    return nombre + apellidos + rut + horas_vuelo;
                    

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