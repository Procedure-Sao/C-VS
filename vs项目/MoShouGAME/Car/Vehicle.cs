using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
   public   abstract class Vehicle
    {
       public   string color;//颜色
       public double dailyrent;//租金
       public string licensno;//车牌号
       public string name;//车名
       public int rentdate;//天数
       public string rentuser;//租用者
       public int yearsofservice;//天数
          public Vehicle() 
          {
          
          }
          public Vehicle(string licen, string name, string color, int date, double rent) 
          {
              this.licensno = licen;
              this.name = name;
              this.color = color;
              this.rentdate = date;
              this.dailyrent = rent;
          }
          public abstract double money();//计算价格
       
    }
}
