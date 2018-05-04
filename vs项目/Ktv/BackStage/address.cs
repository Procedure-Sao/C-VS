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
    public partial class address : Form
    {
        public address()
        {
            InitializeComponent();
        }

        public string name;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            //openFileDialog1.Filter = "所有文件(*.jpg)|*jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string fi = openFileDialog1.FileName;
                textBox1.Text = fi;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            song();
        }


        public void song() {

            SqlConnection conn = new SqlConnection(home1.con);
            try
            {
                conn.Open();
                string sql = " update resource set resource_path='" + textBox1.Text + "' where resource_type='" + name + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int a = cmd.ExecuteNonQuery();
                MessageBox.Show(sql);
                if (a > 0)
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "提示");
            }
            finally {
                conn.Close();
            
            }
        }

        private void address_Load(object sender, EventArgs e)
        {
            if (name.Equals("song"))
            {
                label1.Text = "请选择歌曲地址：";
            }
            else
            {
                label1.Text = "请选择照片地址：";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
