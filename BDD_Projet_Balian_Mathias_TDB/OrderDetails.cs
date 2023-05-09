using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crmf;
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
    public partial class OrderDetails : Form
    {
        private int orderId;
        private decimal totalPrice;
        private string fidelity;

        public OrderDetails(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.totalPrice = 0;
            string queryGetClientFidelity = $"SELECT fidelite FROM commande NATURAL JOIN client WHERE idCommande = {this.orderId};";
            MySqlCommand command = new MySqlCommand(queryGetClientFidelity, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                this.fidelity = reader.GetString(0);
            }
            reader.Close();
            getOrderDetails();
        }


        /// <summary>
        /// Méthode permettant d'obtenir et d'afficher tous les détails de la commande
        /// </summary>
        private void getOrderDetails()
        {
            // Magasin
            this.trueShopLabel.Visible = true;
            this.trueShopLabel.Text = getShopName();
            this.trueShopLabel.Left = (this.ClientSize.Width - this.trueShopLabel.Width) / 2;

            // Type de bouquet
            var isBouquetAndName = isBouquetStandard();
            this.bouquetTypeLabel.Visible = true;
            this.totalPriceLabel.Visible = true;

            if (isBouquetAndName.isbouquetStandard) // Si c'est un bouquet standard
            {
                this.bouquetTypeLabel.Text = "Bouquet " + isBouquetAndName.bouquetStandardName;
                this.bouquetTypeLabel.Left = (this.ClientSize.Width - this.bouquetTypeLabel.Width) / 2;

                this.bouquetStandardPictureBox.Visible = true;
                this.bouquetStandardPictureBox.BackgroundImage = Properties.Resources.ResourceManager.
                                                                 GetObject(OrderForm.getImageNameFromItemName(isBouquetAndName.bouquetStandardName)) as Image;
            }
            else // Si c'est un bouquet personnalisé
            {
                this.bouquetTypeLabel.Text = "Bouquet personnalisé contenant :";
                this.bouquetTypeLabel.Left = (this.ClientSize.Width - this.bouquetTypeLabel.Width) / 2;

                this.bouquetPersoLayoutPanel.Visible = true;
                fillBouquetPersoLayoutPanel("accessoire");
                fillBouquetPersoLayoutPanel("fleur");
                // Pour toujours centrer le flowlayoutpanel par rapport au nombre d'ingrédients
                Point originalBouquetPersoLayoutPanelCoords = this.bouquetPersoLayoutPanel.Location;
                if (this.bouquetPersoLayoutPanel.Controls.Count == 1)
                    this.bouquetPersoLayoutPanel.Location = new Point(originalBouquetPersoLayoutPanelCoords.X + 200, originalBouquetPersoLayoutPanelCoords.Y);
                else if (this.bouquetPersoLayoutPanel.Controls.Count == 2)
                    this.bouquetPersoLayoutPanel.Location = new Point(originalBouquetPersoLayoutPanelCoords.X + 100, originalBouquetPersoLayoutPanelCoords.Y);
                else
                    this.bouquetPersoLayoutPanel.Location = originalBouquetPersoLayoutPanelCoords;
            }

            // On obtient le prix de la commande
            string queryGetOrderPrice = $"SELECT prixTotal FROM commande WHERE idCommande = {this.orderId};";
            MySqlCommand commandGetOrderPrice = new MySqlCommand(queryGetOrderPrice, connection);
            MySqlDataReader mySqlDataReader = commandGetOrderPrice.ExecuteReader();
            if (mySqlDataReader.Read() && !mySqlDataReader.IsDBNull(0))
            {
                this.totalPrice = mySqlDataReader.GetDecimal(0);
            }
            mySqlDataReader.Close();

            this.totalPriceLabel.Text = $"Pour un total de {Decimal.Round((decimal)this.totalPrice, 2)}€";
            this.totalPriceLabel.Left = (this.ClientSize.Width - this.totalPriceLabel.Width) / 2;


            // Adresse de livraison et message floral
            string queryGetAdressAndMessage = $"SELECT adresseLivraison, messageFloral FROM commande WHERE idCommande = {this.orderId};";
            MySqlCommand command = new MySqlCommand(queryGetAdressAndMessage, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                this.deliveryAdressLabel.Text = "Livré à : " + reader.GetString(0);
                this.messageLabel.Text = "Accompagné du message : " + reader.GetString(1);
            }
            this.deliveryAdressLabel.Visible = true;
            this.messageLabel.Visible = true;
            this.deliveryAdressLabel.Left = (this.ClientSize.Width - this.deliveryAdressLabel.Width) / 2;
            this.messageLabel.Left = (this.ClientSize.Width - this.messageLabel.Width) / 2;
            reader.Close();
        }


        /// <summary>
        /// Méthode permettant de savoir si une commande est une commande de bouquet personnalisé ou de bouquet standard
        /// </summary>
        /// <returns>Un tuple contenant un bool (true si bouquet standard, false sinon) et le nom du bouquet standard</returns>
        private (bool isbouquetStandard, string bouquetStandardName) isBouquetStandard()
        {
            string queryGetBouquetType = "SELECT nomBouquet FROM commande NATURAL JOIN arrangementFloral NATURAL JOIN bouquetStandard" +
                $" WHERE idCommande = {this.orderId};";
            MySqlCommand command = new MySqlCommand(queryGetBouquetType, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string bouquetName = reader.GetString(0);
                reader.Close();
                return (true, bouquetName);
            }
            reader.Close();
            return (false, "");
        }


        /// <summary>
        /// Méthode permettant d'obtenir le nom du magasin de la commande
        /// </summary>
        /// <returns>Le nom du magasin</returns>
        private string getShopName()
        {
            string queryGetShopName = $"SELECT nomMagasin FROM commande NATURAL JOIN magasin WHERE idCommande = {this.orderId};";
            MySqlCommand command = new MySqlCommand(queryGetShopName, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string shopName = reader.GetString(0);
                reader.Close();
                return shopName;
            }
            reader.Close();
            return "";
        }



        /// <summary>
        /// Méthode permettant d'obtenir le prix du bouquet sélectionné par l'utilisateur
        /// </summary>
        /// <param name="bouquetName">Le nom du bouquet</param>
        /// <returns>Le prix du bouquet</returns>
        private float getBouquetStandardPrice(string bouquetName)
        {
            string queryGetBouquetPrice = "SELECT prixBouquet FROM bouquetStandard WHERE nomBouquet = @bouquetName;";
            MySqlCommand command = new MySqlCommand(queryGetBouquetPrice, connection);
            addParametersToCommand(command,
                createCustomParameter("@bouquetName", bouquetName, MySqlDbType.VarChar));
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
        /// Méthode permettant d'obtenir l'adresse de livraison de la commande
        /// </summary>
        /// <returns>L'adresse de livraison de la commande</returns>
        private string getDeliveryAdress()
        {
            string queryGetDeliveryAdress = $"SELECT adresseLivraison FROM commande WHERE idCommande = {this.orderId};";
            MySqlCommand command = new MySqlCommand(queryGetDeliveryAdress, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string deliveryAdress = reader.GetString(0);
                reader.Close();
                return deliveryAdress;
            }
            reader.Close();
            return "";
        }


        /// <summary>
        /// Méthode permettant d'afficher les images des items (accessoires et/ou fleurs) de la commande et calculer leur prix
        /// </summary>
        /// <param name="tableName">Le nom de la table (accessoire ou fleur)</param>
        private void fillBouquetPersoLayoutPanel(string tableName)
        {
            string queryGetItemsAndQuantities = $"SELECT nom{tableName}, quantite{tableName} FROM commande " +
                    "NATURAL JOIN arrangementfloral NATURAL JOIN arrangementestcomposebouquetperso " +
                    $"NATURAL JOIN bouquetperso NATURAL JOIN bouquetpersocontient{tableName} " +
                    $"NATURAL JOIN {tableName} WHERE idCommande = {this.orderId};";
            MySqlCommand mySqlCommand = new MySqlCommand(queryGetItemsAndQuantities, connection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                string nomItem = mySqlDataReader.GetString(0);
                int quantiteItem = mySqlDataReader.GetInt32(1);
                for (int i = 0; i < quantiteItem; i++)
                {
                    string imageName = OrderForm.getImageNameFromItemName(nomItem);
                    Image backgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                    if (backgroundImage != null)
                    {
                        PictureBox pb = new PictureBox();
                        pb.BackgroundImage = backgroundImage;
                        pb.BackgroundImageLayout = ImageLayout.Stretch;
                        pb.Size = new Size(200, 200);
                        this.bouquetPersoLayoutPanel.Controls.Add(pb);
                    }
                }
            }
            mySqlDataReader.Close();
        }
    }
}
