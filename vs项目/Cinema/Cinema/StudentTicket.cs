using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
 public   class StudentTicket:Ticket
    {
     public int Discount { get; set; }//折扣

     public StudentTicket()
     {
     }

     public StudentTicket(ScheduleItem scheduleItem, Seat seat, int discount): base(scheduleItem, seat)
     {
         this.Discount = discount;
     }

     public override string CalcPrice()
     {
         Price = ScheduleItem.Movies.Price * Discount / 10;
         return Price.ToString();
     }

     public override void Print()
     {
         string fileName = ScheduleItem.Time.Replace(":", "-") + " " + Seat.SeatNum + ".txt";
         FileStream fs = new FileStream(fileName, FileMode.Create);
         StreamWriter sw = new StreamWriter(fs);
         sw.WriteLine("***************************");
         sw.WriteLine("     青鸟影院 (学生)    ");
         sw.WriteLine("---------------------------");
         sw.WriteLine(" 电影名：\t{0}", ScheduleItem.Movies.Name);
         sw.WriteLine(" 时间：  \t{0}", ScheduleItem.Time);
         sw.WriteLine(" 座位号：\t{0}", Seat.SeatNum);
         sw.WriteLine(" 价格：  \t{0}", Price.ToString());
         sw.WriteLine("***************************");
         sw.Close();
         fs.Close();
     }

     public override void Show()
     {
         MessageBox.Show("已售出!\n\n " + Discount + "折学生票!");
     }

    }
}
