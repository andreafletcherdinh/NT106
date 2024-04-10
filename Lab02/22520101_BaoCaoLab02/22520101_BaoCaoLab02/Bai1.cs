using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520101_BaoCaoLab02
{
    public partial class Bai01Form : Form
    {
        private string content;
        public Bai01Form()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            FileStream fileInputStream = new FileStream("D:\\Network_programming\\Practice\\Lab2\\input1.txt", FileMode.Open);
            StreamReader streamRead = new StreamReader(fileInputStream);
            content = streamRead.ReadToEnd();
            ContentRichTextBox.Text = content;
            streamRead.Close();
            fileInputStream.Close();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            string upperContent = content.ToUpper();
            FileStream fileOutputStream = new FileStream("D:\\Network_programming\\Practice\\Lab2\\ouput1.txt", FileMode.Create);
            StreamWriter streamWrite = new StreamWriter(fileOutputStream);
            streamWrite.Write(upperContent);
            streamWrite.Close();
            fileOutputStream.Close();
        }
    }
}
