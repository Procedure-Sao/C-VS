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
    public partial class frmregist : Form
    {
        public frmregist()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static Message[] array = new Message[10];
        private void frmregist_Load(object sender, EventArgs e)
        {
           
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty && textBox6.Text != string.Empty)
            {
                if (textBox5.Text.Equals(textBox3.Text) && textBox4.Text.Equals(textBox6.Text))
                {
                    Message ms = new Message();
                    ms.name = textBox1.Text;
                    ms.id = textBox2.Text;
                    ms.email = textBox3.Text;
                    ms.email2 = textBox4.Text;
                    ms.pwd = textBox5.Text;
                    ms.pwd2 = textBox6.Text;
                    if (frmregist.AddSong(ms))
                    {
                        MessageBox.Show("注册成功");
                    }
                    else
                    {
                        MessageBox.Show("注册失败");
                    }
                }
                else
                {
                    MessageBox.Show("两次密码或邮箱不同！");
                }
                }
                else
                {
                    MessageBox.Show("数据未输入完整！");
                }
            
           
            
        }
        public static bool AddSong(Message song)//添加用户
        {
            bool Result = false;    //记录用户是否添加成功
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = song;
                    Result = true;
                    break;
                }
            }
            return Result;
        }
    }
}
