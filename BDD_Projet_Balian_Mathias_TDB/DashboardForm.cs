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
        private bool timerPaused = false;
        private bool userDropdownVisible = false;


        public DashboardForm(User user)
        {
            InitializeComponent();
            this.user = user;
            this.datePicker.Value = DateTime.Now;
            this.timer.Start(); // Lancement du timer pour le défilement de la date
        }


        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timer.Stop();
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
            if (!this.timerPaused)
            {
                this.timer.Stop();
                this.timerPaused = true;
                this.pauseButton.BackgroundImage = Properties.Resources.resume_icon;
                return;
            }
            this.timer.Start();
            this.pauseButton.BackgroundImage = Properties.Resources.pause_icon;
            this.timerPaused = false;
        }


        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (this.timer.Interval > 1000)
            {
                this.timer.Interval -= 1000; // On accélère la vitesse de défilement de la date
            }
        }


        private void backwardButton_Click(object sender, EventArgs e)
        {
            this.timer.Interval += 500; // On ralentit la vitesse de défilement de la date
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            if (!this.userDropdownVisible)
            {
                this.userDropdown.Visible = true;
                this.userDropdownVisible = true;
                return;
            }
            this.userDropdownVisible = false;
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
    }
}
