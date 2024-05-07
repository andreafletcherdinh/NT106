namespace Lab_3___Bài_6
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Font = new Font("Calibri", 10F, FontStyle.Bold);
            textBox1.ForeColor = Color.Indigo;
            textBox1.Location = new Point(136, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 28);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            textBox2.ForeColor = Color.Indigo;
            textBox2.Location = new Point(136, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 28);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(26, 150);
            button1.Name = "button1";
            button1.Size = new Size(315, 38);
            button1.TabIndex = 5;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(173, 195);
            button2.Name = "button2";
            button2.Size = new Size(169, 62);
            button2.TabIndex = 6;
            button2.Text = "Tạo tài khoản mới";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(26, 195);
            button3.Name = "button3";
            button3.Size = new Size(140, 62);
            button3.TabIndex = 7;
            button3.Text = "Xóa bộ nhớ ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.FlatStyle = FlatStyle.System;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(27, 263);
            button4.Name = "button4";
            button4.Size = new Size(315, 38);
            button4.TabIndex = 8;
            button4.Text = "Máy chủ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(26, 74);
            label2.Name = "label2";
            label2.Size = new Size(108, 24);
            label2.TabIndex = 11;
            label2.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(26, 114);
            label4.Name = "label4";
            label4.Size = new Size(104, 24);
            label4.TabIndex = 12;
            label4.Text = "Password:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(369, 361);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Bai6_ChatRoom";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label4;
    }
}
