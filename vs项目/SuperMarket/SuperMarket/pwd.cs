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

namespace SuperMarket
{
    public partial class pwd : Form
    {
        public pwd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guanli1 g1 = new guanli1();
            g1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.CheckInput() ==true)
            {
                
                string usernewpwd = txt2.Text.Trim();//输入的新密码
            //确定查询的sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("UPDATE [User] SET [PassWord] = '{0}'",usernewpwd);
  
                //连接数据库
            string con = "Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con);
                //创建Command
            conn.Open();
            SqlCommand cmd = new SqlCommand(sb.ToString(),conn);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("修改成功！密码为：" + usernewpwd);
                conn.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
                conn.Close();
            }
       }
        }



        public string pwd1;
        public bool CheckInput()
        {

           
            string sql = "select * from [User]";
            string con = "Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            //创建Command
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader count = cmd.ExecuteReader();
                while (count.Read())
                {
                      pwd1 = count["PassWord"].ToString();
                }
                count.Close();
              
                //原密码为空的提示
                if (this.txt1.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("请输入原密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt1.Focus();
                    return false;
                }
                //密码不是登录密码时
                else if (this.txt1.Text.Trim() != pwd1)
                {
                    MessageBox.Show("原密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt1.Focus();
                    return false;
                }
                //新密码为空时的提示
                else if (this.txt2.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("请输入新密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt1.Focus();
                    return false;
                }
                //新密码与确定新密码不一致的提示
                else if (this.txt2.Text.Trim() != (this.txt3.Text.Trim()))
                {
                    MessageBox.Show("检查两次输入的密码不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt1.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("修改失败！" + ex, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                conn.Close();
            }
          

        }

        private void pwd_Load(object sender, EventArgs e)
        {

        }
    }
}
