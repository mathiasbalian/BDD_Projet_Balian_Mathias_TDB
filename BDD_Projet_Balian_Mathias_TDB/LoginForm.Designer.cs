namespace BDD_Projet_Balian_Mathias_TDB
{
    partial class LoginForm
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
            connectForm = new GroupBox();
            registerLinkLabel = new LinkLabel();
            noAccountLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            connectButton = new Button();
            welcomeText = new Label();
            passwordInput = new TextBox();
            emailInput = new TextBox();
            connectForm.SuspendLayout();
            SuspendLayout();
            // 
            // connectForm
            // 
            connectForm.Anchor = AnchorStyles.None;
            connectForm.BackColor = SystemColors.Window;
            connectForm.Controls.Add(registerLinkLabel);
            connectForm.Controls.Add(noAccountLabel);
            connectForm.Controls.Add(label2);
            connectForm.Controls.Add(label1);
            connectForm.Controls.Add(connectButton);
            connectForm.Controls.Add(welcomeText);
            connectForm.Controls.Add(passwordInput);
            connectForm.Controls.Add(emailInput);
            connectForm.FlatStyle = FlatStyle.Flat;
            connectForm.Location = new Point(684, 180);
            connectForm.Name = "connectForm";
            connectForm.Padding = new Padding(0, 15, 0, 25);
            connectForm.Size = new Size(415, 498);
            connectForm.TabIndex = 0;
            connectForm.TabStop = false;
            // 
            // registerLinkLabel
            // 
            registerLinkLabel.AutoSize = true;
            registerLinkLabel.Location = new Point(234, 358);
            registerLinkLabel.Name = "registerLinkLabel";
            registerLinkLabel.Size = new Size(67, 20);
            registerLinkLabel.TabIndex = 9;
            registerLinkLabel.TabStop = true;
            registerLinkLabel.Text = "S'inscrire";
            registerLinkLabel.LinkClicked += registerLinkLabel_LinkClicked;
            // 
            // noAccountLabel
            // 
            noAccountLabel.AutoSize = true;
            noAccountLabel.Location = new Point(38, 358);
            noAccountLabel.Name = "noAccountLabel";
            noAccountLabel.Size = new Size(199, 20);
            noAccountLabel.TabIndex = 8;
            noAccountLabel.Text = "Vous n'avez pas de compte ?";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 267);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 7;
            label2.Text = "Mot de passe";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 172);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 6;
            label1.Text = "Email";
            // 
            // connectButton
            // 
            connectButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            connectButton.BackColor = Color.RoyalBlue;
            connectButton.Cursor = Cursors.Hand;
            connectButton.FlatStyle = FlatStyle.Flat;
            connectButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            connectButton.ForeColor = SystemColors.Control;
            connectButton.Location = new Point(214, 422);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(171, 48);
            connectButton.TabIndex = 3;
            connectButton.Text = "Se connecter";
            connectButton.UseVisualStyleBackColor = false;
            connectButton.Click += connectButton_Click;
            // 
            // welcomeText
            // 
            welcomeText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            welcomeText.BackColor = SystemColors.InactiveCaption;
            welcomeText.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeText.Location = new Point(0, 0);
            welcomeText.Name = "welcomeText";
            welcomeText.RightToLeft = RightToLeft.No;
            welcomeText.Size = new Size(418, 110);
            welcomeText.TabIndex = 1;
            welcomeText.Text = "Bienvenue !";
            welcomeText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordInput
            // 
            passwordInput.Anchor = AnchorStyles.Bottom;
            passwordInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordInput.Location = new Point(41, 293);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(229, 34);
            passwordInput.TabIndex = 2;
            // 
            // emailInput
            // 
            emailInput.Anchor = AnchorStyles.Bottom;
            emailInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailInput.Location = new Point(41, 198);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(229, 34);
            emailInput.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1782, 853);
            Controls.Add(connectForm);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application fleurs";
            FormClosed += LoginFormClosed;
            connectForm.ResumeLayout(false);
            connectForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox connectForm;
        private TextBox passwordInput;
        private Label welcomeText;
        private TextBox emailInput;
        private Button connectButton;
        private Label label2;
        private Label label1;
        private LinkLabel registerLinkLabel;
        private Label noAccountLabel;
    }
}