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
using System.Xml;
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
            if (this.user.isAdmin)
            {
                this.userDropdown.Height = 160;
                this.administrationButton.Visible = true;
                this.exportXmlButton.Visible = true;
            }
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
            int monthBefore = this.datePicker.Value.Month;
            this.datePicker.Value = datePicker.Value.AddDays(1); // On ajoute un jour à la date
            if (this.datePicker.Value.Month != monthBefore)
            {
                updateClientsFidelityMonthly(this.user);
                monthBefore = this.datePicker.Value.Month;
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


        private void userButton_Click(object sender, EventArgs e)
        {
            if (!this.userDropdown.Visible)
            {
                this.myProfileButton.Text = $"Bonjour {this.user.firstName} !";
                this.userDropdown.Visible = true;
                this.userDropdown.BringToFront();
                return;
            }
            this.userDropdown.Visible = false;
            this.administrationPanel.Visible = false;
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
            this.isUserActionClose = true;
            this.Hide();
            MyOrdersForm mof = new MyOrdersForm(this.user, this.datePicker.Value);
            mof.Show();
            this.Close();
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
            OrderForm of = new OrderForm(this.user, this.datePicker.Value, false);
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

        private void administrationButton_Click(object sender, EventArgs e)
        {
            if (this.administrationPanel.Visible)
            {
                this.administrationPanel.Visible = false;
                return;
            }
            this.administrationPanel.Visible = true;
            this.administrationPanel.BringToFront();
        }


        private void statisticsButton_Click(object sender, EventArgs e)
        {
            this.isUserActionClose = true;
            this.Hide();
            StatisticsForm sf = new StatisticsForm(this.user, this.datePicker.Value);
            sf.Show();
            this.Close();
        }


        private void adminOrdersButton_Click(object sender, EventArgs e)
        {
            this.isUserActionClose = true;
            this.Hide();
            AllOrdersForm aof = new AllOrdersForm(this.user, this.datePicker.Value);
            aof.Show();
            this.Close();
        }


        private void stocksAndShopsButton_Click(object sender, EventArgs e)
        {
            this.isUserActionClose = true;
            this.Hide();
            StocksAndShopsForm sasf = new StocksAndShopsForm(this.user, this.datePicker.Value);
            sasf.Show();
            this.Close();
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            this.isUserActionClose = true;
            this.Hide();
            AllClientsForm acf = new AllClientsForm(this.user, this.datePicker.Value);
            acf.Show();
            this.Close();
        }


        private void exportXmlButton_Click(object sender, EventArgs e)
        {
            DateTime firstMonthDay = new DateTime(this.datePicker.Value.Year, this.datePicker.Value.Month, 1);
            DateTime lastMonthDay = new DateTime(this.datePicker.Value.Year, this.datePicker.Value.Month, DateTime.DaysInMonth(this.datePicker.Value.Year, this.datePicker.Value.Month));

            string queryGetAllClientsOrderedManyTimesInMonth = "SELECT email, nom, prenom, numTel, adresseFacturation, carteCredit, fidelite " +
                "FROM commande NATURAL JOIN client WHERE DATEDIFF(dateCommande, @startMonthDate) >=0 " +
                "AND DATEDIFF(dateCommande, @endMonthDate) <= 0 GROUP BY email HAVING count(email) >= 2;";
            MySqlCommand command = new MySqlCommand(queryGetAllClientsOrderedManyTimesInMonth, connection);
            addParametersToCommand(command, createCustomParameter("@startMonthDate", firstMonthDay.ToString("yyyy-MM-dd"), MySqlDbType.Date),
                                            createCustomParameter("@endMonthDate", lastMonthDay.ToString("yyyy-MM-dd"), MySqlDbType.Date));
            MySqlDataReader reader = command.ExecuteReader();

            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.NewLineOnAttributes = true;
            xmlWriterSettings.Indent = true;
            XmlWriter xmlDoc = XmlWriter.Create("clients_plusieurs_commandes_dans_mois.xml", xmlWriterSettings);
            xmlDoc.WriteStartElement("clients");

            while (reader.Read())
            {
                xmlDoc.WriteStartElement("client");
                xmlDoc.WriteElementString("email", reader.GetString(0));
                xmlDoc.WriteElementString("nom", reader.GetString(1));
                xmlDoc.WriteElementString("prenom", reader.GetString(2));
                xmlDoc.WriteElementString("numTel", reader.GetString(3));
                xmlDoc.WriteElementString("adresseFacturation", reader.GetString(4));
                xmlDoc.WriteElementString("carteCredit", reader.GetString(5));
                xmlDoc.WriteElementString("fidelite", reader.GetString(6));
                xmlDoc.WriteEndElement();
            }
            reader.Close();
            xmlDoc.WriteEndElement();
            xmlDoc.Close();
            MessageBox.Show("Document XML exporté !");
        }
    }
}
