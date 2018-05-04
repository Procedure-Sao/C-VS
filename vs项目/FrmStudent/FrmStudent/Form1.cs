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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public string con = "Data Source=.;Initial Catalog=QQDB;Integrated Security=True";

        private void butname_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count>0)
            {
                listView1.Items.Clear();
            }
            string name =this.txtname.Text.Trim();
            SqlConnection conn=new SqlConnection(con);
             conn.Open();
             string sql = "select * from UserInfo where [UserName] like '%"+name+"%' ";
            try 
	       {	        
		    SqlCommand cmd=new SqlCommand(sql,conn);
            SqlDataReader reader =cmd.ExecuteReader();
     
                if (!reader.HasRows){
		 MessageBox.Show("没有需要查询的记录！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                	}else{
                        while (reader.Read())
                        {
                            string id = reader["UserId"].ToString();
                            string Name = reader["UserName"].ToString();
                            string pwd = reader["UserPwd"].ToString();
                            string dengji = reader["LevelId"].ToString();
                            string youxiang = reader["Email"].ToString();
                            string day = reader["OnLineDay"].ToString();

  
                            ListViewItem item = new ListViewItem(id);
                            item.SubItems.Add(Name);
                            item.SubItems.Add(pwd);
                            item.SubItems.Add(dengji);
                            item.SubItems.Add(youxiang);
                            item.SubItems.Add(day);

                            listView1.Items.Add(item);
                        }
                     
                }
                reader.Close();
	        }
	    catch (Exception)
	    {
      
	    	 MessageBox.Show("系统出现错误！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
	    }finally
            {
            conn.Close();
            }

        }
     
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xiugai();
        }

        public void xiugai() {

            if (this.listView1.SelectedItems.Count > 0)
            {
                Form3 f3 = new Form3();
                f3.num = Convert.ToInt32( listView1.SelectedItems[0].Text);
                f3.name = listView1.SelectedItems[0].SubItems[1].Text;
                f3.pwd = listView1.SelectedItems[0].SubItems[2].Text;
                f3.dengji = listView1.SelectedItems[0].SubItems[3].Text;
                f3.email = listView1.SelectedItems[0].SubItems[4].Text;
                f3.day = listView1.SelectedItems[0].SubItems[5].Text;
                f3.Show();
            }
            else
            {
                MessageBox.Show("请选择一个学生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
