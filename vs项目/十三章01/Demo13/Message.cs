using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13
{
    class Message
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
            DBhlper db = new DBhlper();
            // 获取值
            bool isReact = db.ChenkUserInfo(userName,password,ref msg);
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

    }
}
