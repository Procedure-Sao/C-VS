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
    public partial class addsinger : Form
    {
        public addsinger()
        {
            InitializeComponent();
        }
        public string chuan;
        public string gender;
        public int panduan;
        public string id;
        public string aa;
        public string name;
        public string dizhi;
        public string num;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect=true;
            openFileDialog1.Filter = "所有文件(*.jpg)|*jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string fi = openFileDialog1.FileName;
                aa = openFileDialog1.SafeFileName;
                pictureBox1.Image = Image.FromFile(fi);
                MessageBox.Show(aa);
            }
        }

        private void addsinger_Load(object sender, EventArgs e)
        {
           
                SqlConnection conn = new SqlConnection(home1.con);
                string sql1 = "select * from dbo.singer_type";
                //conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql1, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow rows = ds.Tables[0].NewRow();
                rows[0] = -1;
                rows[1] = "全部地区";
                ds.Tables[0].Rows.InsertAt(rows, 0);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "singerType_name";
                comboBox1.ValueMember = "singertype_id";

                if (panduan==2)
                {
                    button2.Text = "修改";
                    try
                    {
                        conn.Open();
                        string sql3 = "select singer_id,singer_name,singertype_name,singer_gender,singer_photo_url,singer_description from singer_info,singer_type  where singer_info.singertype_id=singer_type.singertype_id and singer_id='" + chuan + "'";
                        SqlCommand cmd = new SqlCommand(sql3, conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            id = reader["singer_id"].ToString();
                            textBox1.Text = reader["singer_name"].ToString();
                            comboBox1.Text = reader["singertype_name"].ToString();
                            gender = reader["singer_gender"].ToString();
                            gennder2();
                            aa = reader["singer_photo_url"].ToString();
                            pictureBox1.Image = Image.FromFile("E:\\VS\\vs项目\\Ktv\\images\\"+reader["singer_photo_url"].ToString());
                            richTextBox1.Text = reader["singer_description"].ToString();
                        }
                        reader.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString(), "提示");
                    }
                    finally
                    {


                        conn.Close();
                    }

                }
        

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panduan==2)
            {
                gennder();
                huan();
                xiugai();
            }
            else
            {
                MessageBox.Show(panduan.ToString());
                gennder();
                huan();
                jia();
            }
        }
        public void gennder()
        {
            if (radioButton1.Checked == true)
            {
                name = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                name = radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                name = radioButton3.Text;
            }

        }


         public void gennder2() {
             if (gender.Equals("男"))
            {
                radioButton1.Checked=true;
            }
             else if (gender.Equals("女"))
            {
                 radioButton2.Checked = true;
            }
             else if (gender.Equals("组合"))
	        {
                 radioButton3.Checked = true;  
	        }
        
        }


         public void xiugai() 
         {
             SqlConnection conn = new SqlConnection(home1.con);

             try
             {
                 string sql = "update singer_info set singer_name='" + textBox1.Text + "',singertype_id='" + num + "',singer_gender='" + name + "',singer_photo_url='" + aa + "',singer_description='" + richTextBox1.Text + "'  where singer_id='"+id+"'";

                 conn.Open();
                 SqlCommand com = new SqlCommand(sql, conn);

                 int result = com.ExecuteNonQuery();
                 if (result > 0)
                 {
                     MessageBox.Show("修改成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     this.Close();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("数据库操作失败！" + ex, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             finally
             {
                 conn.Close();
             }
         
         
         
         }
        public void jia()
        {
            SqlConnection conn = new SqlConnection(home1.con);
          
            try
            {
                string sql = "INSERT  INTO singer_info(singer_name,singertype_id,singer_gender,singer_photo_url,singer_description) VALUES('" + textBox1.Text + "','" + num + "','" + name + "','" + aa + "','" + richTextBox1.Text + "')";
               
                conn.Open();
                SqlCommand com = new SqlCommand(sql, conn);

                int result = com.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("添加成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作失败！" + ex, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }

        public void huan() {
            SqlConnection conn = new SqlConnection(home1.con);
            try
            {
                dizhi = comboBox1.Text;
                conn.Open();
                string sql1 = @"select singertype_id from dbo.singer_type where singertype_name='"+ dizhi +"'";
               
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    num = reader1["singertype_id"].ToString();
                }

                reader1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
               
            }
            finally {
                conn.Close();
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
