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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string name = textBox1.Text.ToString();
            string pwd = textBox2.Text.ToString(); 
            SqlConnection conn = new SqlConnection(home1.con);
            
            try
            {
                conn.Open();
                string sql = "  select * from admin where admin_name =" + name + " and admin_pwd = " + pwd + "";
                SqlCommand cmd = new SqlCommand(sql,conn);
                int num = (int)cmd.ExecuteScalar();    
                if (num >0)
                {    
                    zhuye zy = new zhuye();
                    zy.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！","温馨提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Hand);
                }

            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.ToString());
            }
            conn.Close();

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
