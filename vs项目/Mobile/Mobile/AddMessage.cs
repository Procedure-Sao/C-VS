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

namespace Mobile
{
    public partial class AddMessage : Form
    {
        public AddMessage()
        {
            InitializeComponent();
        }

        private void AddMessage_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DBhelp.con);
            string sql = "  select * from mobilebrand ";
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Brand";
            comboBox1.ValueMember = "BrandID";


        }
        public  string num;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DBhelp.con);
            string name = comboBox1.Text;
            try
            {
                conn.Open();
                string sql = "  select brandId from mobilebrand where brand='" + name + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    num = reader["brandId"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
              
            }
            finally
            {
                conn.Close();
            }
            if (textBox1.Text != string.Empty)
            {
                if (textBox2.Text != string.Empty)
                {
                    if (textBox3.Text != string.Empty)
                    {
                        if (textBox4.Text != string.Empty)
                        {
                            if (textBox5.Text != string.Empty)
                            {
                                try
                                {
                                    conn.Open();
                                    string sql1 = "insert into MobileInfo values('" + num + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                                    SqlCommand cmd = new SqlCommand(sql1, conn);
                                    int sum = cmd.ExecuteNonQuery();
                                    if (sum > 0)
                                    {
                                        MessageBox.Show("添加成功");
                                    }
                                    else
                                    {
                                        MessageBox.Show("添加失败");
                                    }
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.ToString());
                                }
                                finally
                                {
                                    conn.Close();

                                }
                            }
                            else
                            {
                                MessageBox.Show("手机终端款式为空");
                            }
                        }
                        else
                        {
                            MessageBox.Show("手机重量为空");
                        }
                    }
                    else
                    {
                        MessageBox.Show("手机尺寸为空");
                    }
                }
                else
                {
                    MessageBox.Show("手机价格为空");
                }
            }
            else
            {
                MessageBox.Show("手机型号为空");
            }
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
