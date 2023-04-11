using MySql.Data.MySqlClient;
using System.Configuration;

namespace BDD_Projet_Balian_Mathias_TDB
{
    internal static class Program
    {
        public static MySqlConnection? connection;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            string connectionSettings = "SERVER=localhost;PORT=3306;DATABASE=loueur;UID=root;PASSWORD=root;";
            connection = new MySqlConnection(connectionSettings);
            connection.Open();
            Application.Run(new Connexion_Inscription());
            connection.Close();
        }
    }
}