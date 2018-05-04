using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckupServices
{
    public class HealthSet
    {
        public HealthSet(string name)
        {
            Item = new Dictionary<string, HealthItem>();
            this.Name = name;
        }
         public HealthSet(string name, Dictionary<string, HealthItem> items)
        {
            this.Name = name;
            this.Item = items;
        }
         public Dictionary<string, HealthItem> Item { get; set; }//item的集合
        public string Name { get; set; }//套餐名称
        public int Price { get; set; }//套餐价格
      
        public void CalcPrice() //计算价格
        {
            int totalPrice = 0;
            foreach (HealthItem item in Item.Values)
            {
                totalPrice += item.Price;
            }
            this.Price = totalPrice;
        }
      
    }
}
