using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
 public   class FreeTicket:Ticket
    {
     public string CustomerName { get; set; }//赠票者的名字属性

     public FreeTicket(ScheduleItem scheduleItem, Seat seat, string customername): base(scheduleItem, seat)
     {
         this.CustomerName = customername;
     }

     public override string CalcPrice()
     {
         Price = 0;
         return Price.ToString();
     }

     public override void Print()
     {
         string fileName = ScheduleItem.Time.Replace(":", "-") + " " + Seat.SeatNum + ".txt";
         FileStream fs = new FileStream(fileName, FileMode.Create);
         StreamWriter sw = new StreamWriter(fs);
         sw.WriteLine("***************************");
         sw.WriteLine("     青鸟影院 (赠票)");
         sw.WriteLine("---------------------------");
         sw.WriteLine(" 电影名：\t{0}", ScheduleItem.Movies.Name);
         sw.WriteLine(" 时间：  \t{0}", ScheduleItem.Time);
         sw.WriteLine(" 座位号：\t{0}", Seat.SeatNum);
         sw.WriteLine(" 姓名：  \t{0}", CustomerName);
         sw.WriteLine("***************************");
         sw.Close();
         fs.Close();
     }

     public override void Show()
     {
         MessageBox.Show("已售出!\n\n 赠送者：" + CustomerName);
     }
     
    }
}
