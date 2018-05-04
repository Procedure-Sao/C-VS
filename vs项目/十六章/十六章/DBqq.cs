using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十六章
{
    class DBqq
    {

        private string strConn = "Data Source=.;Initial Catalog=QQDB;User ID=sa;Password=825516949";

        SqlConnection conn = null;

        SqlCommand cmd = null;
        #region 检查管理员信息
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        
        public bool CheckAdmin( string name,string pwd)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                string sql = " select count(*) from admin where LoginId='" + name + "' and LoginPwd='" + pwd + "'";
     

                // 创建SqlCommand对象
                SqlCommand comm = new SqlCommand(sql, conn);
                int Reat = (int)comm.ExecuteScalar();
                if (Reat != 1)
                {
                  
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception )
            {

                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 获取学生信息列表
        /// <summary>
        /// 获取学生信息列表
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetUser()
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                string sql = "select u.UserId,u.UserName,l.LevelName,u.Email,u.OnLineDay from UserInfo as u inner join Level as l on(u.LevelId=l.LevelId)";
                cmd = new SqlCommand(sql,conn);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                return null;
            }
        }


        #endregion

        #region 更新在线天数
        public int update(string name, string ui)
        {
            conn = new SqlConnection(strConn);
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("update UserInfo set [OnLineDay]='" + ui + "'  where [UserId]='" + name + "'");

                cmd = new SqlCommand(sb.ToString(), conn);
                return cmd.ExecuteNonQuery();

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

        #region 添加用户
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPwd"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public int InsertUser(string userName,string userPwd,string email)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                string sql = "insert into  [admin] values ('" + userName + "','" + userPwd + "'，'" + email + "')";
                cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return -1;
            }
        }

        #endregion

        #region    更新等级
        public int UpdateUserLevel(int userId, int iLevel)
        {
            try
            {
                conn.Open();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" UPDATE");
                sb.AppendLine("          from [UserInfo]");
                sb.AppendLine(" SET");
                sb.AppendLine("           [LevelId]=" + iLevel);
                sb.AppendLine(" WHERE");
                sb.AppendLine("           [UserId]=" + userId);
                cmd = new SqlCommand(sb.ToString(), conn);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
        }




        #endregion

        #region 删除用户信息
        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <returns></returns>
        public int DeleteUserInfo(string shu)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                string sql = "delete  from UserInfo where [UserId]= '" + shu + "'";
                cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return -1;
            }
        }
        #endregion

        #region 获取账户Id和在线天数
        public SqlDataReader GetUserIdAndOnlineDay()
        {
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT");
                sb.AppendLine("           UserId");
                sb.AppendLine("          ,OnLineDay");
                sb.AppendLine(" FROM");
                sb.AppendLine("           UserInfo ");
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                return comm.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
   



    }
}

    