namespace Lab01
{
    partial class Bai07Form
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
            this.Tittle = new System.Windows.Forms.Label();
            this.WelcomLabel = new System.Windows.Forms.Label();
            this.InputTextbox = new System.Windows.Forms.TextBox();
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameShow = new System.Windows.Forms.TextBox();
            this.AvergageShow = new System.Windows.Forms.TextBox();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.MaxPointShow = new System.Windows.Forms.TextBox();
            this.MaxPointLabel = new System.Windows.Forms.Label();
            this.MinPointShow = new System.Windows.Forms.TextBox();
            this.MinPointLabel = new System.Windows.Forms.Label();
            this.PassShow = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.FailShow = new System.Windows.Forms.TextBox();
            this.FailLabel = new System.Windows.Forms.Label();
            this.RankShow = new System.Windows.Forms.TextBox();
            this.RankLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle.ForeColor = System.Drawing.Color.Red;
            this.Tittle.Location = new System.Drawing.Point(301, 26);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(190, 38);
            this.Tittle.TabIndex = 0;
            this.Tittle.Text = "Xử lý mảng";
            // 
            // WelcomLabel
            // 
            this.WelcomLabel.AutoSize = true;
            this.WelcomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomLabel.Location = new System.Drawing.Point(12, 82);
            this.WelcomLabel.Name = "WelcomLabel";
            this.WelcomLabel.Size = new System.Drawing.Size(216, 25);
            this.WelcomLabel.TabIndex = 1;
            this.WelcomLabel.Text = "Mời bạn nhập thông tin:";
            // 
            // InputTextbox
            // 
            this.InputTextbox.Location = new System.Drawing.Point(235, 84);
            this.InputTextbox.Name = "InputTextbox";
            this.InputTextbox.Size = new System.Drawing.Size(570, 22);
            this.InputTextbox.TabIndex = 2;
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleLabel.Location = new System.Drawing.Point(12, 131);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(537, 25);
            this.ExampleLabel.TabIndex = 3;
            this.ExampleLabel.Text = "Ví dụ: Nguyễn Thị A, 7.5, 5, 8, 10, 9, 10, 8.5, 9, 10, 3.5 ,5.5, 2";
            // 
            // ProcessButton
            // 
            this.ProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessButton.Location = new System.Drawing.Point(596, 124);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(209, 39);
            this.ProcessButton.TabIndex = 4;
            this.ProcessButton.Text = "Xử lý thông tin";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultGroupBox.Location = new System.Drawing.Point(17, 188);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(788, 128);
            this.ResultGroupBox.TabIndex = 5;
            this.ResultGroupBox.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(254, 334);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(106, 25);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Họ và tên: ";
            // 
            // NameShow
            // 
            this.NameShow.Location = new System.Drawing.Point(366, 338);
            this.NameShow.Name = "NameShow";
            this.NameShow.ReadOnly = true;
            this.NameShow.Size = new System.Drawing.Size(225, 22);
            this.NameShow.TabIndex = 7;
            this.NameShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AvergageShow
            // 
            this.AvergageShow.Location = new System.Drawing.Point(172, 388);
            this.AvergageShow.Name = "AvergageShow";
            this.AvergageShow.ReadOnly = true;
            this.AvergageShow.Size = new System.Drawing.Size(225, 22);
            this.AvergageShow.TabIndex = 9;
            this.AvergageShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageLabel.Location = new System.Drawing.Point(12, 384);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(154, 25);
            this.AverageLabel.TabIndex = 8;
            this.AverageLabel.Text = "Điểm trung bình:";
            // 
            // MaxPointShow
            // 
            this.MaxPointShow.Location = new System.Drawing.Point(172, 431);
            this.MaxPointShow.Name = "MaxPointShow";
            this.MaxPointShow.ReadOnly = true;
            this.MaxPointShow.Size = new System.Drawing.Size(225, 22);
            this.MaxPointShow.TabIndex = 11;
            this.MaxPointShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaxPointLabel
            // 
            this.MaxPointLabel.AutoSize = true;
            this.MaxPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxPointLabel.Location = new System.Drawing.Point(12, 427);
            this.MaxPointLabel.Name = "MaxPointLabel";
            this.MaxPointLabel.Size = new System.Drawing.Size(137, 25);
            this.MaxPointLabel.TabIndex = 10;
            this.MaxPointLabel.Text = "Môn cao nhất:";
            // 
            // MinPointShow
            // 
            this.MinPointShow.Location = new System.Drawing.Point(172, 477);
            this.MinPointShow.Name = "MinPointShow";
            this.MinPointShow.ReadOnly = true;
            this.MinPointShow.Size = new System.Drawing.Size(225, 22);
            this.MinPointShow.TabIndex = 13;
            this.MinPointShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinPointLabel
            // 
            this.MinPointLabel.AutoSize = true;
            this.MinPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinPointLabel.Location = new System.Drawing.Point(12, 473);
            this.MinPointLabel.Name = "MinPointLabel";
            this.MinPointLabel.Size = new System.Drawing.Size(137, 25);
            this.MinPointLabel.TabIndex = 12;
            this.MinPointLabel.Text = "Môn thấp nhất";
            // 
            // PassShow
            // 
            this.PassShow.Location = new System.Drawing.Point(573, 388);
            this.PassShow.Name = "PassShow";
            this.PassShow.ReadOnly = true;
            this.PassShow.Size = new System.Drawing.Size(232, 22);
            this.PassShow.TabIndex = 15;
            this.PassShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(443, 388);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(124, 25);
            this.PassLabel.TabIndex = 14;
            this.PassLabel.Text = "Số môn đậu:";
            // 
            // FailShow
            // 
            this.FailShow.Location = new System.Drawing.Point(573, 434);
            this.FailShow.Name = "FailShow";
            this.FailShow.ReadOnly = true;
            this.FailShow.Size = new System.Drawing.Size(232, 22);
            this.FailShow.TabIndex = 17;
            this.FailShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FailLabel
            // 
            this.FailLabel.AutoSize = true;
            this.FailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailLabel.Location = new System.Drawing.Point(443, 434);
            this.FailLabel.Name = "FailLabel";
            this.FailLabel.Size = new System.Drawing.Size(113, 25);
            this.FailLabel.TabIndex = 16;
            this.FailLabel.Text = "Số môn rớt:";
            // 
            // RankShow
            // 
            this.RankShow.Location = new System.Drawing.Point(573, 477);
            this.RankShow.Name = "RankShow";
            this.RankShow.ReadOnly = true;
            this.RankShow.Size = new System.Drawing.Size(232, 22);
            this.RankShow.TabIndex = 19;
            this.RankShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RankLabel
            // 
            this.RankLabel.AutoSize = true;
            this.RankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankLabel.Location = new System.Drawing.Point(443, 477);
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(89, 25);
            this.RankLabel.TabIndex = 18;
            this.RankLabel.Text = "Xếp loại:";
            // 
            // Bai07Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 545);
            this.Controls.Add(this.RankShow);
            this.Controls.Add(this.RankLabel);
            this.Controls.Add(this.FailShow);
            this.Controls.Add(this.FailLabel);
            this.Controls.Add(this.PassShow);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.MinPointShow);
            this.Controls.Add(this.MinPointLabel);
            this.Controls.Add(this.MaxPointShow);
            this.Controls.Add(this.MaxPointLabel);
            this.Controls.Add(this.AvergageShow);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.NameShow);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.ExampleLabel);
            this.Controls.Add(this.InputTextbox);
            this.Controls.Add(this.WelcomLabel);
            this.Controls.Add(this.Tittle);
            this.Name = "Bai07Form";
            this.Text = "Lab01-Bai7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Label WelcomLabel;
        private System.Windows.Forms.TextBox InputTextbox;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameShow;
        private System.Windows.Forms.TextBox AvergageShow;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.TextBox MaxPointShow;
        private System.Windows.Forms.Label MaxPointLabel;
        private System.Windows.Forms.TextBox MinPointShow;
        private System.Windows.Forms.Label MinPointLabel;
        private System.Windows.Forms.TextBox PassShow;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox FailShow;
        private System.Windows.Forms.Label FailLabel;
        private System.Windows.Forms.TextBox RankShow;
        private System.Windows.Forms.Label RankLabel;
    }
}