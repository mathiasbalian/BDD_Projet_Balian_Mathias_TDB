namespace BDD_Projet_Balian_Mathias_TDB
{
    partial class AllClientsForm
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
            shopsAndStocksLabel = new Label();
            backwardButton = new Button();
            forwardButton = new Button();
            pauseButton = new Button();
            datePicker = new DateTimePicker();
            dateTimer = new System.Windows.Forms.Timer(components);
            returnButton = new Button();
            selectClientLabel = new Label();
            allClientsComboBox = new ComboBox();
            clientsGridView = new DataGridView();
            createClient = new Button();
            ((System.ComponentModel.ISupportInitialize)clientsGridView).BeginInit();
            SuspendLayout();
            // 
            // shopsAndStocksLabel
            // 
            shopsAndStocksLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            shopsAndStocksLabel.BackColor = SystemColors.ActiveCaption;
            shopsAndStocksLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            shopsAndStocksLabel.Location = new Point(326, 9);
            shopsAndStocksLabel.Name = "shopsAndStocksLabel";
            shopsAndStocksLabel.RightToLeft = RightToLeft.No;
            shopsAndStocksLabel.Size = new Size(1130, 89);
            shopsAndStocksLabel.TabIndex = 24;
            shopsAndStocksLabel.Text = "Gestion des clients";
            shopsAndStocksLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            backwardButton.TabIndex = 28;
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
            forwardButton.TabIndex = 27;
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
            pauseButton.TabIndex = 26;
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(12, 12);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(127, 27);
            datePicker.TabIndex = 25;
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
            returnButton.TabIndex = 29;
            returnButton.Text = "Retour";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // selectClientLabel
            // 
            selectClientLabel.AutoSize = true;
            selectClientLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            selectClientLabel.Location = new Point(818, 132);
            selectClientLabel.Name = "selectClientLabel";
            selectClientLabel.Size = new Size(147, 25);
            selectClientLabel.TabIndex = 31;
            selectClientLabel.Text = "Choisir un client";
            // 
            // allClientsComboBox
            // 
            allClientsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            allClientsComboBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            allClientsComboBox.FormattingEnabled = true;
            allClientsComboBox.Location = new Point(751, 160);
            allClientsComboBox.Name = "allClientsComboBox";
            allClientsComboBox.Size = new Size(280, 31);
            allClientsComboBox.TabIndex = 30;
            allClientsComboBox.SelectedValueChanged += allClientsComboBox_SelectedValueChanged;
            // 
            // clientsGridView
            // 
            clientsGridView.AllowUserToAddRows = false;
            clientsGridView.AllowUserToDeleteRows = false;
            clientsGridView.AllowUserToResizeColumns = false;
            clientsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            clientsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            clientsGridView.BackgroundColor = SystemColors.ControlLight;
            clientsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsGridView.Location = new Point(325, 225);
            clientsGridView.Name = "clientsGridView";
            clientsGridView.RowHeadersWidth = 51;
            clientsGridView.RowTemplate.Height = 29;
            clientsGridView.Size = new Size(1132, 258);
            clientsGridView.TabIndex = 32;
            clientsGridView.CellContentClick += clientsGridView_CellContentClick;
            // 
            // createClient
            // 
            createClient.BackColor = Color.Linen;
            createClient.Cursor = Cursors.Hand;
            createClient.FlatStyle = FlatStyle.Flat;
            createClient.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            createClient.Location = new Point(1254, 524);
            createClient.Name = "createClient";
            createClient.Size = new Size(202, 50);
            createClient.TabIndex = 40;
            createClient.Text = "Créer un nouveau client";
            createClient.UseVisualStyleBackColor = false;
            createClient.Click += createClient_Click;
            // 
            // AllClientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1782, 853);
            Controls.Add(createClient);
            Controls.Add(clientsGridView);
            Controls.Add(selectClientLabel);
            Controls.Add(allClientsComboBox);
            Controls.Add(backwardButton);
            Controls.Add(forwardButton);
            Controls.Add(pauseButton);
            Controls.Add(datePicker);
            Controls.Add(returnButton);
            Controls.Add(shopsAndStocksLabel);
            Name = "AllClientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application fleurs";
            FormClosing += AllClientsForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)clientsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label shopsAndStocksLabel;
        private Button backwardButton;
        private Button forwardButton;
        private Button pauseButton;
        private DateTimePicker datePicker;
        private System.Windows.Forms.Timer dateTimer;
        private Button returnButton;
        private Label selectClientLabel;
        private ComboBox allClientsComboBox;
        private DataGridView clientsGridView;
        private Button createClient;
    }
}