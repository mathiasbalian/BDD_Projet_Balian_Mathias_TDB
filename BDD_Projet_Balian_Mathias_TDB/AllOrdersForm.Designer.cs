namespace BDD_Projet_Balian_Mathias_TDB
{
    partial class AllOrdersForm
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
            clientsOrdersLabel = new Label();
            allClientsComboBox = new ComboBox();
            selectClientLabel = new Label();
            clientOrdersGridView = new DataGridView();
            deleteOrderLabel = new Label();
            orderIdDeleteNumericBox = new NumericUpDown();
            deleteOrderButton = new Button();
            createCommandFromClientButton = new Button();
            selectShopLabel = new Label();
            allShopsComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)clientOrdersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderIdDeleteNumericBox).BeginInit();
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
            returnButton.TabIndex = 18;
            returnButton.Text = "Retour";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // clientsOrdersLabel
            // 
            clientsOrdersLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            clientsOrdersLabel.BackColor = SystemColors.ActiveCaption;
            clientsOrdersLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            clientsOrdersLabel.Location = new Point(325, 12);
            clientsOrdersLabel.Name = "clientsOrdersLabel";
            clientsOrdersLabel.RightToLeft = RightToLeft.No;
            clientsOrdersLabel.Size = new Size(1132, 89);
            clientsOrdersLabel.TabIndex = 22;
            clientsOrdersLabel.Text = "Commandes clients";
            clientsOrdersLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // allClientsComboBox
            // 
            allClientsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            allClientsComboBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            allClientsComboBox.FormattingEnabled = true;
            allClientsComboBox.Location = new Point(591, 150);
            allClientsComboBox.Name = "allClientsComboBox";
            allClientsComboBox.Size = new Size(280, 31);
            allClientsComboBox.TabIndex = 23;
            allClientsComboBox.SelectedValueChanged += allClientsComboBox_SelectedValueChanged;
            // 
            // selectClientLabel
            // 
            selectClientLabel.AutoSize = true;
            selectClientLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            selectClientLabel.Location = new Point(658, 122);
            selectClientLabel.Name = "selectClientLabel";
            selectClientLabel.Size = new Size(147, 25);
            selectClientLabel.TabIndex = 24;
            selectClientLabel.Text = "Choisir un client";
            // 
            // clientOrdersGridView
            // 
            clientOrdersGridView.AllowUserToAddRows = false;
            clientOrdersGridView.AllowUserToDeleteRows = false;
            clientOrdersGridView.AllowUserToResizeColumns = false;
            clientOrdersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            clientOrdersGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            clientOrdersGridView.BackgroundColor = SystemColors.ControlLight;
            clientOrdersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientOrdersGridView.Location = new Point(325, 202);
            clientOrdersGridView.Name = "clientOrdersGridView";
            clientOrdersGridView.RowHeadersWidth = 51;
            clientOrdersGridView.RowTemplate.Height = 29;
            clientOrdersGridView.Size = new Size(1132, 258);
            clientOrdersGridView.TabIndex = 25;
            clientOrdersGridView.CellContentClick += clientOrdersGridView_CellContentClick;
            // 
            // deleteOrderLabel
            // 
            deleteOrderLabel.AutoSize = true;
            deleteOrderLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteOrderLabel.Location = new Point(320, 524);
            deleteOrderLabel.Name = "deleteOrderLabel";
            deleteOrderLabel.Size = new Size(296, 23);
            deleteOrderLabel.TabIndex = 0;
            deleteOrderLabel.Text = "Supprimer une commande par son Id";
            // 
            // orderIdDeleteNumericBox
            // 
            orderIdDeleteNumericBox.Location = new Point(325, 550);
            orderIdDeleteNumericBox.Name = "orderIdDeleteNumericBox";
            orderIdDeleteNumericBox.Size = new Size(150, 27);
            orderIdDeleteNumericBox.TabIndex = 26;
            // 
            // deleteOrderButton
            // 
            deleteOrderButton.BackColor = Color.Linen;
            deleteOrderButton.Cursor = Cursors.Hand;
            deleteOrderButton.FlatStyle = FlatStyle.Flat;
            deleteOrderButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            deleteOrderButton.Location = new Point(481, 550);
            deleteOrderButton.Name = "deleteOrderButton";
            deleteOrderButton.Size = new Size(102, 27);
            deleteOrderButton.TabIndex = 37;
            deleteOrderButton.Text = "Supprimer";
            deleteOrderButton.UseVisualStyleBackColor = false;
            deleteOrderButton.Click += deleteOrderButton_Click;
            // 
            // createCommandFromClientButton
            // 
            createCommandFromClientButton.BackColor = Color.Linen;
            createCommandFromClientButton.Cursor = Cursors.Hand;
            createCommandFromClientButton.FlatStyle = FlatStyle.Flat;
            createCommandFromClientButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            createCommandFromClientButton.Location = new Point(1255, 527);
            createCommandFromClientButton.Name = "createCommandFromClientButton";
            createCommandFromClientButton.Size = new Size(202, 71);
            createCommandFromClientButton.TabIndex = 39;
            createCommandFromClientButton.Text = "Effectuer une commande au nom du client sélectionné";
            createCommandFromClientButton.UseVisualStyleBackColor = false;
            createCommandFromClientButton.Click += createCommandFromClientButton_Click;
            // 
            // selectShopLabel
            // 
            selectShopLabel.AutoSize = true;
            selectShopLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            selectShopLabel.Location = new Point(963, 122);
            selectShopLabel.Name = "selectShopLabel";
            selectShopLabel.Size = new Size(170, 25);
            selectShopLabel.TabIndex = 41;
            selectShopLabel.Text = "Choisir un magasin";
            // 
            // allShopsComboBox
            // 
            allShopsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            allShopsComboBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            allShopsComboBox.FormattingEnabled = true;
            allShopsComboBox.Location = new Point(911, 150);
            allShopsComboBox.Name = "allShopsComboBox";
            allShopsComboBox.Size = new Size(280, 31);
            allShopsComboBox.TabIndex = 40;
            allShopsComboBox.SelectedValueChanged += allShopsComboBox_SelectedValueChanged;
            // 
            // AllOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1782, 853);
            Controls.Add(selectShopLabel);
            Controls.Add(allShopsComboBox);
            Controls.Add(createCommandFromClientButton);
            Controls.Add(deleteOrderButton);
            Controls.Add(orderIdDeleteNumericBox);
            Controls.Add(deleteOrderLabel);
            Controls.Add(clientOrdersGridView);
            Controls.Add(selectClientLabel);
            Controls.Add(allClientsComboBox);
            Controls.Add(clientsOrdersLabel);
            Controls.Add(returnButton);
            Controls.Add(backwardButton);
            Controls.Add(forwardButton);
            Controls.Add(pauseButton);
            Controls.Add(datePicker);
            Name = "AllOrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Applications fleurs";
            FormClosing += AllOrdersForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)clientOrdersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderIdDeleteNumericBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backwardButton;
        private Button forwardButton;
        private Button pauseButton;
        private DateTimePicker datePicker;
        private System.Windows.Forms.Timer dateTimer;
        private Button returnButton;
        private Label clientsOrdersLabel;
        private ComboBox allClientsComboBox;
        private Label selectClientLabel;
        private DataGridView clientOrdersGridView;
        private Label deleteOrderLabel;
        private NumericUpDown orderIdDeleteNumericBox;
        private Button deleteOrderButton;
        private Button createCommandFromClientButton;
        private Label selectShopLabel;
        private ComboBox allShopsComboBox;
    }
}