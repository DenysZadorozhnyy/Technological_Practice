namespace WinFormsApp2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Ukr = new Label();
            Math = new Label();
            Hystory = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(44, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(44, 23);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(180, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(44, 23);
            textBox3.TabIndex = 0;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Ukr
            // 
            Ukr.AccessibleRole = AccessibleRole.Text;
            Ukr.AutoSize = true;
            Ukr.Font = new Font("Segoe UI", 14F);
            Ukr.ForeColor = SystemColors.ActiveCaptionText;
            Ukr.ImageKey = "(none)";
            Ukr.Location = new Point(12, 23);
            Ukr.Name = "Ukr";
            Ukr.Size = new Size(156, 25);
            Ukr.TabIndex = 1;
            Ukr.Text = "Українська мова";
            Ukr.Click += label1_Click;
            // 
            // Math
            // 
            Math.AccessibleRole = AccessibleRole.Text;
            Math.AutoSize = true;
            Math.Font = new Font("Segoe UI", 14F);
            Math.ForeColor = SystemColors.ActiveCaptionText;
            Math.ImageKey = "(none)";
            Math.Location = new Point(28, 52);
            Math.Name = "Math";
            Math.Size = new Size(118, 25);
            Math.TabIndex = 1;
            Math.Text = "Математика";
            Math.Click += label1_Click;
            // 
            // Hystory
            // 
            Hystory.AccessibleRole = AccessibleRole.Text;
            Hystory.AutoSize = true;
            Hystory.Font = new Font("Segoe UI", 14F);
            Hystory.ForeColor = SystemColors.ActiveCaptionText;
            Hystory.ImageKey = "(none)";
            Hystory.Location = new Point(18, 77);
            Hystory.Name = "Hystory";
            Hystory.Size = new Size(144, 25);
            Hystory.TabIndex = 1;
            Hystory.Text = "Історія України";
            Hystory.Click += label1_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(205, 178);
            button1.Name = "button1";
            button1.Size = new Size(95, 39);
            button1.TabIndex = 2;
            button1.Text = "Обрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 226);
            Controls.Add(button1);
            Controls.Add(Hystory);
            Controls.Add(Math);
            Controls.Add(Ukr);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            ForeColor = SystemColors.AppWorkspace;
            Name = "Form1";
            Text = "Program";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label Ukr;
        private Label Math;
        private Label Hystory;
        private Button button1;
    }
}
