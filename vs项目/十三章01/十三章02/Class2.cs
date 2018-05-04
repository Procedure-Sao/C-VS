using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十三章02
{
    class Class2
    {
        /// <summary>
        /// 登录方法
        /// </summary>
        public void Login()
        {
            Console.WriteLine("请输入用户名：");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string password = Console.ReadLine();
            // 返回的结果信息
            string msg = string.Empty;
            // 它的定义和初始化等价于 string str = null/str = "";
            // 创建DBhlper对象
            Class1 c1 = new Class1();
            // 获取值
            bool isReact = c1.ChenkUserInfo(userName, password, ref msg);
            // 判断
            if (isReact)
            {
                Console.WriteLine("登录成功！");
            }
            else
            {
                Console.WriteLine("登录失败!!!" + msg);
            }

        }

        public void ShowStudent()
        {
            Class1 _dbOper = new Class1();
            //调用Class1类的方法
            SqlDataReader reader = null;
            reader = _dbOper.GetStudentListReturn();
            if (reader == null)
            {
                Console.WriteLine("出现异常了，额。。。");
                return;
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("学号\t         姓名");
            Console.WriteLine("-------------------------------");
            //创建StringBuilder的对象
            StringBuilder sb = new StringBuilder();
            //循环读取DataReader
            while (reader.Read())
            {
                sb.AppendFormat("{0}\t{1}", reader["StudentNo"], reader["StudentName"]);
                Console.WriteLine(sb);
                sb.Length = 0;
            }
            Console.WriteLine("-------------------------------");
            //关闭DataReader对象
            reader.Close();

        }

    }
}
