using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckupServices
{
    public class HealthSet
    {
        public HealthSet()
        {
            Item = new List<HealthItem>();
        }
        public List<HealthItem> Item { get; set; }//item的集合
        public string Name { get; set; }//套餐名称
        public int Price { get; set; }//套餐价格
      
        public void CalcPrice() //计算价格
        {
            this.Price = 0;
            foreach (HealthItem item in this.Item)
            {
                this.Price += item.Price;
            }
        }
      
    }
}
