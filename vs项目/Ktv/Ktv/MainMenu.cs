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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public string t1;
        public string t2;
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
           DialogResult result=  MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            singer sg = new singer();
            sg.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            music m = new music();
            m.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pinyin py = new pinyin();
            py.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            leixing lx = new leixing();
            lx.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            gedan gd = new gedan();
            gd.sqlyj = "select song_name,singer_name,song_url from singer_info inner join  song_info as a on singer_info.singer_id = a.singer_id order by song_play_count desc";
            gd.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            zishu zs = new zishu();
            zs.Show();
        }
     
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Playlist.CutSong();
               
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Playlist.ListenAgain();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            yidian yd = new yidian();
            yd.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                      textBox1.Text =Playlist.PlayingSongName();
                      textBox2.Text = Playlist.NextSongName1();
           
        }
    }
}
