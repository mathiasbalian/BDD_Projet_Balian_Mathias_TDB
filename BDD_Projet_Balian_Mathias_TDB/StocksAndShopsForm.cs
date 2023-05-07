using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.X509;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BDD_Projet_Balian_Mathias_TDB
{
    public partial class StocksAndShopsForm : Form
    {
        private User user;
        private bool isUserActionClose = false; // Pour vérifier si le form est fermé à partir 
        // du bouton "X"
        private bool dateTimerPaused = false;

        private class Stock
        {
            public string nomProduit { get; set; }
            public string nomMagasin { get; set; }
            public int quantite { get; set; }

            public Stock(string productName, string shopName, int quantityStock)
            {
                this.nomProduit = productName;
                this.nomMagasin = shopName;
                this.quantite = quantityStock;
            }
        }


        public StocksAndShopsForm(User user, DateTime date)
        {
            InitializeComponent();
            this.user = user;
            this.datePicker.Value = date;
            this.dateTimer.Start(); // Lancement du timer pour le défilement de la date

        }


        private void StocksAndShopsForms_FormClosing(object sender, FormClosingEventArgs e)
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


        private void allProductsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            getStocks(this.allProductsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allProductsComboBox.Text),
                            this.allShopsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allShopsComboBox.Text));
        }


        private void allShopsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            getStocks(this.allProductsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allProductsComboBox.Text),
                            this.allShopsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allShopsComboBox.Text));
        }


        private void stocksAndShopsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string result = Interaction.InputBox("Saisir la nouvelle quantité en stock", "Modification stock");
                int newStock;
                if (int.TryParse(result, out newStock) && newStock >= 0)
                {
                    string itemName = (string)this.stocksAndShopsGridView.Rows[e.RowIndex].Cells["nomProduit"].Value;
                    updateItemStock((string)this.stocksAndShopsGridView.Rows[e.RowIndex].Cells["nomMagasin"].Value,
                                              itemName: itemName,
                                              quantity: newStock,
                                              itemTable: getItemTableName(itemName));
                    getStocks(this.allProductsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allProductsComboBox.Text),
                            this.allShopsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allShopsComboBox.Text));
                }
                else
                {
                    MessageBox.Show("Quantité non valide");
                }
            }
        }


        private void addNewShopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.addNewShopCheckBox.Checked)
            {
                this.shopNameTextBox.Visible = true;
                this.shopCityTextBox.Visible = true;
                this.addShopButton.Visible = true;
                return;
            }
            this.shopNameTextBox.Visible = false;
            this.shopCityTextBox.Visible = false;
            this.addShopButton.Visible = false;
        }


        private void addShopButton_Click(object sender, EventArgs e)
        {
            string queryAddProduct = $"INSERT INTO magasin VALUES (@shopName, @shopCity);";
            MySqlCommand command = new MySqlCommand(queryAddProduct, connection);
            addParametersToCommand(command, createCustomParameter("@shopName", this.shopNameTextBox.Text, MySqlDbType.VarChar),
                                            createCustomParameter("@shopCity", this.shopCityTextBox.Text, MySqlDbType.VarChar));
            command.ExecuteNonQuery();
            foreach (string product in this.allProductsComboBox.Items)
            {
                command.Parameters.Clear();
                if (product != "Tous")
                {
                    if (product.Split(" | ")[1] == "Bouquet standard")
                    {
                        queryAddProduct = "INSERT INTO stockBouquet VALUES (@bouquetName, @shopName, 0)";
                        addParametersToCommand(command, createCustomParameter("@bouquetName", product.Split(" | ")[0], MySqlDbType.VarChar),
                                                        createCustomParameter("@shopName", this.shopNameTextBox.Text, MySqlDbType.VarChar));
                    }
                    else if (product.Split(" | ")[1] == "Accessoire")
                    {
                        queryAddProduct = $"INSERT INTO stockAccessoire VALUES ({OrderForm.getItemIdFromName(product.Split(" | ")[0], "accessoire")}, " +
                            "@shopName, 0)";
                        addParametersToCommand(command, createCustomParameter("@shopName", this.shopNameTextBox.Text, MySqlDbType.VarChar));
                    }
                    else
                    {
                        queryAddProduct = $"INSERT INTO stockFleur VALUES ({OrderForm.getItemIdFromName(product.Split(" | ")[0], "fleur")}, " +
                            "@shopName, 0)";
                        addParametersToCommand(command, createCustomParameter("@shopName", this.shopNameTextBox.Text, MySqlDbType.VarChar));
                    }

                    command.CommandText = queryAddProduct;
                    command.ExecuteNonQuery();
                }

            }
            getAllShops();
            getStocks(this.allProductsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allProductsComboBox.Text),
                            this.allShopsComboBox.Text == "Tous" || String.IsNullOrEmpty(this.allShopsComboBox.Text));
        }


        private void StocksAndShopsForms_Load(object sender, EventArgs e)
        {
            getAllShops();
            getAllProducts();
            getStocks(true, true);
            checkStocks();
        }

        #region Méthodes utiles

        /// <summary>
        /// Méthode permettant d'obtenir tous les magasins
        /// </summary>
        private void getAllShops()
        {
            this.allShopsComboBox.Items.Clear();
            this.allShopsComboBox.Items.Add("Tous");
            string queryGetAllShops = "SELECT nomMagasin, ville FROM magasin;";
            MySqlCommand command = new MySqlCommand(queryGetAllShops, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // On ajoute à la liste des magasins chaque magasin avec son nom et sa ville
                this.allShopsComboBox.Items.Add($"{reader.GetString(0)} | {reader.GetString(1)}");
            }
            reader.Close();
        }


        /// <summary>
        /// Méthode permettant d'obtenir tous les produits disponibles dans le catalogue
        /// </summary>
        private void getAllProducts()
        {
            this.allProductsComboBox.Items.Clear();
            this.allProductsComboBox.Items.Add("Tous");

            // Bouquets standard
            string queryGetAllBouquets = "SELECT nomBouquet FROM bouquetStandard;";
            MySqlCommand command = new MySqlCommand(queryGetAllBouquets, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.allProductsComboBox.Items.Add($"{reader.GetString(0)} | Bouquet standard");
            }
            reader.Close();

            // Accessoires
            string queryGetAllAccessories = "SELECT nomAccessoire from accessoire;";
            command.CommandText = queryGetAllAccessories;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.allProductsComboBox.Items.Add($"{reader.GetString(0)} | Accessoire");
            }
            reader.Close();

            // Fleurs
            string queryGetAllFlowers = "SELECT nomFleur from fleur;";
            command.CommandText = queryGetAllFlowers;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.allProductsComboBox.Items.Add($"{reader.GetString(0)} | Fleur");
            }
            reader.Close();
        }


        /// <summary>
        /// Méthode permettant d'obtenir tous les stocks, par produit et / ou par magasin
        /// </summary>
        /// <param name="allProducts">true si on cherche les stocks de tous les produits, false si on cherche
        /// les stocks d'un seul produit</param>
        /// <param name="allShops">true si on cherche les stocks de tous les magasins, false si on cherche
        /// les stocks d'un seul magasin</param>
        private void getStocks(bool allProducts, bool allShops)
        {
            MySqlCommand command = new MySqlCommand("", connection);
            string queryGetStocks;
            List<Stock> stocks = new List<Stock>();

            if (allProducts && allShops) // Si tous les produits et tous les magasins
            {
                // Bouquets standards
                queryGetStocks = "SELECT nomBouquet, nomMagasin, quantite FROM stockbouquet NATURAL JOIN bouquetStandard ORDER BY nomBouquet;";

                command.CommandText = queryGetStocks;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    stocks.Add(new Stock(reader.GetString(0), reader.GetString(1), reader.GetInt32(2)));
                }
                reader.Close();

                // Accessoires
                queryGetStocks = "SELECT nomAccessoire, nomMagasin, quantite FROM stockAccessoire NATURAL JOIN accessoire ORDER BY nomAccessoire;";
                command.CommandText = queryGetStocks;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    stocks.Add(new Stock(reader.GetString(0), reader.GetString(1), reader.GetInt32(2)));
                }
                reader.Close();

                // Fleurs
                queryGetStocks = "SELECT nomFleur, nomMagasin, quantite FROM stockFleur NATURAL JOIN fleur ORDER BY nomFleur;";
                command.CommandText = queryGetStocks;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    stocks.Add(new Stock(reader.GetString(0), reader.GetString(1), reader.GetInt32(2)));
                }
                reader.Close();
                this.stocksAndShopsGridView.DataSource = stocks;
            }

            else if (allProducts && !allShops) // Si tous les produits mais un seul magasin
            {
                // Bouquets standards
                queryGetStocks = "SELECT nomBouquet, nomMagasin, quantite FROM stockbouquet NATURAL JOIN bouquetStandard" +
                    " WHERE nomMagasin = @shopName;";

                command.CommandText = queryGetStocks;
                addParametersToCommand(command, createCustomParameter("@shopName", this.allShopsComboBox.Text.Split(" | ")[0], MySqlDbType.VarChar));
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    stocks.Add(new Stock(reader.GetString(0), reader.GetString(1), reader.GetInt32(2)));
                }
                reader.Close();

                // Accessoires
                queryGetStocks = "SELECT nomAccessoire, nomMagasin, quantite FROM stockAccessoire NATURAL JOIN accessoire" +
                    " WHERE nomMagasin = @shopName;";
                command.CommandText = queryGetStocks;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    stocks.Add(new Stock(reader.GetString(0), reader.GetString(1), reader.GetInt32(2)));
                }
                reader.Close();

                // Fleurs
                queryGetStocks = "SELECT nomFleur, nomMagasin, quantite FROM stockFleur NATURAL JOIN fleur" +
                    " WHERE nomMagasin = @shopName;";
                command.CommandText = queryGetStocks;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    stocks.Add(new Stock(reader.GetString(0), reader.GetString(1), reader.GetInt32(2)));
                }
                reader.Close();

                this.stocksAndShopsGridView.DataSource = stocks;
            }

            else if (!allProducts && allShops) // Si un seul produit mais tous les magasins
            {
                string[] productDetails = this.allProductsComboBox.Text.Split(" | ");
                productDetails[1] = (productDetails[1] == "Bouquet standard") ? "bouquet" : productDetails[1];
                queryGetStocks = $"SELECT nom{productDetails[1]}, nomMagasin, quantite FROM stock{productDetails[1]} NATURAL JOIN {productDetails[1]}" +
                    ((productDetails[1] == "bouquet") ? "standard" : "") +
                    $" WHERE nom{productDetails[1]} = @productName;";

                command.CommandText = queryGetStocks;
                addParametersToCommand(command, createCustomParameter("@productName", productDetails[0], MySqlDbType.VarChar));
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    stocks.Add(new Stock(reader.GetString(0), reader.GetString(1), reader.GetInt32(2)));
                }
                reader.Close();
                this.stocksAndShopsGridView.DataSource = stocks;
            }

            else if (!allProducts && !allShops) // Si un seul produit et un seul magasin
            {
                string[] productDetails = this.allProductsComboBox.Text.Split(" | ");
                productDetails[1] = (productDetails[1] == "Bouquet standard") ? "bouquet" : productDetails[1];
                queryGetStocks = $"SELECT nom{productDetails[1]}, nomMagasin, quantite FROM stock{productDetails[1]} NATURAL JOIN {productDetails[1]}" +
                    ((productDetails[1] == "bouquet") ? "standard" : "") +
                    $" WHERE " +
                    $"nomMagasin = @shopName AND nom{productDetails[1]} = @productName;";
                command.CommandText = queryGetStocks;
                addParametersToCommand(command, createCustomParameter("@shopName", this.allShopsComboBox.Text.Split(" | ")[0], MySqlDbType.VarChar),
                                                createCustomParameter("@productName", productDetails[0], MySqlDbType.VarChar));
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    stocks.Add(new Stock(reader.GetString(0), reader.GetString(1), reader.GetInt32(2)));
                }
                reader.Close();
                this.stocksAndShopsGridView.DataSource = stocks;
            }

            // Ajout de la colonne Modifier stock
            if (this.stocksAndShopsGridView.Columns.Count == 3)
            {
                DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
                dataGridViewButtonColumn.Text = "Modifier le stock";
                dataGridViewButtonColumn.Name = "Modifier";
                dataGridViewButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewButtonColumn.FlatStyle = FlatStyle.System;
                dataGridViewButtonColumn.DefaultCellStyle.BackColor = Color.RoyalBlue;
                dataGridViewButtonColumn.UseColumnTextForButtonValue = true;

                this.stocksAndShopsGridView.Columns.Add(dataGridViewButtonColumn);
                foreach (DataGridViewColumn column in this.stocksAndShopsGridView.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            checkStocks();
            this.stocksAndShopsGridView.ClearSelection();

        }


        /// <summary>
        /// Méthode permettant d'obtenir le nom de la table associée à un produit
        /// </summary>
        /// <param name="itemName">Le nom du produit</param>
        /// <returns>Le nom de la table</returns>
        private string getItemTableName(string itemName)
        {
            switch (itemName)
            {
                case "Gros Merci":
                case "L'Amoureux":
                case "L'Exotique":
                case "Maman":
                case "Vive la mariée":
                    return "bouquet";

                case "Boîte pour bouquet":
                case "Feuille dorée":
                case "Vase":
                case "Ruban":
                case "Pomme de pin":
                    return "accessoire";

                case "Gerbera":
                case "Ginger":
                case "Glaïeul":
                case "Marguerite":
                case "Rose rouge":
                    return "fleur";

                default:
                    return "";
            }
        }


        /// <summary>
        /// Méthode permettant d'afficher en rouge les stocks dont la quantité est inférieure ou égale à 3
        /// </summary>
        private void checkStocks()
        {
            // Vérification des quantités pour déclencher des alertes 
            foreach (DataGridViewRow row in this.stocksAndShopsGridView.Rows)
            {
                if ((int)row.Cells["quantite"].Value <= 3)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.ForeColor = Color.Red;
                    }
                }
            }
        }


        /// <summary>
        /// Méthode permettant d'actualiser le stock d'un produit dans un magasin spécifié
        /// </summary>
        /// <param name="shopName">Le nom du magasin</param>
        /// <param name="itemName">Le nom de l'item</param>
        /// <param name="itemTable">La table de l'item</param>
        /// <param name="quantity">La nouvelle quantité en stock</param>
        private void updateItemStock(string shopName, string itemName = "", string itemTable = "", int quantity = 1)
        {
            MySqlParameter shop = createCustomParameter("@shopName", shopName, MySqlDbType.VarChar);
            if (itemTable == "bouquet")
            {
                string queryUpdateBouquetStock = $"UPDATE stockBouquet SET quantite = {quantity} WHERE " +
                                                 $"nomBouquet = @itemName AND nomMagasin = @shopName;";
                MySqlCommand command = new MySqlCommand(queryUpdateBouquetStock, connection);
                addParametersToCommand(command, shop, createCustomParameter("@itemName", itemName, MySqlDbType.VarChar));
                command.ExecuteNonQuery();
                return;
            }

            string queryUpdateItemStock = $"UPDATE stock{itemTable} NATURAL JOIN {itemTable} SET quantite = {quantity} WHERE " +
                                          $"nom{itemTable} = @itemName AND nomMagasin = @shopName;";
            MySqlCommand command2 = new MySqlCommand(queryUpdateItemStock, connection);
            command2.Parameters.Add(shop);
            command2.Parameters.Add(createCustomParameter("@itemName", itemName, MySqlDbType.VarChar));
            command2.ExecuteNonQuery();
        }

        #endregion


    }
}
