using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XmlParse
{
    public partial class FrmsShow : Form
    {
        public FrmsShow()
        {
            InitializeComponent();
        }
                                                                                                           
        private void FrmsShow_Load(object sender, EventArgs e)
        {
            ShowMxl();
            intrv();
        }
        List<Message> list=new List<Message>();
        public void ShowMxl()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load("Address.xml");
            XmlNode root = myXml.DocumentElement;

            foreach (XmlNode item in root.ChildNodes)
            {
                Message ms = new Message();
                ms.Street = root.Attributes["name"].Value.ToString();
                foreach (XmlNode item1 in item.ChildNodes)
                {
                    ms.Committee = item.Attributes["name"].Value.ToString();
                    foreach (XmlNode item2 in item1.ChildNodes)
                    {
                        ms.Building = item1.Attributes["name"].Value.ToString();
                        foreach (XmlNode item3 in item2.ChildNodes)
                        {
                            ms.Huisnummer = item3.InnerText;
                           
                        }
                       
                       
                    }
                    
                }
               list.Add(ms);
            }
        }



        #region 树状菜单获取
        public void intrv()
        {
           
            TreeNode node = null;
           
            foreach (Message item in list)
            {
                if (node==null)
                {
                    node = new TreeNode(item.Street);
                    treeView1.Nodes.Add(node);
                }
               
               TreeNode tn = new TreeNode(item.Committee);
                node.Nodes.Add(tn);
                TreeNode tn2 = new TreeNode(item.Building);
                tn.Nodes.Add(tn2);
                TreeNode tn3 = new TreeNode(item.Huisnummer);
                tn2.Nodes.Add(tn3);
                
            }
        }
        #endregion

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //根据选择深度填写 信息
            if (treeView1.SelectedNode.Level == 0)
            {
                textBox1.Text = treeView1.SelectedNode.Text;
            }
            if (treeView1.SelectedNode.Level == 1)
            {
                textBox2.Text = treeView1.SelectedNode.Text;
            }
            if (treeView1.SelectedNode.Level == 2)
            {
                textBox3.Text = treeView1.SelectedNode.Text;
            }
            if (treeView1.SelectedNode.Level == 3)
            {
                textBox4.Text = treeView1.SelectedNode.Text;
            }

        }
    }
}
