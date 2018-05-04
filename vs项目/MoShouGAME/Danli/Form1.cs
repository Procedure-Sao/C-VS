using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Danli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPlay fp = FrmPlay.dui();
            fp.url = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            fp.play();
            fp.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Dan> list = new List<Dan>()
            {
                new Dan("花蝴蝶.mp3","E:\\VS\\vs项目\\Ktv\\music\\花蝴蝶.mp3"),
                new Dan("带你去旅行-校长.mp3","E:\\VS\\vs项目\\Ktv\\music\\带你去旅行-校长.mp3"),
                new Dan("病变-韩子曦.mp3","E:\\VS\\vs项目\\Ktv\\music\\病变-韩子曦.mp3"),
            };
            dataGridView1.DataSource = new BindingList<Dan>(list);

        }
    }
}
