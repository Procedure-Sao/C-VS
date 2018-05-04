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

namespace BackStage
{
    public partial class addsong : Form
    {
        public addsong()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public int panduan;
        public string id;
        public string name;

        private void addsong_Load(object sender, EventArgs e)
        {
            xiala();
            if (panduan == 2)
            {
                button1.Text = "修改";
                   SqlConnection conn = new SqlConnection(home1.con);
                try
                {
                    conn.Open();
                    string sql3 = "select song_id,song_name,song_ab,song_word_count,songtype_name,singer_name,song_url from song_info,singer_info as b,song_type as a where song_info.songtype_id = a.songtype_id and song_info.singer_id=b.singer_id  and song_name='" + name + "'";
                    SqlCommand cmd = new SqlCommand(sql3, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader["song_id"].ToString();
                        textBox1.Text = reader["song_name"].ToString();
                        textBox2.Text = reader["song_ab"].ToString();
                        textBox3.Text = reader["song_word_count"].ToString();
                        cboType.Text = reader["songtype_name"].ToString();
                        cboSinger.Text = reader["singer_name"].ToString();
                        textBox4.Text = reader["song_url"].ToString();
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString(), "提示");
                }
                finally {


                    conn.Close();
                }
            
            }
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panduan == 2)
            {
                string songName = textBox1.Text;
                string pinXie = textBox2.Text.ToUpper();
                string count = textBox3.Text;
                string type = cboType.Text;
                string singer = cboSinger.Text;
                string t_id = "";
                string singer_id = "";
                string url = textBox4.Text;
                SqlConnection conn = new SqlConnection(home1.con);

                //歌曲类型id
                try
                {
                    conn.Open();
                    string sql = @"select songtype_id from song_type where songtype_name='" + type + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        t_id = reader["songtype_id"].ToString();
                    } reader.Close();

                    //歌手id
                    string sql1 = @"select singer_id from dbo.singer_info where singer_name='" + singer + "'";
                    SqlCommand cmd1 = new SqlCommand(sql1, conn);
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    if (reader1.Read())
                    {
                        singer_id = reader1["singer_id"].ToString();
                    }

                    reader1.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString(), "异常");
                }
                finally
                {
                    conn.Close();
                }
                try
                {
                    conn.Open();
                    string sql3 = "update song_info set song_name='" + songName + "',song_ab='" + pinXie + "',song_word_count='" + count + "',songtype_id='" + t_id + "',singer_id='" + singer_id + "',song_url='" + url + "' where song_id='" + id + "'";

                    SqlCommand cmd1 = new SqlCommand(sql3, conn);
                    int num = cmd1.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "异常");
                }
                finally
                {

                    conn.Close();
                }
            }
            else
            {
                string songName = textBox1.Text;
                string pinXie = textBox2.Text.ToUpper();
                string count = textBox3.Text;
                string type = cboType.Text;
                string singer = cboSinger.Text;
                string t_id = "";
                string singer_id = "";
                string url = textBox4.Text;
                SqlConnection conn = new SqlConnection(home1.con);

                //歌曲类型id
                try
                {
                    conn.Open();
                    string sql = @"select songtype_id from song_type where songtype_name='" + type + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        t_id = reader["songtype_id"].ToString();
                    } reader.Close();

                    //歌手id
                    string sql1 = @"select singer_id from dbo.singer_info where singer_name='" + singer + "'";
                    SqlCommand cmd1 = new SqlCommand(sql1, conn);
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    if (reader1.Read())
                    {
                        singer_id = reader1["singer_id"].ToString();
                    }

                    reader1.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString(), "异常");
                }
                finally
                {
                    conn.Close();
                }
                try
                {
                    conn.Open();
                    string sql3 = "insert into dbo.song_info values('" + songName + "','" + pinXie + "','" + count + "','" + t_id + "','" + singer_id + "','" + url + "',0)";

                    SqlCommand cmd1 = new SqlCommand(sql3, conn);
                    int num = cmd1.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK);
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "异常");
                }
                finally
                {

                    conn.Close();
                }

            }
         

        }
        public string aa;
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "选择文件";
            openFileDialog1.Filter = "所有文件(*.mp3)|*mp3";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fi = openFileDialog1.FileName;
                aa = openFileDialog1.SafeFileName;
                textBox4.Text = aa;
            
            }
        }


        public void xiala() {


            //歌曲类型显示
            SqlConnection conn = new SqlConnection(home1.con);
            string sql1 = "select * from song_type";
            //conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql1, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataRow rows = ds.Tables[0].NewRow();

            rows[0] = -1;
            rows[1] = "全部类型";
            ds.Tables[0].Rows.InsertAt(rows, 0);
            cboType.DataSource = ds.Tables[0];
            cboType.DisplayMember = "songtype_name";
            cboType.ValueMember = "songtype_id";

            //歌手显示
            SqlConnection conn1 = new SqlConnection(home1.con);
            string sql = "select singer_id,singer_name from dbo.singer_info";
            //conn.Open();
            SqlDataAdapter da1 = new SqlDataAdapter(sql, conn1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            DataRow rows1 = ds1.Tables[0].NewRow();
            rows1[0] = -1;
            rows1[1] = "全部歌手";
            ds1.Tables[0].Rows.InsertAt(rows1, 0);
            cboSinger.DataSource = ds1.Tables[0];
            cboSinger.DisplayMember = "singer_name";
            cboSinger.ValueMember = "singer_id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
