using Google.Protobuf.WellKnownTypes;
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
        private decimal bouquetPriceAfterDiscount;
        private float bouquetPriceBeforeDiscount;
        private bool fromAdmin;



        public OrderForm(User user, DateTime date, bool fromAdmin)
        {
            InitializeComponent();
            this.user = user;
            this.datePicker.Value = date;
            this.dateTimer.Start(); // Lancement du timer pour le défilement de la date
            fillShopComboBox();
            this.fromAdmin = fromAdmin;
            updateFidelityLabel();
            this.totalPriceBeforeDiscountLabel.Font = new Font(this.totalPriceBeforeDiscountLabel.Font, FontStyle.Strikeout);
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
            int monthBefore = this.datePicker.Value.Month;
            this.datePicker.Value = datePicker.Value.AddDays(1); // On ajoute un jour à la date
            if (this.datePicker.Value.Month != monthBefore)
            {
                updateClientsFidelityMonthly(this.user);
                monthBefore = this.datePicker.Value.Month;
                MessageBox.Show(this.user.fidelite);
                updateFidelityLabel();
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
            DashboardForm df = new DashboardForm(this.fromAdmin ? new User("admin", "admin", "admin", "admin", "9999", "admin", "9999", "", true) :
                                                                  this.user, this.datePicker.Value);
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
            this.isUserActionClose = true;
            this.Hide();
            MyOrdersForm mof = new MyOrdersForm(this.user, this.datePicker.Value);
            mof.Show();
            this.Close();
        }


        private void myProfileButton_Click(object sender, EventArgs e)
        {

        }


        private void bouquetStandardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.bouquetPriceAfterDiscount = 0;
            this.totalPriceLabel.Text = $"Total : {this.bouquetPriceAfterDiscount}€";
            this.totalPriceLabel.Left = (this.orderDetailsPanel.Width - this.totalPriceLabel.Width) / 2;
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
            this.bouquetPriceAfterDiscount = 0;
            this.totalPriceLabel.Text = $"Total : {this.bouquetPriceAfterDiscount}€";
            this.totalPriceLabel.Left = (this.orderDetailsPanel.Width - this.totalPriceLabel.Width) / 2;
            if (this.bouquetPersoCheckBox.Checked)
            {
                this.bouquetStandardCheckBox.Enabled = false;
                this.compositionKnownCheckBox.Visible = true;
                this.compositionUnknownCheckBox.Visible = true;
            }
            else
            {
                this.compositionUnknownPanel.Visible = false;
                this.compositionKnownCheckBox.Checked = false;
                this.compositionUnknownCheckBox.Checked = false;
                this.bouquetPersoFlowLayoutPanel.Visible = false;
                this.bouquetPersoFlowLayoutPanel.Controls.Clear();
                this.bouquetStandardCheckBox.Enabled = true;
                this.inStockAccessoryComboBox.Visible = false;
                this.addAccessoryButton.Visible = false;
                this.inStockFlowerComboBox.Visible = false;
                this.addFlowerButton.Visible = false;
                this.requiredCustomItemPictureBox.Visible = false;
                this.compositionKnownCheckBox.Visible = false;
                this.compositionUnknownCheckBox.Visible = false;
            }
        }


        private void compositionKnownCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.compositionKnownCheckBox.Checked)
            {
                this.compositionUnknownCheckBox.Enabled = false;
                this.bouquetPersoFlowLayoutPanel.Visible = true;
                this.inStockAccessoryComboBox.Visible = true;
                this.addAccessoryButton.Visible = true;
                this.inStockFlowerComboBox.Visible = true;
                this.addFlowerButton.Visible = true;
                this.requiredCustomItemPictureBox.Visible = true;
            }
            else
            {
                this.compositionUnknownCheckBox.Enabled = true;
                this.bouquetPersoFlowLayoutPanel.Visible = false;
                this.inStockAccessoryComboBox.Visible = false;
                this.addAccessoryButton.Visible = false;
                this.inStockFlowerComboBox.Visible = false;
                this.addFlowerButton.Visible = false;
                this.requiredCustomItemPictureBox.Visible = false;
            }
        }

        private void compositionUnknownCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.compositionUnknownCheckBox.Checked)
            {
                this.compositionUnknownPanel.Visible = true;
                this.compositionKnownCheckBox.Enabled = false;
            }
            else
            {
                this.compositionKnownCheckBox.Enabled = true;
                this.compositionUnknownPanel.Visible = false;
            }
        }


        private void shopComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            fillInStockBouquetsStandardComboBox();
            fillInStockAccessoryComboBox();
            fillInStockFlowerComboBox();
            this.bouquetPriceAfterDiscount = 0;
            this.totalPriceLabel.Text = $"Total : {this.bouquetPriceAfterDiscount}€";
            this.totalPriceLabel.Left = (this.orderDetailsPanel.Width - this.totalPriceLabel.Width) / 2;
        }


        private void inStockBouquetsStandardComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string imageName = getImageNameFromItemName(this.inStockBouquetsStandardComboBox.Text.Split(" | ")[0]);
            Image backgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
            this.bouquetPanel.BackgroundImage = backgroundImage;
            float bouquetStandardPrice = getBouquetStandardPrice();
            if (this.user.fidelite == "Or")
            {
                this.bouquetPriceBeforeDiscount = bouquetStandardPrice;
                this.totalPriceBeforeDiscountLabel.Text = $"{this.bouquetPriceBeforeDiscount}€";
                this.bouquetPriceAfterDiscount = Decimal.Round((decimal)bouquetStandardPrice * 0.85m, 2);
            }
            else if (this.user.fidelite == "Bronze")
            {
                this.bouquetPriceBeforeDiscount = bouquetStandardPrice;
                this.totalPriceBeforeDiscountLabel.Text = $"{this.bouquetPriceBeforeDiscount}€";
                this.bouquetPriceAfterDiscount = Decimal.Round((decimal)bouquetStandardPrice * 0.95m, 2);
            }
            else
            {
                this.bouquetPriceAfterDiscount = (decimal)bouquetStandardPrice;
            }

            this.totalPriceLabel.Text = $"Total : {this.bouquetPriceAfterDiscount}€";
            this.totalPriceLabel.Left = (this.orderDetailsPanel.Width - this.totalPriceLabel.Width) / 2;
            this.totalPriceBeforeDiscountLabel.Left = (this.orderDetailsPanel.Width - this.totalPriceBeforeDiscountLabel.Width) / 2;
        }


        private void orderButton_Click(object sender, EventArgs e)
        {
            // Si l'utilisateur n'a pas choisi de magasin ou n'a pas rentré son adresse
            if (!inputsNotEmpty(this.shopComboBox, this.deliveryAdressTextBox))
            {
                MessageBox.Show("Merci de bien remplir tous les champs");
                return;
            }

            // Si l'utilisateur n'ai pas choisi d'option pour l'arrangement floral
            if (!this.bouquetStandardCheckBox.Checked && !this.bouquetPersoCheckBox.Checked)
            {
                MessageBox.Show("Merci de choisir une option d'arrangement floral entre bouquet standard et bouquet personnalisé");
                return;
            }

            // Si l'utisateur n'a pas composé son bouquet (standard ou personnalisé)
            if ((this.bouquetStandardCheckBox.Checked && this.bouquetPanel.BackgroundImage == null) ||
                (this.bouquetPersoCheckBox.Checked && (this.compositionKnownCheckBox.Checked && this.bouquetPersoFlowLayoutPanel.Controls.Count == 0)) ||
                (this.bouquetPersoCheckBox.Checked && (!this.compositionUnknownCheckBox.Checked && !this.compositionKnownCheckBox.Checked)))
            {
                MessageBox.Show("Merci de choisir ou de composer votre bouquet");
                return;
            }

            // Si l'utilisateur n'a pas donné de description pour son bouquet personnalisé
            if (this.compositionUnknownCheckBox.Checked && (this.descriptionTextBox.Text.Length == 0 || this.budgetUpDown.Value <= 0))
            {
                MessageBox.Show("Merci de bien vouloir donner une description de votre bouquet ainsi qu'un budget supérieur à 0€");
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

            // Si le client choisit une date de livraison à moins de 3 jours de la date actuelle
            if ((this.deliveryDateTimePicker.Value - this.datePicker.Value).Days < 3)
            {
                if (MessageBox.Show("Choisir une date de livraison à moins de 3 jours de la date actuelle risque d'engendrer un retard de la livraison" +
                    " dû au potentiel manque de stock de certains objets. Voulez-vous quand-même continuer ?", "Avertissement", MessageBoxButtons.YesNo)
                    == DialogResult.No)
                {
                    return;
                }
            }

            // Vérification que le client ne commande pas trop d'items par rapport au stock
            Dictionary<string, int> orderedItemsAndQuantities = getOrderedItemsAndQuantities();
            foreach (var (item, quantity) in orderedItemsAndQuantities)
            {
                string[] itemNameAndTable = item.Split(" | ");
                string itemName = getItemNameFromImageName(itemNameAndTable[0]);
                string itemTable = itemNameAndTable[1];
                int itemId = getItemIdFromName(itemName, itemTable);
                int itemStock = getItemStock(itemName, itemTable, itemId);
                if (quantity > itemStock)
                {
                    MessageBox.Show($"Il n'y a pas suffisamment de {itemName} dans le magasin {this.shopComboBox.Text}. Vous en avez commandé" +
                        $" {quantity}, mais il n'y en a que {itemStock} en stock. Veuillez recommencer.");
                    return;
                }
            }


            // Création entité arrangement_floral
            string queryCreateArrangementFloral;
            MySqlCommand command;
            int arrangementFloralNextId = getNextId("arrangementFloral");
            bool bouquetStandard = this.bouquetStandardCheckBox.Checked;

            // Si bouquet standard, on ajoute le nom du bouquet à l'arrangement, sinon on met la valeur null
            if (bouquetStandard)
            {
                queryCreateArrangementFloral = "INSERT INTO arrangementFloral VALUES " +
                $"({arrangementFloralNextId}, @bouquetStandardName);";
                command = new MySqlCommand(queryCreateArrangementFloral, connection);
                addParametersToCommand(command, createCustomParameter("@bouquetStandardName",
                                                                      this.inStockBouquetsStandardComboBox.Text.Split(" | ")[0],
                                                                      MySqlDbType.VarChar));
                command.ExecuteNonQuery();
                updateItemStock(this.shopComboBox.Text.Split(" | ")[0], itemName: this.inStockBouquetsStandardComboBox.Text.Split(" | ")[0], itemTable: "stockBouquet");
            }
            else // Si bouquet perso
            {
                // Création de l'entité bouquet_perso 
                int bouquetPersoNextId = getNextId("bouquetPerso");
                string queryCreateBouquetPerso = $"INSERT INTO bouquetPerso VALUES ({bouquetPersoNextId}, ";
                if (this.compositionUnknownCheckBox.Checked)
                {
                    queryCreateBouquetPerso += "@description);";
                    command = new MySqlCommand(queryCreateBouquetPerso, connection);
                    command.Parameters.Add(createCustomParameter("@description", this.descriptionTextBox.Text, MySqlDbType.Text));
                }
                else
                {
                    queryCreateBouquetPerso += "'');";
                    command = new MySqlCommand(queryCreateBouquetPerso, connection);
                }
                command.CommandText = queryCreateBouquetPerso;
                command.ExecuteNonQuery();

                if (this.compositionKnownCheckBox.Checked)
                {
                    // Association entre bouquet perso et accessoires / fleurs
                    foreach (var (item, quantity) in orderedItemsAndQuantities)
                    {
                        string[] itemNameAndTable = item.Split(" | ");
                        string itemName = getItemNameFromImageName(itemNameAndTable[0]);
                        string itemTable = itemNameAndTable[1];
                        int itemId = getItemIdFromName(itemName, itemTable);

                        command.CommandText = $"INSERT INTO bouquetPersoContient{itemTable} VALUES ({bouquetPersoNextId}, " +
                                                                                                    $"{itemId}, " +
                                                                                                    $"{quantity});";
                        command.ExecuteNonQuery();
                        updateItemStock(this.shopComboBox.Text.Split(" | ")[0], itemTable: itemTable, itemId: itemId, quantity: quantity);
                    }
                }


                // Création de l'arangement floral
                queryCreateArrangementFloral = "INSERT INTO arrangementFloral VALUES " +
                $"({arrangementFloralNextId}, null);";
                command.CommandText = queryCreateArrangementFloral;
                command.ExecuteNonQuery();


                // Association entre arrangement floral et bouquet perso
                string queryLinkArrangementBouquetPerso = "INSERT INTO arrangementEstComposeBouquetPerso" +
                    $" VALUES ({arrangementFloralNextId}, {bouquetPersoNextId});";
                command.CommandText = queryLinkArrangementBouquetPerso;
                command.ExecuteNonQuery();
            }


            // Création de la commande
            string queryCreateCommand = $"INSERT INTO commande VALUES ({getNextId("commande")}, " +
                                                                      "@orderDate, " +
                                                                      "@deliveryAdress, " +
                                                                      "@deliveryDate, " +
                                                                      "@orderState, " +
                                                                      "@orderMessage, " +
                                                                      "@totalPrice, " +
                                                                      "@clientEmail, " +
                                                                      $"{arrangementFloralNextId}, " +
                                                                      "@shopName);";
            command.CommandText = queryCreateCommand;
            command.Parameters.Clear();

            addParametersToCommand(command, createCustomParameter("@orderDate", this.datePicker.Value.ToString("yyyy-MM-dd"), MySqlDbType.Date),
                                            createCustomParameter("@deliveryAdress", this.deliveryAdressTextBox.Text, MySqlDbType.VarChar),
                                            createCustomParameter("@deliveryDate", this.deliveryDateTimePicker.Value.ToString("yyyy-MM-dd"), MySqlDbType.Date),
                                            createCustomParameter("@orderState", (this.compositionUnknownCheckBox.Checked) ? "CPAV" : "CC", MySqlDbType.Enum),
                                            createCustomParameter("@orderMessage", this.customMessageTextBox.Text, MySqlDbType.Text),
                                            createCustomParameter("@totalPrice", (this.compositionUnknownCheckBox.Checked) ? this.budgetUpDown.Value : this.bouquetPriceAfterDiscount, MySqlDbType.Decimal),
                                            createCustomParameter("@clientEmail", this.user.email, MySqlDbType.VarChar),
                                            createCustomParameter("@shopName", this.shopComboBox.Text.Split(" | ")[0], MySqlDbType.VarChar));
            command.ExecuteNonQuery();
            MessageBox.Show("Commande passée ! Merci beaucoup :)");
            updateFidelity();
            this.isUserActionClose = true;
            this.Hide();
            DashboardForm df = new DashboardForm(this.fromAdmin ? new User("admin", "admin", "admin", "admin", "9999", "admin", "9999", "", true) :
                                                                  this.user, this.datePicker.Value);
            df.Show();
            this.Close();
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
                float accessoryPrice = getAccessoryPrice(this.inStockAccessoryComboBox.Text.Split(" | ")[0]);
                if (this.user.fidelite == "Or")
                {
                    this.bouquetPriceBeforeDiscount += accessoryPrice;
                    this.bouquetPriceAfterDiscount += Decimal.Round((decimal)accessoryPrice * 0.85m, 2);
                }
                else if (this.user.fidelite == "Bronze")
                {
                    this.bouquetPriceBeforeDiscount += accessoryPrice;
                    this.bouquetPriceAfterDiscount += Decimal.Round((decimal)accessoryPrice * 0.95m, 2);
                }
                else
                {
                    this.bouquetPriceAfterDiscount += (decimal)accessoryPrice;
                }
                this.totalPriceBeforeDiscountLabel.Text = $"{this.bouquetPriceBeforeDiscount}€";
                this.totalPriceLabel.Text = $"Total : {this.bouquetPriceAfterDiscount}€";
                this.totalPriceLabel.Left = (this.orderDetailsPanel.Width - this.totalPriceLabel.Width) / 2;
                this.totalPriceBeforeDiscountLabel.Left = (this.orderDetailsPanel.Width - this.totalPriceBeforeDiscountLabel.Width) / 2;
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
                float flowerPrice = getFlowerPrice(this.inStockFlowerComboBox.Text.Split(" | ")[0]);
                if (this.user.fidelite == "Or")
                {
                    this.bouquetPriceBeforeDiscount += flowerPrice;
                    this.bouquetPriceAfterDiscount += Decimal.Round((decimal)flowerPrice * 0.85m, 2);
                }
                else if (this.user.fidelite == "Bronze")
                {
                    this.bouquetPriceBeforeDiscount += flowerPrice;
                    this.bouquetPriceAfterDiscount += Decimal.Round((decimal)flowerPrice * 0.95m, 2);
                }
                else
                {
                    this.bouquetPriceAfterDiscount += (decimal)flowerPrice;
                }
                this.totalPriceBeforeDiscountLabel.Text = $"{this.bouquetPriceBeforeDiscount}€";
                this.totalPriceLabel.Text = $"Total : {this.bouquetPriceAfterDiscount}€";
                this.totalPriceLabel.Left = (this.orderDetailsPanel.Width - this.totalPriceLabel.Width) / 2;
                this.totalPriceBeforeDiscountLabel.Left = (this.orderDetailsPanel.Width - this.totalPriceBeforeDiscountLabel.Width) / 2;
            }
        }


        private void itemButton_Click(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;
            this.bouquetPersoFlowLayoutPanel.Controls.Remove(thisButton);
            string[] buttonName = thisButton.Name.Split(" | ");
            if (this.user.fidelite == "Or")
            {
                if (buttonName[1] == "fleur")
                {
                    float flowerPrice = getFlowerPrice(getItemNameFromImageName(buttonName[0]));
                    this.bouquetPriceBeforeDiscount -= flowerPrice;
                    this.bouquetPriceAfterDiscount -= Decimal.Round((decimal)flowerPrice * 0.85m, 2);
                }
                else
                {
                    float accessoryPrice = getAccessoryPrice(getItemNameFromImageName(buttonName[0]));
                    this.bouquetPriceBeforeDiscount -= accessoryPrice;
                    this.bouquetPriceAfterDiscount -= Decimal.Round((decimal)accessoryPrice * 0.85m, 2);
                }

            }
            else if (this.user.fidelite == "Bronze")
            {
                if (buttonName[1] == "fleur")
                {
                    float flowerPrice = getFlowerPrice(getItemNameFromImageName(buttonName[0]));
                    this.bouquetPriceBeforeDiscount -= flowerPrice;
                    this.bouquetPriceAfterDiscount -= Decimal.Round((decimal)flowerPrice * 0.95m, 2);
                }
                else
                {
                    float accessoryPrice = getAccessoryPrice(getItemNameFromImageName(buttonName[0]));
                    this.bouquetPriceBeforeDiscount -= accessoryPrice;
                    this.bouquetPriceAfterDiscount -= Decimal.Round((decimal)accessoryPrice * 0.95m, 2);
                }
            }
            else
            {
                if (buttonName[1] == "fleur")
                {
                    float flowerPrice = getFlowerPrice(getItemNameFromImageName(buttonName[0]));
                    this.bouquetPriceAfterDiscount -= (decimal)flowerPrice;
                }
                else
                {
                    float accessoryPrice = getAccessoryPrice(getItemNameFromImageName(buttonName[0]));
                    this.bouquetPriceAfterDiscount -= (decimal)accessoryPrice;
                }
            }
            this.totalPriceBeforeDiscountLabel.Text = $"{this.bouquetPriceBeforeDiscount}€";
            this.totalPriceLabel.Text = $"Total : {this.bouquetPriceAfterDiscount}€";
            this.totalPriceLabel.Left = (this.orderDetailsPanel.Width - this.totalPriceLabel.Width) / 2;
            this.totalPriceBeforeDiscountLabel.Left = (this.orderDetailsPanel.Width - this.totalPriceBeforeDiscountLabel.Width) / 2;
        }


        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            fillInStockFlowerComboBox(true);
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
                    "WHERE nomMagasin = @shopName AND quantite > 0;"; // On récupère tous les bouquets stockés par le magasin choisi
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
                "WHERE nomMagasin = @shopName AND quantite > 0;";
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
        /// <param name="resetByDatePicker">Si la méthode a été appelée lorsque la valeur de la date change</param>
        private void fillInStockFlowerComboBox(bool resetByDatePicker = false)
        {
            if (!resetByDatePicker)
            {
                this.bouquetPersoFlowLayoutPanel.Controls.Clear();
                this.inStockFlowerComboBox.Items.Clear();
            }

            string queryGetAllStockFlowers = "SELECT nomFleur, quantite FROM stockFleur NATURAL JOIN fleur" +
                " WHERE nomMagasin = @shopName AND date_format(@currentDate, '%m-%d') >= date_format(dateDebutDispo, '%m-%d')" +
                " AND date_format(@currentDate, '%m-%d') <= date_format(dateFinDispo, '%m-%d') AND quantite > 0;";
            MySqlCommand command = new MySqlCommand(queryGetAllStockFlowers, connection);
            addParametersToCommand(command, createCustomParameter("@shopName", this.shopComboBox.Text.Split(" | ")[0], MySqlDbType.VarChar),
                                            createCustomParameter("@currentDate", this.datePicker.Value.ToString("yyyy-MM-dd"), MySqlDbType.Date));
            MySqlDataReader reader = command.ExecuteReader();
            List<string> flowersReturned = new List<string>();
            while (reader.Read())
            {
                flowersReturned.Add($"{reader.GetString("nomFleur")} | En stock : {reader.GetFloat("quantite")}");
            }
            reader.Close();

            foreach (string flower in flowersReturned)
            {
                if (!this.inStockFlowerComboBox.Items.Contains(flower))
                {
                    this.inStockFlowerComboBox.Items.Add(flower);
                }
            }

            foreach (string flower in this.inStockFlowerComboBox.Items)
            {
                if (!flowersReturned.Contains(flower))
                {
                    this.inStockFlowerComboBox.Items.Remove(flower);
                }
            }
        }


        /// <summary>
        /// Méthode permettant d'obtenir le nom de l'image associée à un nom de bouquet ou item
        /// </summary>
        /// <param name="name">Le nom du bouquet ou de l'item</param>
        /// <returns>Le nom de l'image correspondant au nom du bouquet ou de l'item</returns>
        public static string getImageNameFromItemName(string name)
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
        public static string getItemNameFromImageName(string name)
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
        public float getBouquetStandardPrice()
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
        public static float getFlowerPrice(string flowerName)
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
        public static float getAccessoryPrice(string accessoryName)
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


        /// <summary>
        /// Méthode permettant d'obtenir le stock d'un item (accessoire ou fleur) dans un certain magasin
        /// </summary>
        /// <param name="itemName">Le nom de l'item dont on cherche le stock</param>
        /// <param name="tableName">La table de l'item (fleur ou accessoire)</param>
        /// <param name="itemId">L'id de l'item</param>
        /// <returns>Le stock de l'item dans le magasin</returns>
        private int getItemStock(string itemName, string tableName, int itemId)
        {
            string queryGetItemStock = $"SELECT quantite from stock{tableName} where nomMagasin = @shopName and id{tableName} = {itemId};";
            MySqlCommand command = new MySqlCommand(queryGetItemStock, connection);
            addParametersToCommand(command, createCustomParameter("@shopName", this.shopComboBox.Text.Split(" | ")[0], MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            int itemStock = 0;
            if (reader.Read())
            {
                itemStock = reader.GetInt32(0);
            }
            reader.Close();
            return itemStock;
        }


        /// <summary>
        /// Méthode permettant d'obtenir le nom de la clé primaire d'une table
        /// </summary>
        /// <param name="tableName">La table dont on cherche le nom de la clé primaire</param>
        /// <returns>Le nom de la clé primaire de la table</returns>
        private string getItemIdNameFromTableName(string tableName)
        {
            switch (tableName)
            {
                case "bouquetStandard":
                    return "nomBouquet";

                case "arrangementFloral":
                    return "idArrangement";

                case "accessoire":
                    return "idAccessoire";

                case "fleur":
                    return "idFleur";

                case "bouquetPerso":
                    return "idBouquetPerso";

                case "commande":
                    return "idCommande";
                default:
                    return "";
            }
        }


        /// <summary>
        /// Méthode permettant d'obtenir le prochain id à ajouter dans une table
        /// </summary>
        /// <param name="tableName">Le nom de la table dont on cherche le prochain id</param>
        /// <returns>Le prochain id</returns>
        private int getNextId(string tableName)
        {
            string queryGetMaxId = $"SELECT max({getItemIdNameFromTableName(tableName)}) + 1 FROM {tableName}";
            MySqlCommand command = new MySqlCommand(queryGetMaxId, connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int maxId = 1;
            try
            {
                maxId = reader.GetInt32(0);
            }
            catch (Exception ex) { }
            reader.Close();
            return maxId;
        }


        /// <summary>
        /// Méthode permettant d'obtenir l'id d'un accessoire ou d'une fleur à partir de son nom et de sa table
        /// </summary>
        /// <param name="itemName">Nom de l'item</param>
        /// <param name="itemTable">Nom de la table</param>
        /// <returns>L'id de l'item</returns>
        public static int getItemIdFromName(string itemName, string itemTable)
        {
            string queryGetItemIdFromName = $"SELECT id{itemTable} FROM {itemTable} WHERE nom{itemTable} = @itemName";
            MySqlCommand command = new MySqlCommand(queryGetItemIdFromName, connection);
            addParametersToCommand(command, createCustomParameter("@itemName", itemName, MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            int itemId = 0;
            if (reader.Read())
            {
                itemId = reader.GetInt32(0);
            }
            reader.Close();
            return itemId;
        }


        /// <summary>
        /// Méthode permettant d'obtenir tous les items (distincts) composant le bouquet perso ainsi
        /// que la quantité commandée de chaque item
        /// </summary>
        /// <returns>Un dictionnaire contenant comme clé le nom de l'item et comme la valeur
        /// la quantité commandée</returns>
        private Dictionary<string, int> getOrderedItemsAndQuantities()
        {
            Dictionary<string, int> orderedItemsAndQuantities = new Dictionary<string, int>();
            foreach (Button button in this.bouquetPersoFlowLayoutPanel.Controls)
            {
                if (!orderedItemsAndQuantities.ContainsKey(button.Name))
                {
                    orderedItemsAndQuantities.Add(button.Name, 1);
                }
                else
                {
                    orderedItemsAndQuantities[button.Name] += 1;
                }
            }
            return orderedItemsAndQuantities;
        }


        /// <summary>
        /// Méthode permettant d'actualiser le stock d'un bouquet, d'une fleur ou d'un accessoire en fonction de la quantité
        /// commandée par le client
        /// </summary>
        /// <param name="shopName">Le nom du magasin dont on veut actualiser le stock</param>
        /// <param name="itemName">Paramètre facultatif représentant le nom du bouquet s'il s'agit d'un bouquet standard</param>
        /// <param name="itemTable">Paramètre facultatif représentant le nom de la table de l'item (fleur ou accessoire)</param>
        /// <param name="itemId">Paramètre facultatif représentant l'id de l'item</param>
        /// <param name="quantity">Paramètre facultatif représentant la quantité de l'item commandé</param>
        public static void updateItemStock(string shopName, string itemName = "", string itemTable = "", int itemId = 0, int quantity = 1)
        {
            MySqlParameter shop = createCustomParameter("@shopName", shopName, MySqlDbType.VarChar);
            if (itemTable == "stockBouquet")
            {
                string queryUpdateBouquetStock = $"UPDATE stockBouquet SET quantite = quantite - {quantity} WHERE " +
                                                 $"nomBouquet = @itemName AND nomMagasin = @shopName;";
                MySqlCommand command = new MySqlCommand(queryUpdateBouquetStock, connection);
                addParametersToCommand(command, shop, createCustomParameter("@itemName", itemName, MySqlDbType.VarChar));
                command.ExecuteNonQuery();
                return;
            }

            string queryUpdateItemStock = $"UPDATE stock{itemTable} SET quantite = quantite - {quantity} WHERE " +
                                          $"id{itemTable} = {itemId} AND nomMagasin = @shopName;";
            MySqlCommand comand = new MySqlCommand(queryUpdateItemStock, connection);
            comand.Parameters.Add(shop);
            comand.ExecuteNonQuery();
        }


        private string getFidelity()
        {
            string queryGetFidelity = "SELECT fidelite FROM client WHERE email = @userEmail;";
            MySqlCommand command = new MySqlCommand(queryGetFidelity, connection);
            addParametersToCommand(command, createCustomParameter("@userEmail", this.user.email, MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            string fidelity = "";
            if (reader.Read())
            {
                fidelity = reader.GetString(0);
                reader.Close();
                return fidelity;
            }
            reader.Close();
            return fidelity;
        }


        private void updateFidelity()
        {
            string queryGetFidelity = "SELECT count(email) FROM commande WHERE email = @userEmail AND" +
                " date_format(dateCommande, 'yyyy-MM') = date_format(@currentDate, 'yyyy-MM');";
            MySqlCommand command = new MySqlCommand(queryGetFidelity, connection);
            addParametersToCommand(command, createCustomParameter("@userEmail", this.user.email, MySqlDbType.VarChar),
                                            createCustomParameter("@currentDate", this.datePicker.Value.ToString("yyyy-MM"), MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            int ordersAmount = 0;
            if (reader.Read())
            {
                ordersAmount = reader.GetInt32(0);
            }
            reader.Close();

            string queryUpdateFidelity = "";
            if (ordersAmount >= 5)
            {
                queryUpdateFidelity = "UPDATE client SET fidelite = 'Or' WHERE email = @userEmail;";
                this.user.fidelite = "Or";
                command.Parameters.Clear();
                command.CommandText = queryUpdateFidelity;
                addParametersToCommand(command, createCustomParameter("@userEmail", this.user.email, MySqlDbType.VarChar));
                command.ExecuteNonQuery();
            }
            else if (ordersAmount >= 2)
            {
                queryUpdateFidelity = "UPDATE client SET fidelite = 'Bronze' WHERE email = @userEmail;";
                this.user.fidelite = "Bronze";
                command.Parameters.Clear();
                command.CommandText = queryUpdateFidelity;
                addParametersToCommand(command, createCustomParameter("@userEmail", this.user.email, MySqlDbType.VarChar));
                command.ExecuteNonQuery();
            }

        }


        /// <summary>
        /// Méthode permettant de mettre à jour le texte de fidélité
        /// </summary>
        private void updateFidelityLabel()
        {
            if (this.user.fidelite == "Or")
            {
                this.fidelityLabel.Text = "15% de réduction avec la fidélité Or";
                this.fidelityLabel.Visible = true;
                this.totalPriceBeforeDiscountLabel.Visible = true;
            }
            else if (this.user.fidelite == "Bronze")
            {
                this.fidelityLabel.Text = "5% de rédution avec la fidélité Bronze";
                this.fidelityLabel.Visible = true;
                this.totalPriceBeforeDiscountLabel.Visible = true;
            }
            this.fidelityLabel.Left = (this.orderDetailsPanel.Width - this.fidelityLabel.Width) / 2;
        }

        #endregion

    }
}
