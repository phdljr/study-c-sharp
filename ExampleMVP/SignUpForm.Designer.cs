namespace ExampleMVP
{
    partial class SignUpForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSignUp = new Button();
            btnToLogin = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(78, 23);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(121, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(78, 52);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(121, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(78, 81);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(121, 23);
            txtConfirmPassword.TabIndex = 2;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(78, 119);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(121, 32);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "회원가입";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUpClickHandler;
            // 
            // btnToLogin
            // 
            btnToLogin.Location = new Point(78, 157);
            btnToLogin.Name = "btnToLogin";
            btnToLogin.Size = new Size(121, 32);
            btnToLogin.TabIndex = 4;
            btnToLogin.Text = "로그인 화면";
            btnToLogin.UseVisualStyleBackColor = true;
            btnToLogin.Click += btnNavigateLoginFormHandler;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 198);
            Controls.Add(btnToLogin);
            Controls.Add(btnSignUp);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnSignUp;
        private Button btnToLogin;
    }
}