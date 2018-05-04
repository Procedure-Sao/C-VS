using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Arc : Vehicle
    {
        public Arc()
        { 
        }
        public Arc(string licen, string name, string color, int date, double rent): base(licen, name, color, date, rent)
        { 
        
        }

        public override double money()
        {
            double sum = yearsofservice * dailyrent;
            return sum;
        }
    }
}
