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

namespace FlowerShop
{
    public partial class ReaderFlower : Form
    {
        public ReaderFlower()
        {
            InitializeComponent();
        }

        private void ReaderFlower_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DBhelp.con);//连接数据库
            //连表查询sql语句
            string sql = "select saleId,a.flowerId,flowername,salecount,saledate,saleprice,saleclerk,remark from flower as a,flowersale as b where a.flowerId=b.flowerId";
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);//卡车对象
            DataSet ds = new DataSet();//仓库对象
            da.Fill(ds);//填充数据
            dgv1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DBhelp.con);//连接数据库
            //连表模糊查询sql语句
            string sql = "select saleId,a.flowerId,flowername,salecount,saledate,saleprice,saleclerk,remark from flower as a,flowersale as b where a.flowerId=b.flowerId and flowername like '%"+txt1.Text+"%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);//卡车对象
            DataSet ds = new DataSet();//仓库对象
            da.Fill(ds);//填充数据
            dgv1.DataSource = ds.Tables[0];
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateflower upf = new updateflower();//创建修改窗口对象
            upf.id = dgv1.SelectedRows[0].Cells[0].Value.ToString();//分别获取信息赋值
            upf.num = dgv1.SelectedRows[0].Cells[3].Value.ToString();
            upf.danjia = dgv1.SelectedRows[0].Cells[5].Value.ToString();
            upf.beizhu = dgv1.SelectedRows[0].Cells[7].Value.ToString();
            upf.ShowDialog();//模式化窗口

        }
        
    }
}
