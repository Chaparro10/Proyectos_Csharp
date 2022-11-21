using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.Entidades;

namespace Biblioteca.Datos
{
    public class DLibro
    {
        public static DataTable ObtenLibros()
        {
            SqlDataReader Lector = null;
            DataTable Tabla = new DataTable();
            SqlConnection conexion = null;
            try
            {
                conexion = Conexion.crearConexion();
                string stringComando = "pa_SELECT_LIBROS";
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
        public static string BuscarNombreLibro(string nombreLibro)
        {
            SqlConnection conexion = null;
            string Rpta = "";
            try
            {
                conexion = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("pa_Libro_ExisteNombreLibro", conexion);
                comando.CommandType = CommandType.StoredProcedure;


                comando.Parameters.Add("@nombreLibro", SqlDbType.VarChar).Value=nombreLibro;
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
        public static string BuscarIsbn(string ISBN)
        {
            SqlConnection conexion = null;
            string Rpta = "";
            try
            {
                conexion = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("pa_Libro_ExisteISBN", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = ISBN;
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

        public static string Agregar(Libro libro)
        {
            string Rpta = "";
            SqlConnection conexion = null;
            try
            {
                conexion = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("pa_INSERT_LIBROS", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                //INSERTAR
                comando.Parameters.AddWithValue("@ISBN",libro.PIsbn);
                comando.Parameters.AddWithValue("@NombreLibro", libro.PNombreLibro);
                comando.Parameters.AddWithValue("@Autor", libro.Pautor);
                comando.Parameters.AddWithValue("@Existencia", libro.PExistencia);
                comando.Parameters.AddWithValue("@Editorial", libro.PEditorial);
                comando.Parameters.AddWithValue("@Consulta", libro.PConsulta);
                comando.Parameters.AddWithValue("@TipoPrestamo", libro.PPrestarA);
                
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

        public static DataTable BuscarLi(string buscaNombre)
        {
            SqlDataReader Lector = null;
            DataTable Tabla = new DataTable();
            SqlConnection conexion = null;

            try
            {
                conexion = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("pa_BUSCAR_LIBROS", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Valor", SqlDbType.VarChar).Value = buscaNombre;

                comando.ExecuteNonQuery();

                Lector = comando.ExecuteReader();
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

        public static string Actualizar(Libro libro)
        {
            string Rpta = "";
            SqlConnection conexion = null;
            try
            {
                conexion = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("pa_UPDATE_LIBROS", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                //UPDATE
                comando.Parameters.AddWithValue("@ISBN", libro.PIsbn);
                comando.Parameters.AddWithValue("@NombreLibro",libro.PNombreLibro);
                comando.Parameters.AddWithValue("@Autor", libro.Pautor);
                comando.Parameters.AddWithValue("@Existencia", libro.PExistencia);
                comando.Parameters.AddWithValue("@Editorial", libro.PEditorial);
                comando.Parameters.AddWithValue("@Consulta", libro.PConsulta);

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
        public static string Eliminar(Libro libro)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("pa_DELETE_LIBROS", conn);
                comando.CommandType = CommandType.StoredProcedure;
                //insertar
                comando.Parameters.AddWithValue("@ISBN", libro.PIsbn);
                comando.ExecuteNonQuery();
                Rpta = "OK";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return Rpta;
        }
    }
          
           
 }
      


