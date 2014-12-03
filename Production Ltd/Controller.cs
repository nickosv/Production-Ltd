using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Production_Ltd
{
    class Controller
    {
        static void TilføjKunde()
        {
            SqlConnection SqlConnection = new SqlConnection(
                "Server=ealdb1.eal.local;" +
                "Database=EJL06_DB;" +
                "User Id=ejl06_usr;" +
                "Password=Baz1nga6;");

            try
            {
                SqlCommand TilføjKunde = new SqlCommand("opretKunde", SqlConnection);
                TilføjKunde.CommandType = CommandType.StoredProcedure;

                TilføjKunde.Parameters.Add(new SqlParameter("@AddressLine1", Console.ReadLine()));



                SqlConnection.Open();
                TilføjKunde.ExecuteNonQuery();
                Console.WriteLine("Added successfully");
                Console.WriteLine("\n<Press Enter to go back to menu>");
                Console.ReadKey();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("\n<Press Enter to go back to menu>");
                Console.ReadKey();
            }
            finally
            {
                SqlConnection.Close();
                SqlConnection.Dispose();
            }
        }
    }
}
