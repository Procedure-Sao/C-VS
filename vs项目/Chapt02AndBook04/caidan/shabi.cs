using Chapt02AndBook04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caidan
{
    public partial class shabi : Form
    {
        public shabi()
        {
            InitializeComponent();
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            //fr.MdiParent = this;
            fr.Show();


        }

        private void shabi_Load(object sender, EventArgs e)
        {

        }
    }
}
