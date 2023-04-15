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
            timer.Interval = 2000;
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
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1782, 853);
            Controls.Add(backwardButton);
            Controls.Add(forwardButton);
            Controls.Add(pauseButton);
            Controls.Add(datePicker);
            Controls.Add(button1);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            FormClosing += DashboardForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DateTimePicker datePicker;
        private System.Windows.Forms.Timer timer;
        private Button pauseButton;
        private Button forwardButton;
        private Button backwardButton;
    }
}