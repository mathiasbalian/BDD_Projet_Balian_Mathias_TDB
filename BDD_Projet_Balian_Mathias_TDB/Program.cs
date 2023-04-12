using MySql.Data.MySqlClient;
using System.Configuration;

namespace BDD_Projet_Balian_Mathias_TDB
{
    internal static class Program
    {
        public static MySqlConnection connection = new MySqlConnection("SERVER=localhost;PORT=3306;DATABASE=fleurs;UID=root;PASSWORD=root;");
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Connexion_Inscription());
        }


        /// <summary>
        /// M�thode permettant d'ajouter un ou plusieurs param�tres MySql � une commande
        /// </summary>
        /// <param name="command">La commande � laquelle on va ajouter les param�tres MySql</param>
        /// <param name="parameters">La liste des param�tres MySql � ajouter</param>
        public static void addParameters(MySqlCommand command, params MySqlParameter[] parameters)
        {
            foreach(MySqlParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }
        }
    }
}