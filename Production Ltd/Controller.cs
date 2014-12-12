using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace Production_Ltd
{
    class Controller
    {
        
        public List<Ordre> returnlistOrdreID = new List<Ordre>();
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
        public void TilføjSpecialOrdre( string inputKunde,
                                        int inputAntal, 
                                        DateTime inputDeadline, 
                                        bool inputStansemaskine, 
                                        bool inputSvejsning,
                                        bool inputBukkemaskine,
                                        bool inputMontering,
                                        bool inputLaserCutter,
                                        bool inputCncFræser,
                                        bool inputMaskinsaks)
        {
            SpecialOrdre tilføjspecialordre = new SpecialOrdre();

            List<string> ProcesListe = new List<string>();
            if (inputStansemaskine == true)
            {
                string Proces = "Stansemaskine";
                ProcesListe.Add(Proces);
            }
            if (inputSvejsning == true)
            {
                string Proces = "Svejsemaskine";
                ProcesListe.Add(Proces);
            }
            if (inputBukkemaskine == true)
            {
                string Proces = "Bukkemaskine";
                ProcesListe.Add(Proces);
            }
            if (inputMontering == true)
            {
                string Proces = "Montering";
                ProcesListe.Add(Proces);
            }
            if (inputLaserCutter == true)
            {
                string Proces = "LasterCutter";
                ProcesListe.Add(Proces);
            }
            if (inputCncFræser == true)
            {
                string Proces = "CncFræser";
                ProcesListe.Add(Proces);
            }
            if (inputMaskinsaks == true)
            {
                string Proces = "Maskinsaks";
                ProcesListe.Add(Proces);
            }

            SqlConnection SqlConnection = new SqlConnection(
                "Server=ealdb1.eal.local;" +
                "Database=EJL06_DB;" +
                "User Id=ejl06_usr;" +
                "Password=Baz1nga6;");

            try
            {
                SqlCommand TilføjOrdre = new SqlCommand("TilføjSpecialordre", SqlConnection);
                TilføjOrdre.CommandType = CommandType.StoredProcedure;

                TilføjOrdre.Parameters.Add(new SqlParameter("@Kunde", inputKunde));

                TilføjOrdre.Parameters.Add(new SqlParameter("@Antal", inputAntal));

                TilføjOrdre.Parameters.Add(new SqlParameter("@Deadline", inputDeadline));

                bool Proces1 = false;
                bool Proces2 = false;
                bool Proces3 = false;
                bool Proces4 = false;
                bool Proces5 = false;
                bool Proces6 = false;
                bool Proces7 = false;

                foreach (string Proces in ProcesListe)
	            {
		            if (Proces1 == false)
	                {
                        TilføjOrdre.Parameters.Add(new SqlParameter("@Proces1", Proces));
                        Proces1 = true;
                    }
                    else if (Proces2 == false)
                    {
                        TilføjOrdre.Parameters.Add(new SqlParameter("@Proces2", Proces));
                        Proces2 = true;
                    }
                    else if (Proces3 == false)
                    {
                        TilføjOrdre.Parameters.Add(new SqlParameter("@Proces3", Proces));
                        Proces3 = true;
                    }
                    else if (Proces4 == false)
                    {
                        TilføjOrdre.Parameters.Add(new SqlParameter("@Proces4", Proces));
                        Proces4 = true;
                    }
                    else if (Proces5 == false)
                    {
                        TilføjOrdre.Parameters.Add(new SqlParameter("@Proces5", Proces));
                        Proces5 = true;
                    }
                    else if (Proces6 == false)
                    {
                        TilføjOrdre.Parameters.Add(new SqlParameter("@Proces6", Proces));
                        Proces6 = true;
                    }
                    else if (Proces7 == false)
                    {
                        TilføjOrdre.Parameters.Add(new SqlParameter("@Proces7", Proces));
                        Proces7 = true;
                    }

	            }

                if (Proces1 == false)
                {
                    TilføjOrdre.Parameters.Add(new SqlParameter("@Proces1", ""));
                    Proces1 = true;
                }
                if (Proces2 == false)
                {
                    TilføjOrdre.Parameters.Add(new SqlParameter("@Proces2", ""));
                    Proces2 = true;
                }
                if (Proces3 == false)
                {
                    TilføjOrdre.Parameters.Add(new SqlParameter("@Proces3", ""));
                    Proces3 = true;
                }
                if (Proces4 == false)
                {
                    TilføjOrdre.Parameters.Add(new SqlParameter("@Proces4", ""));
                    Proces4 = true;
                }
                if (Proces5 == false)
                {
                    TilføjOrdre.Parameters.Add(new SqlParameter("@Proces5", ""));
                    Proces5 = true;
                }
                if (Proces6 == false)
                {
                    TilføjOrdre.Parameters.Add(new SqlParameter("@Proces6", ""));
                    Proces6 = true;
                }
                if (Proces7 == false)
                {
                    TilføjOrdre.Parameters.Add(new SqlParameter("@Proces7", ""));
                    Proces7 = true;
                }


                SqlConnection.Open();
                TilføjOrdre.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("\n<Press Enter to go back to menu>");
                MessageBox.Show(e.Message);
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
        public void regneMetode(string standard, int antal)
        {
            int returnTid = 0;
            
            if (standard == "Standard 1")
            {
                returnTid = antal * (5 + 10);
            }
            if (standard == "Standard 2")
            {
                returnTid = antal * (5 + 10);
            }
            if (standard == "Standard 3")
            {
                returnTid = antal * (5 + 9);
            }
            if (standard == "Standard 4")
            {
                returnTid = antal * (8 + 10);
            }
            if (standard == "Standard 5")
            {
                returnTid = antal * (5 + 5 + 5);
            }
            if (standard == "Standard 6")
            {
                returnTid = antal * (10 + 9 + 10);
            }
            if (standard == "Standard 7")
            {
                returnTid = antal * (5 + 8 + 5);
            }
            if (standard == "Standard 8")
            {
                returnTid = antal * (10 + 10 + 9);
            }
            if (standard == "Standard 9")
            {
                returnTid = antal * (5 + 10 + 5 + 5);
            }
            if (standard == "Standard 10")
            {
                returnTid = antal * (10 + 8 + 5 + 10);
            }
            if (standard == "Standard 11")
            {
                returnTid = antal * (5 + 10 + 9 + 10 + 5);
            }
            if (standard == "Standard 12")
            {
                returnTid = antal * (5 + 10 + 5 + 10 + 5);
            }
            if (standard == "Standard 13")
            {
                returnTid = antal * (5 + 10 + 5 + 8 + 5 + 10);
            }
            if (standard == "Standard 14")
            {
                returnTid = antal * (5 + 10 + 9 + 8 + 5 + 10);
            }
            if (standard == "Standard 15")
            {
                returnTid = antal * (5 + 10 + 9 + 8 + 5 + 5 + 10);
            }

            MessageBox.Show("Estimeret tid: " + returnTid / 60 + " timer");         
        }
        public List<Ordre> hentOrdreID()
        {

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
                    Ordre OrdreInfo = new Ordre(Convert.ToString(sdr["Ordrenummer"]), Convert.ToString(sdr["Antal"]), Convert.ToString(sdr["Produkttype"]), Convert.ToString(sdr["Leveringsdato"]), Convert.ToString(sdr["Kunde"]));
                    returnlistOrdreID.Add(OrdreInfo);
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

            return returnlistOrdreID;

        }
    }
}
    
        

