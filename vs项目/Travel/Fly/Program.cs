using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> list=new List<Vehicle>()
            {
                new Fighter(),//创建3个对象
                new Airliner(),
                new Helicopter()
            };
            Console.WriteLine("飞行器在天空自由飞翔");
            Console.WriteLine( );
            foreach (Vehicle item in list)//循环调用fly方法
            {
                item.fly();
            }
            Console.ReadKey();
        }
    }
}
