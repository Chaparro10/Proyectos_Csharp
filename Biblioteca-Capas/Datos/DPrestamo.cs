using System;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.Entidades;

namespace Biblioteca.Datos
{
   public class DPrestamo
    {
        //OBTENER LOS PRESTAMOS
        public static DataTable ObtenPrestamo()
        {
            SqlDataReader Lector = null;
            DataTable Tabla = new DataTable();
            SqlConnection conexion = null;
            try
            {
                conexion = Conexion.crearConexion();
                string stringComando = "pa_SELECT_PRESTAMOS";
                SqlCommand Comand = new SqlCommand(stringComando, conexion);
                Lector = Comand.ExecuteReader();
                Tabla.Load(Lector);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        public static DataTable ObtenISBNPre()
        {
            SqlDataReader Lector = null;
            DataTable Tabla = new DataTable();
            SqlConnection conexion = null;
            try
            {
                conexion = Conexion.crearConexion();
                string stringComando = "pa_SELECT_ISBN_PRESTAR";
                SqlCommand Comand = new SqlCommand(stringComando, conexion);
                Lector = Comand.ExecuteReader();
                Tabla.Load(Lector);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        public static string BuscarCvePrestamo(int ClavePrestamo)
        {
            SqlConnection conexion = null;
            string Rpta = "";
            try
            {
                conexion = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("pa_EXISTE_CLAVE_PRESTAMO", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@valor", SqlDbType.Int).Value = ClavePrestamo;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@Existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(parExiste.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return Rpta;
        }
        //AGREGAR PRESTAMO
        public static string Agregar(Prestamo Prestar)
        {
            string Rpta = "";
            SqlConnection conexion = null;
            try
            {
                conexion = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("pa_INSERT_PRESTAMO", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                //INSERTAR
                comando.Parameters.AddWithValue("@ClavePrestamo", Prestar.PClavePrestamo);
                comando.Parameters.AddWithValue("@ISBN", Prestar.PIsbn);
                comando.Parameters.AddWithValue("@NombreUsuario", Prestar.PNombreUsuario);
                comando.Parameters.AddWithValue("Telefono",Prestar.PTelefono);
                comando.Parameters.AddWithValue("@TipoUsuario", Prestar.PTipoUsuario);
                

                comando.ExecuteNonQuery();
                Rpta = "OK";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return Rpta;
        }

       public static int  Cantidad = 1;

    }
}
