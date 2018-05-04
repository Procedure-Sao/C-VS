using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ktv
{
    public partial class zishu : Form
    {
        public zishu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void zishu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                ListViewItem li = new ListViewItem();
                li.Text = (i + 1) + "个字";
                li.Tag = (i + 1);
                listView1.Items.Add(li);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(listView1.SelectedItems[0].Tag);
            gedan gd = new gedan();
            gd.sqlyj = "select song_name,singer_name,song_url from singer_info inner join  song_info as a on singer_info.singer_id = a.singer_id where song_word_count=" + num + "";
            gd.Show();
        }
    }
}
