using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebTv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void show()
        {
            try
            {
                ChannelManager manager = new ChannelManager();//创建工具类的对象
                manager.LoadAllChannel();//调用频道方法
                Dictionary<string, ChannelBase> fullChannel = manager.fullChannel;//创建新的集合来接收频道的信息
                foreach (ChannelBase channelBase in fullChannel.Values)//遍历集合的values值（就是频道的对象）
                {
                    TreeNode tn = new TreeNode();//节点
                    tn.Text = channelBase.ChannelName;
                  
                    tn.Tag = channelBase;

                    treeView1.Nodes[1].Nodes.Add(tn);//
                    tn.ContextMenuStrip = contextMenuStrip1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       

        public void div()
        {
            
            if (treeView1.SelectedNode.Text.Equals("北京电视台"))
            {
               
                dataGridView1.Rows.Clear();
                TypeAChannel ta = new TypeAChannel();
                ta.fetch();
                dataGridView1.DataSource = new  BindingList<TvProgram>(ta.Tvlist);
            }
            if (treeView1.SelectedNode.Text=="凤凰卫视")
            {
              
                dataGridView1.Rows.Clear();
                TypeBChannel tb = new TypeBChannel();
                tb.fetch();
                dataGridView1.DataSource = new  BindingList<TvProgram>(tb.Tvlist);
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            dataGridView1.AutoGenerateColumns = false;
            show();
          
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            div();
        }

        private void 添加到我的频道ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TreeNode tn = new TreeNode();//节点
            tn.Text = treeView1.SelectedNode.Text;
            treeView1.Nodes[0].Nodes.Add(tn);//
            
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (treeView1.SelectedNode.Parent!=null&&treeView1.SelectedNode.Parent.Text.Equals("全部电台"))
            {
                this.contextMenuStrip1.Items[0].Visible = true;
                this.contextMenuStrip1.Items[1].Visible = false;

            }
            else
            {
                this.contextMenuStrip1.Items[1].Visible = false;
                this.contextMenuStrip1.Items[0].Visible = true;

            }
            if (treeView1.SelectedNode.Level == 0)
            {
                this.contextMenuStrip1.Items[0].Visible = false;
                this.contextMenuStrip1.Items[1].Visible = false;

            }
        }

        private void 删除频道ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

    }
}
