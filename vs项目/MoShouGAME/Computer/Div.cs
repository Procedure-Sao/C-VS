using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Div : Number
    {
        public override double cal()
        {
            if (Sum==0)
            {
                throw new Exception("除数不能为零");
            }
            else
            {
                 return this.Num / this.Sum;
            }
           
        }
    }
}
