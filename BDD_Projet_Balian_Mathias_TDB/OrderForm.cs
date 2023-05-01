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
    public partial class OrderForm : Form
    {
        private User user;
        private bool isUserActionClose = false; // Pour vérifier si le form est fermé à partir 
        // du bouton "X"
        private bool dateTimerPaused = false;
        private float currentBouquetPrice;



        public OrderForm(User user, DateTime date)
        {
            InitializeComponent();
            this.user = user;
            this.datePicker.Value = date;
            this.dateTimer.Start(); // Lancement du timer pour le défilement de la date
            fillShopComboBox();
        }


        #region Méthodes éléments forms

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
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
            fillInStockFlowerComboBox();
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


        private void bouquetStandardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.currentBouquetPrice = 0;
            this.totalPriceLabel.Text = $"Total : {this.currentBouquetPrice}€";
            if (this.bouquetStandardCheckBox.Checked)
            {
                this.bouquetPersoCheckBox.Enabled = false;
                this.inStockBouquetsStandardComboBox.Visible = true;
                this.bouquetPanel.Visible = true;
                this.requiredBouquetStandardPictureBox.Visible = true;
            }
            else
            {
                this.bouquetPersoCheckBox.Enabled = true;
                this.inStockBouquetsStandardComboBox.Visible = false;
                this.bouquetPanel.Visible = false;
                this.bouquetPanel.BackgroundImage = null;
                this.requiredBouquetStandardPictureBox.Visible = false;
            }
        }


        private void bouquetPersoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.currentBouquetPrice = 0;
            this.totalPriceLabel.Text = $"Total : {this.currentBouquetPrice}€";
            if (this.bouquetPersoCheckBox.Checked)
            {
                this.bouquetStandardCheckBox.Enabled = false;
                this.bouquetPersoFlowLayoutPanel.Visible = true;
                this.inStockAccessoryComboBox.Visible = true;
                this.addAccessoryButton.Visible = true;
                this.inStockFlowerComboBox.Visible = true;
                this.addFlowerButton.Visible = true;
                this.requiredCustomItemPictureBox.Visible = true;
            }
            else
            {
                this.bouquetPersoFlowLayoutPanel.Visible = false;
                this.bouquetPersoFlowLayoutPanel.Controls.Clear();
                this.bouquetStandardCheckBox.Enabled = true;
                this.inStockAccessoryComboBox.Visible = false;
                this.addAccessoryButton.Visible = false;
                this.inStockFlowerComboBox.Visible = false;
                this.addFlowerButton.Visible = false;
                this.requiredCustomItemPictureBox.Visible = false;
            }
        }


        private void shopComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            fillInStockBouquetsStandardComboBox();
            fillInStockAccessoryComboBox();
            fillInStockFlowerComboBox();
            this.currentBouquetPrice = 0;
            this.totalPriceLabel.Text = $"Total : {this.currentBouquetPrice}€";
        }


        private void inStockBouquetsStandardComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string imageName = getImageNameFromItemName(this.inStockBouquetsStandardComboBox.Text.Split(" | ")[0]);
            Image backgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
            this.bouquetPanel.BackgroundImage = backgroundImage;
            this.currentBouquetPrice = getBouquetStandardPrice();
            this.totalPriceLabel.Text = $"Total : {this.currentBouquetPrice}€";
        }


        private void orderButton_Click(object sender, EventArgs e)
        {
            // Si l'utilisateur n'a pas choisi de magasin ou n'a pas rentré son adresse
            if (!inputsNotEmpty(this.shopComboBox, this.deliveryAdressTextBox))
            {
                MessageBox.Show("Merci de bien remplir tous les champs");
                return;
            }

            // Si l'utisateur n'a pas composé son bouquet (standard ou personnalisé)
            if ((this.bouquetStandardCheckBox.Checked && this.bouquetPanel.BackgroundImage == null) ||
                (this.bouquetPersoCheckBox.Checked && this.bouquetPersoFlowLayoutPanel.Controls.Count == 0))
            {
                MessageBox.Show("Merci de choisir ou de composer votre bouquet");
                return;
            }

            // Si la date de livraison choisie par l'utilisateur est inférieure ou égale à la date actuelle
            if (DateTime.Compare(this.deliveryDateTimePicker.Value, this.datePicker.Value) < 0 ||
                (this.deliveryDateTimePicker.Value.Day == this.datePicker.Value.Day &&
                 this.deliveryDateTimePicker.Value.Month == this.datePicker.Value.Month &&
                 this.deliveryDateTimePicker.Value.Year == this.datePicker.Value.Year))
            {
                MessageBox.Show("Merci de saisir une date de livraison supérieure à la date actuelle");
                return;
            }



        }


        private void addAccessoryButton_Click(object sender, EventArgs e)
        {
            string imageName = getImageNameFromItemName(this.inStockAccessoryComboBox.Text.Split(" | ")[0]);
            Image backgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
            if (backgroundImage != null)
            {
                Button itemButton = new Button();
                itemButton.Size = new Size(160, 160);
                itemButton.BackgroundImage = backgroundImage;
                itemButton.BackgroundImageLayout = ImageLayout.Stretch;
                itemButton.Cursor = Cursors.Hand;
                itemButton.FlatStyle = FlatStyle.Flat;
                itemButton.Click += itemButton_Click;
                itemButton.Name = imageName + " | accessoire";
                this.bouquetPersoFlowLayoutPanel.Controls.Add(itemButton);
                this.currentBouquetPrice += getAccessoryPrice(this.inStockAccessoryComboBox.Text.Split(" | ")[0]);
                this.totalPriceLabel.Text = $"Total : {this.currentBouquetPrice}€";
            }
        }


        private void addFlowerButton_Click(object sender, EventArgs e)
        {
            string imageName = getImageNameFromItemName(this.inStockFlowerComboBox.Text.Split(" | ")[0]);
            Image backgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
            if (backgroundImage != null)
            {
                Button itemButton = new Button();
                itemButton.Size = new Size(160, 160);
                itemButton.BackgroundImage = backgroundImage;
                itemButton.BackgroundImageLayout = ImageLayout.Stretch;
                itemButton.Cursor = Cursors.Hand;
                itemButton.FlatStyle = FlatStyle.Flat;
                itemButton.Click += itemButton_Click;
                itemButton.Name = imageName + " | fleur";
                this.bouquetPersoFlowLayoutPanel.Controls.Add(itemButton);
                this.currentBouquetPrice += getFlowerPrice(this.inStockFlowerComboBox.Text.Split(" | ")[0]);
                this.totalPriceLabel.Text = $"Total : {this.currentBouquetPrice}€";
            }
        }


        private void itemButton_Click(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;
            this.bouquetPersoFlowLayoutPanel.Controls.Remove(thisButton);
            string[] buttonName = thisButton.Name.Split(" | ");
            this.currentBouquetPrice -= (buttonName[1] == "fleur") ?
                getFlowerPrice(getItemNameFromImageName(buttonName[0])) :
                getAccessoryPrice(getItemNameFromImageName(buttonName[0]));
            this.totalPriceLabel.Text = $"Total : {this.currentBouquetPrice}€";
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            fillInStockFlowerComboBox();
        }

        #endregion



        #region Méthodes utiles

        /// <summary>
        /// Méthode permettant de remplir les options du déroulant des magasins
        /// </summary>
        private void fillShopComboBox()
        {
            string queryGetAllShops = "SELECT nomMagasin, ville FROM magasin;";
            MySqlCommand command = new MySqlCommand(queryGetAllShops, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // On ajoute à la liste des magasins chaque magasin avec son nom et sa ville
                this.shopComboBox.Items.Add($"{reader.GetString(0)} | {reader.GetString(1)}");
            }
            reader.Close();
        }


        /// <summary>
        /// Méthode permettant de remplir les choix de bouquets standards en fonction du magasin choisi
        /// Appelée à chaque fois que la valeur du choix du magasin change
        /// </summary>
        private void fillInStockBouquetsStandardComboBox()
        {
            this.inStockBouquetsStandardComboBox.Items.Clear(); // On enlève tous les éléments déjà présents dans la liste
            this.bouquetPanel.BackgroundImage = null;

            string queryGetAllStockBouquetsStandard = "SELECT nomBouquet, quantite FROM stockBouquet " +
                    "WHERE nomMagasin = @shopName;"; // On récupère tous les bouquets stockés par le magasin choisi
            MySqlCommand command = new MySqlCommand(queryGetAllStockBouquetsStandard, connection);
            addParametersToCommand(command, createCustomParameter("@shopName", this.shopComboBox.Text.Split(" | ")[0], MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // On ajoute tous les bouquets renvoyés (et leur quantité en stock) à la liste des bouquets proposés
                this.inStockBouquetsStandardComboBox.Items.Add($"{reader.GetString("nomBouquet")} | En stock : {reader.GetInt32("quantite")}");
            }
            reader.Close();
        }


        /// <summary>
        /// Méthode permettant de remplir les choix des accessoires composant l'arrangement floral 
        /// personnalisé en fonction du magasin choisi. Appelée à chaque fois que la valeur du 
        /// choix du magasin change
        /// </summary>
        private void fillInStockAccessoryComboBox()
        {
            this.inStockAccessoryComboBox.Items.Clear();
            this.bouquetPersoFlowLayoutPanel.Controls.Clear();

            string queryGetAllStockAccessory = "SELECT nomAccessoire, quantite FROM stockAccessoire NATURAL JOIN accessoire " +
                "WHERE nomMagasin = @shopName;";
            MySqlCommand command = new MySqlCommand(queryGetAllStockAccessory, connection);
            addParametersToCommand(command, createCustomParameter("@shopName", this.shopComboBox.Text.Split(" | ")[0], MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.inStockAccessoryComboBox.Items.Add($"{reader.GetString("nomAccessoire")} | En stock : {reader.GetFloat("quantite")}");
            }
            reader.Close();
        }


        /// <summary>
        /// Méthode permettant de remplir les choix des fleurs composant l'arrangement floral
        /// personnalisé en fonction du magasin choisi. Appelée à chaque fois que la valeur du 
        /// choix du magasin change
        /// </summary>
        private void fillInStockFlowerComboBox()
        {
            this.inStockFlowerComboBox.Items.Clear();
            this.bouquetPersoFlowLayoutPanel.Controls.Clear();

            string queryGetAllStockFlowers = "SELECT nomFleur, quantite FROM stockFleur NATURAL JOIN fleur" +
                " WHERE nomMagasin = @shopName AND date_format(@currentDate, '%m-%d') >= date_format(dateDebutDispo, '%m-%d')" +
                " AND date_format(@currentDate, '%m-%d') <= date_format(dateFinDispo, '%m-%d');";
            MySqlCommand command = new MySqlCommand(queryGetAllStockFlowers, connection);
            addParametersToCommand(command, createCustomParameter("@shopName", this.shopComboBox.Text.Split(" | ")[0], MySqlDbType.VarChar),
                                            createCustomParameter("@currentDate", this.datePicker.Value.ToString("yyyy-MM-dd"), MySqlDbType.Text));
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.inStockFlowerComboBox.Items.Add($"{reader.GetString("nomFleur")} | En stock : {reader.GetFloat("quantite")}");
            }
            reader.Close();
        }


        /// <summary>
        /// Méthode permettant d'obtenir le nom de l'image associée à un nom de bouquet ou item
        /// </summary>
        /// <param name="name">Le nom du bouquet ou de l'item</param>
        /// <returns>Le nom de l'image correspondant au nom du bouquet ou de l'item</returns>
        private string getImageNameFromItemName(string name)
        {
            name = name.Split(" | ")[0];
            switch (name)
            {
                case "Gros Merci":
                    return "bouquet_gros_merci";

                case "L'Amoureux":
                    return "bouquet_l'amoureux1";

                case "L'Exotique":
                    return "bouquet_exotique";

                case "Maman":
                    return "bouquet_maman";

                case "Vive la mariée":
                    return "bouquet_mariage";

                case "Gerbera":
                    return "fleur_gerbera";

                case "Glaïeul":
                    return "fleur_glaieul";

                case "Ginger":
                    return "fleur_ginger";

                case "Marguerite":
                    return "fleur_marguerite";

                case "Rose rouge":
                    return "fleur_rose_rouge";

                case "Boîte pour bouquet":
                    return "bouquet_boîte";

                case "Feuille dorée":
                    return "feuille_dorée";

                case "Vase":
                    return "vase";

                case "Ruban":
                    return "ruban";

                case "Pomme de pin":
                    return "pomme_de_pin";

                default:
                    return "";
            }
        }


        /// <summary>
        /// Méthode permettant d'obtenir le nom d'un item à partir du nom de l'image qui représente cet item
        /// </summary>
        /// <param name="name">Le nom de l'image</param>
        /// <returns>Le nom de l'item</returns>
        private string getItemNameFromImageName(string name)
        {
            name = name.Split(" | ")[0];
            switch (name)
            {
                case "bouquet_gros_merci":
                    return "Gros Merci";

                case "bouquet_l'amoureux1":
                    return "L'Amoureux";

                case "bouquet_exotique":
                    return "L'Exotique";

                case "bouquet_maman":
                    return "Maman";

                case "bouquet_mariage":
                    return "Vive la mariée";

                case "fleur_gerbera":
                    return "Gerbera";

                case "fleur_glaieul":
                    return "Glaïeul";

                case "fleur_ginger":
                    return "Ginger";

                case "fleur_marguerite":
                    return "Marguerite";

                case "fleur_rose_rouge":
                    return "Rose rouge";

                case "bouquet_boîte":
                    return "Boîte pour bouquet";

                case "feuille_dorée":
                    return "Feuille dorée";

                case "vase":
                    return "Vase";

                case "ruban":
                    return "Ruban";

                case "pomme_de_pin":
                    return "Pomme de pin";

                default:
                    return "";
            }
        }


        /// <summary>
        /// Méthode permettant d'obtenir le prix du bouquet sélectionné par l'utilisateur
        /// </summary>
        /// <returns>Le prix du bouquet</returns>
        private float getBouquetStandardPrice()
        {
            string queryGetBouquetPrice = "SELECT prixBouquet FROM bouquetStandard WHERE nomBouquet = @bouquetName;";
            MySqlCommand command = new MySqlCommand(queryGetBouquetPrice, connection);
            addParametersToCommand(command,
                createCustomParameter("@bouquetName", this.inStockBouquetsStandardComboBox.Text.Split(" | ")[0], MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                float bouquetPrice = reader.GetFloat("prixBouquet");
                reader.Close();
                return bouquetPrice;
            }
            reader.Close();
            return 0f;
        }


        /// <summary>
        /// Méthode permettant d'obtenir le prix de la fleur sélectionnée par l'utilisateur
        /// </summary>
        /// <returns>Le prix de la fleur</returns>
        private float getFlowerPrice(string flowerName)
        {
            string queryGetFlowerPrice = "SELECT prixFleur FROM fleur WHERE nomFleur = @flowerName;";
            MySqlCommand command = new MySqlCommand(queryGetFlowerPrice, connection);
            addParametersToCommand(command,
                createCustomParameter("@flowerName", flowerName, MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                float flowerPrice = reader.GetFloat("prixFleur");
                reader.Close();
                return flowerPrice;
            }
            reader.Close();
            return 0f;
        }


        /// <summary>
        /// Méthode permettant d'obtenir le prix de l'accessoire sélectionné par l'utilisateur
        /// </summary>
        /// <returns>Le prix de l'accessoire</returns>
        private float getAccessoryPrice(string accessoryName)
        {
            string queryGetAccessoryPrice = "SELECT prixAccessoire FROM accessoire WHERE nomAccessoire = @accessoryName;";
            MySqlCommand command = new MySqlCommand(queryGetAccessoryPrice, connection);
            addParametersToCommand(command,
                createCustomParameter("@accessoryName", accessoryName, MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                float accessoryPrice = reader.GetFloat("prixAccessoire");
                reader.Close();
                return accessoryPrice;
            }
            reader.Close();
            return 0f;
        }

        #endregion
    }
}
