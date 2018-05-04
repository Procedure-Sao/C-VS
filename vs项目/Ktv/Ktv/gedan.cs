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
    public partial class gedan : Form
    {
        public gedan()
        {
            InitializeComponent();
        }
      
        music ms = new music();
        home hm = new home();
        public string sqlyj;
        private void gedan_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(home.con);
           
            SqlDataAdapter da = new SqlDataAdapter(sqlyj, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddSong();
          
           

        }

        //添加歌曲的方法
        public void AddSong()
        {
            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() !=string.Empty)
            {
                bofang Song = new bofang();
                Song.SongName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Song.Singer = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Song.SongURL = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                Song.playState = SongPlay.unplay;//播放状态为未播
                bool result = Playlist.AddSong(Song); //将歌曲增加到播放列表里面
                if (result)
                {
                    MessageBox.Show("添加成功!!");
                }
                else
                {
                    MessageBox.Show("添加失败!");
                }
            }
            else
            {
                MessageBox.Show("请选择正确的歌曲名称!");
            }
        }
    }
}
