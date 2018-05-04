using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十三章01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 数据库连接字符串
            string connstring = "Data Source=.;Initial Catalog=MySchool;Persist Security Info=True;User ID=sa;Password=825516949";
            // 创建sqlConnection连接对象
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                // 打开数据库连接
                conn.Open();
                Console.WriteLine("打开数据库");
            }
            catch (Exception ex)
            {
                Console.WriteLine("出现异常" + ex.Message);
            }
            finally
            {
                // 关闭数据库连接
                conn.Close();
                Console.WriteLine("关闭数据库");
                Console.ReadLine();
            }

        }
    }
}
