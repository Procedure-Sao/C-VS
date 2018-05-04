using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTv
{
   public class TvProgram
    {
        public DateTime Time { get; set; }//时间
        public string Dang { get; set; }//早晚档
        public string Name { get; set; }//名字
        public string Url { get; set; }//地址
    }
}
