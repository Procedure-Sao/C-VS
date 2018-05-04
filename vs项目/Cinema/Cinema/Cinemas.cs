using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Cinemas
    {
        public Cinemas()
        {
            Schedules=new Schedule();
        }

        public   Dictionary<string, Seat> seats = new Dictionary<string, Seat>();//座位集合
        public Schedule Schedules;//放映计划
        public  List<Ticket> SoldTickets =new List<Ticket>();

        //保存售票信息的方法
        public void Say()
        {
            FileStream fs = new FileStream("soldTickets.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(fs, Encoding.Default);
            for (int index = 0; index < SoldTickets.Count; index++)
            {
                Ticket ticket = SoldTickets[index];
                string info = "|" + ticket.ScheduleItem.Movies.Name + "|" + ticket.ScheduleItem.Movies.Poster + "|" +
                    ticket.ScheduleItem.Movies.Director + "|" + ticket.ScheduleItem.Movies.Actor + "|" + ticket.ScheduleItem.Movies.Type.ToString() + "|" +
                    ticket.ScheduleItem.Movies.Price + "|" + ticket.ScheduleItem.Time + "|" + ticket.Seat.SeatNum + "|" + ticket.Seat.Color + "|" + ticket.Price + "|";
                if (ticket is FreeTicket)
                {
                    string customerName = ((FreeTicket)ticket).CustomerName;
                    writer.WriteLine("free" + info + customerName);
                }
                else if (ticket is StudentTicket)
                {

                    writer.WriteLine("student" + info + "");
                }
                else
                {
                    writer.WriteLine("" + info + "");
                }
            }
            writer.WriteLine("The End");
            writer.Close();
            fs.Close();
        }
        //读取售票信息的方法
        public void Load()
        {
            try
            {
                //创建一个读取对象                       //路径             //转换格式
                StreamReader reader = new StreamReader("soldTickets.txt", Encoding.GetEncoding("GB2312"));
                string line = reader.ReadLine();
                //声明一个数组 存储 soldTickets.txt 的数据
                string[] values;
                //声明一个电影票对象
                Ticket ticket = null;

                while (line.Trim() != "The End")
                {
                    values = line.Split('|');
                    string type = values[0];

                    Movie movie = new Movie(values[1], values[2], values[3], values[4], (MovieType)Enum.Parse(typeof(MovieType), values[5]), int.Parse(values[6]));
                    ScheduleItem scheduleItem = new ScheduleItem();
                    scheduleItem.Time = values[7];
                    scheduleItem.Movies = movie;
                    string color = values[9];
                    string endColor = color.Substring(color.IndexOf("[") + 1, color.Length - 1 - color.IndexOf("[") - 1);
                    Seat seat = new Seat(values[8], Color.FromName(endColor));

                    int discount = 10;
                    switch (type)
                    {
                        case "student":
                            discount = 7;
                            ticket = TicketUtil.CreateTicket(scheduleItem, seat, discount, "", type);
                            break;
                        case "free":
                            discount = 0;
                            ticket = TicketUtil.CreateTicket(scheduleItem, seat, discount, values[11], type);
                            break;
                        default:
                            discount = 10;
                            ticket = TicketUtil.CreateTicket(scheduleItem, seat, discount, "", "");
                            break;
                    }


                    this.SoldTickets.Add(ticket);
                    line = reader.ReadLine();
                }
                reader.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine("出错了:" + ex.Message);
                SoldTickets = new List<Ticket>();
            }
        }

    }
}
