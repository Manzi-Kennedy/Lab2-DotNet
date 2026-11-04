namespace Lab_2
{
    partial class Bicycle_Form
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
            Bicycle = new Label();
            BackButton = new Button();
            LogOutButton = new Button();
            StartTime = new Label();
            EndTime = new Label();
            StartTextBox = new TextBox();
            EndTextBox = new TextBox();
            CalculateButton = new Button();
            ResetButton = new Button();
            Details = new Label();
            TotalTextBox = new TextBox();
            Total = new Label();
            SuspendLayout();
            // 
            // Bicycle
            // 
            Bicycle.AutoSize = true;
            Bicycle.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            Bicycle.Location = new Point(309, 9);
            Bicycle.Name = "Bicycle";
            Bicycle.Size = new Size(109, 37);
            Bicycle.TabIndex = 0;
            Bicycle.Text = "Bicycle";
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.Location = new Point(111, 324);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(85, 39);
            BackButton.TabIndex = 1;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutButton.Location = new Point(463, 324);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(85, 39);
            LogOutButton.TabIndex = 2;
            LogOutButton.Text = "Log out";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // StartTime
            // 
            StartTime.AutoSize = true;
            StartTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartTime.Location = new Point(111, 71);
            StartTime.Name = "StartTime";
            StartTime.Size = new Size(136, 21);
            StartTime.TabIndex = 3;
            StartTime.Text = "Enter Start Time:";
            StartTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EndTime
            // 
            EndTime.AutoSize = true;
            EndTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EndTime.Location = new Point(111, 98);
            EndTime.Name = "EndTime";
            EndTime.Size = new Size(129, 21);
            EndTime.TabIndex = 4;
            EndTime.Text = "Enter End Time:";
            EndTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartTextBox
            // 
            StartTextBox.Location = new Point(318, 69);
            StartTextBox.MaxLength = 2;
            StartTextBox.Name = "StartTextBox";
            StartTextBox.Size = new Size(100, 23);
            StartTextBox.TabIndex = 5;
            StartTextBox.TextChanged += StartTextBox_TextChanged;
            // 
            // EndTextBox
            // 
            EndTextBox.Location = new Point(318, 98);
            EndTextBox.MaxLength = 2;
            EndTextBox.Name = "EndTextBox";
            EndTextBox.Size = new Size(100, 23);
            EndTextBox.TabIndex = 6;
            EndTextBox.TextChanged += EndTextBox_TextChanged;
            // 
            // CalculateButton
            // 
            CalculateButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalculateButton.Location = new Point(458, 119);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(90, 39);
            CalculateButton.TabIndex = 7;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetButton.Location = new Point(309, 324);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(85, 39);
            ResetButton.TabIndex = 8;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // Details
            // 
            Details.AutoSize = true;
            Details.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Details.Location = new Point(180, 221);
            Details.Name = "Details";
            Details.Size = new Size(0, 21);
            Details.TabIndex = 10;
            Details.TextAlign = ContentAlignment.MiddleCenter;
            Details.Click += Details_Click;
            // 
            // TotalTextBox
            // 
            TotalTextBox.Location = new Point(318, 192);
            TotalTextBox.MaxLength = 2;
            TotalTextBox.Name = "TotalTextBox";
            TotalTextBox.ReadOnly = true;
            TotalTextBox.Size = new Size(100, 23);
            TotalTextBox.TabIndex = 11;
            TotalTextBox.TextChanged += TotalTextBox_TextChanged;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total.Location = new Point(180, 190);
            Total.Name = "Total";
            Total.Size = new Size(52, 21);
            Total.TabIndex = 13;
            Total.Text = "Total:";
            Total.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Bicycle_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Total);
            Controls.Add(TotalTextBox);
            Controls.Add(Details);
            Controls.Add(ResetButton);
            Controls.Add(CalculateButton);
            Controls.Add(EndTextBox);
            Controls.Add(StartTextBox);
            Controls.Add(EndTime);
            Controls.Add(StartTime);
            Controls.Add(LogOutButton);
            Controls.Add(BackButton);
            Controls.Add(Bicycle);
            Name = "Bicycle_Form";
            Text = "Bicycle_Form";
            Load += Bicycle_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Bicycle;
        private Button BackButton;
        private Button LogOutButton;
        private Label StartTime;
        private Label EndTime;
        private TextBox StartTextBox;
        private TextBox EndTextBox;
        private Button CalculateButton;
        private Button ResetButton;
        private Label label1;
        private Label Details;
        private TextBox TotalTextBox;
        private Label Total;
    }
}