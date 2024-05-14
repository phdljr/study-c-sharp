namespace MemberForms
{
    partial class MemberLoginForm
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
            LoginButton = new Button();
            IdTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SignUpButton = new Button();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(80, 103);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(131, 29);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "로그인";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += this.LoginHandler;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(80, 24);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(131, 21);
            IdTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(80, 63);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(131, 21);
            PasswordTextBox.TabIndex = 2;
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(80, 140);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(131, 29);
            SignUpButton.TabIndex = 3;
            SignUpButton.Text = "회원가입";
            SignUpButton.UseVisualStyleBackColor = true;
            // 
            // MemberLoginForm
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 181);
            Controls.Add(SignUpButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(LoginButton);
            Font = new Font("D2Coding", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Name = "MemberLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox IdTextBox;
        private TextBox PasswordTextBox;
        private Button SignUpButton;
    }
}
