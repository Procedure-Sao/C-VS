using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Client wang = new Client();
            Waitress waitress = new Waitress();
            Waitress zhang = new Waitress();
            Chef chef = new Chef();
            Order order = new Order();
            //顾客点菜
            order.guke = wang;
            order.id = 10;
            order.mealList = "满汉全席";
            //zhang来服务
            wang.Order(zhang, order);
            //告诉厨师
            zhang.SendOrder(chef);
            //厨师烹饪菜品
            chef.Cook();
            chef.SendAlear(zhang);
            zhang.TransCook();
            Console.ReadLine();
        }
    }
}
