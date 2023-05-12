using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
// On importe la classe Program qui contient les méthodes et les attributs utiles
// à l'entièreté de l'application
using static BDD_Projet_Balian_Mathias_TDB.Program;

namespace BDD_Projet_Balian_Mathias_TDB
{
    public partial class RegisterForm : Form
    {
        private bool isUserActionClose = false;
        private bool fromAdmin;
        private DateTime date;


        public RegisterForm(DateTime date, bool fromAdmin = false)
        {
            InitializeComponent();
            this.fromAdmin = fromAdmin;
            this.date = date;
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si l'utilisateur ferme le forms en utilisant le bouton "X"
            if (e.CloseReason == CloseReason.UserClosing && !this.isUserActionClose)
            {
                closeApp();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Insertion de l'utilisateur, on vérifie qu'aucun champ ne soit vide
            if (!inputsNotEmpty(lastNameInput, firstNameInput, phoneInput,
                emailInput, passwordInput, adressInput,
                cardInput)) // inputsNotEmpty est une méthode statique venant de la classe Program
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

            // On vérifie le format de l'email
            Regex regexEmail = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (!regexEmail.Match(emailInput.Text).Success)
            {
                MessageBox.Show("Mauvais format d'email.");
                return;
            }

            // On vérifie le format du téléphone
            Regex regexPhone = new Regex(@"^((\+)33|0)[1-9](\d{2}){4}$");
            if (!regexPhone.Match(phoneInput.Text).Success)
            {
                MessageBox.Show("Mauvais format de numéro de téléphone");
                return;
            }

            // On vérifie le format de la carte de crédit
            Regex regexCreditCard = new Regex(@"^4[0-9]{12}(?:[0-9]{3})?$");
            if (!regexCreditCard.Match(cardInput.Text).Success)
            {
                MessageBox.Show("Mauvais format de numéro de carte de crédit");
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
            if (!this.fromAdmin)
            {
                this.Hide();
                LoginForm lf = new LoginForm();
                this.isUserActionClose = true;
                lf.Show();
                this.Close();
            }
            else
            {
                this.isUserActionClose = true;
                this.Hide();
                AllClientsForm acf = new AllClientsForm(new User("admin", "admin", "admin", "admin", "9999", "admin", "9999", "", true), this.date);
                acf.Show();
                this.Close();
            }

        }



        private void returnButton_Click(object sender, EventArgs e)
        {
            if (!this.fromAdmin)
            {
                this.Hide();
                LoginForm lf = new LoginForm();
                this.isUserActionClose = true;
                lf.Show();
                this.Close();
            }
            else
            {
                this.isUserActionClose = true;
                this.Hide();
                AllClientsForm acf = new AllClientsForm(new User("admin", "admin", "admin", "admin", "9999", "admin", "9999", "", true), this.date);
                acf.Show();
                this.Close();
            }
            
        }


        #region Méthodes utiles

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

            MySqlDataReader reader = command.ExecuteReader();
            // Si la requête renvoie un client 
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        #endregion
    }
}
