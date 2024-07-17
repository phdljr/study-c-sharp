namespace StudyControlLayout
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            colorDialog1 = new ColorDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 33);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Dock = DockStyle.Left;
            button4.Location = new Point(380, 0);
            button4.Name = "button4";
            button4.Size = new Size(60, 33);
            button4.TabIndex = 9;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(320, 0);
            button3.Name = "button3";
            button3.Size = new Size(60, 33);
            button3.TabIndex = 8;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(260, 0);
            button2.Name = "button2";
            button2.Size = new Size(60, 33);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(200, 0);
            button1.Name = "button1";
            button1.Size = new Size(60, 33);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Left;
            dateTimePicker1.Location = new Point(0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 394);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 56);
            panel2.TabIndex = 2;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.Location = new Point(328, 0);
            button7.Name = "button7";
            button7.Size = new Size(75, 56);
            button7.TabIndex = 2;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Location = new Point(194, 0);
            button6.Name = "button6";
            button6.Size = new Size(75, 56);
            button6.TabIndex = 1;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Location = new Point(53, 0);
            button5.Name = "button5";
            button5.Size = new Size(75, 56);
            button5.TabIndex = 0;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private ColorDialog colorDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button7;
        private Button button6;
        private Button button5;
    }
}
