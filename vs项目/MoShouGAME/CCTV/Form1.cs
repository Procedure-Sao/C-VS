using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;//获取文本框的值
            TreeNode tn = new TreeNode();//创建节点对象
            tn.Text = name;
            foreach (TreeNode item in treeView1.Nodes)
            {
                if (item.Text == name)
                {
                    MessageBox.Show("重复名称，请换一个");
                    return;
                }
            }
            treeView1.Nodes.Add(tn);//绑定到树上
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            TreeNode tn = new TreeNode();
            tn.Text = name;
            TreeNode fu = treeView1.SelectedNode;//获取选中的节点
            foreach (TreeNode item in fu.Nodes)
            {
                if (item.Text==name)
                {
                    MessageBox.Show("重复名称，请换一个");
                    return;
                }
            }
            fu.Nodes.Add(tn);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode fu = treeView1.SelectedNode;
            MessageBox.Show(fu.Text);
        }
    }
}
