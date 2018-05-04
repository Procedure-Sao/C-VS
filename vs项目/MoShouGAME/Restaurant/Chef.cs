using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    public class Chef
    {
        private Order order;
        public void GetOrder(Order order)
        {
            this.order = order;
        }
        public void Cook() 
        {
            Console.WriteLine("厨师烹饪：《{0}》",order.mealList);
            Console.WriteLine("制作完成");
        }
        //提醒饭菜制作完成
        public void SendAlear(Waitress waitress)
        {
            Console.WriteLine("厨师提示服务员取菜");
            waitress.GetOrder(order);
        }
    }
}
