using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十六章2
{
    class Class2
    {
        private const string strConn = "Data Source=.;Initial Catalog=QQDB;User ID=sa;Password=825516949";

        //得到用户列表  
        public SqlDataReader GetUserList()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT");
                sb.AppendLine("           a.[UserId]");
                sb.AppendLine("          ,a.[UserName]");
                sb.AppendLine("          ,b.[LevelName]");
                sb.AppendLine("          ,a.[Email]");
                sb.AppendLine("          ,a.[OnLineDay]");
                sb.AppendLine(" FROM");
                sb.AppendLine("             [UserInfo] a, [Level] b ");
                sb.AppendLine(" WHERE");
                sb.AppendLine("           a.[LevelId] = b.[LevelId]");
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                return comm.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;

            }
        }
        //显示用户信息  
        public void ShowUserInfo()
        {
            StringBuilder sb = new StringBuilder();
            SqlDataReader reader = GetUserList();
            if (reader == null)
            {
                Console.WriteLine("出现异常");
                return;
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("编号\t\t昵称\t\t等级\t\t邮箱\t\t在线天数");
            while (reader.Read())
            {
                sb.AppendFormat("{0}\t{1}\t{2}\t{3}\t{4}", reader["UserId"], reader["UserName"], reader["LevelName"], reader["Email"], reader["OnLineDay"]);
                Console.WriteLine(sb.ToString());
                sb.Length = 0;
            }
            Console.WriteLine("-----------------------------------------------------");
            reader.Close();
        }

        //更改在线天数  
        public int UpdateOnlineDay(int userId, double newOnlineDay)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("UPDATE");
                sb.AppendLine("           [UserInfo]");
                sb.AppendLine("  SET");
                sb.AppendLine("          OnLineDay=" + newOnlineDay);
                sb.AppendLine(" WHERE");
                sb.AppendLine("          UserId=" + userId);

                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                // Console.WriteLine(sb.ToString());  
                return comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }


        //插入用户信息  
        public object InsertUserInfo(string userName, string userPwd, string email)
        {
            SqlConnection conn = new SqlConnection(strConn);
            try
            {
                conn.Open();

                StringBuilder sb = new StringBuilder();

                sb.AppendLine(" INSERT INTO");
                sb.AppendLine("          [UserInfo]");
                sb.AppendLine(" VALUES");
                sb.AppendLine("          ('" + userName + "','" + userPwd + "',1,'" + email + "',0);");

                sb.AppendLine(" SELECT @@Identity;");

                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                return comm.ExecuteScalar();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }


        //获取账户Id和在线天数  
        public SqlDataReader GetUserIdAndOnlineDay()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        //更改指定用户QQ等级  
        public int UpdateUserLevel(int userId, int iLevel)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" UPDATE");
                sb.AppendLine("          from [UserInfo]");
                sb.AppendLine(" SET");
                sb.AppendLine("           [LevelId]=" + iLevel);
                sb.AppendLine(" WHERE");
                sb.AppendLine("           [UserId]=" + userId);
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
        }


        //根据用户编号查找指定用户信息  
        public SqlDataReader GetUserByID(int UserID)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT");
                sb.AppendLine("           a.[UserId]");
                sb.AppendLine("          ,a.[UserName]");
                sb.AppendLine("          ,b.[LevelName]");
                sb.AppendLine("          ,a.[Email]");
                sb.AppendLine("          ,a.[OnLineDay]");
                sb.AppendLine("FROM");
                sb.AppendLine("             [UserInfo] as a, [Level] as b");
                sb.AppendLine(" WHERE");
                sb.AppendLine("           a.[UserId] = " + UserID);
                sb.AppendLine(" AND");
                sb.AppendLine("           a.[LevelId] = b.[LevelId]");
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                return comm.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        //删除用户  
        public int DeleteUserInfo(int strUserId)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                StringBuilder sb = new StringBuilder();

                sb.AppendLine("DELETE");
                sb.AppendLine("           [UserInfo]");
                sb.AppendLine("  WHERE");
                sb.AppendLine("          [UserId]=" + strUserId);
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);
                return comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
    }
}