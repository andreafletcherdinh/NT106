using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Bài 02 – Số lớn nhất, nhỏ nhất
namespace Lab01
{
    public partial class Bai02Form : Form
    {
        private string input1, input2, input3;
        public Bai02Form()
        {
            InitializeComponent();
        }
        // Kiểm tra xem có chứa chữ cái hay không?
        private bool checkLetter (string input)
        {
            foreach (char character in input)
            {
                if (char.IsLetter(character))
                {
                    return true;
                }
            }
            return false;
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            input1 = FirstNumberTextbox.Text.Trim();
            input2 = SecondNumberTextbox.Text.Trim();
            input3 = ThirdNumberTextBox.Text.Trim();
            // Nếu có xuất hiện chữ cái hiện cảnh báo
            if (checkLetter(input1) || checkLetter(input2) || checkLetter(input3))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return;
            }
            double number1 = double.Parse(input1);
            double number2 = double.Parse(input2);
            double number3 = double.Parse(input3);

            double maxNum = number1;
            double minNum = number1;
            // Tìm số lớn nhất dùng if - else
            if (number2 > maxNum && number2 > number3)
            {
                maxNum = number2;
            }
            else if (number3 > maxNum && number3 > number2)
            {
                maxNum = number3;
            }
            MaxNumberTextBox.Text = maxNum.ToString();
            // Tìm số nhỏ nhất dùng if - else
            if (number2 < minNum && number2 < number3)
            {
                minNum = number2;
            }
            else if (number3 < minNum && number3 < number2)
            {
                minNum = number3;
            }
            MinNumberTextBox.Text = minNum.ToString();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            FirstNumberTextbox.Clear();
            SecondNumberTextbox.Clear();
            ThirdNumberTextBox.Clear();
            MaxNumberTextBox.Clear();
            MinNumberTextBox.Clear();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
