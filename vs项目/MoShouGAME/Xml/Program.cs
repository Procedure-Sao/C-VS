using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("XMLFile1.xml");
            XmlNode root = xmldoc.DocumentElement;
            //foreach (XmlNode item in root.ChildNodes)
            //{
            //   Console.WriteLine(item.Attributes["id"].Value.ToString());
            //    Console.WriteLine("图书名称"+item["bookname"].InnerText);
            //    Console.WriteLine("图书价格" + item["bookprice"].InnerText);
            //    Console.WriteLine("图书作者" + item["bookuser"].InnerText);
            //}
            foreach (XmlNode item2 in root.ChildNodes)
            {
                foreach (XmlNode item in item2.ChildNodes)
                {
                    if (item.Name == "bookname")
                    {
                        Console.WriteLine("图书名称\t" + item.InnerText);
                    }
                    if (item.Name == "bookprice")
                    {
                        Console.WriteLine("图书价格\t" + item.InnerText);
                    }
                    if (item.Name == "bookuser")
                    {
                        Console.WriteLine("图书作者\t" + item.InnerText);
                    }
                  

                }
                Console.WriteLine("------------------------------------------");
            }
            
            Console.ReadKey();
        }
    }
}
