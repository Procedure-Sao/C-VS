using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable2
{
    class Book
    {
        public string Bookname { get; set; }
        public string Bookprice { get; set; }

        public override string ToString()
        {
            return this.Bookprice;
        }
    }
}
