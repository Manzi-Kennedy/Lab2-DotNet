namespace Lab_2
{
    partial class Form2
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
            Bicycle = new Button();
            Mushroom = new Button();
            LogOut = new Button();
            Choose = new Label();
            SuspendLayout();
            // 
            // Bicycle
            // 
            Bicycle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bicycle.Location = new Point(167, 151);
            Bicycle.Name = "Bicycle";
            Bicycle.Size = new Size(151, 39);
            Bicycle.TabIndex = 0;
            Bicycle.Text = "Bicycle";
            Bicycle.UseVisualStyleBackColor = true;
            Bicycle.Click += Bicycle_Click;
            // 
            // Mushroom
            // 
            Mushroom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mushroom.Location = new Point(474, 151);
            Mushroom.Name = "Mushroom";
            Mushroom.Size = new Size(151, 39);
            Mushroom.TabIndex = 1;
            Mushroom.Text = "Mushroom";
            Mushroom.UseVisualStyleBackColor = true;
            Mushroom.Click += Mushroom_Click;
            // 
            // LogOut
            // 
            LogOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOut.Location = new Point(317, 257);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(151, 39);
            LogOut.TabIndex = 2;
            LogOut.Text = "Log out";
            LogOut.UseVisualStyleBackColor = true;
            LogOut.Click += LogOut_Click;
            // 
            // Choose
            // 
            Choose.AutoSize = true;
            Choose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Choose.Location = new Point(344, 60);
            Choose.Name = "Choose";
            Choose.Size = new Size(78, 21);
            Choose.TabIndex = 3;
            Choose.Text = "CHOOSE:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Choose);
            Controls.Add(LogOut);
            Controls.Add(Mushroom);
            Controls.Add(Bicycle);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bicycle;
        private Button Mushroom;
        private Button LogOut;
        private Label Choose;
    }
}