using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ktv
{
    public partial class singer : Form
    {
        public singer()
        {
            InitializeComponent();
        }
        string name1 ;
        string con = "Data Source=.;Initial Catalog=Ktv;Integrated Security=True";
        private void singer_Load(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView2.Visible = false;
            listView3.Visible = false;

        }

        private void listView1_Click(object sender, EventArgs e)
        {

            listView1.Visible = false;
            listView2.Visible = true;
            listView3.Visible = false;
            listView2.Location = listView1.Location;
            listView2.Dock = DockStyle.Fill;
             name1 = listView1.SelectedItems[0].Text;

        }

 

        private void listView2_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            listView2.Visible = false;
            listView3.Visible = true;
            listView3.Location = listView1.Location;
            listView3.Dock = DockStyle.Fill;
            string name2 = listView2.SelectedItems[0].Text;
            int i = 0;
            home h = new home();
            try
            {
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string sql = @"select singer_name,singer_photo_url,singertype_name,singer_gender from singer_info  inner  join singer_type as a   on singer_info.singertype_id = a.singertype_id  where singertype_name = '"+ name2 +"' and  singer_gender='"+ name1+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
       
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   
                    string singername = reader["singer_name"].ToString();
                    string singertp = h.tp+reader["singer_photo_url"].ToString();
                    this.imageList2.Images.Add(Image.FromFile(singertp));
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    item.Text = singername;
                    i++;
                    listView3.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
               
            }
           
        }

        private void listView3_Click(object sender, EventArgs e)
        {
            //if (listView3.Items.Count > 0)
            //{
            //    listView3.Items.Clear();
            //}
            gedan gd = new gedan();
            string name = listView3.SelectedItems[0].Text;
            gd.sqlyj = "select song_name,singer_name,song_url from singer_info inner join  song_info as a on singer_info.singer_id = a.singer_id where singer_name='"+name+"'";
            gd.Show();
          
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

  
        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView2.Visible = false;
            listView3.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Playlist.ListenAgain();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Playlist.CutSong();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            yidian yd = new yidian();
            yd.Show();
        }
    }
}
