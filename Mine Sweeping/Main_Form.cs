using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine_Sweeping {
    public partial class Main_Form : Form {
        public Main_Form() {
            InitializeComponent();
        }

        /// <summary>
        /// 点击菜单栏扫雷排行榜时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemShowTop_Click(object sender, EventArgs e) {
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.ShowDialog();
        }

        /// <summary>
        /// 点击菜单栏声音按钮时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemSound_Click(object sender, EventArgs e) {
            ToolStripMenuItemSound.Checked = !ToolStripMenuItemSound.Checked;
        }
    }
}
