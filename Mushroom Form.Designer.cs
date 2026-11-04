namespace Lab_2
{
    partial class Mushroom_Form
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
            BackButton = new Button();
            LogOutButton = new Button();
            Mushroom = new Label();
            richTextChart = new RichTextBox();
            lblStatus = new Label();
            NoButton = new Button();
            YesButton = new Button();
            TryAgainButton = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.Location = new Point(154, 389);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(85, 39);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutButton.Location = new Point(480, 389);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(85, 39);
            LogOutButton.TabIndex = 3;
            LogOutButton.Text = "Log out";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // Mushroom
            // 
            Mushroom.AutoSize = true;
            Mushroom.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            Mushroom.Location = new Point(300, 9);
            Mushroom.Name = "Mushroom";
            Mushroom.Size = new Size(161, 37);
            Mushroom.TabIndex = 4;
            Mushroom.Text = "Mushroom";
            // 
            // richTextChart
            // 
            richTextChart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextChart.Location = new Point(154, 49);
            richTextChart.Name = "richTextChart";
            richTextChart.ReadOnly = true;
            richTextChart.Size = new Size(411, 216);
            richTextChart.TabIndex = 5;
            richTextChart.Text = "";
            richTextChart.TextChanged += richTextChart_TextChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(187, 268);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(131, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Awaiting your answer...";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Click += lblStatus_Click;
            // 
            // NoButton
            // 
            NoButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoButton.Location = new Point(367, 313);
            NoButton.Name = "NoButton";
            NoButton.Size = new Size(49, 27);
            NoButton.TabIndex = 7;
            NoButton.Text = "No";
            NoButton.UseVisualStyleBackColor = true;
            NoButton.Click += NoButton_Click;
            // 
            // YesButton
            // 
            YesButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YesButton.Location = new Point(154, 313);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(62, 27);
            YesButton.TabIndex = 8;
            YesButton.Text = "Yes";
            YesButton.UseVisualStyleBackColor = true;
            YesButton.Click += YesButton_Click;
            // 
            // TryAgainButton
            // 
            TryAgainButton.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            TryAgainButton.Location = new Point(120, 268);
            TryAgainButton.Name = "TryAgainButton";
            TryAgainButton.Size = new Size(61, 24);
            TryAgainButton.TabIndex = 9;
            TryAgainButton.Text = "Try again";
            TryAgainButton.UseVisualStyleBackColor = true;
            TryAgainButton.Click += TryAgainButton_Click;
            // 
            // Mushroom_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TryAgainButton);
            Controls.Add(YesButton);
            Controls.Add(NoButton);
            Controls.Add(lblStatus);
            Controls.Add(richTextChart);
            Controls.Add(Mushroom);
            Controls.Add(LogOutButton);
            Controls.Add(BackButton);
            Name = "Mushroom_Form";
            Text = "Mushroom_Form";
            Load += Mushroom_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Button LogOutButton;
        private Label Mushroom;
        private RichTextBox richTextChart;
        private Label lblStatus;
        private Button NoButton;
        private Button YesButton;
        private Button TryAgainButton;
    }
}