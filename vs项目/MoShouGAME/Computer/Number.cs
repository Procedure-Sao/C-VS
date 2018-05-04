using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
   public abstract class Number
    {
        private double num;

        public double Num
        {
            get { return num; }
            set { num = value; }
        }
        private double sum;

        public double Sum
        {
            get { return sum; }
            set { sum = value; }
        }

        public abstract double cal();
       
    }
}
