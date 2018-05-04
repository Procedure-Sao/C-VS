using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十三章02
{
    class Class1
    {
        // 数据库连接字符串
        
       public  static string connstring = "Data Source=.;Initial Catalog=MySchool;Persist Security Info=True;User ID=sa;Password=825516949";
 // 创建sqlConnection连接对象
          SqlConnection conn = new SqlConnection(connstring);

          SqlDataReader reader = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <param name="strMsg"></param>
        /// <returns></returns>
        
        //登陆
        public bool ChenkUserInfo(string username, string pwd, ref string strMsg)
        {
            try
            { 
                // 打开数据库
                conn.Open();
                // 创建sql语句
                string sql = "select count(*) from Admin where LoginId = '" + username + "' and LoginPwd = '" + pwd + "'";
              

                // 创建SqlCommand对象
                SqlCommand comm = new SqlCommand(sql, conn);
                int Reat = (int)comm.ExecuteScalar();
                if (Reat != 1)
                {
                    strMsg = "用户名密码错误！！！";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                strMsg = "发生异常！！！";
                return false;
            }
            finally
            {
                // 关闭数据库
                conn.Close();
            }
        }


        //获取学生名单
        public void getstudentlist()
        {
            
            conn.Open();
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("select");
                sb.AppendLine("      [StudentNo]       ");
                sb.AppendLine("      ,[StudentName]      ");
                sb.AppendLine("from");
                sb.AppendLine("    Student");

                // 创建SqlCommand对象
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                reader = comm.ExecuteReader();
                if (reader == null)
                {
                    Console.WriteLine("空");
                    return;
                }
                Console.WriteLine("-------------------------------");
                Console.WriteLine("学号\t         姓名");
                Console.WriteLine("-------------------------------");
                StringBuilder sb1 = new StringBuilder();
                //循环读取DataReader
                while (reader.Read())
                {
                    sb1.AppendFormat("{0}\t{1}", reader["StudentNo"], reader["StudentName"]);
                    Console.WriteLine(sb1);
                    sb1.Length = 0;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("数据库操作失败！！！"+ex);
            }
            finally {
                reader.Close();
                conn.Close();
            }
        }


        public SqlDataReader GetStudentListReturn()
        {
            SqlConnection conn = new SqlConnection(connstring);//创建SqlConnection对象，将数据源放入
            //数据库异常处理
            try
            {
                conn.Open();//打开数据库连接
                StringBuilder sb = new StringBuilder();//创建StringBuilder的对象
                sb.AppendLine("select");
                sb.AppendLine(" [StudentNo]");
                sb.AppendLine(" ,[StudentName]  ");
                sb.AppendLine("from");
                sb.AppendLine(" [Student]");
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                /*CommandBeHavior.CloseConnection:在执行命令时，若关闭关联的DataReader对象，则关联的Connection对象也将关闭*/
                return comm.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                return null;
            }

        }


    }

 }

