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

namespace Mobile
{
    public partial class ReadMessage : Form
    {
        public ReadMessage()
        {
            InitializeComponent();
        }

        private void ReadMessage_Load(object sender, EventArgs e)
        {
            showadd();
            SqlConnection conn = new SqlConnection(DBhelp.con);
            string sql = "  select * from mobilebrand ";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataRow rows = ds.Tables[0].NewRow();
            rows[0] = -1;
            rows[1] = "全部类型";
            ds.Tables[0].Rows.InsertAt(rows, 0);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Brand";
            comboBox1.ValueMember = "BrandID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string name;
        public string xingaho;
        public string jiage;
        public string chicun;
        public string zhongliang;
        public string zhongduan;

        public void showadd() {
            SqlConnection conn = new SqlConnection(DBhelp.con);
            try
            {

                conn.Open();
                string sql = "  select brand,type,price,size,weight,style from mobileinfo,mobilebrand where mobilebrand.brandId=mobileinfo.brandid ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    name = reader["brand"].ToString();
                    xingaho = reader["type"].ToString();
                    jiage = reader["price"].ToString();
                    chicun = reader["size"].ToString();
                    zhongliang = reader["weight"].ToString();
                    zhongduan = reader["style"].ToString();

                    ListViewItem item = new ListViewItem(name);
                    item.SubItems.Add(xingaho);
                    item.SubItems.Add(jiage);
                    item.SubItems.Add(chicun);
                    item.SubItems.Add(zhongliang);
                    item.SubItems.Add(zhongduan);
                    listView1.Items.Add(item);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
