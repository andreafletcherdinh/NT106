namespace Lab01
{
    partial class Bai05Form
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
            this.ALabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.ChoiceLabel = new System.Windows.Forms.Label();
            this.ChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TittleLabel = new System.Windows.Forms.Label();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALabel.Location = new System.Drawing.Point(47, 83);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(98, 29);
            this.ALabel.TabIndex = 0;
            this.ALabel.Text = "Nhập A";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLabel.Location = new System.Drawing.Point(436, 83);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(99, 29);
            this.BLabel.TabIndex = 1;
            this.BLabel.Text = "Nhập B";
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(152, 89);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(178, 22);
            this.ATextBox.TabIndex = 2;
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(541, 90);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(178, 22);
            this.BTextBox.TabIndex = 3;
            // 
            // ChoiceLabel
            // 
            this.ChoiceLabel.AutoSize = true;
            this.ChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceLabel.Location = new System.Drawing.Point(277, 148);
            this.ChoiceLabel.Name = "ChoiceLabel";
            this.ChoiceLabel.Size = new System.Drawing.Size(211, 29);
            this.ChoiceLabel.TabIndex = 4;
            this.ChoiceLabel.Text = "Mời bạn lựa chọn";
            // 
            // ChoiceComboBox
            // 
            this.ChoiceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceComboBox.FormattingEnabled = true;
            this.ChoiceComboBox.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán giá trị"});
            this.ChoiceComboBox.Location = new System.Drawing.Point(282, 180);
            this.ChoiceComboBox.Name = "ChoiceComboBox";
            this.ChoiceComboBox.Size = new System.Drawing.Size(194, 33);
            this.ChoiceComboBox.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(273, 254);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(203, 46);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Tính các giá trị";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(142, 254);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(88, 46);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(509, 254);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(88, 46);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TittleLabel
            // 
            this.TittleLabel.AutoSize = true;
            this.TittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TittleLabel.ForeColor = System.Drawing.Color.Red;
            this.TittleLabel.Location = new System.Drawing.Point(294, 27);
            this.TittleLabel.Name = "TittleLabel";
            this.TittleLabel.Size = new System.Drawing.Size(161, 38);
            this.TittleLabel.TabIndex = 9;
            this.TittleLabel.Text = "Tính toán";
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultGroupBox.Location = new System.Drawing.Point(52, 382);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(667, 297);
            this.ResultGroupBox.TabIndex = 10;
            this.ResultGroupBox.TabStop = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(47, 350);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(102, 29);
            this.ResultLabel.TabIndex = 11;
            this.ResultLabel.Text = "Kết quả";
            // 
            // Bai05Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 728);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.TittleLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ChoiceComboBox);
            this.Controls.Add(this.ChoiceLabel);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.ALabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Bai05Form";
            this.Text = "Lab01- Bài05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Label ChoiceLabel;
        private System.Windows.Forms.ComboBox ChoiceComboBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label TittleLabel;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Label ResultLabel;
    }
}