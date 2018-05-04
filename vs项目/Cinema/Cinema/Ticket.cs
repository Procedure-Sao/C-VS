using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
 public   class Ticket
    {
        public Ticket()
        {

        }
        public Ticket(ScheduleItem scheduleItem, Seat seat)
        {
            ScheduleItem = scheduleItem;
            Seat = seat;
        }

        //播放场次
        public ScheduleItem ScheduleItem { get; set; }
        //所属座位对象
        public Seat Seat { get; set; }
        //票价
        public int Price { get; set; }

        //计算票价的虚方法
        public virtual string CalcPrice()
        {
            Price = ScheduleItem.Movies.Price;
            return Price.ToString();
        }

        //打印售票信息的虚方法
        public virtual void Print()
        {
            string fileName = ScheduleItem.Time.Replace(":", "-") + " " + Seat.SeatNum + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("***************************");
            sw.WriteLine("      青鸟影院(普通)     ");
            sw.WriteLine("---------------------------");
            sw.WriteLine(" 电影名：\t{0}", ScheduleItem.Movies.Name);
            sw.WriteLine(" 时间：  \t{0}", ScheduleItem.Time);
            sw.WriteLine(" 座位号：\t{0}", Seat.SeatNum);
            sw.WriteLine(" 价格：  \t{0}", Price.ToString());
            sw.WriteLine("***************************");
            sw.Close();
            fs.Close();
        }

        //显示当前售出票信息的虚方法
        public virtual void Show()
        {
            MessageBox.Show("已售出");
        }
    }
}
