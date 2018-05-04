using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackStage
{
    public partial class zhuye : Form
    {
        public zhuye()
        {
            InitializeComponent();
        }

        private void 歌手ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addsinger ads = new addsinger();
            ads.Show();
        }

        private void 歌曲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             addsong ads2 = new addsong();
            ads2.Show();
        
        }

        private void 查看歌手信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readersinger rd = new readersinger();
            rd.Show();
        }

        private void 查看歌曲信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readersong rd2 = new readersong();
            rd2.Show();
        }

        private void 账户密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xiugai xg = new xiugai();
            xg.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void 歌曲路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            address ads = new address();
            ads.name = "song";
            ads.Show();
        }

        private void 歌手路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            address ads = new address();
            ads.name = "phone";
            ads.Show();
        }
    }
}
