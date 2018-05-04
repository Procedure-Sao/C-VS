using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
  public  class Truck:Vehicle
    {
        private int load;//载重
        public Truck() { 
        
        }
        public Truck(string licen, string name, string color, int date, double rent,int load):base( licen,  name,  color,  date,  rent)
        {
            this.load = load;
        }

        public override double money()
        {
            double sum=yearsofservice*dailyrent;
            return sum;
        }

        public int Load
        {
            get { return load; }
            set { load = value; }
        }
    }
}
