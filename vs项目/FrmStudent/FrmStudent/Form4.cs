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

namespace FrmStudent
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string con = "Data Source=.;Initial Catalog=QQDB;Integrated Security=True";
        private void but1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            dgv1.AutoGenerateColumns = false;
            if (ds.Tables["UserInfo"] != null)
           {
                ds.Tables["UserInfo"].Clear();
            }
            SqlConnection conn = new SqlConnection(con);
            string sql = "select * from UserInfo";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          
            dgv1.AutoGenerateColumns = false;
            
            da.Fill(ds, "xinxi");
           
            dgv1.DataSource = ds.Tables["xinxi"];
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //string mess = string.Format("选中了{0}节点，深度是{1}", treeView1.SelectedNode.Text, treeView1.SelectedNode.Level);
            //MessageBox.Show(mess,"提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
              DataSet ds = new DataSet();
             SqlConnection conn = new SqlConnection(con);
            string sql = "select * from UserInfo";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "xinxi");
            dgv1.DataSource = ds.Tables["xinxi"];
            if (treeView1.SelectedNode != null)
            {
                DataView dv = new DataView(ds.Tables["xinxi"]);
                if (treeView1.SelectedNode.Level == 1)
                {
                    string num = treeView1.SelectedNode.Text;//获取treeView的点击值
                    dv.RowFilter = string.Format("LevelId='{0}'", num);//设置筛选条件
                }
                //else if (treeView1.SelectedNode.Level == 2)
                //{
                //    string sex = treeView1.SelectedNode.Text;//获取treeView的点击值
                //    string gradename = treeView1.SelectedNode.Parent.Text;
                //    dv.RowFilter = string.Format("pwd='{0}'and GradeId={1}", sex, gradename);//设置筛选条件
                //}
                dgv1.DataSource = dv;//重新筛选

            }
        }
    }

       
}
