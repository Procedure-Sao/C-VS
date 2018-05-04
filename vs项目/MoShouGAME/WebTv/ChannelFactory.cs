using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTv
{
   public class ChannelFactory
    {
       public static ChannelBase GC(string type) 
       {
           ChannelBase cbs = null;
           switch (type)
           {
               case "TypeA":
                   cbs = new TypeAChannel();
                   break;
               case "TypeB":
                   cbs = new TypeBChannel();
                   break;
               default:
                   break;
           }
           return cbs;
       }
    }
}
