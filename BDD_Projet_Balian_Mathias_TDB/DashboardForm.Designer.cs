namespace BDD_Projet_Balian_Mathias_TDB
{
    partial class DashboardForm
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
            button1 = new Button();
            datePicker = new DateTimePicker();
            timer = new System.Windows.Forms.Timer(components);
            pauseButton = new Button();
            forwardButton = new Button();
            backwardButton = new Button();
            userButton = new Button();
            userDropdown = new Panel();
            myProfileButton = new Button();
            disconnectButton = new Button();
            myOrdersButton = new Button();
            userDropdown.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(719, 270);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(12, 12);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(127, 27);
            datePicker.TabIndex = 1;
            // 
            // timer
            // 
            timer.Interval = 10000;
            timer.Tick += timer_Tick;
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
            pauseButton.TabIndex = 2;
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
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
            forwardButton.TabIndex = 3;
            forwardButton.UseVisualStyleBackColor = true;
            forwardButton.Click += forwardButton_Click;
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
            backwardButton.TabIndex = 4;
            backwardButton.UseVisualStyleBackColor = true;
            backwardButton.Click += backwardButton_Click;
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
            userButton.TabIndex = 5;
            userButton.UseVisualStyleBackColor = true;
            userButton.Click += userButton_Click;
            // 
            // userDropdown
            // 
            userDropdown.BackColor = SystemColors.ButtonHighlight;
            userDropdown.Controls.Add(myProfileButton);
            userDropdown.Controls.Add(disconnectButton);
            userDropdown.Controls.Add(myOrdersButton);
            userDropdown.Location = new Point(1586, 48);
            userDropdown.Name = "userDropdown";
            userDropdown.Size = new Size(171, 120);
            userDropdown.TabIndex = 6;
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
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1782, 853);
            Controls.Add(userDropdown);
            Controls.Add(userButton);
            Controls.Add(backwardButton);
            Controls.Add(forwardButton);
            Controls.Add(pauseButton);
            Controls.Add(datePicker);
            Controls.Add(button1);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            FormClosing += DashboardForm_FormClosing;
            userDropdown.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DateTimePicker datePicker;
        private System.Windows.Forms.Timer timer;
        private Button pauseButton;
        private Button forwardButton;
        private Button backwardButton;
        private Button userButton;
        private Panel userDropdown;
        private Button disconnectButton;
        private Button myOrdersButton;
        private Button myProfileButton;
    }
}