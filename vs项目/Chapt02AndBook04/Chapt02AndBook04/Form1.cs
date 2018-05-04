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

namespace Chapt02AndBook04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
 
        public void FindGradeName()
        {
            SqlConnection conn = new SqlConnection(coon.co);
             try
            {
               string sql = "select GradeName from Grade";
                conn.Open();
                SqlCommand command = new SqlCommand(sql,conn);
                SqlDataReader reader = command.ExecuteReader();
                if(reader != null){
                    if(reader.HasRows)
                    {
                        cboClass.Items.Add("请选择");
                        cboClass.SelectedIndex = 0;
                        while(reader.Read())
                        {
                            string gradeName = reader["GradeName"].ToString();
                            cboClass.Items.Add(gradeName);
                        }
                        reader.Close();
                        conn.Close();
                      
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("系统发生错误！","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        
        }


        public int FindGradeId(string gName)
        {
            SqlConnection conn = new SqlConnection(coon.co);
            string sql = "select GradeId from Grade where GradeName = '"+gName+"'";
            int pid = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {

                pid = Convert.ToInt32(dr["GradeId"]);
                }
                dr.Close();
                return pid;
            }
            catch (Exception)
            {
                MessageBox.Show("异常");
                throw;
            }
            finally
            {
                conn.Close();
            }
           
        }


        public void AddStudent()
        {
            SqlConnection conn = new SqlConnection(coon.co);
            int stuNo = Convert.ToInt32(txtstuNo.Text);
            string pwd = txtpwd.Text;
            string name = txtName.Text;
            string sex="";
            if (rdoman.Checked)
            {
                sex = "男";
            }
            else if(rdowoman.Checked)
            {
                sex = "女";
            }
            int gId = Convert.ToInt32(FindGradeId(cboClass.Text));
            string date = dtp1.Value.ToString();
            string phone = txtPhone.Text;
            string sql = @"insert into Student (StudentNo,LoginPwd,StudentName,Sex,GradeId,Phone,BornDate) 
            values ('"+stuNo+"','"+pwd+"','"+name+"','"+sex+"','"+gId+"','"+phone+"','"+date+"');";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                int num = command.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("增加成功!");
                }
                else
                {
                    MessageBox.Show("增加失败！");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("异常！");
            }
            finally
            {
                conn.Close();
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FindGradeName();
        }

        private void btoLogin_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

      
    }
}
