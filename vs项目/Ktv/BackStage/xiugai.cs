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
    public partial class xiugai : Form
    {
        public xiugai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Change();
        }

        public string pwd1;
        public string name;
        #region 修改密码
        public void Change()
        {
            SqlConnection conn = new SqlConnection(home1.con);
            string oldPwd = textBox2.Text;
            string newPwd = textBox3.Text;
            string newPwdTure = textBox4.Text;

            string UserName = textBox1.Text;
            string sql = "select * from dbo.admin";
            conn.Open();
            //创建Command

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader count = cmd.ExecuteReader();
            while (count.Read())
            {
                pwd1 = count["admin_pwd"].ToString();
                name = count["admin_name"].ToString();
            }
            count.Close();
            conn.Close();

            if (UserName.Equals(name))
            {
                if (oldPwd == pwd1)
                {
                    if (newPwd.Equals(newPwdTure))
                    {
                        if (newPwd != oldPwd)
                        {
                            try
                            {
                                conn.Open();
                                string sql1 = "  update [admin] set [admin_pwd] = '" + newPwd + "' where [admin_name] = '" + UserName + "'";
                                SqlCommand cmd1 = new SqlCommand(sql1, conn);

                                int count1 = cmd1.ExecuteNonQuery();
                                if (count1 > 0)
                                {
                                    MessageBox.Show("修改成功！密码为：" + newPwd);
                                }
                                else
                                {
                                    MessageBox.Show("修改失败");
                                }
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("出错啦！！" + ex);
                            }
                            finally
                            {
                                conn.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show("新旧密码不可以相同", "提示", MessageBoxButtons.OKCancel);
                        }
                    }
                    else
                    {
                        MessageBox.Show("两次密码不一致！", "提示", MessageBoxButtons.OKCancel);
                    }

                }
                else
                {
                    MessageBox.Show("旧密码错误！", "提示", MessageBoxButtons.OKCancel);
                }

            }
            else
            {
                MessageBox.Show("用户名不存在！", "提示", MessageBoxButtons.OKCancel);
            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void xiugai_Load(object sender, EventArgs e)
        {

        }
    }
}
