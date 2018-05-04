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

namespace FlowerShop
{
    public partial class updateflower : Form
    {
        public updateflower()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//退出
        {
            DialogResult result = MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public string id;//商品编号
        public string num;//销售数量
        public string danjia;//单价
        public string beizhu;//备注
        private void updateflower_Load(object sender, EventArgs e)
        {
            lab1.Text = "销售编号" + id;//分别将获取的值赋到控件中
            txt1.Text = num;
            txt2.Text = danjia;
            richTextBox1.Text = beizhu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection conn = new SqlConnection(DBhelp.con);

             try
             {
                 conn.Open();//打开数据库
                 //根据商品ID修改的sql语句
                 string sql = "update flowersale set salecount='" + txt1.Text + "',saleprice='" + txt2.Text + "',remark='" + richTextBox1.Text + "' where saleId='" + id + "'";
                 SqlCommand cmd = new SqlCommand(sql, conn);
                 int num = cmd.ExecuteNonQuery();//返回行数方法
                 if (num > 0)
                 {
                     MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
                 }
                 else
                 {

                     MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
             catch (Exception ex)//异常处理
             {

                 MessageBox.Show(ex.ToString(), "提示");
             }
             finally {

                 conn.Close();
             }
            
        }
    }
}
