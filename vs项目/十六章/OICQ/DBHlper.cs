using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICQ
{
    class DBHlper
    {
        string strString = "server=.;database=QQDB;uid=sa;pwd=19981120";
        SqlConnection conn = null;
        SqlCommand comm = null;
        

        #region 测试数据库状态
        public void ceshi()
        {
            conn = new SqlConnection(strString);
            conn.Open();
            Console.WriteLine("打开数据库");
            conn.Close();
            Console.WriteLine("关闭数据库");
            Console.ReadLine();
        }
        #endregion

        #region 登录
        public bool chauser(string username, string pwd, ref string strMsg)
        {
            // 创建SqlCconnection对象
            conn = new SqlConnection(strString);
            try
            {
                // 创建sql语句
                string sql = "select count(*) from admin where LoginId = '" + username + "' and LoginPwd = '" + pwd + "'";
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

        #region 查看信息
        public void lookstu()
        {   //创建对象
            conn = new SqlConnection(strString);
            SqlDataReader reader = null;
            try
            {
                
                
                conn.Open();
                StringBuilder sb = new StringBuilder();
                //查询学生信息
                sb.AppendLine("select UserName,UserPwd,LevelId,Email,OnLineDay from UserInfo");
                comm = new SqlCommand(sb.ToString(),conn);
                reader = comm.ExecuteReader();
                Console.WriteLine("========================================================================================");
                Console.WriteLine("姓名\t\t\t密码\t\t等级\t\t邮箱\t\t\t在线天数");
                Console.WriteLine("========================================================================================");
                StringBuilder sb1 = new StringBuilder();
                //循环 学生信息
                while(reader.Read())
                {
                    sb1.AppendFormat("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}",reader["UserName"],reader["UserPwd"],reader["LevelId"],reader["Email"],reader["OnLineDay"]);
                    Console.WriteLine(sb1);
                    sb1.Length = 0;
                }

                Console.WriteLine("========================================================================================");
                
            }
            catch (Exception)
            {
                Console.WriteLine("数据库操作失败");

            }
            finally
            {
                reader.Close();
                conn.Close();
            }

        }
        #endregion

        #region 修改信息
        public int update(string name, string ui)
        {
            conn = new SqlConnection(strString);
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("update UserInfo set [OnLineDay]='"+ui+"'  where [UserId]='"+name+"'");
              
                comm = new SqlCommand(sb.ToString(), conn);
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

        #region 新添信息
        public int xin(string gradeName, string pwd)
        {
            conn = new SqlConnection(strString);
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                //调用sql方法
                sb.AppendLine("insert into");
                sb.AppendLine("     [admin]");
                sb.AppendLine("values");
                //获取参数
                sb.AppendLine("('" + gradeName + "','"+pwd+"')");
                comm = new SqlCommand(sb.ToString(), conn);
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


        #region 升级人数
        public int upup()
        {
            conn = new SqlConnection(strString);
            try
            {
                string ming = "select count(*) from UserInfo where OnLineDay>10 ";
                conn.Open();
                comm = new SqlCommand(ming, conn);
                int isr = (int)comm.ExecuteScalar();
                return isr;


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


        #region 删除信息
        public int delete(string chu)
        {
            conn = new SqlConnection(strString);
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("delete");
                sb.AppendLine(" from");
                sb.AppendLine(" UserInfo");
                sb.AppendLine("where");
                sb.AppendLine(" [UserId]= '" + chu + "'");
                comm = new SqlCommand(sb.ToString(), conn);
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
