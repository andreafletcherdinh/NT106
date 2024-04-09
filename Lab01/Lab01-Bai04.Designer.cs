namespace Lab01
{
    partial class Bai04Form
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
            this.ChoosingPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ThirdScreen = new System.Windows.Forms.Button();
            this.SecondScreen = new System.Windows.Forms.Button();
            this.FirstScreen = new System.Windows.Forms.Button();
            this.ChoosingLabel = new System.Windows.Forms.Label();
            this.TittleLabel = new System.Windows.Forms.Label();
            this.ChoosingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChoosingPanel
            // 
            this.ChoosingPanel.Controls.Add(this.ExitButton);
            this.ChoosingPanel.Controls.Add(this.ThirdScreen);
            this.ChoosingPanel.Controls.Add(this.SecondScreen);
            this.ChoosingPanel.Controls.Add(this.FirstScreen);
            this.ChoosingPanel.Controls.Add(this.ChoosingLabel);
            this.ChoosingPanel.Location = new System.Drawing.Point(110, 69);
            this.ChoosingPanel.Name = "ChoosingPanel";
            this.ChoosingPanel.Size = new System.Drawing.Size(304, 472);
            this.ChoosingPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(27, 348);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(249, 44);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ThirdScreen
            // 
            this.ThirdScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdScreen.Location = new System.Drawing.Point(27, 276);
            this.ThirdScreen.Name = "ThirdScreen";
            this.ThirdScreen.Size = new System.Drawing.Size(249, 44);
            this.ThirdScreen.TabIndex = 6;
            this.ThirdScreen.Text = "Phòng chiếu số 3";
            this.ThirdScreen.UseVisualStyleBackColor = true;
            this.ThirdScreen.Click += new System.EventHandler(this.ThirdScreen_Click);
            // 
            // SecondScreen
            // 
            this.SecondScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondScreen.Location = new System.Drawing.Point(27, 201);
            this.SecondScreen.Name = "SecondScreen";
            this.SecondScreen.Size = new System.Drawing.Size(249, 44);
            this.SecondScreen.TabIndex = 5;
            this.SecondScreen.Text = "Phòng chiếu số 2";
            this.SecondScreen.UseVisualStyleBackColor = true;
            this.SecondScreen.Click += new System.EventHandler(this.SecondScreen_Click);
            // 
            // FirstScreen
            // 
            this.FirstScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstScreen.Location = new System.Drawing.Point(27, 126);
            this.FirstScreen.Name = "FirstScreen";
            this.FirstScreen.Size = new System.Drawing.Size(249, 44);
            this.FirstScreen.TabIndex = 4;
            this.FirstScreen.Text = "Phòng chiếu số 1";
            this.FirstScreen.UseVisualStyleBackColor = true;
            this.FirstScreen.Click += new System.EventHandler(this.FirstScreen_Click);
            // 
            // ChoosingLabel
            // 
            this.ChoosingLabel.AutoSize = true;
            this.ChoosingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoosingLabel.ForeColor = System.Drawing.Color.Red;
            this.ChoosingLabel.Location = new System.Drawing.Point(21, 20);
            this.ChoosingLabel.Name = "ChoosingLabel";
            this.ChoosingLabel.Size = new System.Drawing.Size(248, 32);
            this.ChoosingLabel.TabIndex = 3;
            this.ChoosingLabel.Text = "Mời bạn chọn rạp";
            // 
            // TittleLabel
            // 
            this.TittleLabel.AutoSize = true;
            this.TittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TittleLabel.ForeColor = System.Drawing.Color.Red;
            this.TittleLabel.Location = new System.Drawing.Point(130, 9);
            this.TittleLabel.Name = "TittleLabel";
            this.TittleLabel.Size = new System.Drawing.Size(257, 38);
            this.TittleLabel.TabIndex = 2;
            this.TittleLabel.Text = "Rạp chiếu phim";
            // 
            // Bai04Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 640);
            this.Controls.Add(this.TittleLabel);
            this.Controls.Add(this.ChoosingPanel);
            this.Name = "Bai04Form";
            this.Text = "Lab01-Bai04";
            this.ChoosingPanel.ResumeLayout(false);
            this.ChoosingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ChoosingPanel;
        private System.Windows.Forms.Label ChoosingLabel;
        private System.Windows.Forms.Label TittleLabel;
        private System.Windows.Forms.Button FirstScreen;
        private System.Windows.Forms.Button SecondScreen;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ThirdScreen;
    }
}