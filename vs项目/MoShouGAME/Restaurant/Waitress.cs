using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    public class Waitress
    {
        private Order order;
        //记录客人点餐
        public void GetOrder(Order order)
        {
            this.order = order;
        }
        //传菜
        public void TransCook()
        {
            Console.WriteLine("服务员将菜《{0}》送给客户{1}", order.mealList, order.id);
            order.guke.Eat();
        } 
        //给厨师提供菜单
        public void SendOrder(Chef chef) 
        {
            Console.WriteLine("服务员将菜《{0}》传给厨师",order.mealList);
            chef.GetOrder(order);
        }
       
    }
}
