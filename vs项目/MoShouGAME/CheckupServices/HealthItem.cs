using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckupServices
{
   public class HealthItem
    {
        private string miaoshu;//描述

        public string Miaoshu
        {
            get { return miaoshu; }
            set { miaoshu = value; }
        }
        private string name;//名字

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int price;//价格

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        
    }
}
