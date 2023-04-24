using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static BDD_Projet_Balian_Mathias_TDB.Program;

namespace BDD_Projet_Balian_Mathias_TDB
{
    public partial class LoginForm : Form
    {
        private bool isUserActionClose = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm rf = new RegisterForm();
            this.isUserActionClose = true;
            rf.Show();
            this.Close();
        }

        private void LoginFormClosed(object sender, FormClosedEventArgs e)
        {
            // Si l'utilisateur ferme le forms en utilisant le bouton "X"
            if (e.CloseReason == CloseReason.UserClosing && !this.isUserActionClose)
            {
                closeApp();
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            var existsUser = checkUserLoginExists();
            // On vérifie les informations de connection de l'utilisateur
            if (!existsUser.exists)
            {
                MessageBox.Show("Email ou mot de passe invalide");
                return;
            }

            // On connecte l'utilisateur sur son dashboard
            this.Hide();
            DashboardForm df = new DashboardForm(existsUser.user, DateTime.Now);
            this.isUserActionClose = true;
            df.Show();
            this.Close();
        }


        /// <summary>
        /// Vérifie les informations de connexion de l'utilisateur
        /// </summary>
        /// <returns>Un tuple contenant en première position un bool indiquant si les informations de connexion de l'utilisateur 
        /// n'existent pas déjà (true s'il existe déjà, false sinon) et en deuxième position un utilisateur 
        /// contenant les données de l'utilisateur déjà enregistré
        /// </returns>
        private (bool exists, User user) checkUserLoginExists()
        {
            string query = "SELECT * FROM client WHERE email = @email and motDePasse = @password;";
            MySqlCommand command = new MySqlCommand(query, connection);
            addParametersToCommand(command,
                createCustomParameter("@email", emailInput.Text, MySqlDbType.VarChar),
                createCustomParameter("@password", passwordInput.Text, MySqlDbType.VarChar));

            MySqlDataReader reader = command.ExecuteReader();
            // Si la requête n'a pas renvoyé de client
            if (!reader.Read())
            {
                reader.Close();
                return (false, new User());
            }
            string email = reader.GetString("email");
            string password = reader.GetString("motDePasse");
            string lastName = reader.GetString("nom");
            string firstName = reader.GetString("prenom");
            string phone = reader.GetString("numTel");
            string adress = reader.GetString("adresseFacturation");
            string creditCard = reader.GetString("carteCredit");
            string fidelite = reader.GetString("fidelite");

            reader.Close();
            return (true, new User(email, password, lastName, firstName, phone, adress, creditCard, fidelite, email == "admin"));
        }
    }
}
