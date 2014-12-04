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
        public void TilføjKunde(string inputNavn, string inputAdresse, int inputTelefonnummer, string inputKundeType)
        {
            TilføjKunde tilføjkunde = new TilføjKunde();
            
            SqlConnection SqlConnection = new SqlConnection(
                "Server=ealdb1.eal.local;" +
                "Database=EJL06_DB;" +
                "User Id=ejl06_usr;" +
                "Password=Baz1nga6;");

            try
            {
                SqlCommand TilføjKunde = new SqlCommand("opretKunde", SqlConnection);
                TilføjKunde.CommandType = CommandType.StoredProcedure;

                TilføjKunde.Parameters.Add(new SqlParameter("@Navn", inputNavn));

                TilføjKunde.Parameters.Add(new SqlParameter("@Adresse", inputAdresse));

                TilføjKunde.Parameters.Add(new SqlParameter("@Telefonnummer", inputTelefonnummer));

                TilføjKunde.Parameters.Add(new SqlParameter("@Kundetype", inputKundeType));

                SqlConnection.Open();
                TilføjKunde.ExecuteNonQuery();
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
        public void TilføjOrdre(int inputAntal, string inputProdukttype, DateTime inputLeveringsdato, string inputKunde)
        {
            TilføjOrdre tilføjordre = new TilføjOrdre();

            SqlConnection SqlConnection = new SqlConnection(
                "Server=ealdb1.eal.local;" +
                "Database=EJL06_DB;" +
                "User Id=ejl06_usr;" +
                "Password=Baz1nga6;");

            try
            {
                SqlCommand TilføjOrdre = new SqlCommand("opretOrdre", SqlConnection);
                TilføjOrdre.CommandType = CommandType.StoredProcedure;

                TilføjOrdre.Parameters.Add(new SqlParameter("@Antal", inputAntal));

                TilføjOrdre.Parameters.Add(new SqlParameter("@Produkttype", inputProdukttype));

                TilføjOrdre.Parameters.Add(new SqlParameter("@Leveringsdato", inputLeveringsdato));

                TilføjOrdre.Parameters.Add(new SqlParameter("@Kunde", inputKunde));

                SqlConnection.Open();
                TilføjOrdre.ExecuteNonQuery();
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
