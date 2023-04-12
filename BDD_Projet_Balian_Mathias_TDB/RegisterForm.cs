using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BDD_Projet_Balian_Mathias_TDB.Program;

namespace BDD_Projet_Balian_Mathias_TDB
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si l'utilisateur ferme le forms en utilisant le bouton "X"
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // On vérifie si l'email n'est pas déjà présent dans la base de données
            string queryCheckUser = "SELECT * FROM client WHERE courriel = @courriel;";
            MySqlCommand command = new MySqlCommand(queryCheckUser, connection);
            if (emailInput.Text.Length == 0)
            {
                MessageBox.Show("Merci de saisir un email");
                return;
            }

            addParametersToCommand(command, createCustomParameter("@courriel", emailInput.Text, MySqlDbType.VarChar));

            // Si l'utilisateur existe déjà 
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Courriel déjà existant. Veuillez en saisir un autre.");
                reader.Close();
                return;
            }
            reader.Close();

            // Insertion de l'utilisateur sinon
            string queryRegisterUser = "INSERT INTO client VALUES " +
                "(@courriel, @password, @lastName, @firstName, @phone, @adress, @creditCard, @fidelite)";
            // On vérifie qu'aucun champ ne soit null
            foreach (Control element in registerBox.Controls)
            {
                if (element.Name.Contains("Input") && element.Text.Length == 0)
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                    return;
                }
            }



        }
    }
}
