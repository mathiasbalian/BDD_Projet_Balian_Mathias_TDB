namespace BDD_Projet_Balian_Mathias_TDB
{
    partial class RegisterForm
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
            registerBox = new GroupBox();
            registerButton = new Button();
            cardLabel = new Label();
            cardInput = new TextBox();
            adressLabel = new Label();
            adressInput = new TextBox();
            passwordInput = new TextBox();
            passwordLabel = new Label();
            emailLabel = new Label();
            emailInput = new TextBox();
            phoneLabel = new Label();
            phoneInput = new TextBox();
            firstNameInput = new TextBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            lastNameInput = new TextBox();
            welcomeText = new Label();
            button1 = new Button();
            registerBox.SuspendLayout();
            SuspendLayout();
            // 
            // registerBox
            // 
            registerBox.Anchor = AnchorStyles.None;
            registerBox.BackColor = SystemColors.Window;
            registerBox.Controls.Add(registerButton);
            registerBox.Controls.Add(cardLabel);
            registerBox.Controls.Add(cardInput);
            registerBox.Controls.Add(adressLabel);
            registerBox.Controls.Add(adressInput);
            registerBox.Controls.Add(passwordInput);
            registerBox.Controls.Add(passwordLabel);
            registerBox.Controls.Add(emailLabel);
            registerBox.Controls.Add(emailInput);
            registerBox.Controls.Add(phoneLabel);
            registerBox.Controls.Add(phoneInput);
            registerBox.Controls.Add(firstNameInput);
            registerBox.Controls.Add(firstNameLabel);
            registerBox.Controls.Add(lastNameLabel);
            registerBox.Controls.Add(lastNameInput);
            registerBox.Controls.Add(welcomeText);
            registerBox.FlatStyle = FlatStyle.Flat;
            registerBox.Location = new Point(677, 51);
            registerBox.Name = "registerBox";
            registerBox.Padding = new Padding(0, 15, 0, 25);
            registerBox.Size = new Size(428, 751);
            registerBox.TabIndex = 1;
            registerBox.TabStop = false;
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            registerButton.BackColor = Color.RoyalBlue;
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            registerButton.ForeColor = SystemColors.Control;
            registerButton.Location = new Point(229, 675);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(171, 48);
            registerButton.TabIndex = 4;
            registerButton.Text = "S'inscrire";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // cardLabel
            // 
            cardLabel.AutoSize = true;
            cardLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cardLabel.Location = new Point(36, 580);
            cardLabel.Name = "cardLabel";
            cardLabel.Size = new Size(123, 23);
            cardLabel.TabIndex = 15;
            cardLabel.Text = "Carte de crédit";
            // 
            // cardInput
            // 
            cardInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cardInput.Location = new Point(36, 606);
            cardInput.Name = "cardInput";
            cardInput.Size = new Size(223, 34);
            cardInput.TabIndex = 14;
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            adressLabel.Location = new Point(36, 502);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new Size(181, 23);
            adressLabel.TabIndex = 13;
            adressLabel.Text = "Adresse de facturation";
            // 
            // adressInput
            // 
            adressInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adressInput.Location = new Point(36, 528);
            adressInput.Name = "adressInput";
            adressInput.Size = new Size(223, 34);
            adressInput.TabIndex = 12;
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordInput.Location = new Point(36, 450);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(223, 34);
            passwordInput.TabIndex = 11;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(36, 424);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(112, 23);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Mot de passe";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(36, 346);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(51, 23);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email";
            // 
            // emailInput
            // 
            emailInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailInput.Location = new Point(36, 372);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(223, 34);
            emailInput.TabIndex = 8;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Location = new Point(36, 268);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(179, 23);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Numéro de téléphone";
            // 
            // phoneInput
            // 
            phoneInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneInput.Location = new Point(36, 294);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(223, 34);
            phoneInput.TabIndex = 6;
            // 
            // firstNameInput
            // 
            firstNameInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameInput.Location = new Point(36, 216);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(223, 34);
            firstNameInput.TabIndex = 5;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(36, 190);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(70, 23);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "Prénom";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(36, 112);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(48, 23);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Nom";
            // 
            // lastNameInput
            // 
            lastNameInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameInput.Location = new Point(36, 138);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(223, 34);
            lastNameInput.TabIndex = 2;
            // 
            // welcomeText
            // 
            welcomeText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            welcomeText.BackColor = SystemColors.InactiveCaption;
            welcomeText.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeText.Location = new Point(0, 0);
            welcomeText.Name = "welcomeText";
            welcomeText.RightToLeft = RightToLeft.No;
            welcomeText.Size = new Size(428, 80);
            welcomeText.TabIndex = 1;
            welcomeText.Text = "Inscription";
            welcomeText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.DarkGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(171, 48);
            button1.TabIndex = 16;
            button1.Text = "Retour";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1782, 853);
            Controls.Add(button1);
            Controls.Add(registerBox);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application fleurs";
            FormClosing += RegisterForm_FormClosing;
            registerBox.ResumeLayout(false);
            registerBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox registerBox;
        private Label welcomeText;
        private Label lastNameLabel;
        private TextBox lastNameInput;
        private Label emailLabel;
        private TextBox emailInput;
        private Label phoneLabel;
        private TextBox phoneInput;
        private TextBox firstNameInput;
        private Label firstNameLabel;
        private TextBox passwordInput;
        private Label passwordLabel;
        private Label cardLabel;
        private TextBox cardInput;
        private Label adressLabel;
        private TextBox adressInput;
        private Button registerButton;
        private Button button1;
    }
}