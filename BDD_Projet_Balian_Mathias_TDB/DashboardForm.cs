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
        public DashboardForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si l'utilisateur ferme le forms en utilisant le bouton "X"
            if (e.CloseReason == CloseReason.UserClosing && !this.isButtonClick)
            {
                closeApp();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.user.toString());
        }
    }
}
