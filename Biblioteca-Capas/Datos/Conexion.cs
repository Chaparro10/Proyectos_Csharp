using System;
using System.Data.SqlClient;

using System.Threading.Tasks;
using System.Configuration;

namespace Biblioteca.Datos
{
   public class Conexion
    {
        public static SqlConnection crearConexion()
        {
            string strConn = GetConnectionString();
            // string CadenaConexion = "Data Source=DESKTOP-KMMJKKL\\KLOPEZ;Initial Catalog=Biblioteca;Integrated Security=True"
            SqlConnection conexion;
            try
            {
                conexion = LibreriaBD.UsoBD.ConectaBD(strConn);
            }
            catch (Exception ex)
            {
                conexion = null;
                throw ex;
            }
            return conexion;
        }


        public static string GetConnectionString()
        {
            string strConn = "";
            try
            {
                strConn = ConfigurationManager.ConnectionStrings["conStrBD"].ConnectionString;
            }
            catch(Exception )
            {
                throw;
            }
            return strConn;
        }
    }
   
}
