using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)//退出
        {
            DialogResult result = MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void 查看鲜花销售信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderFlower rf = new ReaderFlower();//打开查看窗口
            rf.MdiParent = this;
            rf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
