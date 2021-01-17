using System;
using System.Windows.Forms;
using System.IO;

namespace 扫雷
{
    public partial class Form2 : Form
    {
        string path = @"D:\MinesweeperHeroes.txt";
        string[] str = new string[3];

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete(path);

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("999|匿名");
                sw.WriteLine("999|匿名");
                sw.WriteLine("999|匿名");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s; int i = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    str[i] = s; i++;
                }
            }

            string[] str1 = str1 = str[0].Split('|');
            string[] str2 = str2 = str[1].Split('|');
            string[] str3 = str3 = str[2].Split('|');

            label1.Text += "  " + str1[0] + "秒      " + str1[1];
            label2.Text += "  " + str2[0] + "秒      " + str2[1];
            label3.Text += "  " + str3[0] + "秒      " + str3[1];
        }
    }
}
