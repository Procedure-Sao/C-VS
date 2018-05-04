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
    public partial class yidian : Form
    {
        public yidian()
        {
            InitializeComponent();
        }

        bofang bf = new bofang();
        private void yidian_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < Playlist.songlist.Length; i++)
            {
                if (Playlist.songlist[i]!=null)
                {
                   
                    ListViewItem item = new ListViewItem(Playlist.songlist[i].SongName);
                    string hao = Playlist.songlist[i].playState == SongPlay.unplay ? "未播放" : "已播放";
                    item.SubItems.Add(hao);  
                    listView1.Items.Add(item);
                }
               
            }
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count != 0)
            {
                Playlist.zhuangtai = "重播";
                string SongName = listView1.SelectedItems[0].SubItems[0].Text;
               Playlist.SelectFromSongName(SongName);
              Playlist.ListenAgain();
                //show();
            }
            else
            {
                MessageBox.Show("请选择一项歌曲!");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                Playlist.zhuangtai = "切歌";
                string SongName = listView1.SelectedItems[0].SubItems[0].Text;
                Playlist.SelectFromSongName(SongName);
                Playlist.CutSong();
                //show();
            }
            else
            {
                MessageBox.Show("请选择一项歌曲!");
            }
            
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
