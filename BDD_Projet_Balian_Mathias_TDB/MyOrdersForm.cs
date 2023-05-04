using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class MyOrdersForm : Form
    {
        private User user;
        private bool isUserActionClose = false; // Pour vérifier si le form est fermé à partir 
        // du bouton "X"
        private bool dateTimerPaused = false;

        public MyOrdersForm(User user, DateTime currentDate)
        {
            InitializeComponent();
            this.user = user;
            this.datePicker.Value = currentDate;
            this.dateTimer.Start(); // Lancement du timer pour le défilement de la date
            getOrders();
        }


        private void MyOrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dateTimer.Stop();
            // Si l'utilisateur ferme le forms en utilisant le bouton "X"
            if (e.CloseReason == CloseReason.UserClosing && !this.isUserActionClose)
            {
                closeApp();
            }
        }


        private void returnButton_Click(object sender, EventArgs e)
        {
            this.isUserActionClose = true;
            this.Hide();
            DashboardForm df = new DashboardForm(this.user, this.datePicker.Value);
            df.Show();
            this.Close();
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


        private void dateTimer_Tick(object sender, EventArgs e)
        {
            this.datePicker.Value = datePicker.Value.AddDays(1); // On ajoute un jour à la date
        }


        private void ordersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                OrderDetails od = new OrderDetails((int)this.ordersGridView.Rows[e.RowIndex].Cells[1].Value);
                od.Show();
            }
        }


        #region Méthodes utiles

        /// <summary>
        /// Méthode permattant d'obtenir toutes les commandes passées par l'utilisateur actuel et de remplir le
        /// DataGridView du forms avec les informations de ces commandes
        /// </summary>
        private void getOrders()
        {
            string queryGetOrders = "SELECT idCommande, dateCommande, dateLivraison, etatCommande " +
                "FROM commande WHERE email = @userEmail;";

            MySqlCommand command = new MySqlCommand(queryGetOrders, connection);
            command.Parameters.Add(createCustomParameter("@userEmail", this.user.email, MySqlDbType.VarChar));
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            this.ordersGridView.DataSource = table;
            
            foreach (DataGridViewColumn column in this.ordersGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
            dataGridViewButtonColumn.Text = "Voir détails commande";
            dataGridViewButtonColumn.Name = "Détails";
            dataGridViewButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewButtonColumn.FlatStyle = FlatStyle.System;
            dataGridViewButtonColumn.DefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            this.ordersGridView.Columns.Add(dataGridViewButtonColumn);
        }

        #endregion

    }
}
