using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十四章
{
    class DbOperation
    {
        // 数据库连接字符串
        public static string connstring = "Data Source=.;Initial Catalog=MySchool;Persist Security Info=True;User ID=sa;Password=825516949";
        // 创建sqlConnection连接对象
        SqlConnection conn = new SqlConnection(connstring);
        SqlDataReader reader = null;
        #region 按学号查询学生信息
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stuNo"></param>
        /// <returns></returns>
        public string GetStudentNameByNo(string stuNo) {
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();//创建StringBuilder的对象
                sb.AppendLine("select");
                sb.AppendLine(" [StudentNo]");
                sb.AppendLine(" ,[StudentName]  ");
                sb.AppendLine("from");
                sb.AppendLine(" [Student]");
                sb.AppendLine("WHERE");
                sb.AppendLine(" [StudentNo]='"+stuNo+"'");
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                SqlDataReader reader = comm.ExecuteReader();
                string stuName = string.Empty;
                if (reader.Read())
                {
                    stuName = Convert.ToString(reader["studentName"]);
                }
                reader.Close();


                return stuName;
            }
            catch (Exception)
            {
                return string.Empty;

            }
            finally {

                conn.Close();
            }
        }
        #endregion
        #region 按姓名查询学生信息
        public SqlDataReader GetStudentInfoByName(string stuName) {

            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("select");
                sb.AppendLine("      A.[StudentNo]");
                sb.AppendLine("     , A.[StudentName]  ");
                sb.AppendLine("     , A.[Sex]  ");
                sb.AppendLine("     , B.[GradeName]  ");
                sb.AppendLine("     , A.[Phone]  ");
                sb.AppendLine("     , A.[Address]  ");
                sb.AppendLine("     , A.[BornDate]  ");
                sb.AppendLine("     , A.[Email]  ");
                sb.AppendLine("from");
                sb.AppendLine(" [Student] as A, [Grade] as B");
                sb.AppendLine("WHERE");
                sb.AppendLine(" [StudentName]   like  '%" + stuName + "%'");
                sb.AppendLine("  and");
                sb.AppendLine("A.[GradeId]=B.[GradeId]");
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                return comm.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception )
            {

                return null;
            }
        
             

        }
        #endregion
        #region 登陆
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <param name="strMsg"></param>
        /// <returns></returns>
        public bool ChenkUserInfo(string username, string pwd, ref string strMsg)
        {
            try
            {
                // 创建sql语句
                string sql = "select count(*) from Admin where LoginId = '" + username + "' and LoginPwd = '" + pwd + "'";
                // 打开数据库
                conn.Open();

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
        #endregion
        #region 获取学生名单
        public void getstudentlist()
        {
            conn = new SqlConnection(connstring);
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
                Console.WriteLine("数据库操作失败！！！" + ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
        }
        #endregion
        #region   示例3
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
        #endregion
        #region 查询学生总数
        public int GetStudentCount() {

            try
            {
                string strsql = "select count(*) from Student";
                conn.Open();
                SqlCommand comm = new SqlCommand(strsql, conn);
                int iret = (int)comm.ExecuteScalar();
                return iret;
            }
            catch (Exception)
            {

                return -1;
            }
            finally {

                conn.Close();
            }
        }
        #endregion
        #region 新增年级信息
        public int InsertGrade( string graderName) {
            conn = new SqlConnection(connstring);
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();//创建StringBuilder的对象
                sb.AppendLine("    insert into  ");
                sb.AppendLine("  [Grade]");
                sb.AppendLine("    values   ");
                sb.AppendLine("   ('" + graderName + "')  ");
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            finally {

                conn.Close();
            }
        }
        #endregion
        #region 删除学生信息
        public int InsertDelete(string graderName)
        {
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();//创建StringBuilder的对象
                sb.AppendLine("  delete  ");
                sb.AppendLine("  from   ");
                sb.AppendLine("  [Grade]   ");
                sb.AppendLine("  where   ");
                sb.AppendLine("   [GradeName]='" + graderName + "'");
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {

                conn.Close();
            }
        }
        #endregion
        #region 修改学生信息
        public int Insertupdate(string graderName,string pwd)
        {
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();//创建StringBuilder的对象
                sb.AppendLine("  update  ");
                sb.AppendLine("  Admin ");
                sb.AppendLine("  set   ");
                sb.AppendLine("  [LoginPwd]= '" + pwd +  "'");
                sb.AppendLine("  where   ");
                sb.AppendLine("  [LoginId] = '" + graderName + "'");
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {

                conn.Close();
            }
        }
        #endregion
    }
}
