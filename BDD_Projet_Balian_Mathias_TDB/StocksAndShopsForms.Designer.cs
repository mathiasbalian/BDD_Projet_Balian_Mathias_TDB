namespace BDD_Projet_Balian_Mathias_TDB
{
    partial class StocksAndShopsForms
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
            returnButton = new Button();
            backwardButton = new Button();
            forwardButton = new Button();
            pauseButton = new Button();
            datePicker = new DateTimePicker();
            dateTimer = new System.Windows.Forms.Timer(components);
            shopsAndStocksLabel = new Label();
            selectShopLabel = new Label();
            allShopsComboBox = new ComboBox();
            selectProductLabel = new Label();
            allProductsComboBox = new ComboBox();
            stocksAndShopsGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)stocksAndShopsGridView).BeginInit();
            SuspendLayout();
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
            returnButton.TabIndex = 22;
            returnButton.Text = "Retour";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
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
            backwardButton.TabIndex = 21;
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
            forwardButton.TabIndex = 20;
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
            pauseButton.TabIndex = 19;
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(12, 12);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(127, 27);
            datePicker.TabIndex = 18;
            datePicker.TabStop = false;
            // 
            // dateTimer
            // 
            dateTimer.Interval = 15000;
            dateTimer.Tick += dateTimer_Tick;
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
            shopsAndStocksLabel.TabIndex = 23;
            shopsAndStocksLabel.Text = "Gestions des magasins et des stocks";
            shopsAndStocksLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectShopLabel
            // 
            selectShopLabel.AutoSize = true;
            selectShopLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            selectShopLabel.Location = new Point(963, 163);
            selectShopLabel.Name = "selectShopLabel";
            selectShopLabel.Size = new Size(170, 25);
            selectShopLabel.TabIndex = 45;
            selectShopLabel.Text = "Choisir un magasin";
            // 
            // allShopsComboBox
            // 
            allShopsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            allShopsComboBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            allShopsComboBox.FormattingEnabled = true;
            allShopsComboBox.Location = new Point(911, 191);
            allShopsComboBox.Name = "allShopsComboBox";
            allShopsComboBox.Size = new Size(280, 31);
            allShopsComboBox.TabIndex = 44;
            allShopsComboBox.SelectedValueChanged += allShopsComboBox_SelectedValueChanged;
            // 
            // selectProductLabel
            // 
            selectProductLabel.AutoSize = true;
            selectProductLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            selectProductLabel.Location = new Point(658, 163);
            selectProductLabel.Name = "selectProductLabel";
            selectProductLabel.Size = new Size(164, 25);
            selectProductLabel.TabIndex = 43;
            selectProductLabel.Text = "Choisir un produit";
            // 
            // allProductsComboBox
            // 
            allProductsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            allProductsComboBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            allProductsComboBox.FormattingEnabled = true;
            allProductsComboBox.Location = new Point(591, 191);
            allProductsComboBox.Name = "allProductsComboBox";
            allProductsComboBox.Size = new Size(280, 31);
            allProductsComboBox.TabIndex = 42;
            allProductsComboBox.SelectedValueChanged += allProductsComboBox_SelectedValueChanged;
            // 
            // stocksAndShopsGridView
            // 
            stocksAndShopsGridView.AllowUserToAddRows = false;
            stocksAndShopsGridView.AllowUserToDeleteRows = false;
            stocksAndShopsGridView.AllowUserToResizeColumns = false;
            stocksAndShopsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            stocksAndShopsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            stocksAndShopsGridView.BackgroundColor = SystemColors.ControlLight;
            stocksAndShopsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stocksAndShopsGridView.Location = new Point(325, 268);
            stocksAndShopsGridView.Name = "stocksAndShopsGridView";
            stocksAndShopsGridView.RowHeadersWidth = 51;
            stocksAndShopsGridView.RowTemplate.Height = 29;
            stocksAndShopsGridView.Size = new Size(1132, 258);
            stocksAndShopsGridView.TabIndex = 46;
            // 
            // StocksAndShopsForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1782, 853);
            Controls.Add(stocksAndShopsGridView);
            Controls.Add(selectShopLabel);
            Controls.Add(allShopsComboBox);
            Controls.Add(selectProductLabel);
            Controls.Add(allProductsComboBox);
            Controls.Add(shopsAndStocksLabel);
            Controls.Add(returnButton);
            Controls.Add(backwardButton);
            Controls.Add(forwardButton);
            Controls.Add(pauseButton);
            Controls.Add(datePicker);
            Name = "StocksAndShopsForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application fleurs";
            FormClosing += StocksAndShopsForms_FormClosing;
            ((System.ComponentModel.ISupportInitialize)stocksAndShopsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnButton;
        private Button backwardButton;
        private Button forwardButton;
        private Button pauseButton;
        private DateTimePicker datePicker;
        private System.Windows.Forms.Timer dateTimer;
        private Label shopsAndStocksLabel;
        private Label selectShopLabel;
        private ComboBox allShopsComboBox;
        private Label selectProductLabel;
        private ComboBox allProductsComboBox;
        private DataGridView stocksAndShopsGridView;
    }
}