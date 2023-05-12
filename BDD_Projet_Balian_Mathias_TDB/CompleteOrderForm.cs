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
    public partial class CompleteOrderForm : Form
    {
        private AllOrdersForm aof;
        private int orderId;
        private decimal totalPrice;
        private string shop;
        private string fidelity;
        private string description;
        private decimal budget;


        public CompleteOrderForm(AllOrdersForm aof, int orderId)
        {
            InitializeComponent();
            this.aof = aof;
            this.orderId = orderId;
            this.shop = getOrderShop();
            this.fidelity = getClientFidelity();
            if (this.fidelity == "Or")
            {
                this.fidelityLabel.Text = "15% de réduction avec la fidélité Or";
                this.fidelityLabel.Visible = true;
            }
            else if (this.fidelity == "Bronze")
            {
                this.fidelityLabel.Text = "5% de réduction avec la fidélité Bronze";
                this.fidelityLabel.Visible = true;
            }
            fillInStockAccessoryComboBox();
            fillInStockFlowerComboBox();
            getBudgetAndDescription();
        }


        private void finalizeButton_Click(object sender, EventArgs e)
        {
            // Vérification que l'admin ne commande pas trop d'items par rapport au stock
            Dictionary<string, int> orderedItemsAndQuantities = getOrderedItemsAndQuantities();
            foreach (var (item, quantity) in orderedItemsAndQuantities)
            {
                string[] itemNameAndTable = item.Split(" | ");
                string itemName = OrderForm.getItemNameFromImageName(itemNameAndTable[0]);
                string itemTable = itemNameAndTable[1];
                int itemId = OrderForm.getItemIdFromName(itemName, itemTable);
                int itemStock = getItemStock(itemName, itemTable, itemId);
                if (quantity > itemStock)
                {
                    MessageBox.Show($"Il n'y a pas suffisamment de {itemName} dans le magasin {this.shop}. Vous en avez commandé" +
                        $" {quantity}, mais il n'y en a que {itemStock} en stock. Veuillez recommencer.");
                    return;
                }
            }

            // Association entre bouquet perso et accessoires / fleurs
            MySqlCommand command = new MySqlCommand("", connection);
            int bouquetPersoId = getBouquetPersoId();
            foreach (var (item, quantity) in orderedItemsAndQuantities)
            {
                string[] itemNameAndTable = item.Split(" | ");
                string itemName = OrderForm.getItemNameFromImageName(itemNameAndTable[0]);
                string itemTable = itemNameAndTable[1];
                int itemId = OrderForm.getItemIdFromName(itemName, itemTable);

                command.CommandText = $"INSERT INTO bouquetPersoContient{itemTable} VALUES ({bouquetPersoId}, " +
                                                                                            $"{itemId}, " +
                                                                                            $"{quantity});";
                command.ExecuteNonQuery();
                OrderForm.updateItemStock(this.shop, itemTable: itemTable, itemId: itemId, quantity: quantity);
            }

            // Mise à jour du prix de la commande
            string formattedPrice = $"{Decimal.Round(this.totalPrice, 2)}".Replace(",", ".");
            string queryUpdateOrderTotalPrice = $"UPDATE commande SET prixTotal = {formattedPrice} WHERE idCommande = {this.orderId};";
            command.CommandText = queryUpdateOrderTotalPrice;
            command.ExecuteNonQuery();

            string queryUpdateOrderState = $"UPDATE commande SET etatCommande = @orderState WHERE idCommande = {this.orderId};";
            command.CommandText = queryUpdateOrderState;
            command.Parameters.Add(createCustomParameter("@orderState", "CC", MySqlDbType.VarChar));
            command.ExecuteNonQuery();
            if (aof.orderToCompleteCheckBox.Checked)
            {
                aof.getOrdersToComplete(aof.allClientsComboBox.Text == "Tous" || String.IsNullOrEmpty(aof.allClientsComboBox.Text),
                            aof.allShopsComboBox.Text == "Tous" || String.IsNullOrEmpty(aof.allShopsComboBox.Text));
            }
            else
            {
                aof.getOrders(aof.allClientsComboBox.Text == "Tous" || String.IsNullOrEmpty(aof.allClientsComboBox.Text),
                            aof.allShopsComboBox.Text == "Tous" || String.IsNullOrEmpty(aof.allShopsComboBox.Text));
            }
            this.Close();
        }


        private void addAccessoryButton_Click(object sender, EventArgs e)
        {
            string imageName = OrderForm.getImageNameFromItemName(this.inStockAccessoryComboBox.Text.Split(" | ")[0]);
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
                float accessoryPrice = OrderForm.getAccessoryPrice(this.inStockAccessoryComboBox.Text.Split(" | ")[0]);
                if (this.fidelity == "Or")
                {
                    if (this.totalPrice + Decimal.Round((decimal)accessoryPrice * 0.85m, 2) > this.budget)
                    {
                        MessageBox.Show("Vous dépassez le budget du client !");
                        return;
                    }
                    this.totalPrice += Decimal.Round((decimal)accessoryPrice * 0.85m, 2);
                }
                else if (this.fidelity == "Bronze")
                {
                    if (this.totalPrice + Decimal.Round((decimal)accessoryPrice * 0.95m, 2) > this.budget)
                    {
                        MessageBox.Show("Vous dépassez le budget du client !");
                        return;
                    }
                    this.totalPrice += Decimal.Round((decimal)accessoryPrice * 0.95m, 2);
                }
                else
                {
                    if (this.totalPrice + (decimal)accessoryPrice > this.budget)
                    {
                        MessageBox.Show("Vous dépassez le budget du client !");
                        return;
                    }
                    this.totalPrice += (decimal)accessoryPrice;
                }

                this.bouquetPersoFlowLayoutPanel.Controls.Add(itemButton);
                this.totalPriceLabel.Text = $"Total : {this.totalPrice}€";
            }
        }


        private void addFlowerButton_Click(object sender, EventArgs e)
        {
            string imageName = OrderForm.getImageNameFromItemName(this.inStockFlowerComboBox.Text.Split(" | ")[0]);
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
                float flowerPrice = OrderForm.getFlowerPrice(this.inStockFlowerComboBox.Text.Split(" | ")[0]);
                if (this.fidelity == "Or")
                {
                    if (this.totalPrice + Decimal.Round((decimal)flowerPrice * 0.85m, 2) > this.budget)
                    {
                        MessageBox.Show("Vous dépassez le budget du client !");
                        return;
                    }
                    this.totalPrice += Decimal.Round((decimal)flowerPrice * 0.85m, 2);
                }
                else if (this.fidelity == "Bronze")
                {
                    if (this.totalPrice + Decimal.Round((decimal)flowerPrice * 0.95m, 2) > this.budget)
                    {
                        MessageBox.Show("Vous dépassez le budget du client !");
                        return;
                    }
                    this.totalPrice += Decimal.Round((decimal)flowerPrice * 0.95m, 2);
                }
                else
                {
                    if (this.totalPrice + (decimal)flowerPrice > this.budget)
                    {
                        MessageBox.Show("Vous dépassez le budget du client !");
                        return;
                    }
                    this.totalPrice += (decimal)flowerPrice;
                }

                this.bouquetPersoFlowLayoutPanel.Controls.Add(itemButton);
                this.totalPriceLabel.Text = $"Total : {this.totalPrice}€";
            }
        }


        private void itemButton_Click(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;
            this.bouquetPersoFlowLayoutPanel.Controls.Remove(thisButton);
            string[] buttonName = thisButton.Name.Split(" | ");
            if (this.fidelity == "Or")
            {
                if (buttonName[1] == "fleur")
                {
                    float flowerPrice = OrderForm.getFlowerPrice(OrderForm.getItemNameFromImageName(buttonName[0]));
                    this.totalPrice -= Decimal.Round((decimal)flowerPrice * 0.85m, 2);
                }
                else
                {
                    float accessoryPrice = OrderForm.getAccessoryPrice(OrderForm.getItemNameFromImageName(buttonName[0]));
                    this.totalPrice -= Decimal.Round((decimal)accessoryPrice * 0.85m, 2);
                }

            }
            else if (this.fidelity == "Bronze")
            {
                if (buttonName[1] == "fleur")
                {
                    float flowerPrice = OrderForm.getFlowerPrice(OrderForm.getItemNameFromImageName(buttonName[0]));
                    this.totalPrice -= Decimal.Round((decimal)flowerPrice * 0.95m, 2);
                }
                else
                {
                    float accessoryPrice = OrderForm.getAccessoryPrice(OrderForm.getItemNameFromImageName(buttonName[0]));
                    this.totalPrice -= Decimal.Round((decimal)accessoryPrice * 0.95m, 2);
                }
            }
            else
            {
                if (buttonName[1] == "fleur")
                {
                    float flowerPrice = OrderForm.getFlowerPrice(OrderForm.getItemNameFromImageName(buttonName[0]));
                    this.totalPrice -= (decimal)flowerPrice;
                }
                else
                {
                    float accessoryPrice = OrderForm.getAccessoryPrice(OrderForm.getItemNameFromImageName(buttonName[0]));
                    this.totalPrice -= (decimal)accessoryPrice;
                }
            }
            this.totalPriceLabel.Text = $"Total : {this.totalPrice}€";
        }



        #region Méthodes utiles

        /// <summary>
        /// Méthode permettant d'obtenir la fidélité du client ayant placé la commande
        /// </summary>
        /// <returns>Une string contenant la fidélité du client</returns>
        private string getClientFidelity()
        {
            string getClientFidelity = $"SELECT fidelite FROM commande NATURAL JOIN client WHERE idCommande = {this.orderId};";
            MySqlCommand command = new MySqlCommand(getClientFidelity, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string fidelity = reader.GetString(0);
                reader.Close();
                return fidelity;
            }
            reader.Close();
            return "";
        }


        /// <summary>
        /// Méthode permettant d'obtenir le budget et la description du bouquet indiqués par le client
        /// </summary>
        private void getBudgetAndDescription()
        {
            string queryGetBudgetAndDescription = "SELECT prixTotal, descriptionBouquet FROM commande NATURAL JOIN arrangementFloral" +
                $" NATURAL JOIN bouquetPerso WHERE idCommande = {this.orderId};";
            MySqlCommand command = new MySqlCommand(queryGetBudgetAndDescription, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                this.budget = reader.GetDecimal(0);
                this.description = reader.GetString(1);
            }
            reader.Close();
            this.budgetLabel.Text = $"Budget : {this.budget}€";
            this.bouquetDescriptionTextBox.Text = this.description;
        }


        /// <summary>
        /// Méthode permettant de remplir la combobox dédiée aux accessoires
        /// </summary>
        private void fillInStockAccessoryComboBox()
        {
            this.inStockAccessoryComboBox.Items.Clear();
            this.bouquetPersoFlowLayoutPanel.Controls.Clear();

            string queryGetAllStockAccessory = "SELECT nomAccessoire, quantite FROM stockAccessoire NATURAL JOIN accessoire " +
                "WHERE nomMagasin = @shopName AND quantite > 0;";
            MySqlCommand command = new MySqlCommand(queryGetAllStockAccessory, connection);
            addParametersToCommand(command, createCustomParameter("@shopName", this.shop, MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.inStockAccessoryComboBox.Items.Add($"{reader.GetString(0)} | En stock : {reader.GetFloat(1)}");
            }
            reader.Close();
        }


        /// <summary>
        /// Méthode permettant de remplir la combobox dédiée aux fleurs
        /// </summary>
        private void fillInStockFlowerComboBox()
        {
            this.inStockFlowerComboBox.Items.Clear();
            this.bouquetPersoFlowLayoutPanel.Controls.Clear();

            string queryGetAllStockAccessory = "SELECT nomFleur, quantite FROM stockFleur NATURAL JOIN fleur " +
                "WHERE nomMagasin = @shopName AND quantite > 0;";
            MySqlCommand command = new MySqlCommand(queryGetAllStockAccessory, connection);
            addParametersToCommand(command, createCustomParameter("@shopName", this.shop, MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.inStockFlowerComboBox.Items.Add($"{reader.GetString(0)} | En stock : {reader.GetFloat(1)}");
            }
            reader.Close();
        }


        /// <summary>
        /// Méthode permettant d'obtenir le magasin dans lequel la commande a été passée
        /// </summary>
        /// <returns>Une string contenant le nom du magasin</returns>
        private string getOrderShop()
        {
            string queryGetOrderShop = $"SELECT nomMagasin FROM commande WHERE idCommande = {this.orderId};";
            MySqlCommand command = new MySqlCommand(queryGetOrderShop, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string shop = reader.GetString(0);
                reader.Close();
                return shop;
            }
            reader.Close();
            return "";
        }


        /// <summary>
        /// Méthode permettant d'obtenir l'id du bouquet perso associé à cette commande
        /// </summary>
        /// <returns>Un entier représentant l'id du bouquet perso</returns>
        private int getBouquetPersoId()
        {
            string queryGetBouquetPersoId = "SELECT idBouquetPerso FROM commande NATURAL JOIN arrangementFloral " +
                "NATURAL JOIN arrangementEstComposeBouquetPerso" +
                " NATURAL JOIN bouquetPerso" +
                $" WHERE idCommande = {this.orderId};";
            MySqlCommand command = new MySqlCommand(queryGetBouquetPersoId, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                reader.Close();
                return id;
            }
            reader.Close();
            return 0;
        }


        /// <summary>
        /// Méthode permettant d'obtenir les items et leur quantité choisie par l'admin
        /// </summary>
        /// <returns>Un dictionaire dont la clé est le nom de l'item et la valeur est la quantité commandée</returns>
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
        /// Méthode permettant d'obtenir le stock d'un item
        /// </summary>
        /// <param name="itemName">Le nom de l'item</param>
        /// <param name="tableName">La table de l'item (accessoire ou fleur)</param>
        /// <param name="itemId">L'id de l'item</param>
        /// <returns>La quantité en stock de cet item</returns>
        private int getItemStock(string itemName, string tableName, int itemId)
        {
            string queryGetItemStock = $"SELECT quantite from stock{tableName} where nomMagasin = @shopName and id{tableName} = {itemId};";
            MySqlCommand command = new MySqlCommand(queryGetItemStock, connection);
            addParametersToCommand(command, createCustomParameter("@shopName", this.shop, MySqlDbType.VarChar));
            MySqlDataReader reader = command.ExecuteReader();
            int itemStock = 0;
            if (reader.Read())
            {
                itemStock = reader.GetInt32(0);
            }
            reader.Close();
            return itemStock;
        }

        #endregion

    }
}
