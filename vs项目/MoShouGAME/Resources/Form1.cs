using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resources
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tv1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();//清除内容
            TreeNode node = this.tv1.SelectedNode;//获取选中节点
            this.BindINfo(node);//调用获取方法

            DirectoryInfo dic = new DirectoryInfo(node.Tag.ToString());//获取目录对象
           
            FileInfo[] foInfos = dic.GetFiles();//获取目录文件的集合
            List<Files> list = new List<Files>();//保存信息表
            foreach (FileInfo file in foInfos)//循环将其遍历，赋值到list集合中
            {
                Files fl = new Files();
                fl.FileName = file.Name;
                float a = file.Length;
                fl.FileLength = float.Parse(Math.Round(a/1024,2).ToString());//将内存转换为KB
                fl.FileType = file.Extension;
                fl.FilePath = file.FullName;
                list.Add(fl);
         
            }
            foreach (Files em in list)//循环将list内的信息绑定到listview
            {
                ListViewItem item = new ListViewItem(em.FileName);
                item.SubItems.Add(em.FileLength.ToString());
                item.SubItems.Add(em.FileType);
                item.SubItems.Add(em.FilePath);
                listView1.Items.Add(item);
            }
        }

        private void BindINfo(TreeNode node)
        {
           DirectoryInfo dic=new DirectoryInfo(node.Tag.ToString());
            DirectoryInfo[] dirs = dic.GetDirectories();
            foreach (DirectoryInfo item in dirs)//循环获取当前目录的子目录
            {
                TreeNode temp=new TreeNode();
                temp.Text = item.Name;
                temp.Tag = item.FullName;//详细地址
                node.Nodes.Add(temp);
            }
           
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count==0)//数量为零时，重新执行
            {
                return;
            }
            FolderBrowserDialog fdb = new FolderBrowserDialog();//打开选择器
            DialogResult result = fdb.ShowDialog();
            string yuanPath = listView1.SelectedItems[0].SubItems[3].Text;//原地址
            string newPath = null;
            if (result==DialogResult.OK)
            {
                newPath = fdb.SelectedPath;
                newPath += "\\" + listView1.SelectedItems[0].SubItems[0].Text;//给新地址赋值
                File.Copy(yuanPath,newPath);//执行复制
                MessageBox.Show("复制成功");
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)//数量为零时，重新执行
            {
                return;
            }
            string yuanPath = listView1.SelectedItems[0].SubItems[3].Text;//地址
            DialogResult result = MessageBox.Show("确定要删除吗", "提示", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)//点击确定时，执行删除
            {
                File.Delete(yuanPath);
            }
            listView1.SelectedItems[0].Remove();//移除该项
        }
    }
}
