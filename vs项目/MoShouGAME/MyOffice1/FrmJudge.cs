using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOffice1
{
    public partial class FrmJudge : Form
    {
        public FrmJudge()
        {
            InitializeComponent();
        }
        public ListViewItem zhazha;
       
        private void FrmJudge_Load(object sender, EventArgs e)
        {
            textBox1.Text = zhazha.SubItems[1].Text;
            richTextBox1.Text = zhazha.SubItems[3].Text;
            textBox2.Text = zhazha.SubItems[4].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zhazha.SubItems[3].Text=richTextBox1.Text;
            zhazha.SubItems[4].Text = textBox2.Text;
            this.Close();
        }
    }
}
