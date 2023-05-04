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
            SuspendLayout();
            // 
            // shopLabel
            // 
            shopLabel.AutoSize = true;
            shopLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            shopLabel.Location = new Point(621, 134);
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
            trueShopLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            trueShopLabel.Location = new Point(647, 192);
            trueShopLabel.Name = "trueShopLabel";
            trueShopLabel.Size = new Size(88, 28);
            trueShopLabel.TabIndex = 23;
            trueShopLabel.Text = "Magasin";
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1382, 653);
            Controls.Add(trueShopLabel);
            Controls.Add(yourOrdersLabel);
            Controls.Add(shopLabel);
            Name = "OrderDetails";
            Text = "Détails de la commande";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label shopLabel;
        private Label yourOrdersLabel;
        private Label trueShopLabel;
    }
}