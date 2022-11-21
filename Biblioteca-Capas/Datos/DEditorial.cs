using System;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.Entidades;


namespace Biblioteca.Datos
{
    public class DEditorial
    {
        public static DataTable ObtenEditorial()
        {
            SqlDataReader Lector = null;
            DataTable Tabla = new DataTable();
            SqlConnection conexion = null;
            try
            {
                conexion = Conexion.crearConexion();
                string stringComando = "pa_SELECT_EDITORIAL";
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
        public static string Agregar(Editorial Edi)
        {
            string Rpta = "";
            SqlConnection conexion = null;
            try
            {
                conexion = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("pa_INSERT_EDITORIAL", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                //INSERTAR
                comando.Parameters.AddWithValue("@NOMBRE", Edi.PNombreEdi);
                comando.Parameters.AddWithValue("@TELEFONO", Edi.PTelefono);
                comando.Parameters.AddWithValue("@EMAIL", Edi.PCorreo);
               

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

        public static string BuscarNombreEdi(string NombreEdi)
        {
            SqlConnection conexion = null;
            string Rpta = "";
            try
            {
                conexion = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("pa_EXISTE_NombreEdi", conexion);
                comando.CommandType = CommandType.StoredProcedure;


                comando.Parameters.Add("@Valor", SqlDbType.VarChar).Value = NombreEdi;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
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
    }
}
