using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
   public class ScheduleItem
    {
       public ScheduleItem()
       {
           Movies = new Movie();
       }

       public string Time { get; set; }//放映时间
       public Movie Movies { get; set; }//放映电影属性
    }
}
