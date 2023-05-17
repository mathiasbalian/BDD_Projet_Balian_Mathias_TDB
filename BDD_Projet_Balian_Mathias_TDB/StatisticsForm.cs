using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BDD_Projet_Balian_Mathias_TDB.Program;

namespace BDD_Projet_Balian_Mathias_TDB
{
    public partial class StatisticsForm : Form
    {
        private User user;
        private bool isUserActionClose = false; // Pour vérifier si le form est fermé à partir 
        // du bouton "X"
        private bool dateTimerPaused = false;


        public StatisticsForm(User user, DateTime date)
        {
            InitializeComponent();
            this.datePicker.Value = date;
            this.user = user;
            this.dateTimer.Start(); // Lancement du timer pour le défilement de la date
            getBestMonthClient();
            getBestYearClient();
            getAverageOrderPrice();
            getMostFamousBouquetStandard();
            getMostCAShop();
            getMostOrderedFlower();
            getMostOrderedAccessory();
            compareCA();
            getSuperClients();
        }


        private void StatisticsForm_FormClosing(object sender, FormClosingEventArgs e)
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
                getBestMonthClient();
            }
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


        private void statisticsDatePicker_ValueChanged(object sender, EventArgs e)
        {
            getBestMonthClient();
            getBestYearClient();
        }


