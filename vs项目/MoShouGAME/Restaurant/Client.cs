using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    public class Client
    {
        public void Order(Waitress waitress, Order order)
        {
            Console.WriteLine("顾客开始点菜《{0}》",order.mealList);
            waitress.GetOrder(order);
        }
        public void Eat() {
            Console.WriteLine("客人用餐！");
        }
    }
}
