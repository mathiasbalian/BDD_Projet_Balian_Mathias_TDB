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


        public DashboardForm(User user)
        {
            InitializeComponent();
            this.user = user;
            this.datePicker.Value = DateTime.Now;
            this.timer.Start(); // Lancement du timer pour le défilement de la date
        }


        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si l'utilisateur ferme le forms en utilisant le bouton "X"
            if (e.CloseReason == CloseReason.UserClosing && !this.isUserActionClose)
            {
                this.timer.Stop();
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
            if (this.timer.Interval >= 501)
            {
                this.timer.Interval -= 500; // On accélère la vitesse de défilement de la date
            }
        }


        private void backwardButton_Click(object sender, EventArgs e)
        {
            this.timer.Interval += 500; // On ralentit la vitesse de défilement de la date
        }
    }
}
