namespace BDD_Projet_Balian_Mathias_TDB
{
    partial class OrderForm
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
            components = new System.ComponentModel.Container();
            backwardButton = new Button();
            forwardButton = new Button();
            pauseButton = new Button();
            datePicker = new DateTimePicker();
            dateTimer = new System.Windows.Forms.Timer(components);
            returnButton = new Button();
            userDropdown = new Panel();
            myProfileButton = new Button();
            disconnectButton = new Button();
            myOrdersButton = new Button();
            userButton = new Button();
            orderDetailsPanel = new Panel();
            compositionUnknownCheckBox = new CheckBox();
            compositionKnownCheckBox = new CheckBox();
            totalPriceBeforeDiscountLabel = new Label();
            fidelityLabel = new Label();
            requiredDeliveryAdressPictureBox = new PictureBox();
            requiredCustomItemPictureBox = new PictureBox();
            requiredBouquetStandardPictureBox = new PictureBox();
            requiredShopPictureBox = new PictureBox();
            addFlowerButton = new Button();
            accessoryLabel = new Label();
            flowerLabel = new Label();
            inStockFlowerComboBox = new ComboBox();
            addAccessoryButton = new Button();
            inStockAccessoryComboBox = new ComboBox();
            bouquetPersoFlowLayoutPanel = new FlowLayoutPanel();
            orderButton = new Button();
            label1 = new Label();
            deliveryDateTimePicker = new DateTimePicker();
            customMessageTextBox = new TextBox();
            deliveryAdressTextBox = new TextBox();
            totalPriceLabel = new Label();
            bouquetPanel = new Panel();
            inStockBouquetsStandardComboBox = new ComboBox();
            bouquetPersoCheckBox = new CheckBox();
            bouquetStandardCheckBox = new CheckBox();
            shopLabel = new Label();
            shopComboBox = new ComboBox();
            orderDetailsLabel = new Label();
            compositionUnknownPanel = new Panel();
            budgetLabel = new Label();
            budgetUpDown = new NumericUpDown();
            descriptionTextBox = new TextBox();
            quickDescriptionLabel = new Label();
            userDropdown.SuspendLayout();
            orderDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requiredDeliveryAdressPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)requiredCustomItemPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)requiredBouquetStandardPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)requiredShopPictureBox).BeginInit();
            compositionUnknownPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)budgetUpDown).BeginInit();
            SuspendLayout();
            // 
            // backwardButton
            // 
            backwardButton.BackgroundImage = Properties.Resources.backward_icon_crop;
            backwardButton.BackgroundImageLayout = ImageLayout.Stretch;
            backwardButton.Cursor = Cursors.Hand;
            backwardButton.FlatAppearance.BorderSize = 0;
            backwardButton.FlatStyle = FlatStyle.Flat;
            backwardButton.ForeColor = Color.Transparent;
            backwardButton.Location = new Point(32, 45);
            backwardButton.Name = "backwardButton";
            backwardButton.Size = new Size(12, 12);
            backwardButton.TabIndex = 8;
            backwardButton.UseVisualStyleBackColor = true;
            backwardButton.Click += backwardButton_Click;
            // 
            // forwardButton
            // 
            forwardButton.BackgroundImage = Properties.Resources.forward_icon_crop;
            forwardButton.BackgroundImageLayout = ImageLayout.Stretch;
            forwardButton.Cursor = Cursors.Hand;
            forwardButton.FlatAppearance.BorderSize = 0;
            forwardButton.FlatStyle = FlatStyle.Flat;
            forwardButton.ForeColor = Color.Transparent;
            forwardButton.Location = new Point(100, 45);
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(12, 12);
            forwardButton.TabIndex = 7;
            forwardButton.UseVisualStyleBackColor = true;
            forwardButton.Click += forwardButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.BackgroundImage = Properties.Resources.pause_icon;
            pauseButton.BackgroundImageLayout = ImageLayout.Stretch;
            pauseButton.Cursor = Cursors.Hand;
            pauseButton.FlatAppearance.BorderSize = 0;
            pauseButton.FlatStyle = FlatStyle.Flat;
            pauseButton.ForeColor = Color.Transparent;
            pauseButton.Location = new Point(66, 45);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(12, 12);
            pauseButton.TabIndex = 6;
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(12, 12);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(127, 27);
            datePicker.TabIndex = 5;
            datePicker.TabStop = false;
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // dateTimer
            // 
            dateTimer.Interval = 15000;
            dateTimer.Tick += dateTimer_Tick;
            // 
            // returnButton
            // 
            returnButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            returnButton.BackColor = Color.Silver;
            returnButton.Cursor = Cursors.Hand;
            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            returnButton.ForeColor = SystemColors.ActiveCaptionText;
            returnButton.Location = new Point(12, 793);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(171, 48);
            returnButton.TabIndex = 17;
            returnButton.Text = "Retour";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // userDropdown
            // 
            userDropdown.BackColor = SystemColors.ButtonHighlight;
            userDropdown.BorderStyle = BorderStyle.FixedSingle;
            userDropdown.Controls.Add(myProfileButton);
            userDropdown.Controls.Add(disconnectButton);
            userDropdown.Controls.Add(myOrdersButton);
            userDropdown.Location = new Point(1586, 48);
            userDropdown.Name = "userDropdown";
            userDropdown.Size = new Size(171, 120);
            userDropdown.TabIndex = 18;
            userDropdown.Visible = false;
            // 
            // myProfileButton
            // 
            myProfileButton.BackColor = SystemColors.ButtonFace;
            myProfileButton.Cursor = Cursors.Hand;
            myProfileButton.FlatAppearance.BorderSize = 0;
            myProfileButton.FlatStyle = FlatStyle.Flat;
            myProfileButton.Location = new Point(0, 0);
            myProfileButton.Margin = new Padding(0);
            myProfileButton.Name = "myProfileButton";
            myProfileButton.Size = new Size(171, 40);
            myProfileButton.TabIndex = 2;
            myProfileButton.Text = "Mon profil";
            myProfileButton.UseVisualStyleBackColor = false;
            myProfileButton.Click += myProfileButton_Click;
            // 
            // disconnectButton
            // 
            disconnectButton.BackColor = SystemColors.ButtonFace;
            disconnectButton.Cursor = Cursors.Hand;
            disconnectButton.FlatAppearance.BorderSize = 0;
            disconnectButton.FlatStyle = FlatStyle.Flat;
            disconnectButton.Location = new Point(0, 80);
            disconnectButton.Margin = new Padding(0);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new Size(171, 40);
            disconnectButton.TabIndex = 1;
            disconnectButton.Text = "Se déconnecter";
            disconnectButton.UseVisualStyleBackColor = false;
            disconnectButton.Click += disconnectButton_Click;
            // 
            // myOrdersButton
            // 
            myOrdersButton.BackColor = SystemColors.ButtonFace;
            myOrdersButton.Cursor = Cursors.Hand;
            myOrdersButton.FlatAppearance.BorderSize = 0;
            myOrdersButton.FlatStyle = FlatStyle.Flat;
            myOrdersButton.Location = new Point(0, 40);
            myOrdersButton.Margin = new Padding(0);
            myOrdersButton.Name = "myOrdersButton";
            myOrdersButton.Size = new Size(171, 40);
            myOrdersButton.TabIndex = 0;
            myOrdersButton.Text = "Mes commandes";
            myOrdersButton.UseVisualStyleBackColor = false;
            myOrdersButton.Click += myOrdersButton_Click;
            // 
            // userButton
            // 
            userButton.BackgroundImage = Properties.Resources.user_icon;
            userButton.BackgroundImageLayout = ImageLayout.Stretch;
            userButton.Cursor = Cursors.Hand;
            userButton.FlatAppearance.BorderSize = 0;
            userButton.FlatStyle = FlatStyle.Flat;
            userButton.Location = new Point(1727, 12);
            userButton.Name = "userButton";
            userButton.Size = new Size(30, 30);
            userButton.TabIndex = 6;
            userButton.UseVisualStyleBackColor = true;
            userButton.Click += userButton_Click;
            // 
            // orderDetailsPanel
            // 
            orderDetailsPanel.BackColor = SystemColors.Window;
            orderDetailsPanel.Controls.Add(compositionUnknownCheckBox);
            orderDetailsPanel.Controls.Add(compositionKnownCheckBox);
            orderDetailsPanel.Controls.Add(totalPriceBeforeDiscountLabel);
            orderDetailsPanel.Controls.Add(fidelityLabel);
            orderDetailsPanel.Controls.Add(requiredDeliveryAdressPictureBox);
            orderDetailsPanel.Controls.Add(requiredCustomItemPictureBox);
            orderDetailsPanel.Controls.Add(requiredBouquetStandardPictureBox);
            orderDetailsPanel.Controls.Add(requiredShopPictureBox);
            orderDetailsPanel.Controls.Add(addFlowerButton);
            orderDetailsPanel.Controls.Add(accessoryLabel);
            orderDetailsPanel.Controls.Add(flowerLabel);
            orderDetailsPanel.Controls.Add(inStockFlowerComboBox);
            orderDetailsPanel.Controls.Add(addAccessoryButton);
            orderDetailsPanel.Controls.Add(inStockAccessoryComboBox);
            orderDetailsPanel.Controls.Add(bouquetPersoFlowLayoutPanel);
            orderDetailsPanel.Controls.Add(orderButton);
            orderDetailsPanel.Controls.Add(label1);
            orderDetailsPanel.Controls.Add(deliveryDateTimePicker);
            orderDetailsPanel.Controls.Add(customMessageTextBox);
            orderDetailsPanel.Controls.Add(deliveryAdressTextBox);
            orderDetailsPanel.Controls.Add(totalPriceLabel);
            orderDetailsPanel.Controls.Add(bouquetPanel);
            orderDetailsPanel.Controls.Add(inStockBouquetsStandardComboBox);
            orderDetailsPanel.Controls.Add(bouquetPersoCheckBox);
            orderDetailsPanel.Controls.Add(bouquetStandardCheckBox);
            orderDetailsPanel.Controls.Add(shopLabel);
            orderDetailsPanel.Controls.Add(shopComboBox);
            orderDetailsPanel.Controls.Add(orderDetailsLabel);
            orderDetailsPanel.Location = new Point(326, 40);
            orderDetailsPanel.Name = "orderDetailsPanel";
            orderDetailsPanel.Padding = new Padding(30);
            orderDetailsPanel.Size = new Size(1130, 773);
            orderDetailsPanel.TabIndex = 19;
            // 
            // compositionUnknownCheckBox
            // 
            compositionUnknownCheckBox.AutoSize = true;
            compositionUnknownCheckBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            compositionUnknownCheckBox.Location = new Point(844, 203);
            compositionUnknownCheckBox.Name = "compositionUnknownCheckBox";
            compositionUnknownCheckBox.Size = new Size(253, 24);
            compositionUnknownCheckBox.TabIndex = 48;
            compositionUnknownCheckBox.Text = "Je ne connais pas la composition";
            compositionUnknownCheckBox.UseVisualStyleBackColor = true;
            compositionUnknownCheckBox.Visible = false;
            compositionUnknownCheckBox.CheckedChanged += compositionUnknownCheckBox_CheckedChanged;
            // 
            // compositionKnownCheckBox
            // 
            compositionKnownCheckBox.AutoSize = true;
            compositionKnownCheckBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            compositionKnownCheckBox.Location = new Point(883, 173);
            compositionKnownCheckBox.Name = "compositionKnownCheckBox";
            compositionKnownCheckBox.Size = new Size(205, 24);
            compositionKnownCheckBox.TabIndex = 47;
            compositionKnownCheckBox.Text = "Je connais la composition";
            compositionKnownCheckBox.UseVisualStyleBackColor = true;
            compositionKnownCheckBox.Visible = false;
            compositionKnownCheckBox.CheckedChanged += compositionKnownCheckBox_CheckedChanged;
            // 
            // totalPriceBeforeDiscountLabel
            // 
            totalPriceBeforeDiscountLabel.AutoSize = true;
            totalPriceBeforeDiscountLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            totalPriceBeforeDiscountLabel.Location = new Point(540, 465);
            totalPriceBeforeDiscountLabel.Name = "totalPriceBeforeDiscountLabel";
            totalPriceBeforeDiscountLabel.Size = new Size(0, 25);
            totalPriceBeforeDiscountLabel.TabIndex = 46;
            totalPriceBeforeDiscountLabel.Visible = false;
            // 
            // fidelityLabel
            // 
            fidelityLabel.AutoSize = true;
            fidelityLabel.Location = new Point(540, 509);
            fidelityLabel.Name = "fidelityLabel";
            fidelityLabel.Size = new Size(50, 20);
            fidelityLabel.TabIndex = 45;
            fidelityLabel.Text = "label2";
            fidelityLabel.Visible = false;
            // 
            // requiredDeliveryAdressPictureBox
            // 
            requiredDeliveryAdressPictureBox.BackgroundImage = Properties.Resources.required;
            requiredDeliveryAdressPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            requiredDeliveryAdressPictureBox.Location = new Point(333, 619);
            requiredDeliveryAdressPictureBox.Name = "requiredDeliveryAdressPictureBox";
            requiredDeliveryAdressPictureBox.Size = new Size(9, 9);
            requiredDeliveryAdressPictureBox.TabIndex = 44;
            requiredDeliveryAdressPictureBox.TabStop = false;
            // 
            // requiredCustomItemPictureBox
            // 
            requiredCustomItemPictureBox.BackgroundImage = Properties.Resources.required;
            requiredCustomItemPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            requiredCustomItemPictureBox.Location = new Point(1103, 294);
            requiredCustomItemPictureBox.Name = "requiredCustomItemPictureBox";
            requiredCustomItemPictureBox.Size = new Size(9, 9);
            requiredCustomItemPictureBox.TabIndex = 43;
            requiredCustomItemPictureBox.TabStop = false;
            requiredCustomItemPictureBox.Visible = false;
            // 
            // requiredBouquetStandardPictureBox
            // 
            requiredBouquetStandardPictureBox.BackgroundImage = Properties.Resources.required;
            requiredBouquetStandardPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            requiredBouquetStandardPictureBox.Location = new Point(305, 186);
            requiredBouquetStandardPictureBox.Name = "requiredBouquetStandardPictureBox";
            requiredBouquetStandardPictureBox.Size = new Size(9, 9);
            requiredBouquetStandardPictureBox.TabIndex = 42;
            requiredBouquetStandardPictureBox.TabStop = false;
            requiredBouquetStandardPictureBox.Visible = false;
            // 
            // requiredShopPictureBox
            // 
            requiredShopPictureBox.BackgroundImage = Properties.Resources.required;
            requiredShopPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            requiredShopPictureBox.Location = new Point(603, 98);
            requiredShopPictureBox.Name = "requiredShopPictureBox";
            requiredShopPictureBox.Size = new Size(9, 9);
            requiredShopPictureBox.TabIndex = 41;
            requiredShopPictureBox.TabStop = false;
            // 
            // addFlowerButton
            // 
            addFlowerButton.BackColor = Color.Linen;
            addFlowerButton.Cursor = Cursors.Hand;
            addFlowerButton.FlatStyle = FlatStyle.Flat;
            addFlowerButton.Location = new Point(971, 318);
            addFlowerButton.Name = "addFlowerButton";
            addFlowerButton.Size = new Size(126, 28);
            addFlowerButton.TabIndex = 40;
            addFlowerButton.Text = "Ajouter";
            addFlowerButton.UseVisualStyleBackColor = false;
            addFlowerButton.Visible = false;
            addFlowerButton.Click += addFlowerButton_Click;
            // 
            // accessoryLabel
            // 
            accessoryLabel.AutoSize = true;
            accessoryLabel.Location = new Point(699, 229);
            accessoryLabel.Name = "accessoryLabel";
            accessoryLabel.Size = new Size(85, 20);
            accessoryLabel.TabIndex = 39;
            accessoryLabel.Text = "Accessoires";
            accessoryLabel.Visible = false;
            // 
            // flowerLabel
            // 
            flowerLabel.AutoSize = true;
            flowerLabel.Location = new Point(699, 295);
            flowerLabel.Name = "flowerLabel";
            flowerLabel.Size = new Size(47, 20);
            flowerLabel.TabIndex = 38;
            flowerLabel.Text = "Fleurs";
            flowerLabel.Visible = false;
            // 
            // inStockFlowerComboBox
            // 
            inStockFlowerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            inStockFlowerComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inStockFlowerComboBox.FormattingEnabled = true;
            inStockFlowerComboBox.Location = new Point(699, 318);
            inStockFlowerComboBox.Name = "inStockFlowerComboBox";
            inStockFlowerComboBox.Size = new Size(266, 28);
            inStockFlowerComboBox.TabIndex = 37;
            inStockFlowerComboBox.Visible = false;
            // 
            // addAccessoryButton
            // 
            addAccessoryButton.BackColor = Color.Linen;
            addAccessoryButton.Cursor = Cursors.Hand;
            addAccessoryButton.FlatStyle = FlatStyle.Flat;
            addAccessoryButton.Location = new Point(971, 252);
            addAccessoryButton.Name = "addAccessoryButton";
            addAccessoryButton.Size = new Size(126, 28);
            addAccessoryButton.TabIndex = 36;
            addAccessoryButton.Text = "Ajouter";
            addAccessoryButton.UseVisualStyleBackColor = false;
            addAccessoryButton.Visible = false;
            addAccessoryButton.Click += addAccessoryButton_Click;
            // 
            // inStockAccessoryComboBox
            // 
            inStockAccessoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            inStockAccessoryComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inStockAccessoryComboBox.FormattingEnabled = true;
            inStockAccessoryComboBox.Location = new Point(699, 252);
            inStockAccessoryComboBox.Name = "inStockAccessoryComboBox";
            inStockAccessoryComboBox.Size = new Size(266, 28);
            inStockAccessoryComboBox.TabIndex = 35;
            inStockAccessoryComboBox.Visible = false;
            // 
            // bouquetPersoFlowLayoutPanel
            // 
            bouquetPersoFlowLayoutPanel.AutoScroll = true;
            bouquetPersoFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            bouquetPersoFlowLayoutPanel.Location = new Point(699, 364);
            bouquetPersoFlowLayoutPanel.Name = "bouquetPersoFlowLayoutPanel";
            bouquetPersoFlowLayoutPanel.Size = new Size(398, 222);
            bouquetPersoFlowLayoutPanel.TabIndex = 34;
            bouquetPersoFlowLayoutPanel.Visible = false;
            // 
            // orderButton
            // 
            orderButton.BackColor = Color.RoyalBlue;
            orderButton.Cursor = Cursors.Hand;
            orderButton.FlatStyle = FlatStyle.Flat;
            orderButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            orderButton.ForeColor = SystemColors.Control;
            orderButton.Location = new Point(883, 674);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(214, 66);
            orderButton.TabIndex = 33;
            orderButton.TabStop = false;
            orderButton.Text = "Commander";
            orderButton.UseVisualStyleBackColor = false;
            orderButton.Click += orderButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(603, 674);
            label1.Name = "label1";
            label1.Size = new Size(216, 23);
            label1.TabIndex = 32;
            label1.Text = "Date de livraison souhaitée";
            // 
            // deliveryDateTimePicker
            // 
            deliveryDateTimePicker.Format = DateTimePickerFormat.Short;
            deliveryDateTimePicker.Location = new Point(607, 700);
            deliveryDateTimePicker.Name = "deliveryDateTimePicker";
            deliveryDateTimePicker.Size = new Size(127, 27);
            deliveryDateTimePicker.TabIndex = 20;
            deliveryDateTimePicker.TabStop = false;
            // 
            // customMessageTextBox
            // 
            customMessageTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            customMessageTextBox.Location = new Point(33, 674);
            customMessageTextBox.Multiline = true;
            customMessageTextBox.Name = "customMessageTextBox";
            customMessageTextBox.PlaceholderText = "Message accompagnant l'arrangement floral";
            customMessageTextBox.RightToLeft = RightToLeft.No;
            customMessageTextBox.Size = new Size(545, 66);
            customMessageTextBox.TabIndex = 31;
            // 
            // deliveryAdressTextBox
            // 
            deliveryAdressTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            deliveryAdressTextBox.Location = new Point(33, 619);
            deliveryAdressTextBox.Name = "deliveryAdressTextBox";
            deliveryAdressTextBox.PlaceholderText = "Adresse de livraison";
            deliveryAdressTextBox.Size = new Size(294, 31);
            deliveryAdressTextBox.TabIndex = 30;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalPriceLabel.Location = new Point(515, 471);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(100, 28);
            totalPriceLabel.TabIndex = 28;
            totalPriceLabel.Text = "Total : 0€";
            // 
            // bouquetPanel
            // 
            bouquetPanel.BackgroundImageLayout = ImageLayout.Stretch;
            bouquetPanel.Location = new Point(33, 243);
            bouquetPanel.Name = "bouquetPanel";
            bouquetPanel.Size = new Size(255, 255);
            bouquetPanel.TabIndex = 26;
            bouquetPanel.Visible = false;
            // 
            // inStockBouquetsStandardComboBox
            // 
            inStockBouquetsStandardComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            inStockBouquetsStandardComboBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            inStockBouquetsStandardComboBox.FormattingEnabled = true;
            inStockBouquetsStandardComboBox.Location = new Point(33, 195);
            inStockBouquetsStandardComboBox.Name = "inStockBouquetsStandardComboBox";
            inStockBouquetsStandardComboBox.Size = new Size(266, 33);
            inStockBouquetsStandardComboBox.TabIndex = 25;
            inStockBouquetsStandardComboBox.Visible = false;
            inStockBouquetsStandardComboBox.SelectedValueChanged += inStockBouquetsStandardComboBox_SelectedValueChanged;
            // 
            // bouquetPersoCheckBox
            // 
            bouquetPersoCheckBox.AutoSize = true;
            bouquetPersoCheckBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bouquetPersoCheckBox.Location = new Point(788, 134);
            bouquetPersoCheckBox.Name = "bouquetPersoCheckBox";
            bouquetPersoCheckBox.Size = new Size(309, 27);
            bouquetPersoCheckBox.TabIndex = 24;
            bouquetPersoCheckBox.Text = "Créer son propre arrangement floral";
            bouquetPersoCheckBox.UseVisualStyleBackColor = true;
            bouquetPersoCheckBox.CheckedChanged += bouquetPersoCheckBox_CheckedChanged;
            // 
            // bouquetStandardCheckBox
            // 
            bouquetStandardCheckBox.AutoSize = true;
            bouquetStandardCheckBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bouquetStandardCheckBox.Location = new Point(33, 134);
            bouquetStandardCheckBox.Name = "bouquetStandardCheckBox";
            bouquetStandardCheckBox.Size = new Size(294, 27);
            bouquetStandardCheckBox.TabIndex = 23;
            bouquetStandardCheckBox.Text = "Commander un bouquet standard";
            bouquetStandardCheckBox.UseVisualStyleBackColor = true;
            bouquetStandardCheckBox.CheckedChanged += bouquetStandardCheckBox_CheckedChanged;
            // 
            // shopLabel
            // 
            shopLabel.AutoSize = true;
            shopLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            shopLabel.Location = new Point(528, 98);
            shopLabel.Name = "shopLabel";
            shopLabel.Size = new Size(75, 23);
            shopLabel.TabIndex = 22;
            shopLabel.Text = "Magasin";
            // 
            // shopComboBox
            // 
            shopComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shopComboBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            shopComboBox.FormattingEnabled = true;
            shopComboBox.Location = new Point(424, 124);
            shopComboBox.Name = "shopComboBox";
            shopComboBox.Size = new Size(282, 33);
            shopComboBox.TabIndex = 21;
            shopComboBox.SelectedValueChanged += shopComboBox_SelectedValueChanged;
            // 
            // orderDetailsLabel
            // 
            orderDetailsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            orderDetailsLabel.BackColor = SystemColors.ActiveCaption;
            orderDetailsLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            orderDetailsLabel.Location = new Point(0, 0);
            orderDetailsLabel.Name = "orderDetailsLabel";
            orderDetailsLabel.RightToLeft = RightToLeft.No;
            orderDetailsLabel.Size = new Size(1130, 89);
            orderDetailsLabel.TabIndex = 20;
            orderDetailsLabel.Text = "Détails de la commande";
            orderDetailsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // compositionUnknownPanel
            // 
            compositionUnknownPanel.BackColor = SystemColors.Window;
            compositionUnknownPanel.BorderStyle = BorderStyle.FixedSingle;
            compositionUnknownPanel.Controls.Add(quickDescriptionLabel);
            compositionUnknownPanel.Controls.Add(descriptionTextBox);
            compositionUnknownPanel.Controls.Add(budgetLabel);
            compositionUnknownPanel.Controls.Add(budgetUpDown);
            compositionUnknownPanel.Location = new Point(1025, 274);
            compositionUnknownPanel.Name = "compositionUnknownPanel";
            compositionUnknownPanel.Size = new Size(398, 314);
            compositionUnknownPanel.TabIndex = 49;
            compositionUnknownPanel.Visible = false;
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Location = new Point(20, 28);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(96, 20);
            budgetLabel.TabIndex = 1;
            budgetLabel.Text = "Votre budget";
            // 
            // budgetUpDown
            // 
            budgetUpDown.Location = new Point(24, 51);
            budgetUpDown.Name = "budgetUpDown";
            budgetUpDown.Size = new Size(150, 27);
            budgetUpDown.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(20, 159);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(350, 135);
            descriptionTextBox.TabIndex = 2;
            // 
            // quickDescriptionLabel
            // 
            quickDescriptionLabel.AutoSize = true;
            quickDescriptionLabel.Location = new Point(20, 114);
            quickDescriptionLabel.Name = "quickDescriptionLabel";
            quickDescriptionLabel.Size = new Size(250, 40);
            quickDescriptionLabel.TabIndex = 3;
            quickDescriptionLabel.Text = "Donnez-nous une description rapide\r\nde ce que vous souhaitez !";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1782, 853);
            Controls.Add(compositionUnknownPanel);
            Controls.Add(orderDetailsPanel);
            Controls.Add(userButton);
            Controls.Add(userDropdown);
            Controls.Add(returnButton);
            Controls.Add(backwardButton);
            Controls.Add(forwardButton);
            Controls.Add(pauseButton);
            Controls.Add(datePicker);
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application fleurs";
            FormClosing += OrderForm_FormClosing;
            userDropdown.ResumeLayout(false);
            orderDetailsPanel.ResumeLayout(false);
            orderDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)requiredDeliveryAdressPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)requiredCustomItemPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)requiredBouquetStandardPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)requiredShopPictureBox).EndInit();
            compositionUnknownPanel.ResumeLayout(false);
            compositionUnknownPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)budgetUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button backwardButton;
        private Button forwardButton;
        private Button pauseButton;
        private DateTimePicker datePicker;
        private System.Windows.Forms.Timer dateTimer;
        private Button returnButton;
        private Panel userDropdown;
        private Button myProfileButton;
        private Button disconnectButton;
        private Button myOrdersButton;
        private Button userButton;
        private Panel orderDetailsPanel;
        private Label orderDetailsLabel;
        private Label shopLabel;
        private ComboBox shopComboBox;
        private CheckBox bouquetPersoCheckBox;
        private CheckBox bouquetStandardCheckBox;
        private ComboBox inStockBouquetsStandardComboBox;
        private Panel bouquetPanel;
        private Label totalPriceLabel;
        private TextBox deliveryAdressTextBox;
        private TextBox customMessageTextBox;
        private Button orderButton;
        private Label label1;
        private DateTimePicker deliveryDateTimePicker;
        private FlowLayoutPanel bouquetPersoFlowLayoutPanel;
        private ComboBox inStockAccessoryComboBox;
        private Button addAccessoryButton;
        private Button addFlowerButton;
        private Label accessoryLabel;
        private Label flowerLabel;
        private ComboBox inStockFlowerComboBox;
        private PictureBox requiredShopPictureBox;
        private PictureBox requiredBouquetStandardPictureBox;
        private PictureBox requiredCustomItemPictureBox;
        private PictureBox requiredDeliveryAdressPictureBox;
        private Label fidelityLabel;
        private Label totalPriceBeforeDiscountLabel;
        private CheckBox compositionUnknownCheckBox;
        private CheckBox compositionKnownCheckBox;
        private Panel compositionUnknownPanel;
        private Label budgetLabel;
        private NumericUpDown budgetUpDown;
        private Label quickDescriptionLabel;
        private TextBox descriptionTextBox;
    }
}