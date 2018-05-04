using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEdaka
{
  public  class Record
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime SignInTime { get; set; }
        public DateTime SignOutTime { get; set; }
    }
}
