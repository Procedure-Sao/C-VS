using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void 增加信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMessage am = new AddMessage();
            am.Show();
           
        }

        private void 查询信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadMessage rm = new ReadMessage();
            rm.Show();
        }
    }
}
