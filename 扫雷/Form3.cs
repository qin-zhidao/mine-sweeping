using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 扫雷
{
    public partial class Form3 : Form
    {
        public static string HeroName { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "已破当前记录，\r\n请留下尊姓大名";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HeroName = textBox1.Text;
            this.Close();
        }
    }
}
