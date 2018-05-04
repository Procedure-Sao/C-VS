using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    class text
    {
        double result;

       Class1 cl = new Class1();
        public void show1() 
        {
            string account = "";
            string pwd;
            Console.WriteLine("请输入账号");
            account = Console.ReadLine();
            if (account.Length == 0) {
                Console.WriteLine("输入的账号不正确！");
                return;
            }
            Console.WriteLine("请输入账户密码");
            pwd = Console.ReadLine();
            if(cl.password !=pwd)
            {
                Console.WriteLine("密码有误");
                return;
            }
           Console.WriteLine("请输入取款金额");
        double money=double.Parse(Console.ReadLine());
        result = cl.show(money);
        if(result==-1)
    {
        Console.WriteLine("取款失败");
    }
    else
{
    Console.WriteLine("取款成功"+money);
    }
    }

        static void Main(string[] args)
        {
            text tt = new text();
            tt.show1();
            Console.ReadLine();

        }
    }
}
