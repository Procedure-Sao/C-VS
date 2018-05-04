using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class guanli1 : Form
    {
        public guanli1()
        {
            InitializeComponent();
        }

        private void ptb1_Click(object sender, EventArgs e)
        {
            caidan f4 = new caidan();
            f4.ShowDialog();
            this.Hide();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pwd f3 = new pwd();
            f3.ShowDialog();
            this.Hide();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出吗！！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
