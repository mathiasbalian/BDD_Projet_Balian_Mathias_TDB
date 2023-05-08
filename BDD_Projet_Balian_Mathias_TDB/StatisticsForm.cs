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


        #region Méthodes utiles

        private void getBestMonthClient()
        {
            this.trueBestMonthClientLabel.Text = "";
            string queryGetBestMonthClient = "SELECT nom, prenom, email FROM commande NATURAL JOIN client " +
                "WHERE date_format(commande.dateCommande, '%Y-%m') = @currentDate group by email " +
                "HAVING count(email) >= all(SELECT count(email) FROM commande GROUP BY email);";
            MySqlCommand command = new MySqlCommand(queryGetBestMonthClient, connection);
            addParametersToCommand(command, createCustomParameter("@currentDate", this.datePicker.Value.ToString("yyyy-MM"), MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.trueBestMonthClientLabel.Text += $"{reader.GetString(0)} {reader.GetString(1)} | ";
            }
            reader.Close();
            this.trueBestMonthClientLabel.Text = this.trueBestMonthClientLabel.Text.Remove(this.trueBestMonthClientLabel.Text.Length - 3, 2);
        }
        

        private void getBestYearClient()
        {
            this.trueBestYearClientLabel.Text = "";
            string queryGetBestMonthClient = "SELECT nom, prenom, email FROM commande NATURAL JOIN client " +
                "WHERE date_format(commande.dateCommande, '%Y') = @currentDate group by email " +
                "HAVING count(email) >= all(SELECT count(email) FROM commande GROUP BY email);";
            MySqlCommand command = new MySqlCommand(queryGetBestMonthClient, connection);
            addParametersToCommand(command, createCustomParameter("@currentDate", this.datePicker.Value.ToString("yyyy"), MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.trueBestYearClientLabel.Text += $"{reader.GetString(0)} {reader.GetString(1)} | ";
            }
            reader.Close();
            this.trueBestYearClientLabel.Text = this.trueBestYearClientLabel.Text.Remove(this.trueBestYearClientLabel.Text.Length - 3, 2);
        }

        #endregion
    }
}
