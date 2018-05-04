using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly
{
    //战斗机
    class Fighter:Vehicle
    {
        public override void fly()//重写父类抽象方法
        {
            Console.WriteLine("战斗机保卫着国土");
        }
    }
}
