﻿using System;
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
                string ErrorToMessage = e.Message;
                System.Windows.MessageBox.Show(ErrorToMessage);
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
        public List<string> hentProcesser()
        {
            List<string> returnlistProcesser = new List<string>();
            TilføjOrdre _tilføjOrdre = new TilføjOrdre();

            SqlConnection SqlConnection = new SqlConnection(
                "Server=ealdb1.eal.local;" +
                "Database=EJL06_DB;" +
                "User Id=ejl06_usr;" +
                "Password=Baz1nga6;");

            try
            {
                SqlConnection.Open();

                SqlCommand cmd = new SqlCommand("findProcesNavn", SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string procesNavn = ("" + sdr["ProcesNavn"]);
                    returnlistProcesser.Add(procesNavn);
                }
            }
            catch (SqlException)
            {

            }
            finally
            {
                SqlConnection.Close();
                SqlConnection.Dispose();
            }

            return returnlistProcesser;
        }
        public List<string> hentKunder()
        {
            List<string> returnlistKunder = new List<string>();
            TilføjOrdre _tilføjOrdre = new TilføjOrdre();

            SqlConnection SqlConnection = new SqlConnection(
                "Server=ealdb1.eal.local;" +
                "Database=EJL06_DB;" +
                "User Id=ejl06_usr;" +
                "Password=Baz1nga6;");

            try
            {
                SqlConnection.Open();

                SqlCommand cmd = new SqlCommand("findKundeNavn", SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string kundeNavn = ("" + sdr["Navn"]);
                    returnlistKunder.Add(kundeNavn);
                }
            }
            catch (SqlException)
            {

            }
            finally
            {
                SqlConnection.Close();
                SqlConnection.Dispose();
            }

            return returnlistKunder;

        }
        public List<string> hentStandard()
        {
            List<string> returnlistStandard = new List<string>();
            TilføjOrdre _tilføjOrdre = new TilføjOrdre();

            SqlConnection SqlConnection = new SqlConnection(
                "Server=ealdb1.eal.local;" +
                "Database=EJL06_DB;" +
                "User Id=ejl06_usr;" +
                "Password=Baz1nga6;");

            try
            {
                SqlConnection.Open();

                SqlCommand cmd = new SqlCommand("findStandard", SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string Titel = ("" + sdr["Titel"]);
                    returnlistStandard.Add(Titel);
                }
            }
            catch (SqlException)
            {

            }
            finally
            {
                SqlConnection.Close();
                SqlConnection.Dispose();
            }

            return returnlistStandard;

        }
        public List<string> hentOrdre()
        {
            List<string> returnlistOrdre = new List<string>();
            TilføjOrdre _tilføjOrdre = new TilføjOrdre();

            SqlConnection SqlConnection = new SqlConnection(
                "Server=ealdb1.eal.local;" +
                "Database=EJL06_DB;" +
                "User Id=ejl06_usr;" +
                "Password=Baz1nga6;");

            try
            {
                SqlConnection.Open();

                SqlCommand cmd = new SqlCommand("findOrdre", SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string ordre = ("" + sdr["Ordrenummer"]);
                    returnlistOrdre.Add(ordre);
                }
            }
            catch (SqlException)
            {

            }
            finally
            {
                SqlConnection.Close();
                SqlConnection.Dispose();
            }

            return returnlistOrdre;

        }
        public void regneMetode()
        {
            if (true)
            {
                
            }
        }
    }
}
    
        

