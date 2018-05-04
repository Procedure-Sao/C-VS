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
    public partial class readersinger : Form
    {
        public readersinger()
        {
            InitializeComponent();
        }

        private void readersinger_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet(); 
            dataGridView1.AutoGenerateColumns = false;
            if (ds.Tables["singer_info"] != null)
            {
                ds.Tables["singer_info"].Clear();
            }
            SqlConnection conn = new SqlConnection(home1.con);
            string sql = "select singer_name,singertype_name,singer_gender,singer_id from singer_info inner join singer_type as a on singer_info.singertype_id = a.singertype_id";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "xinxi");
            dataGridView1.DataSource = ds.Tables["xinxi"];
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataSet ds = new DataSet();
            dataGridView1.AutoGenerateColumns = false;
            if (ds.Tables["singer_info"] != null)
            {
                ds.Tables["singer_info"].Clear();
            }
            SqlConnection conn = new SqlConnection(home1.con);
            string sql = "select singer_name,singertype_name,singer_gender,singer_id from singer_info inner join singer_type as a on singer_info.singertype_id = a.singertype_id";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "xinxi");
            dataGridView1.DataSource = ds.Tables["xinxi"];

            if (treeView1.SelectedNode != null)
            {
                DataView dv = new DataView(ds.Tables["xinxi"]);
                if (treeView1.SelectedNode.Level == 1)
                {
                    string num = treeView1.SelectedNode.Text;//获取treeView的点击值
                    dv.RowFilter = string.Format("singer_gender='{0}'", num);//设置筛选条件
                }
                dataGridView1.DataSource = dv;//重新筛选
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string id = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            SqlConnection conn = new SqlConnection(home1.con);
            try
            {
                conn.Open();
                string sql = " delete  from song_info where singer_id='" + id + "'  delete  from singer_info where singer_name='" + name + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int a = cmd.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (a > 0)
                    {
                        MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addsinger add = new addsinger();
            add.panduan = 2;
            add.chuan = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            add.Show();
        }
    }
}
