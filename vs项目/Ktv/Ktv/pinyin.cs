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
    public partial class pinyin : Form
    {
        public pinyin()
        {
            InitializeComponent();
        }
        music ms = new music();
        home hm = new home();
        private void pinyin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(home.con);
            string sql = "select song_name,singer_name,song_url from singer_info inner join  song_info as a on singer_info.singer_id = a.singer_id";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(home.con);
            string sql = "select song_name,singer_name,song_url from singer_info inner join  song_info as a on singer_info.singer_id = a.singer_id where (song_name like '%" + textBox1.Text + "%' or song_ab like '%" + textBox1.Text + "%')";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() != string.Empty)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
