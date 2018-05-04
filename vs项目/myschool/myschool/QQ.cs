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

namespace myschool
{
    public partial class QQ : Form
    {
        public QQ()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Q号_Click(object sender, EventArgs e)
        {

        }

        private void QQ_Load(object sender, EventArgs e)
        {

        }

        private void 登方_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            show();
           
            
        }
      

        #region  登录验证
        public const string weizi = "输入提示";
        public bool checkinput()
        {
            if (this.tet1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入用户名", weizi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tet1.Focus();
                return false;
            }
            else if (this.tet2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入密码", weizi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tet2.Focus();
                return false;
            }
            else if (this.登方1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请选择登录类型", weizi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.登方1.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }

        #endregion

        public void show() {

            SqlConnection conn = new SqlConnection(dbutils.str);
            string userName = tet1.Text;
            string pwd = tet2.Text;

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
                    string sql = @"select count(*) from admin  where LoginId = '" + userName + "' and LoginPwd = '" + pwd + "'";
                    //用sqlcomman执行命令
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //处理返回
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("登录成功!", "操作提醒", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        //创建yingyong的对象
                        huanyingcs sb = new huanyingcs();
                        sb.name = tet1.Text.Trim();
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


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认取消登录吗？", "操作提醒！", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
