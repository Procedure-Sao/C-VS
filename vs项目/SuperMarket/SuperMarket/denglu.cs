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
    public partial class denglu : Form
    {
        public denglu()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            show();
        }
        public void show()
        {
            string con = "Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con);
            string userName = txt1.Text;
            string pwd = txt2.Text;

            if (userName.Equals(string.Empty))
            {
                MessageBox.Show("请输入用户名", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (pwd.Equals(string.Empty))
            {
                MessageBox.Show("请输入密码", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                try
                {
                    //打开数据库
                    conn.Open();
                    //拼接sql语句
                    string sql = @"select * from [User]  where UserName = '" + userName + "' and PassWord = '" + pwd + "'";
                    //用sqlcomman执行命令
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //处理返回
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("登录成功!", "操作提醒", MessageBoxButtons.OK, MessageBoxIcon.None);
                        //创建yingyong的对象
                        guanli1 sb = new guanli1();
                        sb.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("登录失败！");
                    }

                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void but2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出吗！！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void denglu_Load(object sender, EventArgs e)
        {

        }
    }
}
