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
        private bool isButtonClick = false;
        private bool timerPaused = false;
        public DashboardForm(User user)
        {
            InitializeComponent();
            this.user = user;
            this.datePicker.Value = DateTime.Now;
            this.timer.Start();
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si l'utilisateur ferme le forms en utilisant le bouton "X"
            if (e.CloseReason == CloseReason.UserClosing && !this.isButtonClick)
            {
                this.timer.Stop();
                closeApp();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.user.toString());
            this.Hide();
            Test t = new Test();
            t.Show();
            this.isButtonClick = true;
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.datePicker.Value = datePicker.Value.AddDays(1);
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (!this.timerPaused)
            {
                this.timer.Stop();
                this.timerPaused = true;
                return;
            }
            this.timer.Start();
            this.timerPaused = false;
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if(this.timer.Interval >= 501)
            {
                this.timer.Interval -= 500;
            }
        }

        private void backwardButton_Click(object sender, EventArgs e)
        {
            this.timer.Interval += 500;
        }
    }
}
