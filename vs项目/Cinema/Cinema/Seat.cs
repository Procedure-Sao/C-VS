using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
 public   class Seat
    {


     public Seat(string num,System.Drawing.Color color)
     {
         this.SeatNum = num;
         this.Color = color;
     }

     public string  SeatNum { get; set; }//座位号
     public System.Drawing.Color  Color { get; set; }//颜色
    }
}
