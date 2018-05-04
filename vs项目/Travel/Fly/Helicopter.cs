using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly
{
    //客机
    class Helicopter:Vehicle
    {
        public override void fly()//重写父类抽象方法
        {
            Console.WriteLine("客机运输乘客");
        }
    }
}
