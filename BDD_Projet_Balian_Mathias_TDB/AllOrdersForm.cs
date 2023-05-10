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
    public partial class AllOrdersForm : Form
    {
        private User user;
        private bool isUserActionClose = false; // Pour vérifier si le form est fermé à partir 
        // du bouton "X"
        private bool dateTimerPaused = false;


        public AllOrdersForm(User user, DateTime date)
        {
            InitializeComponent();
            this.datePicker.Value = date;
            this.user = user;
            this.dateTimer.Start(); // Lancement du timer pour le défilement de la date
            getAllClients();
            getAllShops();
        }


        private void AllOrdersForm_Load(object sender, EventArgs e)
        {
            getOrders(true, true);
        }

        private void AllOrdersForm_FormClosing(object sender, FormClosingEventArgs e)
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
            int monthBefore = this.datePicker.Value.Month;
            this.datePicker.Value = datePicker.Value.AddDays(1); // On ajoute un jour à la date
            if (this.datePicker.Value.Month != monthBefore)
            {
                updateClientsFidelityMonthly(this.user);
                monthBefore = this.datePicker.Value.Month;
            }
            updateOrdersState(this.datePicker.Value);
            getOrders(this.allClientsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allClientsComboBox.Text),
                            this.allShopsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allShopsComboBox.Text));
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


        private void orderToCompleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.orderToCompleteCheckBox.Checked)
            {
                getOrdersToComplete(this.allClientsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allClientsComboBox.Text),
                            this.allShopsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allShopsComboBox.Text));
            }
            else
            {
                getOrders(this.allClientsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allClientsComboBox.Text),
                            this.allShopsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allShopsComboBox.Text));
            }
        }


        private void clientOrdersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if ((string)this.clientOrdersGridView.Rows[e.RowIndex].Cells["etatCommande"].Value == "CPAV")
                {
                    CompleteOrderForm cof = new CompleteOrderForm(this, (int)this.clientOrdersGridView.Rows[e.RowIndex].Cells["idCommande"].Value);
                    cof.Show();
                }
                else
                {
                    OrderDetails od = new OrderDetails((int)this.clientOrdersGridView.Rows[e.RowIndex].Cells["idCommande"].Value);
                    od.Show();
                }
            }
        }


        private void allClientsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(this.orderToCompleteCheckBox.Checked)
            {
                getOrdersToComplete(this.allClientsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allClientsComboBox.Text),
                            this.allShopsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allShopsComboBox.Text));
            }
            else
            {
                getOrders(this.allClientsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allClientsComboBox.Text),
                                this.allShopsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allShopsComboBox.Text));
            }
        }


        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            string queryDeleteOrder = $"DELETE FROM commande WHERE idCommande = {this.orderIdDeleteNumericBox.Value};";
            MySqlCommand command = new MySqlCommand(queryDeleteOrder, connection);
            command.ExecuteNonQuery();

            MessageBox.Show("Commande supprimée");
            getOrders(this.allClientsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allClientsComboBox.Text),
                            this.allShopsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allShopsComboBox.Text));
        }


        private void createCommandFromClientButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.allClientsComboBox.Text) || this.allClientsComboBox.Text == "Tous")
            {
                MessageBox.Show("Aucun utilisateur spécifique sélectionné.");
                return;
            }
            this.isUserActionClose = true;
            this.Hide();
            OrderForm of = new OrderForm(getUser(), this.datePicker.Value, true);
            of.Show();
            this.Close();
        }


        private void allShopsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.orderToCompleteCheckBox.Checked)
            {
                getOrdersToComplete(this.allClientsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allClientsComboBox.Text),
                            this.allShopsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allShopsComboBox.Text));
            }
            else
            {
                getOrders(this.allClientsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allClientsComboBox.Text),
                                this.allShopsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allShopsComboBox.Text));
            }
        }

        #region Méthodes utiles

        /// <summary>
        /// Méthode permettant d'obtenir tous les clients
        /// </summary>
        private void getAllClients()
        {
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
        /// Méthode permettant d'obtenir toutes les commandes, par client et / ou par magasin
        /// </summary>
        /// <param name="allClients">true Si on cherche les commandes de tous les clients, false si on cherche
        /// les commandes d'un seul client</param>
        /// <param name="allShops">true Si on cherche les commandes passées dans tous les magasins, false si on cherche
        /// les commandes d'un seul magasin</param>
        public void getOrders(bool allClients, bool allShops)
        {
            MySqlCommand command = new MySqlCommand("", connection);
            string queryGetOrders;
            if (allClients && allShops)
            {
                queryGetOrders = "SELECT idCommande, email, dateCommande, dateLivraison, etatCommande, nomMagasin " +
                "FROM commande NATURAL JOIN client ORDER BY email;";
                command.CommandText = queryGetOrders;
            }
            else if (allClients && !allShops)
            {
                queryGetOrders = "SELECT idCommande, email, dateCommande, dateLivraison, etatCommande, nomMagasin " +
                    "FROM commande NATURAL JOIN client NATURAL JOIN magasin WHERE nomMagasin = @shopName" +
                    " ORDER BY email;";
                command.CommandText = queryGetOrders;
                command.Parameters.Add(createCustomParameter("@shopName", this.allShopsComboBox.Text.Split(" | ")[0], MySqlDbType.VarChar));
            }
            else if (!allClients && allShops)
            {
                queryGetOrders = "SELECT idCommande, email, dateCommande, dateLivraison, etatCommande, nomMagasin " +
                    "FROM commande NATURAL JOIN client WHERE email = @email;";
                command.CommandText = queryGetOrders;
                command.Parameters.Add(createCustomParameter("@email", this.allClientsComboBox.Text.Split(" | ")[1], MySqlDbType.VarChar));
            }
            else if (!allClients && !allShops)
            {
                queryGetOrders = "SELECT idCommande, email, dateCommande, dateLivraison, etatCommande, nomMagasin " +
                    "FROM commande NATURAL JOIN client NATURAL JOIN magasin WHERE email = @email and nomMagasin = @shopName;";
                command.CommandText = queryGetOrders;
                addParametersToCommand(command, createCustomParameter("@shopName", this.allShopsComboBox.Text.Split(" | ")[0], MySqlDbType.VarChar),
                                       createCustomParameter("@email", this.allClientsComboBox.Text.Split(" | ")[1], MySqlDbType.VarChar));
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            this.clientOrdersGridView.DataSource = table;
            if (this.clientOrdersGridView.Columns.Count == 6)
            {
                DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
                dataGridViewButtonColumn.Name = "Actions";
                dataGridViewButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewButtonColumn.FlatStyle = FlatStyle.System;
                dataGridViewButtonColumn.DefaultCellStyle.BackColor = Color.RoyalBlue;

                this.clientOrdersGridView.Columns.Add(dataGridViewButtonColumn);
                foreach (DataGridViewColumn column in this.clientOrdersGridView.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

            }

            foreach (DataGridViewRow row in this.clientOrdersGridView.Rows)
            {
                if ((string)row.Cells["etatCommande"].Value == "CPAV")
                {

                    row.Cells["Actions"].Style.BackColor = Color.Red;
                    row.Cells["Actions"].Value = (string)"FINALISER";
                }
                else
                {
                    row.Cells["Actions"].Value = (string)"Détails commande";
                }
            }
        }


        /// <summary>
        /// Méthode permettant d'obtenir tous les magasins
        /// </summary>
        private void getAllShops()
        {
            this.allShopsComboBox.Items.Add("Tous");
            string queryGetAllShops = "SELECT nomMagasin, ville FROM magasin;";
            MySqlCommand command = new MySqlCommand(queryGetAllShops, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // On ajoute à la liste des magasins chaque magasin avec son nom et sa ville
                this.allShopsComboBox.Items.Add($"{reader.GetString(0)} | {reader.GetString(1)}");
            }
            reader.Close();
        }


        /// <summary>
        /// Méthode permettant d'obtenir une instance de la classe User à partir de l'utilisateur sélectionné
        /// </summary>
        /// <returns>Une instance de la classe User avec les informations de l'utilisateur sélectionné</returns>
        private User getUser()
        {
            string query = "SELECT * FROM client WHERE email = @email;";
            MySqlCommand command = new MySqlCommand(query, connection);
            addParametersToCommand(command,
                createCustomParameter("@email", this.allClientsComboBox.Text.Split(" | ")[1], MySqlDbType.VarChar));

            MySqlDataReader reader = command.ExecuteReader();
            // Si la requête n'a pas renvoyé de client
            if (!reader.Read())
            {
                reader.Close();
                return new User();
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
            return new User(email, password, lastName, firstName, phone, adress, creditCard, fidelite, email == "admin");
        }



        public void getOrdersToComplete(bool allClients, bool allShops)
        {
            MySqlCommand command = new MySqlCommand("", connection);
            string queryGetOrders;
            if (allClients && allShops)
            {
                queryGetOrders = "SELECT idCommande, email, dateCommande, dateLivraison, etatCommande, nomMagasin " +
                "FROM commande NATURAL JOIN client WHERE etatCommande = @orderState ORDER BY email;";
                command.CommandText = queryGetOrders;
            }
            else if (allClients && !allShops)
            {
                queryGetOrders = "SELECT idCommande, email, dateCommande, dateLivraison, etatCommande, nomMagasin " +
                    "FROM commande NATURAL JOIN client NATURAL JOIN magasin WHERE nomMagasin = @shopName AND etatCommande = @orderState" +
                    " ORDER BY email;";
                command.Parameters.Add(createCustomParameter("@shopName", this.allShopsComboBox.Text.Split(" | ")[0], MySqlDbType.VarChar));
                command.CommandText = queryGetOrders;
            }
            else if (!allClients && allShops)
            {
                queryGetOrders = "SELECT idCommande, email, dateCommande, dateLivraison, etatCommande, nomMagasin " +
                    "FROM commande NATURAL JOIN client WHERE email = @email AND etatCommande = @orderState;";
                command.Parameters.Add(createCustomParameter("@email", this.allClientsComboBox.Text.Split(" | ")[1], MySqlDbType.VarChar));
                command.CommandText = queryGetOrders;
            }
            else if (!allClients && !allShops)
            {
                queryGetOrders = "SELECT idCommande, email, dateCommande, dateLivraison, etatCommande, nomMagasin " +
                    "FROM commande NATURAL JOIN client NATURAL JOIN magasin WHERE email = @email and nomMagasin = @shopName AND etatCommande = @orderState;";
                command.Parameters.Add(createCustomParameter("@shopName", this.allShopsComboBox.Text.Split(" | ")[0], MySqlDbType.VarChar));
                command.Parameters.Add(createCustomParameter("@email", this.allClientsComboBox.Text.Split(" | ")[1], MySqlDbType.VarChar));
                command.CommandText = queryGetOrders;
            }
            command.Parameters.Add(createCustomParameter("@orderState", "CPAV", MySqlDbType.VarChar));

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            this.clientOrdersGridView.DataSource = table;
            if (this.clientOrdersGridView.Columns.Count == 6)
            {
                DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
                dataGridViewButtonColumn.Name = "Actions";
                dataGridViewButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewButtonColumn.FlatStyle = FlatStyle.System;
                dataGridViewButtonColumn.DefaultCellStyle.BackColor = Color.RoyalBlue;

                this.clientOrdersGridView.Columns.Add(dataGridViewButtonColumn);
                foreach (DataGridViewColumn column in this.clientOrdersGridView.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

            }

            foreach (DataGridViewRow row in this.clientOrdersGridView.Rows)
            {
                if ((string)row.Cells["etatCommande"].Value == "CPAV")
                {

                    row.Cells["Actions"].Style.BackColor = Color.Red;
                    row.Cells["Actions"].Value = (string)"FINALISER";
                }
                else
                {
                    row.Cells["Actions"].Value = (string)"Détails commande";
                }
            }
        }

        #endregion

    }

}
