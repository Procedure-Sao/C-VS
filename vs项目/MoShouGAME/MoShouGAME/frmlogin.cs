using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoShouGAME
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmregist fg1 = new frmregist();
            fg1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim()!=string.Empty||textBox2.Text.Trim()!=string.Empty)
            {
                foreach (Message item in frmregist.array)
                {
                    if (item!=null)
                    {
                        if (item.email==textBox1.Text && item.pwd==textBox2.Text)
                        {
                            frmmain fm = new frmmain();
                            fm.name = "欢迎" + item.name;
                            fm.Show();
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("用户名或密码不能为空", "提示");
            }
            
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            Message ms1 = new Message();
            ms1.name = "1";
            ms1.id = "1";
            ms1.email = "1";
            ms1.email2 = "1";
            ms1.pwd = "1";
            ms1.pwd2 = "1";
            frmregist.array[0] = ms1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
