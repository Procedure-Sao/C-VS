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
    public partial class tianxiu : Form
    {
        public tianxiu()
        {
            InitializeComponent();
        }
        public int commodityID = 0;
       public  string con = "Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True";
        private void Form5_Load(object sender, EventArgs e)
        {
            // 添加
            if (this.commodityID == 0)
            {
                SqlConnection conn = new SqlConnection(con);

                string sql = "select * from [CommoditySort]";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();

                da.Fill(ds, "pwd");

                DataRow row = ds.Tables["pwd"].NewRow();
                row[0] = -1;
                row[1] = "请选择";
                ds.Tables["pwd"].Rows.InsertAt(row, 0);

                comboBox1.DataSource = ds.Tables["pwd"];
                comboBox1.DisplayMember = "SortName";
                comboBox1.ValueMember = "SortID";
            }
            // 修改
            else
            {
                this.button1.Text = "修改(&U)";
                SqlConnection conn = new SqlConnection(con);

                string sql = "select * from [CommoditySort]";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();

                da.Fill(ds, "pwd");

                DataRow row = ds.Tables["pwd"].NewRow();
                row[0] = -1;
                row[1] = "请选择";
                ds.Tables["pwd"].Rows.InsertAt(row, 0);

                comboBox1.DataSource = ds.Tables["pwd"];
                comboBox1.DisplayMember = "SortName";
                comboBox1.ValueMember = "SortID";
                this.GetCommidity();
               
            }



           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出吗！！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void GetCommidity()//修改前得到的信息
        {
            SqlConnection conn = new SqlConnection(con);
            try
            {
                StringBuilder sb = new StringBuilder();

                //得到信息
                sb.AppendFormat("SELECT * FROM [Commodity] WHERE CommodityID={0}", this.commodityID);
                SqlCommand com = new SqlCommand(sb.ToString(),conn);
                conn.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    //得到信息给控件值
                    this.textBox1.Text = reader["CommodityName"].ToString();
                    this.comboBox1.SelectedValue = reader["SortID"].ToString();
                    this.numericUpDown1.Value = Convert.ToDecimal(reader["CommodityPrice"].ToString());
                    this.checkBox2.Checked = Convert.ToBoolean(reader["IsDiscount"].ToString());
                    this.numericUpDown2.Value = Convert.ToDecimal(reader["ReducedPrice"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作错误！"+ex, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.CheckInput())
            {
                // 判断commodityID 0为添加数据 其他数字为修改数据
                if (this.commodityID == 0)
                {
                    this.InsertCommodity();
                }
                else
                {
                    this.UpdateCommodity();
                }
            }
        }
        private void InsertCommodity()//添加方法
        {
            SqlConnection conn = new SqlConnection(con);
            try
            {
                StringBuilder sql = new StringBuilder();

                sql.AppendLine("INSERT INTO [Commodity]");
                sql.AppendFormat(" VALUES('{0}',{1},{2},{3},{4})",
                    this.textBox1.Text, Convert.ToInt32(this.comboBox1.SelectedValue), this.numericUpDown1.Value, this.checkBox2.Checked ? 1 : 0, this.numericUpDown2.Value);
                SqlCommand com = new SqlCommand(sql.ToString(),conn);
                conn.Open();
                int result = com.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("添加成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作失败！"+ex, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

        }
        private void UpdateCommodity()//修改方法
        {
            SqlConnection conn = new SqlConnection(con);
            try
            {
                StringBuilder sql = new StringBuilder();

                //修改数据库语句
                sql.AppendFormat("UPDATE [Commodity] SET [CommodityName]='{0}'", this.textBox1.Text);
                sql.AppendFormat(" ,[SortID]='{0}'", Convert.ToInt32(this.comboBox1.SelectedValue));
                sql.AppendFormat(" ,[CommodityPrice]='{0}'", this.numericUpDown1.Value);
                sql.AppendFormat(" ,[IsDiscount]='{0}'", this.checkBox2.Checked ? 1 : 0);
                sql.AppendFormat(" ,[ReducedPrice]='{0}'", this.numericUpDown2.Value);
                sql.AppendFormat(" WHERE [CommodityID]={0}", this.commodityID);
                //执行SQL语句
                SqlCommand com = new SqlCommand(sql.ToString(),conn);
                conn.Open();
                int result = com.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("修改成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }
        private bool CheckInput()//修改时名称不能为空
        {
            bool ok = true;
            this.textBox1.Text = this.textBox1.Text.Trim();
            if (this.textBox1.Text.Length == 0)
            {
                MessageBox.Show("名称不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ok = false;
            }
            return ok;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
              //判断是否特价
            if (checkBox2.Checked)
            {
                //是否特价就和特价价格发生反应
                this.numericUpDown2.Enabled = true;
            }
            else
            {
                //是否特价如果不选则和预售的价格相等
                this.numericUpDown2.Enabled = false;
                this.numericUpDown2.Value = this.numericUpDown1.Value;
               
            }

        }
    }
}
