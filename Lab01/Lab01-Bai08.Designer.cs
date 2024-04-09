namespace Lab01
{
    partial class AddButton
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
            this.TittleLabel = new System.Windows.Forms.Label();
            this.EnterFoodLabel = new System.Windows.Forms.Label();
            this.EnterFoodTextBox = new System.Windows.Forms.TextBox();
            this.FoodListView = new System.Windows.Forms.ListView();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.AddFoodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TittleLabel
            // 
            this.TittleLabel.AutoSize = true;
            this.TittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TittleLabel.ForeColor = System.Drawing.Color.Red;
            this.TittleLabel.Location = new System.Drawing.Point(299, 42);
            this.TittleLabel.Name = "TittleLabel";
            this.TittleLabel.Size = new System.Drawing.Size(259, 38);
            this.TittleLabel.TabIndex = 0;
            this.TittleLabel.Text = "Hôm nay ăn gì?";
            // 
            // EnterFoodLabel
            // 
            this.EnterFoodLabel.AutoSize = true;
            this.EnterFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterFoodLabel.Location = new System.Drawing.Point(12, 124);
            this.EnterFoodLabel.Name = "EnterFoodLabel";
            this.EnterFoodLabel.Size = new System.Drawing.Size(135, 25);
            this.EnterFoodLabel.TabIndex = 1;
            this.EnterFoodLabel.Text = "Nhập món ăn:";
            // 
            // EnterFoodTextBox
            // 
            this.EnterFoodTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterFoodTextBox.Location = new System.Drawing.Point(174, 121);
            this.EnterFoodTextBox.Name = "EnterFoodTextBox";
            this.EnterFoodTextBox.Size = new System.Drawing.Size(321, 30);
            this.EnterFoodTextBox.TabIndex = 2;
            // 
            // FoodListView
            // 
            this.FoodListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodListView.HideSelection = false;
            this.FoodListView.Location = new System.Drawing.Point(524, 121);
            this.FoodListView.Name = "FoodListView";
            this.FoodListView.Size = new System.Drawing.Size(301, 243);
            this.FoodListView.TabIndex = 3;
            this.FoodListView.UseCompatibleStateImageBehavior = false;
            this.FoodListView.View = System.Windows.Forms.View.List;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(315, 316);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 48);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(315, 221);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(180, 48);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.Location = new System.Drawing.Point(17, 316);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(223, 48);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Tìm món ăn";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(283, 421);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(261, 32);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Món ăn hôm nay là:";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(114, 471);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(630, 34);
            this.ResultTextBox.TabIndex = 9;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddFoodButton
            // 
            this.AddFoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFoodButton.Location = new System.Drawing.Point(17, 221);
            this.AddFoodButton.Name = "AddFoodButton";
            this.AddFoodButton.Size = new System.Drawing.Size(223, 48);
            this.AddFoodButton.TabIndex = 10;
            this.AddFoodButton.Text = "Thêm món ăn";
            this.AddFoodButton.UseVisualStyleBackColor = true;
            this.AddFoodButton.Click += new System.EventHandler(this.AddFoodButton_Click);
            // 
            // AddButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(847, 580);
            this.Controls.Add(this.AddFoodButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FoodListView);
            this.Controls.Add(this.EnterFoodTextBox);
            this.Controls.Add(this.EnterFoodLabel);
            this.Controls.Add(this.TittleLabel);
            this.Name = "AddButton";
            this.Text = "Lab01-Bai08";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TittleLabel;
        private System.Windows.Forms.Label EnterFoodLabel;
        private System.Windows.Forms.TextBox EnterFoodTextBox;
        private System.Windows.Forms.ListView FoodListView;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button AddFoodButton;
    }
}