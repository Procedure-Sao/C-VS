using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly
{
    //直升机
    class Airliner:Vehicle

    {

        public override void fly()//重写父类抽象方法
        {
            Console.WriteLine("直升机执行任务");
        }
    }
}
