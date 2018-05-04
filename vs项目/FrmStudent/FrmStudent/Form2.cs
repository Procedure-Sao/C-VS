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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < this.imageList1.Images.Count - 1)
            {
                index++;
            }
            else {
                index = 0;
            }
            this.pictureBox1.Image = imageList1.Images[index];
        }
 public string con = "Data Source=.;Initial Catalog=QQDB;Integrated Security=True";
        private void Form2_Load(object sender, EventArgs e)
        {


            NewMethod();
            SqlConnection conn = new SqlConnection(con);
            string sql = "select * from UserInfo";
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            da.Fill(ds,"xinxi");
            dataGridView1.DataSource = ds.Tables["xinxi"];

        }

        private void NewMethod()
        {
            SqlConnection conn = new SqlConnection(con);

            string sql = "select * from UserInfo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            da.Fill(ds, "pwd");

            DataRow row = ds.Tables["pwd"].NewRow();
            row[0] = -1;
            row[1] = "全部";
            ds.Tables["pwd"].Rows.InsertAt(row, 0);

            cmb1.DataSource = ds.Tables["pwd"];
            cmb1.DisplayMember = "UserName";
            cmb1.ValueMember = "UserId";
        }

      
    }
}
