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
    public partial class leixing : Form
    {
        public leixing()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            gedan gd = new gedan();
            string name = listView1.SelectedItems[0].Tag.ToString();
            gd.sqlyj = "select song_name,singer_name,song_url from singer_info inner join  song_info as a on singer_info.singer_id = a.singer_id where   songtype_id='"+name+"'";
            gd.Show();
        }

        private void leixing_Load(object sender, EventArgs e)
        {

        }
    }
}
