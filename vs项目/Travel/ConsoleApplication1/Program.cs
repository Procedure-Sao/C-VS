using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  internal   class Program
    {

      private static int Max = 100; 
        public Program(string name) 
        {
            this.Name = name;                          //1
        }
       private string name;
        public  string Name
        {
            set { name = value; }                         //2
        }

        static void Main(string[] args)
        {
            Program teacher = new Program("Jason");       //3
            Console.WriteLine(teacher.Name);             //4
        }
}
    }
}
