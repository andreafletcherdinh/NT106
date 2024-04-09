namespace Lab01
{
    partial class Bai02Form
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
            this.SecondNumberLabel = new System.Windows.Forms.Label();
            this.ThirdNumberLabel = new System.Windows.Forms.Label();
            this.SecondNumberTextbox = new System.Windows.Forms.TextBox();
            this.ThirdNumberTextBox = new System.Windows.Forms.TextBox();
            this.TittleLabel = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FirstNumberLabel = new System.Windows.Forms.Label();
            this.FirstNumberTextbox = new System.Windows.Forms.TextBox();
            this.MaxNumberTextBox = new System.Windows.Forms.TextBox();
            this.MaxNumberLabel = new System.Windows.Forms.Label();
            this.MinNumberTextBox = new System.Windows.Forms.TextBox();
            this.MinNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SecondNumberLabel
            // 
            this.SecondNumberLabel.AutoSize = true;
            this.SecondNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNumberLabel.Location = new System.Drawing.Point(376, 127);
            this.SecondNumberLabel.Name = "SecondNumberLabel";
            this.SecondNumberLabel.Size = new System.Drawing.Size(136, 29);
            this.SecondNumberLabel.TabIndex = 1;
            this.SecondNumberLabel.Text = "Số thứ hai:";
            // 
            // ThirdNumberLabel
            // 
            this.ThirdNumberLabel.AutoSize = true;
            this.ThirdNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdNumberLabel.Location = new System.Drawing.Point(706, 127);
            this.ThirdNumberLabel.Name = "ThirdNumberLabel";
            this.ThirdNumberLabel.Size = new System.Drawing.Size(123, 29);
            this.ThirdNumberLabel.TabIndex = 2;
            this.ThirdNumberLabel.Text = "Số thứ ba";
            // 
            // SecondNumberTextbox
            // 
            this.SecondNumberTextbox.Location = new System.Drawing.Point(518, 133);
            this.SecondNumberTextbox.Name = "SecondNumberTextbox";
            this.SecondNumberTextbox.Size = new System.Drawing.Size(134, 22);
            this.SecondNumberTextbox.TabIndex = 4;
            // 
            // ThirdNumberTextBox
            // 
            this.ThirdNumberTextBox.Location = new System.Drawing.Point(835, 133);
            this.ThirdNumberTextBox.Name = "ThirdNumberTextBox";
            this.ThirdNumberTextBox.Size = new System.Drawing.Size(134, 22);
            this.ThirdNumberTextBox.TabIndex = 5;
            // 
            // TittleLabel
            // 
            this.TittleLabel.AutoSize = true;
            this.TittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TittleLabel.ForeColor = System.Drawing.Color.Red;
            this.TittleLabel.Location = new System.Drawing.Point(310, 41);
            this.TittleLabel.Name = "TittleLabel";
            this.TittleLabel.Size = new System.Drawing.Size(383, 38);
            this.TittleLabel.TabIndex = 6;
            this.TittleLabel.Text = "Tìm số lớn nhất, nhỏ nhất";
            this.TittleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.Location = new System.Drawing.Point(190, 215);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(99, 41);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Tìm";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(433, 215);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(97, 41);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(668, 215);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(104, 41);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FirstNumberLabel
            // 
            this.FirstNumberLabel.AutoSize = true;
            this.FirstNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumberLabel.Location = new System.Drawing.Point(48, 127);
            this.FirstNumberLabel.Name = "FirstNumberLabel";
            this.FirstNumberLabel.Size = new System.Drawing.Size(150, 29);
            this.FirstNumberLabel.TabIndex = 0;
            this.FirstNumberLabel.Text = "Số thứ nhất:";
            // 
            // FirstNumberTextbox
            // 
            this.FirstNumberTextbox.Location = new System.Drawing.Point(198, 133);
            this.FirstNumberTextbox.Name = "FirstNumberTextbox";
            this.FirstNumberTextbox.Size = new System.Drawing.Size(134, 22);
            this.FirstNumberTextbox.TabIndex = 3;
            // 
            // MaxNumberTextBox
            // 
            this.MaxNumberTextBox.Location = new System.Drawing.Point(289, 342);
            this.MaxNumberTextBox.Name = "MaxNumberTextBox";
            this.MaxNumberTextBox.ReadOnly = true;
            this.MaxNumberTextBox.Size = new System.Drawing.Size(134, 22);
            this.MaxNumberTextBox.TabIndex = 11;
            // 
            // MaxNumberLabel
            // 
            this.MaxNumberLabel.AutoSize = true;
            this.MaxNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxNumberLabel.Location = new System.Drawing.Point(139, 336);
            this.MaxNumberLabel.Name = "MaxNumberLabel";
            this.MaxNumberLabel.Size = new System.Drawing.Size(151, 29);
            this.MaxNumberLabel.TabIndex = 10;
            this.MaxNumberLabel.Text = "Số lớn nhất:";
            // 
            // MinNumberTextBox
            // 
            this.MinNumberTextBox.Location = new System.Drawing.Point(695, 342);
            this.MinNumberTextBox.Name = "MinNumberTextBox";
            this.MinNumberTextBox.ReadOnly = true;
            this.MinNumberTextBox.Size = new System.Drawing.Size(134, 22);
            this.MinNumberTextBox.TabIndex = 13;
            // 
            // MinNumberLabel
            // 
            this.MinNumberLabel.AutoSize = true;
            this.MinNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinNumberLabel.Location = new System.Drawing.Point(535, 336);
            this.MinNumberLabel.Name = "MinNumberLabel";
            this.MinNumberLabel.Size = new System.Drawing.Size(158, 29);
            this.MinNumberLabel.TabIndex = 12;
            this.MinNumberLabel.Text = "Số nhỏ nhất:";
            // 
            // Bai02Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.MinNumberTextBox);
            this.Controls.Add(this.MinNumberLabel);
            this.Controls.Add(this.MaxNumberTextBox);
            this.Controls.Add(this.MaxNumberLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.TittleLabel);
            this.Controls.Add(this.ThirdNumberTextBox);
            this.Controls.Add(this.SecondNumberTextbox);
            this.Controls.Add(this.FirstNumberTextbox);
            this.Controls.Add(this.ThirdNumberLabel);
            this.Controls.Add(this.SecondNumberLabel);
            this.Controls.Add(this.FirstNumberLabel);
            this.Name = "Bai02Form";
            this.Text = " Lab01-Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SecondNumberLabel;
        private System.Windows.Forms.Label ThirdNumberLabel;
        private System.Windows.Forms.TextBox SecondNumberTextbox;
        private System.Windows.Forms.TextBox ThirdNumberTextBox;
        private System.Windows.Forms.Label TittleLabel;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label FirstNumberLabel;
        private System.Windows.Forms.TextBox FirstNumberTextbox;
        private System.Windows.Forms.TextBox MaxNumberTextBox;
        private System.Windows.Forms.Label MaxNumberLabel;
        private System.Windows.Forms.TextBox MinNumberTextBox;
        private System.Windows.Forms.Label MinNumberLabel;
    }
}