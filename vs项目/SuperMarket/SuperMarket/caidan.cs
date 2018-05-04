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

namespace SuperMarket
{
    public partial class caidan : Form
    {
        public caidan()
        {
            InitializeComponent();
        }
        public  string con = "Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True";

     
        private void Form4_Load(object sender, EventArgs e)
        {
             
         
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
          
             
            try
            {
                SqlConnection conn = new SqlConnection(con);
                if (treeView1.SelectedNode != null)
                {
                    DataSet ds = new DataSet();
      
             
                // 通过连接进行查询
                string sql = "SELECT A.CommodityID,A.CommodityName,B.SortName" +
                   ",A.CommodityPrice,A.IsDiscount,A.ReducedPrice  FROM [Commodity] AS A " +
                   " JOIN [CommoditySort]  AS B ON A.SortID=B.SortID";

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn);
                da.Fill(ds, "zhazha");
                dataGridView1.DataSource =ds.Tables[0];
                  DataView dv = new DataView(ds.Tables[0]);
                    if (treeView1.SelectedNode.Level == 1)
                    {
                        bool isDiscount = Convert.ToBoolean(treeView1.SelectedNode.Tag);
                        if (isDiscount == true)
                        {
                            dv.RowFilter = "isDiscount='false'";
                           
                        }
                        else
                        {
                            dv.RowFilter = "isDiscount ='true'";
                          
                        }
                        //重新绑定数据源
                        dataGridView1.DataSource = dv;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
           SqlConnection conn = new SqlConnection(con);
             try
            {
               
                if (this.dataGridView1.CurrentRow != null)
                {
                    string message = string.Format("确定要删除商品名称为 {0} 的数据吗?", this.dataGridView1.CurrentRow.Cells[1].Value);
                    
                    // 通过谈出对话框让用户选择
                    if (MessageBox.Show(message, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        StringBuilder sb = new StringBuilder();
                        int num = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                        // 删除语句
                        sb.AppendFormat("DELETE FROM [Commodity] WHERE CommodityID={0}", num);

                        // 执行删除操作
                      
                        SqlCommand command = new SqlCommand(sb.ToString(), conn);
                      
                        int result = command.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 重新加载新数据
                            FillCommodityInfo();
                        }                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("数据库操作失败！"+ex, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                conn.Close();
            }
        }
        private void FillCommodityInfo()
        {
           
            SqlConnection conn = new SqlConnection(con);
            try
            {
                // 通过连接进行查询
                string sql = "SELECT A.CommodityID,A.CommodityName,B.SortName" +
                   ",A.CommodityPrice,A.IsDiscount,A.ReducedPrice  FROM [Commodity] AS A " +
                   " JOIN [CommoditySort]  AS B ON A.SortID=B.SortID";

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = new SqlCommand(sql, conn);
                da.Fill(ds, "a");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作错误！" + ex, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出吗！！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tianxiu f5 = new tianxiu();
            f5.commodityID = 0;
            f5.ShowDialog();
            FillCommodityInfo();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tianxiu f5 = new tianxiu();
            f5.commodityID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            f5.ShowDialog();
            FillCommodityInfo();
          
        }

        //#region 显示所有
        //public void All()
        //{
        //    SqlConnection conn = new SqlConnection(con);
        //    string sql = "SELECT A.CommodityID,A.CommodityName,B.SortName" +
        //           ",A.CommodityPrice,A.IsDiscount,A.ReducedPrice  FROM [Commodity] AS A " +
        //           " JOIN [CommoditySort]  AS B ON A.SortID=B.SortID";

        //    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        //    DataSet ds = new DataSet();
        //    da.Fill(this.ds, "s");
        //    dataGridView1.DataSource = this.ds.Tables["s"];

        //}
        //#endregion

    
    }
}
