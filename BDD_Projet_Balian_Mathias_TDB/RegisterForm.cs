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
// On importe la classe Program qui contient les méthodes et les attributs utiles
// à l'entièreté de l'application
using static BDD_Projet_Balian_Mathias_TDB.Program;

namespace BDD_Projet_Balian_Mathias_TDB
{
    public partial class RegisterForm : Form
    {
        private bool isButtonClick = false;


        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si l'utilisateur ferme le forms en utilisant le bouton "X"
            if (e.CloseReason == CloseReason.UserClosing && !this.isButtonClick)
            {
                closeApp();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Insertion de l'utilisateur, on vérifie qu'aucun champ ne soit vide
            if (!inputsNotEmpty(lastNameInput, firstNameInput, phoneInput,
                emailInput, passwordInput, adressInput,
                cardInput))
            {
                MessageBox.Show("Merci de remplir tous les champs");
                return;
            }

            // On vérifie si un utilisateur avec le même email existe déjà
            if (emailAlreadyExists())
            {
                MessageBox.Show("Email déjà existant. Merci d'en saisir un autre");
                return;
            }

            // Ajout de l'utilisateur si toutes les vérifications ont été validées
            string queryRegisterUser = "INSERT INTO client VALUES " +
                "(@email, @password, @lastName, @firstName, @phone, @adress, @creditCard, @fidelite)";
            MySqlCommand command = new MySqlCommand(queryRegisterUser, connection);
            addParametersToCommand(command,
                createCustomParameter("@email", emailInput.Text, MySqlDbType.VarChar),
                createCustomParameter("@password", passwordInput.Text, MySqlDbType.VarChar),
                createCustomParameter("@lastName", lastNameInput.Text, MySqlDbType.VarChar),
                createCustomParameter("@firstName", firstNameInput.Text, MySqlDbType.VarChar),
                createCustomParameter("@phone", phoneInput.Text, MySqlDbType.VarChar),
                createCustomParameter("@adress", adressInput.Text, MySqlDbType.VarChar),
                createCustomParameter("@creditCard", cardInput.Text, MySqlDbType.VarChar),
                createCustomParameter("@fidelite", "", MySqlDbType.VarChar)
                );
            command.ExecuteNonQuery();
            MessageBox.Show("Inscription validée !");
            this.Hide();
            LoginForm lf = new LoginForm();
            this.isButtonClick = true;
            lf.Show();
            this.Close();
        }



        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            this.isButtonClick = true;
            lf.Show();
            this.Close();
        }


        /// <summary>
        /// Vérifie si un utilisateur un utilisateur avec le même email n'existe pas déjà
        /// dans la base de données
        /// </summary>
        /// <returns>True si l'utilisateur existe déjà, false sinon</returns>
        private bool emailAlreadyExists()
        {
            string queryCheckUser = "SELECT * FROM client WHERE email = @email;";
            MySqlCommand command = new MySqlCommand(queryCheckUser, connection);
            addParametersToCommand(command, createCustomParameter("@email", emailInput.Text, MySqlDbType.VarChar));

            // Si l'utilisateur existe déjà 
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }
    }
}
