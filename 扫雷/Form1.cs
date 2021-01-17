using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace 扫雷
{
    public partial class MineSweepForm : Form
    {
        private MineCell[,] MineCells { get; set; }
        private int RemainingMinesCount { get; set; }

        private int GameTime = 0;

        private bool disposed = false;

        Random r = new Random(DateTime.Now.Second); // 以当前秒数作为随机数种子

        string path = @"D:\MinesweeperHeroes.txt";

        string[] str = new string[3];


        int[] TopTime = new int[3];

        Form3 form3 = new Form3();

        public MineSweepForm()
        {
            InitializeComponent();

            // 利用双缓冲消除界面闪烁
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void MineSweepForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(path)) // 加载排行榜内容
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("999|匿名");
                    sw.WriteLine("999|匿名");
                    sw.WriteLine("999|匿名");
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    string s; int i = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        str[i] = s; i++;
                    }
                }

                string[] str1 = str[0].Split('|');
                string[] str2 = str[1].Split('|');
                string[] str3 = str[2].Split('|');

                TopTime[0] = Convert.ToInt32(str1[0]);
                TopTime[1] = Convert.ToInt32(str2[0]);
                TopTime[2] = Convert.ToInt32(str3[0]);
            }
            else
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s; int i = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        str[i] = s; i++;
                    }
                }

                string[] str1 = str[0].Split('|');
                string[] str2 = str[1].Split('|');
                string[] str3 = str[2].Split('|');

                TopTime[0] = Convert.ToInt32(str1[0]);
                TopTime[1] = Convert.ToInt32(str2[0]);
                TopTime[2] = Convert.ToInt32(str3[0]);
            }

            this.BackColor = Color.FromArgb(192, 192, 192);
            SetGameTime(0);
            SetRemainingMinesCount(0);
            FaceButton.ImageIndex = 0;

            中级ToolStripMenuItem_Click(sender, e);
        }

        private void 初级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            timer1.Stop();

            if (disposed)
            {
                foreach (MineCell item in MineCells)
                {
                    item.Dispose();
                }
            }

            初级ToolStripMenuItem.Checked = true;
            中级ToolStripMenuItem.Checked = false;
            高级ToolStripMenuItem.Checked = false;

            FaceButton.ImageIndex = 0;
            SetRemainingMinesCount(10);
            GameTime = 0;
            SetGameTime(GameTime);
            RemainingMinesCount = 10;
            this.Width = 211; this.Height = 301;
            panel2.Width = 184; panel2.Height = 184;

            MineCells = new MineCell[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    MineCells[i, j] = new MineCell
                    {
                        Name = "",
                        Open = false,
                        IsMine = false,
                        Size = new Size(20, 20),
                        Image = MineImageList.Images[9],
                        Location = new Point(j * 20, i * 20),
                    };
                    // 绑定事件
                    MineCells[i, j].MouseDown += new MouseEventHandler(Mine_MouseDown);
                    MineCells[i, j].MouseUp += new MouseEventHandler(Mine_MouseUp);
                    panel2.Controls.Add(MineCells[i, j]);
                }
            }
            disposed = true;
            RandomSteBomb(MineCells, 10);

            this.Visible = true;
        }

        private void 中级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            timer1.Stop();

            if (disposed)
            {
                foreach (MineCell item in MineCells)
                {
                    item.Dispose();
                }
            }

            初级ToolStripMenuItem.Checked = false;
            中级ToolStripMenuItem.Checked = true;
            高级ToolStripMenuItem.Checked = false;

            FaceButton.ImageIndex = 0;
            SetRemainingMinesCount(40);
            GameTime = 0;
            SetGameTime(GameTime);
            RemainingMinesCount = 40;
            this.Width = 351; this.Height = 441;
            panel2.Width = 324; panel2.Height = 324;

            MineCells = new MineCell[16, 16];
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    MineCells[i, j] = new MineCell
                    {
                        Name = "",
                        Open = false,
                        IsMine = false,
                        Size = new Size(20, 20),
                        Image = MineImageList.Images[9],
                        Location = new Point(j * 20, i * 20),
                    };
                    // 绑定事件
                    MineCells[i, j].MouseDown += new MouseEventHandler(Mine_MouseDown);
                    MineCells[i, j].MouseUp += new MouseEventHandler(Mine_MouseUp);
                    
                    panel2.Controls.Add(MineCells[i, j]);
                }
            }
            disposed = true;
            RandomSteBomb(MineCells, 40);

            this.Visible = true;
        }

        private void 高级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            timer1.Stop();

            if (disposed)
            {
                foreach (MineCell item in MineCells)
                {
                    item.Dispose();
                }
            }

            初级ToolStripMenuItem.Checked = false;
            中级ToolStripMenuItem.Checked = false;
            高级ToolStripMenuItem.Checked = true;

            FaceButton.ImageIndex = 0;
            SetRemainingMinesCount(99);
            GameTime = 0;
            SetGameTime(GameTime);
            RemainingMinesCount = 99;
            this.Width = 631; this.Height = 441;
            panel2.Width = 604; panel2.Height = 324;

            MineCells = new MineCell[16, 30];
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    MineCells[i, j] = new MineCell
                    {
                        Name = "",
                        Open = false,
                        IsMine = false,
                        Size = new Size(20, 20),            
                        Image = MineImageList.Images[9],
                        Location = new Point(j * 20, i * 20),
                    };
                    // 绑定事件
                    MineCells[i, j].MouseDown += new MouseEventHandler(Mine_MouseDown);
                    MineCells[i, j].MouseUp += new MouseEventHandler(Mine_MouseUp);
                    panel2.Controls.Add(MineCells[i, j]);
                }
            }
            disposed = true;
            RandomSteBomb(MineCells, 99);

            this.Visible = true;
        }

        /// <summary>
        /// 随机生成雷
        /// </summary>
        /// <param name="bonbCells"></param>
        /// <param name="num">雷数</param>
        private void RandomSteBomb(MineCell[,] bonbCells, int num)
        {
            for (int i = 0; i < num; i++) {
                int x = r.Next(bonbCells.GetLength(0));
                int y = r.Next(bonbCells.GetLength(1));
                if (!bonbCells[x, y].IsMine) bonbCells[x, y].IsMine = true;
                else i -= 1;
            }
        }

        /// <summary>
        /// 自动打开周围雷数为0的控件
        /// </summary>
        /// <param name="mineCell"></param>
        private void AutoOpen(MineCell mineCell)
        {
            // 获取该控件的坐标和下标
            Point point = mineCell.Location;
            int x = point.Y / 20;
            int y = point.X / 20;
            Point[] points = new Point[8];
            points[0] = new Point(x - 1, y);
            points[1] = new Point(x, y - 1);
            points[2] = new Point(x + 1, y);
            points[3] = new Point(x, y + 1);
            points[4] = new Point(x - 1, y - 1);
            points[5] = new Point(x - 1, y + 1);
            points[6] = new Point(x + 1, y - 1);
            points[7] = new Point(x + 1, y + 1);
            for (int i = 0; i < 8; i++)
            {
                if (points[i].X < MineCells.GetLength(0) && points[i].X >= 0 && points[i].Y < MineCells.GetLength(1) && points[i].Y >= 0)
                {
                    if (!MineCells[points[i].X, points[i].Y].Open)
                    {
                        MineCells[points[i].X, points[i].Y].Open = true;
                        MineCells[points[i].X, points[i].Y].Image = MineImageList.Images[MineAroundNum(MineCells[points[i].X, points[i].Y])];

                        if (MineAroundNum(MineCells[points[i].X, points[i].Y]) == 0)
                            AutoOpen(MineCells[points[i].X, points[i].Y]);
                    }
                }
                else continue;
            }
        }

        /// <summary>
        /// 返回周围雷数
        /// </summary>
        /// <param name="mineCell"></param>
        /// <returns></returns>
        private int MineAroundNum(MineCell mineCell)
        {
            int num = 0;
            // 获取该控件的坐标和下标
            Point point = mineCell.Location;
            int x = point.Y / 20;
            int y = point.X / 20;
            Point[] points = new Point[8];
            points[0] = new Point(x - 1, y);
            points[1] = new Point(x, y - 1);
            points[2] = new Point(x + 1, y);
            points[3] = new Point(x, y + 1);
            points[4] = new Point(x - 1, y - 1);
            points[5] = new Point(x - 1, y + 1);
            points[6] = new Point(x + 1, y - 1);
            points[7] = new Point(x + 1, y + 1);
            for (int i = 0; i < 8; i++) {
                if (points[i].X < MineCells.GetLength(0) && points[i].X >= 0 && points[i].Y < MineCells.GetLength(1) && points[i].Y >= 0)
                {
                    if (MineCells[points[i].X, points[i].Y].IsMine)
                        num++;
                }
                else {
                    continue;
                }
            }
            return num;
        }    

        /// <summary>
        /// 鼠标按键按下时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mine_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 检查计时器是否在运行
                if (!timer1.Enabled) timer1.Start();

                FaceButton.ImageIndex = 2;
            }     
        }

        /// <summary>
        /// 鼠标按键抬起时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mine_MouseUp(object sender, MouseEventArgs e)
        {
            MineCell mineCell = (MineCell)sender;

            // 点击鼠标左键
            if (e.Button == MouseButtons.Left)
            {
                FaceButton.ImageIndex = 0;

                // 控件没有被标记时
                if (!mineCell.Marked)
                {
                    // 踩到雷时
                    if (mineCell.IsMine)
                    {
                        timer1.Stop();
                        FaceButton.ImageIndex = 3;

                        // 解绑事件
                        for (int i = 0; i < MineCells.GetLength(0); i++)
                        {
                            for (int j = 0; j < MineCells.GetLength(1); j++)
                            {
                                MineCells[i, j].MouseDown -= new MouseEventHandler(Mine_MouseDown);
                                MineCells[i, j].MouseUp -= new MouseEventHandler(Mine_MouseUp);
                                // 显示所有的雷
                                if (MineCells[i, j].IsMine)
                                    MineCells[i, j].Image = MineImageList.Images[14];
                                // 标记错误
                                if (!MineCells[i, j].IsMine && MineCells[i, j].Marked)
                                    MineCells[i, j].Image = MineImageList.Images[13];
                            }
                        }
                        mineCell.Open = true;
                        mineCell.Image = MineImageList.Images[12];
                    }
                    else
                    {
                        // 周围没有雷时将周围控件全部打开
                        if (MineAroundNum(mineCell) == 0)
                        {
                            mineCell.Open = true;
                            mineCell.Image = MineImageList.Images[0];
                            AutoOpen(mineCell);
                        }
                        else
                        {
                            mineCell.Open = true;
                            mineCell.Image = MineImageList.Images[MineAroundNum(mineCell)]; // 显示周围的雷数（未完成）
                        }
                    }
                }
            }
            // 点击鼠标右键
            if (e.Button == MouseButtons.Right)
            {
                while (true)
                {
                    if (mineCell.Open) break;
                    if (mineCell.Name == "?")
                    {
                        mineCell.Image = MineImageList.Images[9];
                        break;
                    }
                    if (mineCell.Marked)
                    {
                        mineCell.Marked = false; // 取消标记
                        mineCell.Image = MineImageList.Images[11]; // 显示问号
                        mineCell.Name = "?";
                        RemainingMinesCount += 1;
                        SetRemainingMinesCount(RemainingMinesCount);
                        break;
                    }
                    if (!mineCell.Marked)
                    {
                        mineCell.Marked = true; // 标记
                        mineCell.Image = MineImageList.Images[10]; // 显示旗帜
                        mineCell.Name = "flag";
                        RemainingMinesCount -= 1;
                        SetRemainingMinesCount(RemainingMinesCount);
                        break;
                    }
                }
            }

            bool win = true;

            // 结束时检查标记是否正确
            if (RemainingMinesCount == 0)
            {
                timer1.Stop();
                foreach (MineCell item in MineCells)
                    if (!item.IsMine && item.Marked)
                    {
                        win = false;
                        item.Image = MineImageList.Images[13];
                        FaceButton.ImageIndex = 3;
                    }
                if (win) // 胜利
                {
                    FaceButton.ImageIndex = 4;
                    if (初级ToolStripMenuItem.Checked && GameTime < TopTime[0])
                    {
                        form3.ShowDialog();
                        File.Delete(path);
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine($"{GameTime}|{Form3.HeroName}");
                            sw.WriteLine($"{str[1]}");
                            sw.WriteLine($"{str[2]}");
                        }
                    }
                    if (中级ToolStripMenuItem.Checked && GameTime < TopTime[1])
                    {
                        form3.ShowDialog();
                        File.Delete(path);
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine($"{str[0]}");
                            sw.WriteLine($"{GameTime}|{Form3.HeroName}");
                            sw.WriteLine($"{str[2]}");
                        }

                    }
                    if (高级ToolStripMenuItem.Checked && GameTime < TopTime[2])
                    {
                        form3.ShowDialog();
                        File.Delete(path);
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine($"{str[0]}");
                            sw.WriteLine($"{str[1]}");
                            sw.WriteLine($"{GameTime}|{Form3.HeroName}");
                        }
                    }
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s; int i = 0;
                        while ((s = sr.ReadLine()) != null)
                        {
                            str[i] = s; i++;
                        }
                    }

                    string[] str1 = str[0].Split('|');
                    string[] str2 = str[1].Split('|');
                    string[] str3 = str[2].Split('|');

                    TopTime[0] = Convert.ToInt32(str1[0]);
                    TopTime[1] = Convert.ToInt32(str2[0]);
                    TopTime[2] = Convert.ToInt32(str3[0]);

                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                }
            }
        }

        /// <summary>
        /// 显示剩余的雷数
        /// </summary>
        /// <param name="num"></param>
        private void SetRemainingMinesCount(int num)
        {
            pictureBox3.Image = SumImageList.Images[num % 10];
            pictureBox2.Image = SumImageList.Images[(num / 10) % 10];
            pictureBox1.Image = SumImageList.Images[num / 100];
        }

        /// <summary>
        /// 显示游戏时间
        /// </summary>
        private void SetGameTime(int time)
        {
            pictureBox4.Image = SumImageList.Images[time % 10];
            pictureBox5.Image = SumImageList.Images[(time / 10) % 10];
            pictureBox6.Image = SumImageList.Images[time / 100];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameTime += 1;
            SetGameTime(GameTime);
        }

        private void FaceButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (初级ToolStripMenuItem.Checked) 初级ToolStripMenuItem_Click(sender, e);
            if (中级ToolStripMenuItem.Checked) 中级ToolStripMenuItem_Click(sender, e);
            if (高级ToolStripMenuItem.Checked) 高级ToolStripMenuItem_Click(sender, e);
            this.Visible = true;
        }

        private void FaceButton_MouseDown(object sender, MouseEventArgs e)
        {
            FaceButton.ImageIndex = 1;
        }

        private void FaceButton_MouseUp(object sender, MouseEventArgs e)
        {
            FaceButton.ImageIndex = 0;
        }

        private void 开局ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaceButton_Click(sender, e);
        }

        private void 声明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本程序仅用来学习交流，如有问题，\n请联系：qinzhidao@foxmail.com", "声明", MessageBoxButtons.OK);
        }

        private void 扫雷英雄榜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}