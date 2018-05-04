using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class TicketUtil
    {
        public static Ticket CreateTicket(ScheduleItem scheduleItem, Seat seat,int discount, string customerName, string type)
        {
            Ticket ticket = null;
            switch (type)
            {
                case "student":
                    ticket = new StudentTicket(scheduleItem,seat,discount);
                    break;
                case "free":
                    ticket = new FreeTicket(scheduleItem,seat,customerName);
                    break;
                default:
                    ticket = new Ticket(scheduleItem, seat);
                    break;
            }
            return ticket;
        }
    }
}
