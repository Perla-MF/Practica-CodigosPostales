using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;

namespace CodigosPostales
{
    public class Connection
    {
        private static SqlConnection cnx = new SqlConnection();

        private static void Connect()
        {
            try
            {
                cnx.ConnectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=codPostales; Integrated Security=True";
                cnx.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private static void Disconnect()
        {
            try
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al desconectar de la base de datos: " + ex.Message);
            }
        }

        public static DataTable SelectQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(query, cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }

    }
}
