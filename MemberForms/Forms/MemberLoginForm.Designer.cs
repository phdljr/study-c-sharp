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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(813, 21);
            textBox1.TabIndex = 0;
            // 
            // MemberLoginForm
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 520);
            Controls.Add(textBox1);
            Font = new Font("D2Coding", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Name = "MemberLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
    }
}
