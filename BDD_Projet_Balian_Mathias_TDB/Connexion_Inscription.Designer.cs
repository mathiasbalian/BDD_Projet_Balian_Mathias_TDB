namespace BDD_Projet_Balian_Mathias_TDB
{
    partial class Connexion_Inscription
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
            Connexion_formulaire = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            inscrireLinkText = new LinkLabel();
            noAccountText = new Label();
            connectButton = new Button();
            Bienvenue_text = new Label();
            passwordInput = new TextBox();
            emailInput = new TextBox();
            Connexion_formulaire.SuspendLayout();
            SuspendLayout();
            // 
            // Connexion_formulaire
            // 
            Connexion_formulaire.Anchor = AnchorStyles.None;
            Connexion_formulaire.BackColor = SystemColors.Window;
            Connexion_formulaire.Controls.Add(label2);
            Connexion_formulaire.Controls.Add(label1);
            Connexion_formulaire.Controls.Add(inscrireLinkText);
            Connexion_formulaire.Controls.Add(noAccountText);
            Connexion_formulaire.Controls.Add(connectButton);
            Connexion_formulaire.Controls.Add(Bienvenue_text);
            Connexion_formulaire.Controls.Add(passwordInput);
            Connexion_formulaire.Controls.Add(emailInput);
            Connexion_formulaire.FlatStyle = FlatStyle.Flat;
            Connexion_formulaire.Location = new Point(684, 180);
            Connexion_formulaire.Name = "Connexion_formulaire";
            Connexion_formulaire.Padding = new Padding(0, 15, 0, 25);
            Connexion_formulaire.Size = new Size(415, 492);
            Connexion_formulaire.TabIndex = 0;
            Connexion_formulaire.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 250);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 7;
            label2.Text = "Mot de passe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 166);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 6;
            label1.Text = "Email";
            // 
            // inscrireLinkText
            // 
            inscrireLinkText.AutoSize = true;
            inscrireLinkText.Location = new Point(237, 341);
            inscrireLinkText.Name = "inscrireLinkText";
            inscrireLinkText.Size = new Size(67, 20);
            inscrireLinkText.TabIndex = 5;
            inscrireLinkText.TabStop = true;
            inscrireLinkText.Text = "S'inscrire";
            inscrireLinkText.LinkClicked += inscrireLinkText_LinkClicked;
            // 
            // noAccountText
            // 
            noAccountText.AutoSize = true;
            noAccountText.Location = new Point(41, 341);
            noAccountText.Name = "noAccountText";
            noAccountText.Size = new Size(199, 20);
            noAccountText.TabIndex = 4;
            noAccountText.Text = "Vous n'avez pas de compte ?";
            // 
            // connectButton
            // 
            connectButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            connectButton.BackColor = Color.RoyalBlue;
            connectButton.Cursor = Cursors.Hand;
            connectButton.FlatStyle = FlatStyle.Flat;
            connectButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            connectButton.ForeColor = SystemColors.Control;
            connectButton.Location = new Point(221, 416);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(171, 48);
            connectButton.TabIndex = 3;
            connectButton.Text = "Se connecter";
            connectButton.UseVisualStyleBackColor = false;
            // 
            // Bienvenue_text
            // 
            Bienvenue_text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Bienvenue_text.BackColor = SystemColors.InactiveCaption;
            Bienvenue_text.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Bienvenue_text.Location = new Point(0, 0);
            Bienvenue_text.Name = "Bienvenue_text";
            Bienvenue_text.RightToLeft = RightToLeft.No;
            Bienvenue_text.Size = new Size(415, 105);
            Bienvenue_text.TabIndex = 1;
            Bienvenue_text.Text = "Bienvenue !";
            Bienvenue_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordInput.Location = new Point(41, 276);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(229, 34);
            passwordInput.TabIndex = 2;
            // 
            // emailInput
            // 
            emailInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailInput.Location = new Point(41, 192);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(229, 34);
            emailInput.TabIndex = 0;
            // 
            // Connexion_Inscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1782, 853);
            Controls.Add(Connexion_formulaire);
            Name = "Connexion_Inscription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application fleurs";
            Connexion_formulaire.ResumeLayout(false);
            Connexion_formulaire.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Connexion_formulaire;
        private TextBox passwordInput;
        private Label Bienvenue_text;
        private TextBox emailInput;
        private Button connectButton;
        private Label noAccountText;
        private LinkLabel inscrireLinkText;
        private Label label2;
        private Label label1;
    }
}