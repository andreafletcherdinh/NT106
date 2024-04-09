using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Bài 01 – Tính tổng 2 số nguyên (Có điều kiện)
namespace Lab01
{
    public partial class Bai01Form : Form
    {
        private long firstNumber, secondNumber;
        public Bai01Form()
        {
            InitializeComponent();
        }

        public bool checkingLetter(string inputString)
        {
            foreach (char character in inputString)
            {
                if (char.IsLetter(character))
                {
                    return true;
                }
            }
            return false;      
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string input1 = FirstNumberTextBox.Text.Trim();
            string input2 = SecondNumberTextBox.Text.Trim();
            if (checkingLetter(input1) || checkingLetter(input2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return;
            }
            firstNumber = long.Parse(FirstNumberTextBox.Text.Trim());
            secondNumber = long.Parse(SecondNumberTextBox.Text.Trim());
            long result = firstNumber + secondNumber;
            ResultTextBox.Text = result.ToString();
        }
    }
}
