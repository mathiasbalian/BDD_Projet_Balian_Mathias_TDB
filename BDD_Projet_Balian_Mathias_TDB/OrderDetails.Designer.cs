namespace BDD_Projet_Balian_Mathias_TDB
{
    partial class OrderDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            shopLabel = new Label();
            yourOrdersLabel = new Label();
            trueShopLabel = new Label();
            bouquetTypeLabel = new Label();
            bouquetStandardPictureBox = new PictureBox();
            totalPriceLabel = new Label();
            deliveryAdressLabel = new Label();
            messageLabel = new Label();
            bouquetPersoLayoutPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)bouquetStandardPictureBox).BeginInit();
            SuspendLayout();
            // 
            // shopLabel
            // 
            shopLabel.AutoSize = true;
            shopLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            shopLabel.Location = new Point(621, 117);
            shopLabel.Name = "shopLabel";
            shopLabel.Size = new Size(140, 38);
            shopLabel.TabIndex = 0;
            shopLabel.Text = "Magasin :";
            // 
            // yourOrdersLabel
            // 
            yourOrdersLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            yourOrdersLabel.BackColor = SystemColors.ActiveCaption;
            yourOrdersLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            yourOrdersLabel.Location = new Point(12, 9);
            yourOrdersLabel.Name = "yourOrdersLabel";
            yourOrdersLabel.RightToLeft = RightToLeft.No;
            yourOrdersLabel.Size = new Size(1358, 98);
            yourOrdersLabel.TabIndex = 22;
            yourOrdersLabel.Text = "Détails de la commande";
            yourOrdersLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trueShopLabel
            // 
            trueShopLabel.AutoSize = true;
            trueShopLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            trueShopLabel.Location = new Point(647, 175);
            trueShopLabel.Name = "trueShopLabel";
            trueShopLabel.Size = new Size(88, 28);
            trueShopLabel.TabIndex = 23;
            trueShopLabel.Text = "Magasin";
            trueShopLabel.Visible = false;
            // 
            // bouquetTypeLabel
            // 
            bouquetTypeLabel.AutoSize = true;
            bouquetTypeLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            bouquetTypeLabel.Location = new Point(618, 227);
            bouquetTypeLabel.Name = "bouquetTypeLabel";
            bouquetTypeLabel.Size = new Size(147, 38);
            bouquetTypeLabel.TabIndex = 24;
            bouquetTypeLabel.Text = "Bouquet x";
            bouquetTypeLabel.Visible = false;
            // 
            // bouquetStandardPictureBox
            // 
            bouquetStandardPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            bouquetStandardPictureBox.Location = new Point(591, 278);
            bouquetStandardPictureBox.Name = "bouquetStandardPictureBox";
            bouquetStandardPictureBox.Size = new Size(200, 200);
            bouquetStandardPictureBox.TabIndex = 25;
            bouquetStandardPictureBox.TabStop = false;
            bouquetStandardPictureBox.Visible = false;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalPriceLabel.Location = new Point(594, 502);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(194, 28);
            totalPriceLabel.TabIndex = 26;
            totalPriceLabel.Text = "Pour un total de x€";
            totalPriceLabel.Visible = false;
            // 
            // deliveryAdressLabel
            // 
            deliveryAdressLabel.AutoSize = true;
            deliveryAdressLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            deliveryAdressLabel.Location = new Point(617, 567);
            deliveryAdressLabel.Name = "deliveryAdressLabel";
            deliveryAdressLabel.Size = new Size(149, 25);
            deliveryAdressLabel.TabIndex = 27;
            deliveryAdressLabel.Text = "Livré à l'adresse : ";
            deliveryAdressLabel.Visible = false;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            messageLabel.Location = new Point(575, 609);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(232, 25);
            messageLabel.TabIndex = 28;
            messageLabel.Text = "Accompagné du message : ";
            messageLabel.Visible = false;
            // 
            // bouquetPersoLayoutPanel
            // 
            bouquetPersoLayoutPanel.AutoScroll = true;
            bouquetPersoLayoutPanel.Location = new Point(381, 278);
            bouquetPersoLayoutPanel.Name = "bouquetPersoLayoutPanel";
            bouquetPersoLayoutPanel.Size = new Size(620, 221);
            bouquetPersoLayoutPanel.TabIndex = 29;
            bouquetPersoLayoutPanel.Visible = false;
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1382, 653);
            Controls.Add(bouquetPersoLayoutPanel);
            Controls.Add(messageLabel);
            Controls.Add(deliveryAdressLabel);
            Controls.Add(totalPriceLabel);
            Controls.Add(bouquetStandardPictureBox);
            Controls.Add(bouquetTypeLabel);
            Controls.Add(trueShopLabel);
            Controls.Add(yourOrdersLabel);
            Controls.Add(shopLabel);
            Name = "OrderDetails";
            Text = "Détails de la commande";
            ((System.ComponentModel.ISupportInitialize)bouquetStandardPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label shopLabel;
        private Label yourOrdersLabel;
        private Label trueShopLabel;
        private Label bouquetTypeLabel;
        private PictureBox bouquetStandardPictureBox;
        private Label totalPriceLabel;
        private Label deliveryAdressLabel;
        private Label messageLabel;
        private FlowLayoutPanel bouquetPersoLayoutPanel;
    }
}