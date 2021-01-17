namespace 扫雷
{
    partial class MineSweepForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MineSweepForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.游戏GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开局ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.初级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.扫雷英雄榜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.声明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FaceButton = new System.Windows.Forms.Button();
            this.FaceImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SumImageList = new System.Windows.Forms.ImageList(this.components);
            this.MineImageList = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏GToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 游戏GToolStripMenuItem
            // 
            this.游戏GToolStripMenuItem.Checked = true;
            this.游戏GToolStripMenuItem.CheckOnClick = true;
            this.游戏GToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.游戏GToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开局ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.初级ToolStripMenuItem,
            this.中级ToolStripMenuItem,
            this.高级ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.扫雷英雄榜ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.退出ToolStripMenuItem});
            this.游戏GToolStripMenuItem.Name = "游戏GToolStripMenuItem";
            this.游戏GToolStripMenuItem.ShowShortcutKeys = false;
            this.游戏GToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.游戏GToolStripMenuItem.Text = "游戏(&G)";
            // 
            // 开局ToolStripMenuItem
            // 
            this.开局ToolStripMenuItem.Name = "开局ToolStripMenuItem";
            this.开局ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.开局ToolStripMenuItem.Text = "开局(&F2)";
            this.开局ToolStripMenuItem.Click += new System.EventHandler(this.开局ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 6);
            // 
            // 初级ToolStripMenuItem
            // 
            this.初级ToolStripMenuItem.Name = "初级ToolStripMenuItem";
            this.初级ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.初级ToolStripMenuItem.Text = "初级(&B)";
            this.初级ToolStripMenuItem.Click += new System.EventHandler(this.初级ToolStripMenuItem_Click);
            // 
            // 中级ToolStripMenuItem
            // 
            this.中级ToolStripMenuItem.Name = "中级ToolStripMenuItem";
            this.中级ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.中级ToolStripMenuItem.Text = "中级(&I)";
            this.中级ToolStripMenuItem.Click += new System.EventHandler(this.中级ToolStripMenuItem_Click);
            // 
            // 高级ToolStripMenuItem
            // 
            this.高级ToolStripMenuItem.Name = "高级ToolStripMenuItem";
            this.高级ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.高级ToolStripMenuItem.Text = "高级(&E)";
            this.高级ToolStripMenuItem.Click += new System.EventHandler(this.高级ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 6);
            // 
            // 扫雷英雄榜ToolStripMenuItem
            // 
            this.扫雷英雄榜ToolStripMenuItem.Name = "扫雷英雄榜ToolStripMenuItem";
            this.扫雷英雄榜ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.扫雷英雄榜ToolStripMenuItem.Text = "扫雷英雄榜(&T)";
            this.扫雷英雄榜ToolStripMenuItem.Click += new System.EventHandler(this.扫雷英雄榜ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(148, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.退出ToolStripMenuItem.Text = "退出(&X)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.声明ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 声明ToolStripMenuItem
            // 
            this.声明ToolStripMenuItem.Name = "声明ToolStripMenuItem";
            this.声明ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.声明ToolStripMenuItem.Text = "声明";
            this.声明ToolStripMenuItem.Click += new System.EventHandler(this.声明ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.FaceButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(5, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 38);
            this.panel1.TabIndex = 2;
            // 
            // FaceButton
            // 
            this.FaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FaceButton.FlatAppearance.BorderSize = 0;
            this.FaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FaceButton.ImageList = this.FaceImageList;
            this.FaceButton.Location = new System.Drawing.Point(370, 6);
            this.FaceButton.Name = "FaceButton";
            this.FaceButton.Size = new System.Drawing.Size(25, 25);
            this.FaceButton.TabIndex = 2;
            this.FaceButton.UseVisualStyleBackColor = true;
            this.FaceButton.Click += new System.EventHandler(this.FaceButton_Click);
            this.FaceButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FaceButton_MouseDown);
            this.FaceButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FaceButton_MouseUp);
            // 
            // FaceImageList
            // 
            this.FaceImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FaceImageList.ImageStream")));
            this.FaceImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.FaceImageList.Images.SetKeyName(0, "0.png");
            this.FaceImageList.Images.SetKeyName(1, "1.png");
            this.FaceImageList.Images.SetKeyName(2, "2.png");
            this.FaceImageList.Images.SetKeyName(3, "3.png");
            this.FaceImageList.Images.SetKeyName(4, "4.png");
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Location = new System.Drawing.Point(722, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(43, 27);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(26, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(14, 23);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(13, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(14, 23);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(14, 23);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(5, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(44, 27);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(26, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(14, 23);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(13, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 23);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 23);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(5, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 485);
            this.panel2.TabIndex = 3;
            // 
            // SumImageList
            // 
            this.SumImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SumImageList.ImageStream")));
            this.SumImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.SumImageList.Images.SetKeyName(0, "0.png");
            this.SumImageList.Images.SetKeyName(1, "1.png");
            this.SumImageList.Images.SetKeyName(2, "2.png");
            this.SumImageList.Images.SetKeyName(3, "3.png");
            this.SumImageList.Images.SetKeyName(4, "4.png");
            this.SumImageList.Images.SetKeyName(5, "5.png");
            this.SumImageList.Images.SetKeyName(6, "6.png");
            this.SumImageList.Images.SetKeyName(7, "7.png");
            this.SumImageList.Images.SetKeyName(8, "8.png");
            this.SumImageList.Images.SetKeyName(9, "9.png");
            this.SumImageList.Images.SetKeyName(10, "10.png");
            this.SumImageList.Images.SetKeyName(11, "11.png");
            // 
            // MineImageList
            // 
            this.MineImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MineImageList.ImageStream")));
            this.MineImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MineImageList.Images.SetKeyName(0, "0.png");
            this.MineImageList.Images.SetKeyName(1, "1.png");
            this.MineImageList.Images.SetKeyName(2, "2.png");
            this.MineImageList.Images.SetKeyName(3, "3.png");
            this.MineImageList.Images.SetKeyName(4, "4.png");
            this.MineImageList.Images.SetKeyName(5, "5.png");
            this.MineImageList.Images.SetKeyName(6, "6.png");
            this.MineImageList.Images.SetKeyName(7, "7.png");
            this.MineImageList.Images.SetKeyName(8, "8.png");
            this.MineImageList.Images.SetKeyName(9, "9.png");
            this.MineImageList.Images.SetKeyName(10, "10.png");
            this.MineImageList.Images.SetKeyName(11, "11.png");
            this.MineImageList.Images.SetKeyName(12, "12.png");
            this.MineImageList.Images.SetKeyName(13, "13.png");
            this.MineImageList.Images.SetKeyName(14, "14.png");
            this.MineImageList.Images.SetKeyName(15, "15.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MineSweepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MineSweepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "扫雷";
            this.Load += new System.EventHandler(this.MineSweepForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 游戏GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开局ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 初级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 扫雷英雄榜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList SumImageList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ImageList FaceImageList;
        private System.Windows.Forms.ImageList MineImageList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button FaceButton;
        private System.Windows.Forms.ToolStripMenuItem 声明ToolStripMenuItem;
    }
}

