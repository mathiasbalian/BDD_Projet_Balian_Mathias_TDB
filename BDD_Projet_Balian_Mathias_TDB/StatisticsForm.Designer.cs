namespace BDD_Projet_Balian_Mathias_TDB
{
    partial class StatisticsForm
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
            statisticsLabel = new Label();
            backwardButton = new Button();
            forwardButton = new Button();
            pauseButton = new Button();
            datePicker = new DateTimePicker();
            returnButton = new Button();
            dateTimer = new System.Windows.Forms.Timer(components);
            bestMonthClientLabel = new Label();
            trueBestMonthClientLabel = new Label();
            bestYearClientLabel = new Label();
            trueBestYearClientLabel = new Label();
            averageOrderPriceLabel = new Label();
            trueAverageOrderPriceLabel = new Label();
            mostFamousBouquetStandardLabel = new Label();
            trueMostFamousBouquetStandardLabel = new Label();
            mostFamousBouquetStandardPictureBox = new PictureBox();
            mostCAShopLabel = new Label();
            trueMostCAShopLabel = new Label();
            mostOrderedFlowerPictureBox = new PictureBox();
            trueMostOrderedFlowerLabel = new Label();
            mostOrderedFlowerLabel = new Label();
            mostOrderedAccessoryPictureBox = new PictureBox();
            trueMostOrderedAccessoryLabel = new Label();
            mostOrderedAccessoryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)mostFamousBouquetStandardPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mostOrderedFlowerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mostOrderedAccessoryPictureBox).BeginInit();
            SuspendLayout();
            // 
            // statisticsLabel
            // 
            statisticsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            statisticsLabel.BackColor = SystemColors.ActiveCaption;
            statisticsLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            statisticsLabel.Location = new Point(341, 9);
            statisticsLabel.Name = "statisticsLabel";
            statisticsLabel.RightToLeft = RightToLeft.No;
            statisticsLabel.Size = new Size(1130, 89);
            statisticsLabel.TabIndex = 25;
            statisticsLabel.Text = "Statistiques";
            statisticsLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            backwardButton.TabIndex = 33;
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
            forwardButton.TabIndex = 32;
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
            pauseButton.TabIndex = 31;
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(12, 12);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(127, 27);
            datePicker.TabIndex = 30;
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
            returnButton.TabIndex = 34;
            returnButton.Text = "Retour";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // dateTimer
            // 
            dateTimer.Interval = 15000;
            dateTimer.Tick += dateTimer_Tick;
            // 
            // bestMonthClientLabel
            // 
            bestMonthClientLabel.AutoSize = true;
            bestMonthClientLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            bestMonthClientLabel.Location = new Point(32, 194);
            bestMonthClientLabel.Name = "bestMonthClientLabel";
            bestMonthClientLabel.Size = new Size(242, 23);
            bestMonthClientLabel.TabIndex = 35;
            bestMonthClientLabel.Text = "Meilleur(s) client(s) du mois :";
            // 
            // trueBestMonthClientLabel
            // 
            trueBestMonthClientLabel.AutoSize = true;
            trueBestMonthClientLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            trueBestMonthClientLabel.Location = new Point(280, 194);
            trueBestMonthClientLabel.Name = "trueBestMonthClientLabel";
            trueBestMonthClientLabel.Size = new Size(54, 23);
            trueBestMonthClientLabel.TabIndex = 36;
            trueBestMonthClientLabel.Text = "Client";
            // 
            // bestYearClientLabel
            // 
            bestYearClientLabel.AutoSize = true;
            bestYearClientLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            bestYearClientLabel.Location = new Point(32, 248);
            bestYearClientLabel.Name = "bestYearClientLabel";
            bestYearClientLabel.Size = new Size(260, 23);
            bestYearClientLabel.TabIndex = 37;
            bestYearClientLabel.Text = "Meilleur(s) client(s) de l'année :";
            // 
            // trueBestYearClientLabel
            // 
            trueBestYearClientLabel.AutoSize = true;
            trueBestYearClientLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            trueBestYearClientLabel.Location = new Point(298, 248);
            trueBestYearClientLabel.Name = "trueBestYearClientLabel";
            trueBestYearClientLabel.Size = new Size(54, 23);
            trueBestYearClientLabel.TabIndex = 38;
            trueBestYearClientLabel.Text = "Client";
            // 
            // averageOrderPriceLabel
            // 
            averageOrderPriceLabel.AutoSize = true;
            averageOrderPriceLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            averageOrderPriceLabel.Location = new Point(32, 302);
            averageOrderPriceLabel.Name = "averageOrderPriceLabel";
            averageOrderPriceLabel.Size = new Size(243, 23);
            averageOrderPriceLabel.TabIndex = 39;
            averageOrderPriceLabel.Text = "Prix moyen des commandes :";
            // 
            // trueAverageOrderPriceLabel
            // 
            trueAverageOrderPriceLabel.AutoSize = true;
            trueAverageOrderPriceLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            trueAverageOrderPriceLabel.Location = new Point(280, 302);
            trueAverageOrderPriceLabel.Name = "trueAverageOrderPriceLabel";
            trueAverageOrderPriceLabel.Size = new Size(38, 23);
            trueAverageOrderPriceLabel.TabIndex = 40;
            trueAverageOrderPriceLabel.Text = "Prix";
            // 
            // mostFamousBouquetStandardLabel
            // 
            mostFamousBouquetStandardLabel.AutoSize = true;
            mostFamousBouquetStandardLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mostFamousBouquetStandardLabel.Location = new Point(638, 194);
            mostFamousBouquetStandardLabel.Name = "mostFamousBouquetStandardLabel";
            mostFamousBouquetStandardLabel.Size = new Size(315, 23);
            mostFamousBouquetStandardLabel.TabIndex = 41;
            mostFamousBouquetStandardLabel.Text = "Bouquet standard le plus commandé :";
            // 
            // trueMostFamousBouquetStandardLabel
            // 
            trueMostFamousBouquetStandardLabel.AutoSize = true;
            trueMostFamousBouquetStandardLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            trueMostFamousBouquetStandardLabel.Location = new Point(853, 409);
            trueMostFamousBouquetStandardLabel.Name = "trueMostFamousBouquetStandardLabel";
            trueMostFamousBouquetStandardLabel.Size = new Size(118, 23);
            trueMostFamousBouquetStandardLabel.TabIndex = 42;
            trueMostFamousBouquetStandardLabel.Text = "Nom bouquet";
            trueMostFamousBouquetStandardLabel.Visible = false;
            // 
            // mostFamousBouquetStandardPictureBox
            // 
            mostFamousBouquetStandardPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            mostFamousBouquetStandardPictureBox.Location = new Point(638, 232);
            mostFamousBouquetStandardPictureBox.Name = "mostFamousBouquetStandardPictureBox";
            mostFamousBouquetStandardPictureBox.Size = new Size(200, 200);
            mostFamousBouquetStandardPictureBox.TabIndex = 43;
            mostFamousBouquetStandardPictureBox.TabStop = false;
            mostFamousBouquetStandardPictureBox.Visible = false;
            // 
            // mostCAShopLabel
            // 
            mostCAShopLabel.AutoSize = true;
            mostCAShopLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mostCAShopLabel.Location = new Point(31, 356);
            mostCAShopLabel.Name = "mostCAShopLabel";
            mostCAShopLabel.Size = new Size(302, 23);
            mostCAShopLabel.TabIndex = 44;
            mostCAShopLabel.Text = "Magasin ayant réalisé le plus de CA :";
            // 
            // trueMostCAShopLabel
            // 
            trueMostCAShopLabel.AutoSize = true;
            trueMostCAShopLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            trueMostCAShopLabel.Location = new Point(339, 356);
            trueMostCAShopLabel.Name = "trueMostCAShopLabel";
            trueMostCAShopLabel.Size = new Size(74, 23);
            trueMostCAShopLabel.TabIndex = 45;
            trueMostCAShopLabel.Text = "Magasin";
            // 
            // mostOrderedFlowerPictureBox
            // 
            mostOrderedFlowerPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            mostOrderedFlowerPictureBox.Location = new Point(1047, 232);
            mostOrderedFlowerPictureBox.Name = "mostOrderedFlowerPictureBox";
            mostOrderedFlowerPictureBox.Size = new Size(200, 200);
            mostOrderedFlowerPictureBox.TabIndex = 48;
            mostOrderedFlowerPictureBox.TabStop = false;
            mostOrderedFlowerPictureBox.Visible = false;
            // 
            // trueMostOrderedFlowerLabel
            // 
            trueMostOrderedFlowerLabel.AutoSize = true;
            trueMostOrderedFlowerLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            trueMostOrderedFlowerLabel.Location = new Point(1262, 409);
            trueMostOrderedFlowerLabel.Name = "trueMostOrderedFlowerLabel";
            trueMostOrderedFlowerLabel.Size = new Size(87, 23);
            trueMostOrderedFlowerLabel.TabIndex = 47;
            trueMostOrderedFlowerLabel.Text = "Nom fleur";
            trueMostOrderedFlowerLabel.Visible = false;
            // 
            // mostOrderedFlowerLabel
            // 
            mostOrderedFlowerLabel.AutoSize = true;
            mostOrderedFlowerLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mostOrderedFlowerLabel.Location = new Point(1047, 194);
            mostOrderedFlowerLabel.Name = "mostOrderedFlowerLabel";
            mostOrderedFlowerLabel.Size = new Size(220, 23);
            mostOrderedFlowerLabel.TabIndex = 46;
            mostOrderedFlowerLabel.Text = "Fleur la plus commandée :";
            // 
            // mostOrderedAccessoryPictureBox
            // 
            mostOrderedAccessoryPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            mostOrderedAccessoryPictureBox.Location = new Point(1411, 232);
            mostOrderedAccessoryPictureBox.Name = "mostOrderedAccessoryPictureBox";
            mostOrderedAccessoryPictureBox.Size = new Size(200, 200);
            mostOrderedAccessoryPictureBox.TabIndex = 51;
            mostOrderedAccessoryPictureBox.TabStop = false;
            mostOrderedAccessoryPictureBox.Visible = false;
            // 
            // trueMostOrderedAccessoryLabel
            // 
            trueMostOrderedAccessoryLabel.AutoSize = true;
            trueMostOrderedAccessoryLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            trueMostOrderedAccessoryLabel.Location = new Point(1626, 409);
            trueMostOrderedAccessoryLabel.Name = "trueMostOrderedAccessoryLabel";
            trueMostOrderedAccessoryLabel.Size = new Size(87, 23);
            trueMostOrderedAccessoryLabel.TabIndex = 50;
            trueMostOrderedAccessoryLabel.Text = "Nom fleur";
            trueMostOrderedAccessoryLabel.Visible = false;
            // 
            // mostOrderedAccessoryLabel
            // 
            mostOrderedAccessoryLabel.AutoSize = true;
            mostOrderedAccessoryLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mostOrderedAccessoryLabel.Location = new Point(1411, 194);
            mostOrderedAccessoryLabel.Name = "mostOrderedAccessoryLabel";
            mostOrderedAccessoryLabel.Size = new Size(253, 23);
            mostOrderedAccessoryLabel.TabIndex = 49;
            mostOrderedAccessoryLabel.Text = "Accessoire le plus commandé :";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1782, 853);
            Controls.Add(mostOrderedAccessoryPictureBox);
            Controls.Add(trueMostOrderedAccessoryLabel);
            Controls.Add(mostOrderedAccessoryLabel);
            Controls.Add(mostOrderedFlowerPictureBox);
            Controls.Add(trueMostOrderedFlowerLabel);
            Controls.Add(mostOrderedFlowerLabel);
            Controls.Add(trueMostCAShopLabel);
            Controls.Add(mostCAShopLabel);
            Controls.Add(mostFamousBouquetStandardPictureBox);
            Controls.Add(trueMostFamousBouquetStandardLabel);
            Controls.Add(mostFamousBouquetStandardLabel);
            Controls.Add(trueAverageOrderPriceLabel);
            Controls.Add(averageOrderPriceLabel);
            Controls.Add(trueBestYearClientLabel);
            Controls.Add(bestYearClientLabel);
            Controls.Add(trueBestMonthClientLabel);
            Controls.Add(bestMonthClientLabel);
            Controls.Add(backwardButton);
            Controls.Add(forwardButton);
            Controls.Add(pauseButton);
            Controls.Add(datePicker);
            Controls.Add(returnButton);
            Controls.Add(statisticsLabel);
            Name = "StatisticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application fleurs";
            FormClosing += StatisticsForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)mostFamousBouquetStandardPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mostOrderedFlowerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mostOrderedAccessoryPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label statisticsLabel;
        private Button backwardButton;
        private Button forwardButton;
        private Button pauseButton;
        private DateTimePicker datePicker;
        private Button returnButton;
        private System.Windows.Forms.Timer dateTimer;
        private Label bestMonthClientLabel;
        private Label trueBestMonthClientLabel;
        private Label bestYearClientLabel;
        private Label trueBestYearClientLabel;
        private Label averageOrderPriceLabel;
        private Label trueAverageOrderPriceLabel;
        private Label mostFamousBouquetStandardLabel;
        private Label trueMostFamousBouquetStandardLabel;
        private PictureBox mostFamousBouquetStandardPictureBox;
        private Label mostCAShopLabel;
        private Label trueMostCAShopLabel;
        private PictureBox mostOrderedFlowerPictureBox;
        private Label trueMostOrderedFlowerLabel;
        private Label mostOrderedFlowerLabel;
        private PictureBox mostOrderedAccessoryPictureBox;
        private Label trueMostOrderedAccessoryLabel;
        private Label mostOrderedAccessoryLabel;
    }
}