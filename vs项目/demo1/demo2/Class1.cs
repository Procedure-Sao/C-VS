using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    class Class1
    {
       public string password ="123456";
        double balance=5000;
        public double show(double money)
        {
            if (money > 0)
            {
                if (money <= balance)
                {
                    return balance;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
