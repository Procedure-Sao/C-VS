using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.book.util
{
    public class DBhlper
    {
        //连接数据库语句
         private string strstring="Data Source=.;Initial Catalog=Dbhlper;User ID=sa;Password=825516949";
        //创建空连接
         private  SqlConnection conn;
         private SqlCommand comm;
         //   SqlConnection conn = new SqlConnection(connstring);
         #region 打开数据库
         public void bookopen() {

             //判断为空
             if (conn==null)
             {//创建对象
                  conn = new SqlConnection(strstring);
                 //打开数据库
                 conn.Open();
             }
                 //判断连接状态是否为断开
             else if (conn.State == ConnectionState.Broken)
             {
                 //关闭连接
                 conn.Close();
                 //打开连接
                 conn.Open();

             }
             else {
                 //打开连接
                 conn.Open();
             }
     
         }

    
     #endregion

         #region 关闭数据库
         public void bookclose(){
            //如果状态不为空  并且 为不关闭状态
            if (conn!=null && conn.State!= ConnectionState.Closed)
            {
                //关闭数据库
                conn.Close();
            }
             }
         #endregion

         #region 异常处理
         public SqlDataReader read(string sql) {
            try
            {
                //创建命令
                using (comm = new SqlCommand(sql,conn)) {
                    //执行sql语句，并返回结果
                    return comm.ExecuteReader();
                }
            }
            catch (Exception)
            {
                //遇到异常，返回空值
                return null;
            }
         }
         #endregion

         #region 增，删，改
         public int NonQuery(string sql)
         {
             try
             {
                 //创建命令
                 using (comm = new SqlCommand(sql, conn))
                 {
                     //执行sql语句，并返回结果
                     return comm.ExecuteNonQuery();
                 }
             }
             catch (Exception)
             {
                 //遇到异常，返回-1
                 return -1;
             }
         }
         #endregion
    }
}
