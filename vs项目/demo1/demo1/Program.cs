using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入名字");
            string name =Console.ReadLine();
            Console.WriteLine("请输入qq等级");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("加号连接");
            Console.WriteLine(name+"您好!您的等级是"+age);
            Console.WriteLine("格式字符串");
            Console.WriteLine("{0}您好!您的等级是{1}",name,age);
            Console.ReadLine();
        }
    }
}
