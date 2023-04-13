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
        public LoginForm()
        {
            InitializeComponent();
            connection.Open();
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm rf = new RegisterForm(this);
            rf.ShowDialog();
        }

        private void LoginFormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // On vérifie les informations de connection de l'utilisateur
            if (!checkUserLoginExists())
            {
                MessageBox.Show("Email ou mot de passe invalide");
                return;
            }
            
            // On connecte l'utilisateur

        }


        /// <summary>
        /// Vérifie les informations de connexion de l'utilisateur
        /// </summary>
        /// <returns>Renvoie false si les informations sont incorrectes, true sinon</returns>
        private bool checkUserLoginExists()
        {
            string query = "SELECT * FROM client WHERE courriel = @courriel and motDePasse = @password;";
            MySqlCommand command = new MySqlCommand(query, connection);
            addParametersToCommand(command,
                createCustomParameter("@courriel", emailInput.Text, MySqlDbType.VarChar),
                createCustomParameter("@password", passwordInput.Text, MySqlDbType.VarChar));

            MySqlDataReader reader = command.ExecuteReader();
            if (!reader.Read())
            {
                reader.Close();
                return false;
            }
            reader.Close();
            return true;
        }
    }
}
