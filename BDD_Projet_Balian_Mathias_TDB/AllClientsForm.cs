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
    public partial class AllClientsForm : Form
    {
        private User user;
        private bool isUserActionClose = false; // Pour vérifier si le form est fermé à partir 
        // du bouton "X"
        private bool dateTimerPaused = false;


        public AllClientsForm(User user, DateTime date)
        {
            InitializeComponent();
            this.datePicker.Value = date;
            this.user = user;
            this.dateTimer.Start(); // Lancement du timer pour le défilement de la date
            getAllClients();
            getSelectedClients(this.allClientsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allClientsComboBox.Text));
        }


        private void AllClientsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dateTimer.Stop();
            // Si l'utilisateur ferme le forms en utilisant le bouton "X"
            if (e.CloseReason == CloseReason.UserClosing && !this.isUserActionClose)
            {
                closeApp();
            }
        }


        private void dateTimer_Tick(object sender, EventArgs e)
        {
            this.datePicker.Value = datePicker.Value.AddDays(1); // On ajoute un jour à la date
            updateOrdersState(this.datePicker.Value);
        }


        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (!this.dateTimerPaused)
            {
                this.dateTimer.Stop();
                this.dateTimerPaused = true;
                this.pauseButton.BackgroundImage = Properties.Resources.resume_icon;
                return;
            }
            this.dateTimer.Start();
            this.pauseButton.BackgroundImage = Properties.Resources.pause_icon;
            this.dateTimerPaused = false;
        }


        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (this.dateTimer.Interval > 1000)
            {
                this.dateTimer.Interval -= 1000; // On accélère la vitesse de défilement de la date
            }
        }


        private void backwardButton_Click(object sender, EventArgs e)
        {
            this.dateTimer.Interval += 500; // On ralentit la vitesse de défilement de la date
        }


        private void returnButton_Click(object sender, EventArgs e)
        {
            this.isUserActionClose = true;
            this.Hide();
            DashboardForm df = new DashboardForm(this.user, this.datePicker.Value);
            df.Show();
            this.Close();
        }


        private void allClientsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            getSelectedClients(this.allClientsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allClientsComboBox.Text));
        }


        private void clientsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if ((string)this.clientsGridView.Rows[e.RowIndex].Cells["email"].Value == "admin")
                {
                    MessageBox.Show("Suppression de ce client impossible car il s'agit d'un administrateur.");
                    return;
                }
                deleteClient((string)this.clientsGridView.Rows[e.RowIndex].Cells["email"].Value);
                MessageBox.Show($"Client {(string)this.clientsGridView.Rows[e.RowIndex].Cells["email"].Value} supprimé.");
                getAllClients();
                getSelectedClients(this.allClientsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allClientsComboBox.Text));
            }
        }


        private void createClient_Click(object sender, EventArgs e)
        {
            this.isUserActionClose = true;
            this.Hide();
            RegisterForm rf = new RegisterForm(this.datePicker.Value, true);
            rf.Show();
            this.Close();
        }


        #region Méthodes utiles

        /// <summary>
        /// Méthode permettant d'obtenir tous les clients
        /// </summary>
        private void getAllClients()
        {
            this.allClientsComboBox.Items.Clear();
            this.allClientsComboBox.Items.Add("Tous");
            string queryGetAllClients = "SELECT nom, prenom, email FROM client;";
            MySqlCommand command = new MySqlCommand(queryGetAllClients, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.allClientsComboBox.Items.Add($"{reader.GetString(0)} {reader.GetString(1)} | {reader.GetString(2)}");
            }
            reader.Close();
        }


        /// <summary>
        /// Méthode permettant d'obtenir le client (ou les clients si aucun spécifique précisé) correspondant à un email
        /// </summary>
        /// <param name="allClients">Si tous les clients sont sélectionnés ou non</param>
        private void getSelectedClients(bool allClients)
        {
            string queryGetSelectedClients;
            MySqlCommand command = new MySqlCommand("", connection);
            if (allClients)
            {
                queryGetSelectedClients = "SELECT email, nom, prenom, numTel, adresseFacturation, fidelite FROM client;";
            }
            else
            {
                queryGetSelectedClients = "SELECT email, nom, prenom, numTel, adresseFacturation, fidelite FROM client WHERE email = @clientEmail;";
                addParametersToCommand(command,
                                       createCustomParameter("@clientEmail", this.allClientsComboBox.Text.Split(" | ")[1], MySqlDbType.VarChar));

            }
            command.CommandText = queryGetSelectedClients;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            this.clientsGridView.DataSource = table;
            if (this.clientsGridView.Columns.Count == 6)
            {
                DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
                dataGridViewButtonColumn.Text = "Supprimer client";
                dataGridViewButtonColumn.Name = "Supprimer client";
                dataGridViewButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewButtonColumn.FlatStyle = FlatStyle.System;
                dataGridViewButtonColumn.DefaultCellStyle.BackColor = Color.RoyalBlue;
                dataGridViewButtonColumn.UseColumnTextForButtonValue = true;

                this.clientsGridView.Columns.Add(dataGridViewButtonColumn);
                foreach (DataGridViewColumn column in this.clientsGridView.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }


        /// <summary>
        /// Méthode permettant de supprimer un client
        /// </summary>
        /// <param name="clientEmail">L'email du client à supprimer</param>
        private void deleteClient(string clientEmail)
        {
            string queryDeleteClient = "DELETE FROM client WHERE email = @clientEmail;";
            MySqlCommand command = new MySqlCommand(queryDeleteClient, connection);
            addParametersToCommand(command,
                                   createCustomParameter("@clientEmail", clientEmail, MySqlDbType.VarChar));
            command.ExecuteNonQuery();
        }

        #endregion
    }
}
