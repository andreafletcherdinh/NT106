using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai07Form : Form
    {
        public Bai07Form()
        {
            InitializeComponent();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            string getInput = InputTextbox.Text.Trim();
            // Kiểm tra xem các giá trị có cách nhau bởi 1 dấu phẩy hay không?
            if (!getInput.Contains(','))
            {
                MessageBox.Show("Nhập sai format, xin vui lòng nhập lại!");
                return;
            }
            // Dùng hàm split để tách các phần tử khi gặp dấu ','
            string[] data = getInput.Split(',');
            // Lấy tên của sinh viên
            string nameOfStudent = data[0].Trim();
            /*Để có thể kiểm tra xem việc chuyển đổi có thành công hay không, ta sử dụng dấu _ (gọi là discard) 
             * sau từ khóa out như sau:*/
            /*Do format đề yêu cầu là nhập tên đầu tiên nên ta kiểm tra phần tử đầu tiên có phải là một số sau khi chuyển 
             chuỗi hay không, nếu phải thì xuất ra thông báo lỗi*/
            if (double.TryParse(nameOfStudent, out _))
            {
                MessageBox.Show("Nhập sai format, xin vui lòng nhập lại!");
                return;
            }
            // Trường hợp tên có chứa số, thì cũng thông báo lỗi
            if (nameOfStudent.Any(char.IsDigit))
            {
                MessageBox.Show("Nhập sai format, xin vui lòng nhập lại!");
                return;
            }
            NameShow.Text = nameOfStudent;
            // Kiểm tra các số điền sau có phải là chữ hay không, nếu đúng thì thông báo lỗi
            for (int index = 1; index < data.Length; index++)
            {
                if (!double.TryParse(data[index], out _))
                {
                    MessageBox.Show("Nhập sai format, xin vui lòng nhập lại!");
                    return;
                }
                break;
            }
            // Chuyển các giá trị từ phần tử thứ 2 của mảng string data ban đầu sang mảng string mới mang tên score
            List<double> scoresTest = new List<double>();
            for (int j = 1; j < data.Length; j++)
            {
                if (double.TryParse(data[j], out double score))
                {
                    scoresTest.Add(score);
                }
            }
            // Sắp xếp các phần tử từ bé đến lớn sau đó chuyển từ list sang mảng
            scoresTest.Sort();
            double[] finalScore = scoresTest.ToArray();
            // Thông báo bảng điểm của từng môn
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < finalScore.Length; i++)
            {
                result.Append($"Môn {i + 1}: {finalScore[i]}, " + " ");
            }
            ResultGroupBox.Text = result.ToString();
            // Tìm điểm lớn nhất và nhỏ nhất
            MinPointShow.Text = finalScore[0].ToString();
            MaxPointShow.Text = finalScore[finalScore.Length - 1].ToString();
            // Tính điểm trung bình
            double averageScore;
            double sumOFValue = 0;
            for (int i = 0; i < finalScore.Length; i++)
            {
                sumOFValue = sumOFValue + finalScore[i];
            }
            averageScore = sumOFValue / (finalScore.Length);
            double finalAverageScore = Math.Round(averageScore, 2);
            AvergageShow.Text = finalAverageScore.ToString();
            // Tính số môn đậu và không đậu
            int passSubjectCount = 0;
            int failSubjectCount = 0;
            for (int i = 0; i < finalScore.Length; i++)
            {
                if (finalScore[i] >= 5)
                {
                    passSubjectCount++;
                } 
                else if (finalScore[i] < 5)
                {
                    failSubjectCount++;
                }
            }
            PassShow.Text = passSubjectCount.ToString();
            FailShow.Text = failSubjectCount.ToString();
            // Xếp loại sinh viên
            string rank = String.Empty;
            for (int i = 0; i < finalScore.Length; i++)
            {
                if (finalAverageScore >= 8 && finalScore[i] > 6.5)
                {
                    rank = "Giỏi";
                }
                else if (finalAverageScore >= 6.5 && finalScore[i] > 5)
                {
                    rank = "Khá";
                }
                else if (finalAverageScore >= 5 && finalScore[i] > 3.5)
                {
                    rank = "Trung bình";
                }
                else if (finalAverageScore >= 3.5 && finalScore[i] > 2)
                {
                    rank = "Yếu";
                }
                else
                {
                    rank = "Kém";
                }
            }
            RankShow.Text = rank;
        }
    }
}