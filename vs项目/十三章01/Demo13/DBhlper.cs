using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13
{
    /// <summary>
    /// 工具类
    /// </summary>
    class DBhlper
    {
        // 连接字符串
        public static string connstring = "Data Source=.;Initial Catalog=MySchool;Persist Security Info=True;User ID=sa;Password=825516949";

        // SqlConnection对象
        SqlConnection conn = null;

        /// <summary>
        /// 用户验证
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="strMsg">需要返回处理的信息</param>
        /// <returns>返回结果（成功&失败）</returns>
        public bool ChenkUserInfo(string username, string pwd,ref string strMsg)
        {
            // 创建SqlCconnection对象
            conn = new SqlConnection(strString);
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


        #region 获取学生名单

        public void GetStudentLinst() 
        {
            // 创建SqlConnection连接对象
            conn = new SqlConnection(strString);
            try
            {
                // 打开数据库
                conn.Open();

                // 创建StringBuilder对象
                StringBuilder str = new StringBuilder();
                str.AppendLine("select");
                str.AppendLine("    count(*)    ");
                str.AppendLine("from");
                str.AppendLine("    Student");

                // 创建SqlCommand对象
                SqlCommand comm = new SqlCommand(str.ToString(), conn);

            }
            catch (Exception ex)
            {

                Console.WriteLine("数据操作异常！" + ex);
            }
            finally
            {
                conn.Close();
            }
        }


        #endregion






        #region 打开数据库连接
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OopenConnection()
        {
            // 创建SqlConnection连接对象
            conn = new SqlConnection(strString);

            try
            {
                conn.Open();
                Console.WriteLine("打开数据库连接成功！");
            }
            catch (Exception ex)
            {
                Console.WriteLine("异常：" + ex.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("关闭成功！！！");
                Console.ReadLine();
            }

        #endregion
        }

      


    }
}
