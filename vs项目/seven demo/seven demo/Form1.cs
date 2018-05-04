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

namespace seven_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string con = "Data Source=.;Initial Catalog=ticket;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);

            string sql = "select * from CityInfo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "CityInfo");
            da.Fill(ds, "CityInfo2");

            //向数据集第一行添加数据"请选择"
            DataRow row = ds.Tables["CityInfo"].NewRow();
            row["Id"] = -1;
            row["CityName"] = "请选择";
            ds.Tables["CityInfo"].Rows.InsertAt(row, 0);

            DataRow row1 = ds.Tables["CityInfo2"].NewRow();
            row1["Id"] = -1;
            row1["CityName"] = "请选择";
            ds.Tables["CityInfo2"].Rows.InsertAt(row1, 0);

            //向下拉框填充数据
            this.comboBox1.DataSource = ds.Tables["CityInfo"];
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.DisplayMember = "CityName";

            this.comboBox2.DataSource = ds.Tables["CityInfo2"];
            this.comboBox2.ValueMember = "Id";
            this.comboBox2.DisplayMember = "CityName";

        }

        private void but1_Click(object sender, EventArgs e)
        {

            int go = Convert.ToInt32(comboBox1.SelectedValue);
            int qu = Convert.ToInt32(comboBox2.SelectedValue);
            string str = "Data Source=.;Initial Catalog=Ticket;Integrated Security=True";//连接数据库语句
            string sql = @" select f.FlightNo,a.Airways ,f.LeaveTime,f.LandTime,f.Price from AirwaysInfo as a,FlightInfo as f 
                where a.Id=f.AirwaysId and LeaveCity='" + go + "' and Destination='" + qu + "'";
            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "aa");//保存在临时数据表
            dgv1.DataSource = ds.Tables["aa"];

        }

        private void dgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string no = dgv1.SelectedRows[0].Cells[0].Value.ToString();
            string hangban = dgv1.SelectedRows[0].Cells[1].Value.ToString();
            string chu = Convert.ToString(dgv1.SelectedRows[0].Cells[2].Value);
            string mudidi = dgv1.SelectedRows[0].Cells[3].Value.ToString();
            int piaojia = Convert.ToInt32(dgv1.SelectedRows[0].Cells[4].Value);
            txt1.Text = no;//航班号
            txt5.Text = hangban;//航班公司
            txt2.Text = comboBox1.Text;//出发地
            txt6.Text = comboBox2.Text;//目的地
            txt3.Text = Convert.ToString(chu);//出发时间
            txt7.Text = mudidi;//到达时间
            txt4.Text = piaojia.ToString();//成人票价

        }

        private void but2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            string date = dtp1.Value.ToString();//时间控件转字符串
            conn.Open();
            Random rd = new Random();
            int num1 = rd.Next(10000, 10000000);//随机数
            string sql =@"insert into  OrderInfo ([OrderId],[FlightNo],
                [LeaveDate],[Number])values('" + num1 + "','" + txt1.Text + "','" + date + "','" + nup1.Text + "')";
            try
            {

                if (txt1.Text==string.Empty)
                {
                    MessageBox.Show("请选择一个航班！");
                }
                else
                {

                    if (DateTime.Now < dtp1.Value)
                    {
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        int num = cmd.ExecuteNonQuery();
                        if (num > 0)
                        {
                            MessageBox.Show("增加'" + nup1.Text + "'张成功!");
                        }
                        else
                        {
                            MessageBox.Show("增加失败！");
                        }
                    }
                    else {
                        MessageBox.Show("时间格式不对！");
                    }
                    
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("异常！"+ex, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }


        }

        private void but3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出吗！！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
