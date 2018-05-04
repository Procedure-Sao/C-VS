using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Book> ice = new Dictionary<string, Book>();
            Book one = new Book();
            one.Bookname = "山海经";
            one.Bookprice = "43";
            ice.Add(one.Bookname, one);

            Book two = new Book();
            two.Bookname = "天才在左疯子在右";
            two.Bookprice = "56";
            ice.Add(two.Bookname, two);

            foreach (string key in ice.Keys)
            {
                Console.WriteLine(key+"\t"+ice[key]);
            }
            Console.WriteLine();
            foreach (Book item in ice.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (KeyValuePair<string,Book> item in ice)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            Console.ReadLine();



        }
    }
}
