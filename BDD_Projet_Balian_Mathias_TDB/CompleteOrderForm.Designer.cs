namespace BDD_Projet_Balian_Mathias_TDB
{
    partial class CompleteOrderForm
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
            addFlowerButton = new Button();
            accessoryLabel = new Label();
            flowerLabel = new Label();
            inStockFlowerComboBox = new ComboBox();
            addAccessoryButton = new Button();
            inStockAccessoryComboBox = new ComboBox();
            bouquetPersoFlowLayoutPanel = new FlowLayoutPanel();
            addItemsPanel = new Panel();
            bouquetDescriptionTextBox = new TextBox();
            orderDetailsLabel = new Label();
            descriptionLabel = new Label();
            budgetLabel = new Label();
            totalPriceLabel = new Label();
            finalizeButton = new Button();
            fidelityLabel = new Label();
            addItemsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addFlowerButton
            // 
            addFlowerButton.BackColor = Color.Linen;
            addFlowerButton.Cursor = Cursors.Hand;
            addFlowerButton.FlatStyle = FlatStyle.Flat;
            addFlowerButton.Location = new Point(288, 114);
            addFlowerButton.Name = "addFlowerButton";
            addFlowerButton.Size = new Size(126, 28);
            addFlowerButton.TabIndex = 47;
            addFlowerButton.Text = "Ajouter";
            addFlowerButton.UseVisualStyleBackColor = false;
            addFlowerButton.Click += addFlowerButton_Click;
            // 
            // accessoryLabel
            // 
            accessoryLabel.AutoSize = true;
            accessoryLabel.Location = new Point(16, 25);
            accessoryLabel.Name = "accessoryLabel";
            accessoryLabel.Size = new Size(85, 20);
            accessoryLabel.TabIndex = 46;
            accessoryLabel.Text = "Accessoires";
            // 
            // flowerLabel
            // 
            flowerLabel.AutoSize = true;
            flowerLabel.Location = new Point(16, 91);
            flowerLabel.Name = "flowerLabel";
            flowerLabel.Size = new Size(47, 20);
            flowerLabel.TabIndex = 45;
            flowerLabel.Text = "Fleurs";
            // 
            // inStockFlowerComboBox
            // 
            inStockFlowerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            inStockFlowerComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inStockFlowerComboBox.FormattingEnabled = true;
            inStockFlowerComboBox.Location = new Point(16, 114);
            inStockFlowerComboBox.Name = "inStockFlowerComboBox";
            inStockFlowerComboBox.Size = new Size(266, 28);
            inStockFlowerComboBox.TabIndex = 44;
            // 
            // addAccessoryButton
            // 
            addAccessoryButton.BackColor = Color.Linen;
            addAccessoryButton.Cursor = Cursors.Hand;
            addAccessoryButton.FlatStyle = FlatStyle.Flat;
            addAccessoryButton.Location = new Point(288, 48);
            addAccessoryButton.Name = "addAccessoryButton";
            addAccessoryButton.Size = new Size(126, 28);
            addAccessoryButton.TabIndex = 43;
            addAccessoryButton.Text = "Ajouter";
            addAccessoryButton.UseVisualStyleBackColor = false;
            addAccessoryButton.Click += addAccessoryButton_Click;
            // 
            // inStockAccessoryComboBox
            // 
            inStockAccessoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            inStockAccessoryComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inStockAccessoryComboBox.FormattingEnabled = true;
            inStockAccessoryComboBox.Location = new Point(16, 48);
            inStockAccessoryComboBox.Name = "inStockAccessoryComboBox";
            inStockAccessoryComboBox.Size = new Size(266, 28);
            inStockAccessoryComboBox.TabIndex = 42;
            // 
            // bouquetPersoFlowLayoutPanel
            // 
            bouquetPersoFlowLayoutPanel.AutoScroll = true;
            bouquetPersoFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            bouquetPersoFlowLayoutPanel.Location = new Point(16, 160);
            bouquetPersoFlowLayoutPanel.Name = "bouquetPersoFlowLayoutPanel";
            bouquetPersoFlowLayoutPanel.Size = new Size(398, 222);
            bouquetPersoFlowLayoutPanel.TabIndex = 41;
            // 
            // addItemsPanel
            // 
            addItemsPanel.BackColor = SystemColors.Window;
            addItemsPanel.Controls.Add(flowerLabel);
            addItemsPanel.Controls.Add(addFlowerButton);
            addItemsPanel.Controls.Add(bouquetPersoFlowLayoutPanel);
            addItemsPanel.Controls.Add(accessoryLabel);
            addItemsPanel.Controls.Add(inStockAccessoryComboBox);
            addItemsPanel.Controls.Add(addAccessoryButton);
            addItemsPanel.Controls.Add(inStockFlowerComboBox);
            addItemsPanel.Location = new Point(475, 155);
            addItemsPanel.Name = "addItemsPanel";
            addItemsPanel.Size = new Size(433, 403);
            addItemsPanel.TabIndex = 48;
            // 
            // bouquetDescriptionTextBox
            // 
            bouquetDescriptionTextBox.BackColor = SystemColors.Window;
            bouquetDescriptionTextBox.Location = new Point(41, 319);
            bouquetDescriptionTextBox.Multiline = true;
            bouquetDescriptionTextBox.Name = "bouquetDescriptionTextBox";
            bouquetDescriptionTextBox.ReadOnly = true;
            bouquetDescriptionTextBox.Size = new Size(329, 193);
            bouquetDescriptionTextBox.TabIndex = 49;
            // 
            // orderDetailsLabel
            // 
            orderDetailsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            orderDetailsLabel.BackColor = SystemColors.ActiveCaption;
            orderDetailsLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            orderDetailsLabel.Location = new Point(12, 9);
            orderDetailsLabel.Name = "orderDetailsLabel";
            orderDetailsLabel.RightToLeft = RightToLeft.No;
            orderDetailsLabel.Size = new Size(1358, 89);
            orderDetailsLabel.TabIndex = 50;
            orderDetailsLabel.Text = "Finaliser la commande";
            orderDetailsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(41, 290);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(105, 23);
            descriptionLabel.TabIndex = 51;
            descriptionLabel.Text = "Description :";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            budgetLabel.Location = new Point(41, 221);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(110, 23);
            budgetLabel.TabIndex = 52;
            budgetLabel.Text = "Budget : XX€";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalPriceLabel.Location = new Point(1099, 312);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(100, 28);
            totalPriceLabel.TabIndex = 53;
            totalPriceLabel.Text = "Total : 0€";
            // 
            // finalizeButton
            // 
            finalizeButton.BackColor = Color.RoyalBlue;
            finalizeButton.Cursor = Cursors.Hand;
            finalizeButton.FlatStyle = FlatStyle.Flat;
            finalizeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            finalizeButton.ForeColor = SystemColors.Control;
            finalizeButton.Location = new Point(1145, 566);
            finalizeButton.Name = "finalizeButton";
            finalizeButton.Size = new Size(214, 66);
            finalizeButton.TabIndex = 54;
            finalizeButton.TabStop = false;
            finalizeButton.Text = "Finaliser";
            finalizeButton.UseVisualStyleBackColor = false;
            finalizeButton.Click += finalizeButton_Click;
            // 
            // fidelityLabel
            // 
            fidelityLabel.AutoSize = true;
            fidelityLabel.Location = new Point(1009, 352);
            fidelityLabel.Name = "fidelityLabel";
            fidelityLabel.Size = new Size(50, 20);
            fidelityLabel.TabIndex = 55;
            fidelityLabel.Text = "label2";
            fidelityLabel.Visible = false;
            // 
            // CompleteOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1382, 653);
            Controls.Add(fidelityLabel);
            Controls.Add(finalizeButton);
            Controls.Add(totalPriceLabel);
            Controls.Add(budgetLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(orderDetailsLabel);
            Controls.Add(bouquetDescriptionTextBox);
            Controls.Add(addItemsPanel);
            Name = "CompleteOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compléter la commande";
            addItemsPanel.ResumeLayout(false);
            addItemsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addFlowerButton;
        private Label accessoryLabel;
        private Label flowerLabel;
        private ComboBox inStockFlowerComboBox;
        private Button addAccessoryButton;
        private ComboBox inStockAccessoryComboBox;
        private FlowLayoutPanel bouquetPersoFlowLayoutPanel;
        private Panel addItemsPanel;
        private TextBox bouquetDescriptionTextBox;
        private Label orderDetailsLabel;
        private Label descriptionLabel;
        private Label budgetLabel;
        private Label totalPriceLabel;
        private Button finalizeButton;
        private Label fidelityLabel;
    }
}