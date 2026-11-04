namespace Lab_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username = new Label();
            Password = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            CancelButton = new Button();
            Loginbutton = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(96, 60);
            Username.Name = "Username";
            Username.Size = new Size(91, 21);
            Username.TabIndex = 0;
            Username.Text = "Username:";
            Username.TextAlign = ContentAlignment.MiddleCenter;
            Username.Click += Username_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(96, 128);
            Password.Name = "Password";
            Password.Size = new Size(86, 21);
            Password.TabIndex = 1;
            Password.Text = "Password:";
            Password.TextAlign = ContentAlignment.MiddleCenter;
            Password.Click += Password_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameTextBox.Location = new Point(244, 60);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(198, 23);
            UsernameTextBox.TabIndex = 2;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Location = new Point(244, 130);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(198, 23);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(357, 245);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(85, 31);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // Loginbutton
            // 
            Loginbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbutton.Location = new Point(97, 245);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(85, 31);
            Loginbutton.TabIndex = 5;
            Loginbutton.Text = "Log in";
            Loginbutton.UseVisualStyleBackColor = true;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Loginbutton);
            Controls.Add(CancelButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label Password;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button CancelButton;
        private Button Loginbutton;
    }
}
