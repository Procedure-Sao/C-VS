using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四章
{
    class Program
    {

            static void Main(string[] args)
            {
                string url;
                string protocol;
                Console.WriteLine("请输入一个http或者发ftp地址");
                url = Console.ReadLine();
                protocol = GetProtocol(url);
                Console.WriteLine("您输入的地址使用的协议类型是：");
                Console.WriteLine(protocol);
                Console.ReadLine();
            }

            private static string GetProtocol(string url)
            {
                int position;
                string protocol;
                position = url.IndexOf(":");
                if (position > 0)
                {
                    protocol = url.Substring(0, position);

                }
                else {

                    protocol = "没找到";
                }
                return protocol;
            }
    }
}
