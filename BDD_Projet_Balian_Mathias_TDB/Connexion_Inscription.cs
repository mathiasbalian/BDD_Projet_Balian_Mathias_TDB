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

namespace BDD_Projet_Balian_Mathias_TDB
{
    public partial class Connexion_Inscription : Form
    {
        public Connexion_Inscription()
        {
            InitializeComponent();
            Program.connection.Open();
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Connexion_Inscription_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.connection.Close();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM client WHERE courriel = @courriel and motDePasse = @password;";
            MySqlCommand command = new MySqlCommand(query, Program.connection);
            Program.addParameters(command, 
                new MySqlParameter("@courriel", emailInput.Text), 
                new MySqlParameter("@password", passwordInput.Text));

            MySqlDataReader reader = command.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("Utilisateur introuvable");
                return;
            }
            MessageBox.Show("Salut bravo");
        }
    }
}
