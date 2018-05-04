using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四章
{
    class Class1
    {
        public  string show(string name)
        {
            string[] names = name.Split(' ');
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].Substring(0,1).ToUpper() + names[i].Substring(1).ToLower();

            }
            string names1 = string.Join("", names);
            return names1;
        }
       static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Console.WriteLine("请输入你的名字");
            string name = Console.ReadLine();
            
            Console.WriteLine("格式化后你的名字");
            string name1 = c1.show(name);
            Console.WriteLine(name1);
            Console.ReadLine();
        }

     
    }
}
