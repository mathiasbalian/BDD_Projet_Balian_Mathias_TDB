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
            bestYearClientLabel.Location = new Point(32, 251);
            bestYearClientLabel.Name = "bestYearClientLabel";
            bestYearClientLabel.Size = new Size(260, 23);
            bestYearClientLabel.TabIndex = 37;
            bestYearClientLabel.Text = "Meilleur(s) client(s) de l'année :";
            // 
            // trueBestYearClientLabel
            // 
            trueBestYearClientLabel.AutoSize = true;
            trueBestYearClientLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            trueBestYearClientLabel.Location = new Point(298, 251);
            trueBestYearClientLabel.Name = "trueBestYearClientLabel";
            trueBestYearClientLabel.Size = new Size(54, 23);
            trueBestYearClientLabel.TabIndex = 38;
            trueBestYearClientLabel.Text = "Client";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1782, 853);
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
    }
}