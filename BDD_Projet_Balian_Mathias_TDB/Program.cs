using MySql.Data.MySqlClient;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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
            Application.Run(new App());
        }


        /// <summary>
        /// Permet d'ex�cuter du code avant d'appeler la fonction Application.Exit() depuis les
        /// autres forms
        /// </summary>
        public static void closeApp()
        {
            connection.Close();
            Application.Exit();
        }


        /// <summary>
        /// M�thode permettant d'ajouter un ou plusieurs param�tres MySql � une commande
        /// </summary>
        /// <param name="command">La commande � laquelle on va ajouter les param�tres MySql</param>
        /// <param name="parameters">La liste des param�tres MySql � ajouter</param>
        public static void addParametersToCommand(MySqlCommand command, params MySqlParameter[] parameters)
        {
            foreach(MySqlParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }
            // Ne retourne rien car command est pass�e en param�tre par r�f�rence et non par valeur
        }


        /// <summary>
        /// Permet de cr�er un MySqlParameter � partir d'un nom, d'une value et d'un dbType (il n'existe aucune surcharge du constructeur 
        /// MySqlParameter dans le package MySql.Data.MySqlClient permettant de faire cela).
        /// </summary>
        /// <param name="parameterName">Le nom du param�tre dans la commande</param>
        /// <param name="value">La valeur du param�tre</param>
        /// <param name="dbType">Le type du param�tre</param>
        /// <returns>Une instance de MySqlParameter</returns>
        public static MySqlParameter createCustomParameter(string parameterName, object value, MySqlDbType dbType)
        {
            MySqlParameter param = new MySqlParameter(parameterName, dbType);
            param.Value = value;
            return param;
        }


        /// <summary>
        /// V�rifie si les inputs pass�s en param�tre ne sont pas vides
        /// </summary>
        /// <param name="inputs">Liste des inputs � v�rifier</param>
        /// <returns>True si aucun des inputs sont vides, False si un seul input est vide</returns>
        public static bool inputsNotEmpty(params Control[] inputs)
        {
            foreach(Control input in inputs)
            {
                if(String.IsNullOrEmpty(input.Text))
                {
                    return false;
                }
            }
            return true;
        }

        
        /// <summary>
        /// M�thode permettant d'actualiser l'�tat des commandes (CPAV, CC, CAL, CL) 
        /// </summary>
        public static void updateOrdersState(DateTime date)
        {
            string queryUpdateOrders = "UPDATE commande SET etatCommande = etatCommande + 1 WHERE etatCommande = 'CC';";
            MySqlCommand command = new MySqlCommand(queryUpdateOrders, connection);
            command.ExecuteNonQuery();

            string queryUpdateOrders2 = "UPDATE commande SET etatCommande = etatCommande + 1 WHERE " +
                "date_format(@currentDate, '%Y-%m-%d') >= date_format(dateLivraison, '%Y-%m-%d') AND " +
                "etatCommande = @calOrderState;";
            command.CommandText = queryUpdateOrders2;
            addParametersToCommand(command, createCustomParameter("@currentDate", date.ToString("yyyy-MM-dd"), MySqlDbType.Date),
                                            createCustomParameter("@calOrderState", "CAL", MySqlDbType.VarChar));
            command.ExecuteNonQuery();
        }


        /// <summary>
        /// M�thode permettant d'actualiser les fid�lit�s de l'utilisateur actuel et de tous les autres clients de la base de donn�es
        /// </summary>
        /// <param name="user">L'utilisateur actuel de l'application</param>
        public static void updateClientsFidelityMonthly(User user)
        {
            // On met � jour la fid�lit� de l'objet User
            string getCurrentUserFidelity = "SELECT fidelite FROM client WHERE email = @userEmail AND email != 'admin';";
            MySqlCommand command = new MySqlCommand(getCurrentUserFidelity, connection);
            command.Parameters.Add(createCustomParameter("@userEmail", user.email, MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                if(reader.GetString(0) == "Bronze")
                {
                    user.fidelite = "";
                }
                else if(reader.GetString(0) == "Or")
                {
                    user.fidelite = "Bronze";
                }
            }
            reader.Close();

            // On met � jour la fid�lit� de tous les clients de la base de donn�e
            // De Bronze � aucune
            string updateAllClientsFidelity = "UPDATE client SET fidelite = '' WHERE fidelite = 'Bronze' AND email != 'admin';";
            command.CommandText = updateAllClientsFidelity;
            command.Parameters.Clear();
            command.ExecuteNonQuery();

            // De Or � Bronze
            updateAllClientsFidelity = "UPDATE client SET fidelite = 'Bronze' WHERE fidelite = 'Or' AND email != 'admin';";
            command.CommandText = updateAllClientsFidelity;
            command.ExecuteNonQuery();
        }
    }
}