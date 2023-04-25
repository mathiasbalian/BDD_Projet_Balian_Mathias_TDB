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
            orderDetailsLabel = new Label();
            userDropdown.SuspendLayout();
            orderDetailsPanel.SuspendLayout();
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
            // 
            // dateTimer
            // 
            dateTimer.Interval = 10000;
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
            orderDetailsPanel.Controls.Add(orderDetailsLabel);
            orderDetailsPanel.Location = new Point(454, 40);
            orderDetailsPanel.Name = "orderDetailsPanel";
            orderDetailsPanel.Size = new Size(875, 773);
            orderDetailsPanel.TabIndex = 19;
            // 
            // orderDetailsLabel
            // 
            orderDetailsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            orderDetailsLabel.BackColor = SystemColors.ActiveCaption;
            orderDetailsLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            orderDetailsLabel.Location = new Point(0, 0);
            orderDetailsLabel.Name = "orderDetailsLabel";
            orderDetailsLabel.RightToLeft = RightToLeft.No;
            orderDetailsLabel.Size = new Size(875, 89);
            orderDetailsLabel.TabIndex = 20;
            orderDetailsLabel.Text = "Détails de la commande";
            orderDetailsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1782, 853);
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
    }
}