
namespace Mine_Sweeping {
    partial class Main_Form {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLevel_0 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLevel_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLevel_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLevel_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemSound = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemShowTop = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MineImageList = new System.Windows.Forms.ImageList(this.components);
            this.FaceImageList = new System.Windows.Forms.ImageList(this.components);
            this.NumsImageList = new System.Windows.Forms.ImageList(this.components);
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Game,
            this.ToolStripMenuItem_Help});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(327, 25);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Game
            // 
            this.ToolStripMenuItem_Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLevel_0,
            this.ToolStripMenuItemLevel_1,
            this.ToolStripMenuItemLevel_2,
            this.ToolStripMenuItemLevel_3,
            this.toolStripMenuItem1,
            this.ToolStripMenuItemSound,
            this.toolStripMenuItem2,
            this.ToolStripMenuItemShowTop});
            this.ToolStripMenuItem_Game.Name = "ToolStripMenuItem_Game";
            this.ToolStripMenuItem_Game.Size = new System.Drawing.Size(61, 21);
            this.ToolStripMenuItem_Game.Text = "游戏(&G)";
            // 
            // ToolStripMenuItemLevel_0
            // 
            this.ToolStripMenuItemLevel_0.Name = "ToolStripMenuItemLevel_0";
            this.ToolStripMenuItemLevel_0.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemLevel_0.Text = "初级";
            // 
            // ToolStripMenuItemLevel_1
            // 
            this.ToolStripMenuItemLevel_1.Name = "ToolStripMenuItemLevel_1";
            this.ToolStripMenuItemLevel_1.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemLevel_1.Text = "中级";
            // 
            // ToolStripMenuItemLevel_2
            // 
            this.ToolStripMenuItemLevel_2.Name = "ToolStripMenuItemLevel_2";
            this.ToolStripMenuItemLevel_2.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemLevel_2.Text = "高级";
            // 
            // ToolStripMenuItemLevel_3
            // 
            this.ToolStripMenuItemLevel_3.Enabled = false;
            this.ToolStripMenuItemLevel_3.Name = "ToolStripMenuItemLevel_3";
            this.ToolStripMenuItemLevel_3.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemLevel_3.Text = "自定义";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolStripMenuItemSound
            // 
            this.ToolStripMenuItemSound.Checked = true;
            this.ToolStripMenuItemSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItemSound.Name = "ToolStripMenuItemSound";
            this.ToolStripMenuItemSound.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSound.Text = "声音";
            this.ToolStripMenuItemSound.Click += new System.EventHandler(this.ToolStripMenuItemSound_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolStripMenuItemShowTop
            // 
            this.ToolStripMenuItemShowTop.Name = "ToolStripMenuItemShowTop";
            this.ToolStripMenuItemShowTop.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemShowTop.Text = "扫雷英雄榜";
            this.ToolStripMenuItemShowTop.Click += new System.EventHandler(this.ToolStripMenuItemShowTop_Click);
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemRule,
            this.toolStripMenuItem3,
            this.ToolStripMenuItemAbout});
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(61, 21);
            this.ToolStripMenuItem_Help.Text = "帮助(&H)";
            // 
            // ToolStripMenuItemRule
            // 
            this.ToolStripMenuItemRule.Name = "ToolStripMenuItemRule";
            this.ToolStripMenuItemRule.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItemRule.Text = "规则";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(97, 6);
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItemAbout.Text = "关于";
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
            // NumsImageList
            // 
            this.NumsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("NumsImageList.ImageStream")));
            this.NumsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.NumsImageList.Images.SetKeyName(0, "0.png");
            this.NumsImageList.Images.SetKeyName(1, "1.png");
            this.NumsImageList.Images.SetKeyName(2, "2.png");
            this.NumsImageList.Images.SetKeyName(3, "3.png");
            this.NumsImageList.Images.SetKeyName(4, "4.png");
            this.NumsImageList.Images.SetKeyName(5, "5.png");
            this.NumsImageList.Images.SetKeyName(6, "6.png");
            this.NumsImageList.Images.SetKeyName(7, "7.png");
            this.NumsImageList.Images.SetKeyName(8, "8.png");
            this.NumsImageList.Images.SetKeyName(9, "9.png");
            this.NumsImageList.Images.SetKeyName(10, "10.png");
            this.NumsImageList.Images.SetKeyName(11, "11.png");
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 367);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "扫雷";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Game;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLevel_0;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLevel_1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLevel_2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLevel_3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSound;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowTop;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRule;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.ImageList MineImageList;
        private System.Windows.Forms.ImageList FaceImageList;
        private System.Windows.Forms.ImageList NumsImageList;
    }
}

