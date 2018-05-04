using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOliu
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream mf = new FileStream(@"E:\VS\vs项目\MoShouGAME\IOliu\晚自习.txt", FileMode.Create);
            //StreamWriter mw = new StreamWriter(mf);
            //mw.Write("晚自习真的很刺激");
            //mw.Close();
            //mf.Close();
            //Console.WriteLine("写入成功");
            //Console.ReadKey();

            FileStream mf = new FileStream(@"E:\VS\vs项目\MoShouGAME\IOliu\晚自习.txt", FileMode.Open);
            StreamReader mr = new StreamReader(mf);
            Console.WriteLine(mr.ReadToEnd());
            mr.Close();
            mf.Close();
            Console.WriteLine("读取成功");
            Console.ReadKey();
        }
    }
}
