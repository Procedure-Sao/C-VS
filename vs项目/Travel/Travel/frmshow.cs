using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
    public partial class frmshow : Form
    {
        public frmshow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream myfs = new FileStream(("D:\\" + txt2.Text)+".txt", FileMode.Append);//创建流
                StreamWriter mysw = new StreamWriter(myfs);//写入器
                mysw.Write(lab1.Text + txt1.Text.Trim() + "    " + lab2.Text + txt2.Text.Trim() + "    " + lab3.Text + rtb1.Text.Trim()+"\n");
                mysw.Close();//关闭写入器
                myfs.Close();//关闭io流
                MessageBox.Show("保存成功","提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());//弹出异常
              
            }
            
        }

        private void button2_Click(object sender, EventArgs e)//退出处理
        {
            DialogResult result = MessageBox.Show("是否退出？", "操作提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
