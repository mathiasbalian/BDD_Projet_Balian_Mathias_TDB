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
    public partial class DashboardForm : Form
    {
        private User user;
        private bool isUserActionClose = false; // Pour vérifier si le form est fermé à partir 
        // du bouton "X"
        private bool dateTimerPaused = false;
        private bool productsSummaryVisible = false;


        public DashboardForm(User user, DateTime date)
        {
            InitializeComponent();
            this.productsPanel.Height = 68;
            this.user = user;
            this.datePicker.Value = date;
            this.dateTimer.Start(); // Lancement du timer pour le défilement de la date
            this.productsPanel.AutoScroll = false;
        }


        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dateTimer.Stop();
            // Si l'utilisateur ferme le forms en utilisant le bouton "X"
            if (e.CloseReason == CloseReason.UserClosing && !this.isUserActionClose)
            {
                closeApp();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.user.toString());
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            this.datePicker.Value = datePicker.Value.AddDays(1); // On ajoute un jour à la date
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


        private void userButton_Click(object sender, EventArgs e)
        {
            if (!this.userDropdown.Visible)
            {
                this.userDropdown.Visible = true;
                this.userDropdown.BringToFront();
                return;
            }
            this.userDropdown.Visible = false;
        }


        private void disconnectButton_Click(object sender, EventArgs e)
        {
            this.isUserActionClose = true;
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }


        private void myOrdersButton_Click(object sender, EventArgs e)
        {

        }


        private void myProfileButton_Click(object sender, EventArgs e)
        {

        }


        private void productsButton_Click(object sender, EventArgs e)
        {
            this.dropdownTimer.Start();
        }


        private void dropdownTimer_Tick(object sender, EventArgs e)
        {
            if (!this.productsSummaryVisible)
            {
                this.productsPanel.Height += 35;
                if (this.productsPanel.Height >= 690)
                {
                    this.dropdownTimer.Stop();
                    this.productsSummaryVisible = true;
                    this.productsPanel.AutoScroll = true;
                }
            }
            else
            {
                this.productsPanel.Height -= 35;
                if (this.productsPanel.Height <= 70)
                {
                    this.dropdownTimer.Stop();
                    this.productsSummaryVisible = false;
                    this.productsPanel.AutoScroll = false;
                }
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            this.isUserActionClose = true;
            this.Hide();
            OrderForm of = new OrderForm(this.user, this.datePicker.Value);
            of.Show();
            this.Close();
        }

        private void grosMerciButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Un bouquet idéal pour toutes les occasions, pour faire plaisir à vos proches !" +
                "\nArrangement de marguerites et autres verdures. \n45€ TTC");
        }

        private void lamoureuxButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous souhaitez offrir un magnifique bouquet à votre partenaire ? N'hésitez pas ! Ce magnifique" +
                " bouquet composé de roses rouges et blanches est parfait pour la Saint-Valentin. \n65€ TTC");
        }

        private void exotiqueButton_Click(object sender, EventArgs e)
        {

        }

        private void mamanButton_Click(object sender, EventArgs e)
        {

        }

        private void marieeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
