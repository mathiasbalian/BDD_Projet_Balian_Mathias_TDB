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
            dateTimer = new System.Windows.Forms.Timer(components);
            pauseButton = new Button();
            forwardButton = new Button();
            backwardButton = new Button();
            userButton = new Button();
            userDropdown = new Panel();
            myProfileButton = new Button();
            disconnectButton = new Button();
            myOrdersButton = new Button();
            productsPanel = new Panel();
            pommePinLabel = new Label();
            pommePinButton = new Button();
            rubanLabel = new Label();
            rubanButton = new Button();
            vaseLabel = new Label();
            vaseButton = new Button();
            feuilleOrLabel = new Label();
            feuilleOrButton = new Button();
            boxLabel = new Label();
            accessoireButton = new Button();
            boxButton = new Button();
            roseRougeLabel = new Label();
            roseRougeButton = new Button();
            margueriteLabel = new Label();
            margueriteButton = new Button();
            gingerLabel = new Label();
            gingerButton = new Button();
            glaieulLabel = new Label();
            glaieulButton = new Button();
            gerberaLabel = new Label();
            flowersLabel = new Button();
            gerberaButton = new Button();
            marieeLabel = new Label();
            marieeButton = new Button();
            mamanLabel = new Label();
            mamanButton = new Button();
            exotiqueLabel = new Label();
            exotiqueButton = new Button();
            amoureuxLabel = new Label();
            lamoureuxButton = new Button();
            grosMerciLabel = new Label();
            bouquetsButton = new Button();
            grosMerciButton = new Button();
            productsButton = new Button();
            orderButton = new Button();
            dropdownTimer = new System.Windows.Forms.Timer(components);
            userDropdown.SuspendLayout();
            productsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1329, 13);
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
            // dateTimer
            // 
            dateTimer.Interval = 10000;
            dateTimer.Tick += timer_Tick;
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
            userDropdown.BorderStyle = BorderStyle.FixedSingle;
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
            // productsPanel
            // 
            productsPanel.AutoScroll = true;
            productsPanel.AutoScrollMargin = new Size(5, 5);
            productsPanel.BorderStyle = BorderStyle.FixedSingle;
            productsPanel.Controls.Add(pommePinLabel);
            productsPanel.Controls.Add(pommePinButton);
            productsPanel.Controls.Add(rubanLabel);
            productsPanel.Controls.Add(rubanButton);
            productsPanel.Controls.Add(vaseLabel);
            productsPanel.Controls.Add(vaseButton);
            productsPanel.Controls.Add(feuilleOrLabel);
            productsPanel.Controls.Add(feuilleOrButton);
            productsPanel.Controls.Add(boxLabel);
            productsPanel.Controls.Add(accessoireButton);
            productsPanel.Controls.Add(boxButton);
            productsPanel.Controls.Add(roseRougeLabel);
            productsPanel.Controls.Add(roseRougeButton);
            productsPanel.Controls.Add(margueriteLabel);
            productsPanel.Controls.Add(margueriteButton);
            productsPanel.Controls.Add(gingerLabel);
            productsPanel.Controls.Add(gingerButton);
            productsPanel.Controls.Add(glaieulLabel);
            productsPanel.Controls.Add(glaieulButton);
            productsPanel.Controls.Add(gerberaLabel);
            productsPanel.Controls.Add(flowersLabel);
            productsPanel.Controls.Add(gerberaButton);
            productsPanel.Controls.Add(marieeLabel);
            productsPanel.Controls.Add(marieeButton);
            productsPanel.Controls.Add(mamanLabel);
            productsPanel.Controls.Add(mamanButton);
            productsPanel.Controls.Add(exotiqueLabel);
            productsPanel.Controls.Add(exotiqueButton);
            productsPanel.Controls.Add(amoureuxLabel);
            productsPanel.Controls.Add(lamoureuxButton);
            productsPanel.Controls.Add(grosMerciLabel);
            productsPanel.Controls.Add(bouquetsButton);
            productsPanel.Controls.Add(grosMerciButton);
            productsPanel.Controls.Add(productsButton);
            productsPanel.Location = new Point(29, 131);
            productsPanel.Margin = new Padding(0);
            productsPanel.Name = "productsPanel";
            productsPanel.Size = new Size(1725, 690);
            productsPanel.TabIndex = 7;
            // 
            // pommePinLabel
            // 
            pommePinLabel.AutoSize = true;
            pommePinLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            pommePinLabel.Location = new Point(1460, 1259);
            pommePinLabel.Name = "pommePinLabel";
            pommePinLabel.Size = new Size(157, 25);
            pommePinLabel.TabIndex = 33;
            pommePinLabel.Text = "La pomme de pin";
            // 
            // pommePinButton
            // 
            pommePinButton.BackgroundImage = Properties.Resources.pomme_de_pin;
            pommePinButton.BackgroundImageLayout = ImageLayout.Stretch;
            pommePinButton.Cursor = Cursors.Hand;
            pommePinButton.FlatStyle = FlatStyle.Flat;
            pommePinButton.Location = new Point(1399, 991);
            pommePinButton.Name = "pommePinButton";
            pommePinButton.Size = new Size(270, 265);
            pommePinButton.TabIndex = 32;
            pommePinButton.UseVisualStyleBackColor = true;
            // 
            // rubanLabel
            // 
            rubanLabel.AutoSize = true;
            rubanLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            rubanLabel.Location = new Point(1168, 1259);
            rubanLabel.Name = "rubanLabel";
            rubanLabel.Size = new Size(65, 25);
            rubanLabel.TabIndex = 31;
            rubanLabel.Text = "Ruban";
            // 
            // rubanButton
            // 
            rubanButton.BackgroundImage = Properties.Resources.ruban;
            rubanButton.BackgroundImageLayout = ImageLayout.Stretch;
            rubanButton.Cursor = Cursors.Hand;
            rubanButton.FlatStyle = FlatStyle.Flat;
            rubanButton.Location = new Point(1062, 991);
            rubanButton.Name = "rubanButton";
            rubanButton.Size = new Size(270, 265);
            rubanButton.TabIndex = 30;
            rubanButton.UseVisualStyleBackColor = true;
            // 
            // vaseLabel
            // 
            vaseLabel.AutoSize = true;
            vaseLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            vaseLabel.Location = new Point(835, 1259);
            vaseLabel.Name = "vaseLabel";
            vaseLabel.Size = new Size(50, 25);
            vaseLabel.TabIndex = 29;
            vaseLabel.Text = "Vase";
            // 
            // vaseButton
            // 
            vaseButton.BackgroundImage = Properties.Resources.vase;
            vaseButton.BackgroundImageLayout = ImageLayout.Stretch;
            vaseButton.Cursor = Cursors.Hand;
            vaseButton.FlatStyle = FlatStyle.Flat;
            vaseButton.Location = new Point(725, 991);
            vaseButton.Name = "vaseButton";
            vaseButton.Size = new Size(270, 265);
            vaseButton.TabIndex = 28;
            vaseButton.UseVisualStyleBackColor = true;
            // 
            // feuilleOrLabel
            // 
            feuilleOrLabel.AutoSize = true;
            feuilleOrLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            feuilleOrLabel.Location = new Point(466, 1259);
            feuilleOrLabel.Name = "feuilleOrLabel";
            feuilleOrLabel.Size = new Size(121, 25);
            feuilleOrLabel.TabIndex = 27;
            feuilleOrLabel.Text = "Feuille dorée";
            // 
            // feuilleOrButton
            // 
            feuilleOrButton.BackgroundImage = Properties.Resources.feuille_dorée;
            feuilleOrButton.BackgroundImageLayout = ImageLayout.Stretch;
            feuilleOrButton.Cursor = Cursors.Hand;
            feuilleOrButton.FlatStyle = FlatStyle.Flat;
            feuilleOrButton.Location = new Point(388, 991);
            feuilleOrButton.Name = "feuilleOrButton";
            feuilleOrButton.Size = new Size(270, 265);
            feuilleOrButton.TabIndex = 26;
            feuilleOrButton.UseVisualStyleBackColor = true;
            // 
            // boxLabel
            // 
            boxLabel.AutoSize = true;
            boxLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            boxLabel.Location = new Point(95, 1259);
            boxLabel.Name = "boxLabel";
            boxLabel.Size = new Size(178, 25);
            boxLabel.TabIndex = 25;
            boxLabel.Text = "Boîte pour bouquet";
            // 
            // accessoireButton
            // 
            accessoireButton.BackColor = SystemColors.InactiveCaption;
            accessoireButton.FlatAppearance.BorderSize = 0;
            accessoireButton.FlatStyle = FlatStyle.Flat;
            accessoireButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            accessoireButton.Location = new Point(-1, 905);
            accessoireButton.Name = "accessoireButton";
            accessoireButton.Size = new Size(1725, 70);
            accessoireButton.TabIndex = 24;
            accessoireButton.Text = "Les accessoires";
            accessoireButton.UseVisualStyleBackColor = false;
            // 
            // boxButton
            // 
            boxButton.BackgroundImage = Properties.Resources.bouquet_boîte;
            boxButton.BackgroundImageLayout = ImageLayout.Stretch;
            boxButton.Cursor = Cursors.Hand;
            boxButton.FlatStyle = FlatStyle.Flat;
            boxButton.Location = new Point(51, 991);
            boxButton.Name = "boxButton";
            boxButton.Size = new Size(270, 265);
            boxButton.TabIndex = 23;
            boxButton.UseVisualStyleBackColor = true;
            // 
            // roseRougeLabel
            // 
            roseRougeLabel.AutoSize = true;
            roseRougeLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            roseRougeLabel.Location = new Point(1477, 849);
            roseRougeLabel.Name = "roseRougeLabel";
            roseRougeLabel.Size = new Size(134, 25);
            roseRougeLabel.TabIndex = 22;
            roseRougeLabel.Text = "La Rose Rouge";
            // 
            // roseRougeButton
            // 
            roseRougeButton.BackgroundImage = Properties.Resources.fleur_rose_rouge;
            roseRougeButton.BackgroundImageLayout = ImageLayout.Stretch;
            roseRougeButton.Cursor = Cursors.Hand;
            roseRougeButton.FlatStyle = FlatStyle.Flat;
            roseRougeButton.Location = new Point(1399, 581);
            roseRougeButton.Name = "roseRougeButton";
            roseRougeButton.Size = new Size(270, 265);
            roseRougeButton.TabIndex = 21;
            roseRougeButton.UseVisualStyleBackColor = true;
            // 
            // margueriteLabel
            // 
            margueriteLabel.AutoSize = true;
            margueriteLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            margueriteLabel.Location = new Point(1135, 849);
            margueriteLabel.Name = "margueriteLabel";
            margueriteLabel.Size = new Size(129, 25);
            margueriteLabel.TabIndex = 20;
            margueriteLabel.Text = "La Marguerite";
            // 
            // margueriteButton
            // 
            margueriteButton.BackgroundImage = Properties.Resources.fleur_marguerite;
            margueriteButton.BackgroundImageLayout = ImageLayout.Stretch;
            margueriteButton.Cursor = Cursors.Hand;
            margueriteButton.FlatStyle = FlatStyle.Flat;
            margueriteButton.Location = new Point(1062, 581);
            margueriteButton.Name = "margueriteButton";
            margueriteButton.Size = new Size(270, 265);
            margueriteButton.TabIndex = 19;
            margueriteButton.UseVisualStyleBackColor = true;
            // 
            // gingerLabel
            // 
            gingerLabel.AutoSize = true;
            gingerLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gingerLabel.Location = new Point(807, 849);
            gingerLabel.Name = "gingerLabel";
            gingerLabel.Size = new Size(92, 25);
            gingerLabel.TabIndex = 18;
            gingerLabel.Text = "La Ginger";
            // 
            // gingerButton
            // 
            gingerButton.BackgroundImage = Properties.Resources.fleur_ginger;
            gingerButton.BackgroundImageLayout = ImageLayout.Stretch;
            gingerButton.Cursor = Cursors.Hand;
            gingerButton.FlatStyle = FlatStyle.Flat;
            gingerButton.Location = new Point(725, 581);
            gingerButton.Name = "gingerButton";
            gingerButton.Size = new Size(270, 265);
            gingerButton.TabIndex = 17;
            gingerButton.UseVisualStyleBackColor = true;
            // 
            // glaieulLabel
            // 
            glaieulLabel.AutoSize = true;
            glaieulLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            glaieulLabel.Location = new Point(466, 849);
            glaieulLabel.Name = "glaieulLabel";
            glaieulLabel.Size = new Size(93, 25);
            glaieulLabel.TabIndex = 16;
            glaieulLabel.Text = "La Glaïeul";
            // 
            // glaieulButton
            // 
            glaieulButton.BackgroundImage = Properties.Resources.fleur_glaieul;
            glaieulButton.BackgroundImageLayout = ImageLayout.Stretch;
            glaieulButton.Cursor = Cursors.Hand;
            glaieulButton.FlatStyle = FlatStyle.Flat;
            glaieulButton.Location = new Point(388, 581);
            glaieulButton.Name = "glaieulButton";
            glaieulButton.Size = new Size(270, 265);
            glaieulButton.TabIndex = 15;
            glaieulButton.UseVisualStyleBackColor = true;
            // 
            // gerberaLabel
            // 
            gerberaLabel.AutoSize = true;
            gerberaLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gerberaLabel.Location = new Point(121, 849);
            gerberaLabel.Name = "gerberaLabel";
            gerberaLabel.Size = new Size(109, 25);
            gerberaLabel.TabIndex = 14;
            gerberaLabel.Text = "La Gerbrera";
            // 
            // flowersLabel
            // 
            flowersLabel.BackColor = SystemColors.InactiveCaption;
            flowersLabel.FlatAppearance.BorderSize = 0;
            flowersLabel.FlatStyle = FlatStyle.Flat;
            flowersLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            flowersLabel.Location = new Point(-1, 495);
            flowersLabel.Name = "flowersLabel";
            flowersLabel.Size = new Size(1725, 70);
            flowersLabel.TabIndex = 13;
            flowersLabel.Text = "Les fleurs";
            flowersLabel.UseVisualStyleBackColor = false;
            // 
            // gerberaButton
            // 
            gerberaButton.BackgroundImage = Properties.Resources.fleur_gerbera;
            gerberaButton.BackgroundImageLayout = ImageLayout.Stretch;
            gerberaButton.Cursor = Cursors.Hand;
            gerberaButton.FlatStyle = FlatStyle.Flat;
            gerberaButton.Location = new Point(51, 581);
            gerberaButton.Name = "gerberaButton";
            gerberaButton.Size = new Size(270, 265);
            gerberaButton.TabIndex = 12;
            gerberaButton.UseVisualStyleBackColor = true;
            // 
            // marieeLabel
            // 
            marieeLabel.AutoSize = true;
            marieeLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            marieeLabel.Location = new Point(1476, 438);
            marieeLabel.Name = "marieeLabel";
            marieeLabel.Size = new Size(129, 25);
            marieeLabel.TabIndex = 11;
            marieeLabel.Text = "Vive la mariée";
            // 
            // marieeButton
            // 
            marieeButton.BackgroundImage = Properties.Resources.bouquet_mariage;
            marieeButton.BackgroundImageLayout = ImageLayout.Stretch;
            marieeButton.Cursor = Cursors.Hand;
            marieeButton.FlatStyle = FlatStyle.Flat;
            marieeButton.Location = new Point(1398, 170);
            marieeButton.Name = "marieeButton";
            marieeButton.Size = new Size(270, 265);
            marieeButton.TabIndex = 10;
            marieeButton.UseVisualStyleBackColor = true;
            marieeButton.Click += marieeButton_Click;
            // 
            // mamanLabel
            // 
            mamanLabel.AutoSize = true;
            mamanLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            mamanLabel.Location = new Point(1154, 438);
            mamanLabel.Name = "mamanLabel";
            mamanLabel.Size = new Size(74, 25);
            mamanLabel.TabIndex = 9;
            mamanLabel.Text = "Maman";
            // 
            // mamanButton
            // 
            mamanButton.BackgroundImage = Properties.Resources.bouquet_maman;
            mamanButton.BackgroundImageLayout = ImageLayout.Stretch;
            mamanButton.Cursor = Cursors.Hand;
            mamanButton.FlatStyle = FlatStyle.Flat;
            mamanButton.Location = new Point(1061, 170);
            mamanButton.Name = "mamanButton";
            mamanButton.Size = new Size(270, 265);
            mamanButton.TabIndex = 8;
            mamanButton.UseVisualStyleBackColor = true;
            mamanButton.Click += mamanButton_Click;
            // 
            // exotiqueLabel
            // 
            exotiqueLabel.AutoSize = true;
            exotiqueLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            exotiqueLabel.Location = new Point(806, 438);
            exotiqueLabel.Name = "exotiqueLabel";
            exotiqueLabel.Size = new Size(99, 25);
            exotiqueLabel.TabIndex = 7;
            exotiqueLabel.Text = "L'Exotique";
            // 
            // exotiqueButton
            // 
            exotiqueButton.BackgroundImage = Properties.Resources.bouquet_exotique;
            exotiqueButton.BackgroundImageLayout = ImageLayout.Stretch;
            exotiqueButton.Cursor = Cursors.Hand;
            exotiqueButton.FlatStyle = FlatStyle.Flat;
            exotiqueButton.Location = new Point(724, 170);
            exotiqueButton.Name = "exotiqueButton";
            exotiqueButton.Size = new Size(270, 265);
            exotiqueButton.TabIndex = 6;
            exotiqueButton.UseVisualStyleBackColor = true;
            exotiqueButton.Click += exotiqueButton_Click;
            // 
            // amoureuxLabel
            // 
            amoureuxLabel.AutoSize = true;
            amoureuxLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            amoureuxLabel.Location = new Point(465, 438);
            amoureuxLabel.Name = "amoureuxLabel";
            amoureuxLabel.Size = new Size(113, 25);
            amoureuxLabel.TabIndex = 5;
            amoureuxLabel.Text = "L'Amoureux";
            // 
            // lamoureuxButton
            // 
            lamoureuxButton.BackgroundImage = Properties.Resources.bouquet_l_amoureux1;
            lamoureuxButton.BackgroundImageLayout = ImageLayout.Stretch;
            lamoureuxButton.Cursor = Cursors.Hand;
            lamoureuxButton.FlatStyle = FlatStyle.Flat;
            lamoureuxButton.Location = new Point(387, 170);
            lamoureuxButton.Name = "lamoureuxButton";
            lamoureuxButton.Size = new Size(270, 265);
            lamoureuxButton.TabIndex = 4;
            lamoureuxButton.UseVisualStyleBackColor = true;
            lamoureuxButton.Click += lamoureuxButton_Click;
            // 
            // grosMerciLabel
            // 
            grosMerciLabel.AutoSize = true;
            grosMerciLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            grosMerciLabel.Location = new Point(120, 438);
            grosMerciLabel.Name = "grosMerciLabel";
            grosMerciLabel.Size = new Size(127, 25);
            grosMerciLabel.TabIndex = 3;
            grosMerciLabel.Text = "Le Gros Merci";
            // 
            // bouquetsButton
            // 
            bouquetsButton.BackColor = SystemColors.InactiveCaption;
            bouquetsButton.FlatAppearance.BorderSize = 0;
            bouquetsButton.FlatStyle = FlatStyle.Flat;
            bouquetsButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bouquetsButton.Location = new Point(-2, 84);
            bouquetsButton.Name = "bouquetsButton";
            bouquetsButton.Size = new Size(1725, 70);
            bouquetsButton.TabIndex = 2;
            bouquetsButton.Text = "Les bouquets";
            bouquetsButton.UseVisualStyleBackColor = false;
            // 
            // grosMerciButton
            // 
            grosMerciButton.BackgroundImage = Properties.Resources.bouquet_gros_merci;
            grosMerciButton.BackgroundImageLayout = ImageLayout.Stretch;
            grosMerciButton.Cursor = Cursors.Hand;
            grosMerciButton.FlatStyle = FlatStyle.Flat;
            grosMerciButton.Location = new Point(50, 170);
            grosMerciButton.Name = "grosMerciButton";
            grosMerciButton.Size = new Size(270, 265);
            grosMerciButton.TabIndex = 1;
            grosMerciButton.UseVisualStyleBackColor = true;
            grosMerciButton.Click += grosMerciButton_Click;
            // 
            // productsButton
            // 
            productsButton.Anchor = AnchorStyles.Top;
            productsButton.BackColor = SystemColors.ActiveCaption;
            productsButton.Cursor = Cursors.Hand;
            productsButton.FlatAppearance.BorderSize = 0;
            productsButton.FlatStyle = FlatStyle.Flat;
            productsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            productsButton.Location = new Point(-2, -3);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(1725, 70);
            productsButton.TabIndex = 0;
            productsButton.Text = "Nos produits";
            productsButton.UseVisualStyleBackColor = false;
            productsButton.Click += productsButton_Click;
            // 
            // orderButton
            // 
            orderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            orderButton.BackColor = Color.RoyalBlue;
            orderButton.Cursor = Cursors.Hand;
            orderButton.FlatStyle = FlatStyle.Flat;
            orderButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            orderButton.ForeColor = SystemColors.Control;
            orderButton.Location = new Point(770, 12);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(243, 68);
            orderButton.TabIndex = 5;
            orderButton.TabStop = false;
            orderButton.Text = "Passer une commande";
            orderButton.UseVisualStyleBackColor = false;
            orderButton.Click += orderButton_Click;
            // 
            // dropdownTimer
            // 
            dropdownTimer.Interval = 2;
            dropdownTimer.Tick += dropdownTimer_Tick;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1782, 853);
            Controls.Add(orderButton);
            Controls.Add(productsPanel);
            Controls.Add(userDropdown);
            Controls.Add(userButton);
            Controls.Add(backwardButton);
            Controls.Add(forwardButton);
            Controls.Add(pauseButton);
            Controls.Add(datePicker);
            Controls.Add(button1);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application fleurs";
            FormClosing += DashboardForm_FormClosing;
            userDropdown.ResumeLayout(false);
            productsPanel.ResumeLayout(false);
            productsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DateTimePicker datePicker;
        private System.Windows.Forms.Timer dateTimer;
        private Button pauseButton;
        private Button forwardButton;
        private Button backwardButton;
        private Button userButton;
        private Panel userDropdown;
        private Button disconnectButton;
        private Button myOrdersButton;
        private Button myProfileButton;
        private Panel productsPanel;
        private Button productsButton;
        private Label marieeLabel;
        private Button marieeButton;
        private Label mamanLabel;
        private Button mamanButton;
        private Label exotiqueLabel;
        private Button exotiqueButton;
        private Label amoureuxLabel;
        private Button lamoureuxButton;
        private Label grosMerciLabel;
        private Button bouquetsButton;
        private Button grosMerciButton;
        private Button orderButton;
        private System.Windows.Forms.Timer dropdownTimer;
        private Label roseRougeLabel;
        private Button roseRougeButton;
        private Label margueriteLabel;
        private Button margueriteButton;
        private Label gingerLabel;
        private Button gingerButton;
        private Label glaieulLabel;
        private Button glaieulButton;
        private Label gerberaLabel;
        private Button flowersLabel;
        private Button gerberaButton;
        private Label pommePinLabel;
        private Button pommePinButton;
        private Label rubanLabel;
        private Button rubanButton;
        private Label vaseLabel;
        private Button vaseButton;
        private Label feuilleOrLabel;
        private Button feuilleOrButton;
        private Label boxLabel;
        private Button accessoireButton;
        private Button boxButton;
    }
}