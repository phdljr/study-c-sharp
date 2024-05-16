namespace ExampleMVP
{
    partial class LoginForm
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
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSignup = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(77, 109);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 38);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLoginClickHandler;
            // 
            // txtId
            // 
            txtUsername.Location = new Point(77, 40);
            txtUsername.Name = "txtId";
            txtUsername.Size = new Size(117, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(77, 69);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(117, 23);
            txtPassword.TabIndex = 2;
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(77, 153);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(117, 38);
            btnSignup.TabIndex = 3;
            btnSignup.Text = "회원가입";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignUpClickHandler;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 198);
            Controls.Add(btnSignup);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "로그인";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSignup;
    }
}
