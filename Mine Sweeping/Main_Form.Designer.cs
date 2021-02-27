
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLevel_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLevel_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLevel_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLevel_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemSound = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemShowTop = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ToolStripMenuItemLevel_1,
            this.ToolStripMenuItemLevel_2,
            this.ToolStripMenuItemLevel_3,
            this.ToolStripMenuItemLevel_4,
            this.toolStripMenuItem1,
            this.ToolStripMenuItemSound,
            this.toolStripMenuItem2,
            this.ToolStripMenuItemShowTop});
            this.ToolStripMenuItem_Game.Name = "ToolStripMenuItem_Game";
            this.ToolStripMenuItem_Game.Size = new System.Drawing.Size(61, 21);
            this.ToolStripMenuItem_Game.Text = "游戏(&G)";
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
            // ToolStripMenuItemLevel_1
            // 
            this.ToolStripMenuItemLevel_1.Name = "ToolStripMenuItemLevel_1";
            this.ToolStripMenuItemLevel_1.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemLevel_1.Text = "初级";
            // 
            // ToolStripMenuItemLevel_2
            // 
            this.ToolStripMenuItemLevel_2.Name = "ToolStripMenuItemLevel_2";
            this.ToolStripMenuItemLevel_2.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemLevel_2.Text = "中级";
            // 
            // ToolStripMenuItemLevel_3
            // 
            this.ToolStripMenuItemLevel_3.Name = "ToolStripMenuItemLevel_3";
            this.ToolStripMenuItemLevel_3.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemLevel_3.Text = "高级";
            // 
            // ToolStripMenuItemLevel_4
            // 
            this.ToolStripMenuItemLevel_4.Enabled = false;
            this.ToolStripMenuItemLevel_4.Name = "ToolStripMenuItemLevel_4";
            this.ToolStripMenuItemLevel_4.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemLevel_4.Text = "自定义";
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
            // ToolStripMenuItemRule
            // 
            this.ToolStripMenuItemRule.Name = "ToolStripMenuItemRule";
            this.ToolStripMenuItemRule.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemRule.Text = "规则";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemAbout.Text = "关于";
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLevel_1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLevel_2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLevel_3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLevel_4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSound;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowTop;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRule;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
    }
}