        private void informationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il s'agit de la liste des clients ayant réalisé une commande dont le prix" +
                " est plus de 2 fois supérieur à la moyenne des prix des commandes.");
        }


        #region Méthodes utiles

        /// <summary>
        /// Méthode permettant d'obtenir le meilleur client du mois en fonction de la date sélectionnée
        /// </summary>
        private void getBestMonthClient()
        {
            this.trueBestMonthClientLabel.Text = "";
            string queryGetBestMonthClient = "SELECT nom, prenom, email FROM commande NATURAL JOIN client " +
                "WHERE date_format(commande.dateCommande, '%Y-%m') = @currentDate group by email " +
                "HAVING count(email) >= all(SELECT count(email) FROM commande GROUP BY email);";
            MySqlCommand command = new MySqlCommand(queryGetBestMonthClient, connection);
            addParametersToCommand(command, createCustomParameter("@currentDate", this.statisticsDatePicker.Value.ToString("yyyy-MM"), MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    this.trueBestMonthClientLabel.Text += $"{reader.GetString(0)} {reader.GetString(1)} | ";
                }
            }
            reader.Close();
            if (this.trueBestMonthClientLabel.Text.Length >= 3)
            {
                this.trueBestMonthClientLabel.Text = this.trueBestMonthClientLabel.Text.Remove(this.trueBestMonthClientLabel.Text.Length - 3, 2);
            }
        }


        /// <summary>
        /// Méthode permettant d'obtenir le meilleur client de l'année selon la date choisie
        /// </summary>
        private void getBestYearClient()
        {
            this.trueBestYearClientLabel.Text = "";
            string queryGetBestMonthClient = "SELECT nom, prenom, email FROM commande NATURAL JOIN client " +
                "WHERE date_format(commande.dateCommande, '%Y') = @currentDate group by email " +
                "HAVING count(email) >= all(SELECT count(email) FROM commande GROUP BY email);";
            MySqlCommand command = new MySqlCommand(queryGetBestMonthClient, connection);
            addParametersToCommand(command, createCustomParameter("@currentDate", this.statisticsDatePicker.Value.ToString("yyyy"), MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    this.trueBestYearClientLabel.Text += $"{reader.GetString(0)} {reader.GetString(1)} | ";
                }
            }
            reader.Close();
            if (this.trueBestYearClientLabel.Text.Length >= 3)
            {
                this.trueBestYearClientLabel.Text = this.trueBestYearClientLabel.Text.Remove(this.trueBestYearClientLabel.Text.Length - 3, 2);
            }
        }


        /// <summary>
        /// Méthode permettant d'obtenir le prix moyen des commandes
        /// </summary>
        private void getAverageOrderPrice()
        {
            string queryGetAverageOrderPrice = "SELECT avg(prixTotal) FROM commande;";
            MySqlCommand command = new MySqlCommand(queryGetAverageOrderPrice, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read() && !reader.IsDBNull(0))
            {
                this.trueAverageOrderPriceLabel.Text = $"{Decimal.Round(reader.GetDecimal(0), 2)}€";
            }
            reader.Close();
        }


        /// <summary>
        /// Méthode permettant d'obtenir le magasin réalisant le plus de chiffre d'affaires
        /// </summary>
        private void getMostCAShop()
        {
            string queryGetMostCAShop = "SELECT nomMagasin, ville FROM commande NATURAL JOIN magasin " +
                "GROUP BY nomMagasin, ville HAVING sum(prixTotal) >= all(SELECT sum(prixTotal) " +
                "FROM commande GROUP BY nomMagasin);";
            MySqlCommand command = new MySqlCommand(queryGetMostCAShop, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    this.trueMostCAShopLabel.Text = $"{reader.GetString(0)} | {reader.GetString(1)}";
                }
            }
            reader.Close();
        }


        /// <summary>
        /// Méthode permettant d'obtenir le bouquet standard le plus commandé
        /// </summary>
        private void getMostFamousBouquetStandard()
        {
            string queryGetMostFamousBouquetStandard = "SELECT nomBouquet FROM commande NATURAL JOIN arrangementFloral " +
                "GROUP BY nomBouquet HAVING " +
                "count(nomBouquet) >= all(SELECT count(nomBouquet) FROM commande NATURAL JOIN arrangementFloral GROUP BY nomBouquet); ";
            MySqlCommand command = new MySqlCommand(queryGetMostFamousBouquetStandard, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    this.trueMostFamousBouquetStandardLabel.Text = reader.GetString(0);
                    this.mostFamousBouquetStandardPictureBox.Visible = true;
                    this.trueMostFamousBouquetStandardLabel.Visible = true;
                }
            }
            reader.Close();
            this.mostFamousBouquetStandardPictureBox.BackgroundImage =
                Properties.Resources.ResourceManager.GetObject(OrderForm.getImageNameFromItemName(this.trueMostFamousBouquetStandardLabel.Text)) as Image;
        }


        /// <summary>
        /// Méthode permettant d'obtenir la fleur les plus commandées
        /// </summary>
        private void getMostOrderedFlower()
        {
            string queryGetMostOrderedFlower = "SELECT nomFleur FROM bouquetpersocontientfleur NATURAL JOIN fleur " +
                "GROUP BY nomFleur " +
                "HAVING sum(quantiteFleur) >= all(SELECT sum(quantiteFleur) FROM bouquetpersocontientfleur NATURAL JOIN fleur GROUP BY nomFleur);";
            MySqlCommand command = new MySqlCommand(queryGetMostOrderedFlower, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    this.trueMostOrderedFlowerLabel.Text = reader.GetString(0);
                    this.trueMostOrderedFlowerLabel.Visible = true;
                    this.mostOrderedFlowerPictureBox.Visible = true;
                }
            }
            reader.Close();
            this.mostOrderedFlowerPictureBox.BackgroundImage =
                Properties.Resources.ResourceManager.GetObject(OrderForm.getImageNameFromItemName(this.trueMostOrderedFlowerLabel.Text)) as Image;
        }


        /// <summary>
        /// Méthode permettant d'obtenir l'accessoire le plus commandé
        /// </summary>
        private void getMostOrderedAccessory()
        {
            string queryGetMostOrderedFlower = "SELECT nomAccessoire FROM bouquetPersoContientAccessoire NATURAL JOIN accessoire " +
               "GROUP BY nomAccessoire " +
               "HAVING sum(quantiteAccessoire) >= all(SELECT sum(quantiteAccessoire) FROM bouquetPersoContientAccessoire NATURAL JOIN accessoire GROUP BY nomAccessoire);";
            MySqlCommand command = new MySqlCommand(queryGetMostOrderedFlower, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    this.trueMostOrderedAccessoryLabel.Text = reader.GetString(0);
                    this.trueMostOrderedAccessoryLabel.Visible = true;
                    this.mostOrderedAccessoryPictureBox.Visible = true;
                }
            }
            reader.Close();
            this.mostOrderedAccessoryPictureBox.BackgroundImage =
                Properties.Resources.ResourceManager.GetObject(OrderForm.getImageNameFromItemName(this.trueMostOrderedAccessoryLabel.Text)) as Image;
        }


        /// <summary>
        /// Méthode permettant de comparer les chiffres d'affaire entre les magasins
        /// </summary>
        private void compareCA()
        {
            string queryCompareCA = "SELECT DISTINCT c1.nomMagasin as FAIT_PLUS_DE_CA, c2.nomMagasin as FAIT_MOINS_DE_CA " +
                "FROM commande c1, commande c2 WHERE (SELECT sum(prixTotal) FROM commande " +
                "WHERE nomMagasin = c1.nomMagasin) > " +
                "(SELECT sum(prixTotal) FROM commande WHERE nomMagasin = c2.nomMagasin) ORDER BY c1.nomMagasin;";
            MySqlCommand command = new MySqlCommand(queryCompareCA, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            this.caComparisonGridView.DataSource = table;
            foreach (DataGridViewColumn column in this.caComparisonGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.ReadOnly = true;
            }
        }


        /// <summary>
        /// Méthode permettant d'obtenir les super clients
        /// </summary>
        private void getSuperClients()
        {
            string queryGetSuperClients = "SELECT distinct c.email, c.nom, c.prenom FROM client c NATURAL JOIN commande cmd " +
                "WHERE cmd.prixTotal > 2*(SELECT avg(cmd2.prixTotal) FROM commande cmd2);";
            MySqlCommand command = new MySqlCommand(queryGetSuperClients, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            this.superClientsGridView.DataSource = table;
            foreach (DataGridViewColumn column in this.superClientsGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        #endregion


    }
}
