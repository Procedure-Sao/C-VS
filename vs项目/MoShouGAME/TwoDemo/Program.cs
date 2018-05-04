using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 150;
            //int b = a;
            //Console.WriteLine("过去a身高{0}，过去b身高{1}",a,b);
            //b = 180;
            //Console.WriteLine("过去a身高{0}，过去b身高{1}", a, b);
          
            //JieGou jg;
            //jg.a = 150;
            //jg.b = 325;
            //jg.title(); 
            //Console.ReadLine();


            //Console.WriteLine("请输入商品原价");
            //double jiage =Convert.ToDouble( Console.ReadLine());
            //zhuan(ref jiage);
            //Console.WriteLine("价格为"+jiage);


         int []num=new int[5]{98,99,58,78,68};

         foreach (var item in num)
         {
             Console.Write(item+"   ");
         }
         zhuan2(num);
         Console.WriteLine();
         foreach (var item in num)
         {
             Console.Write(item + "   ");
         }
            Console.ReadLine();
           
        }

        private static void zhuan2(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                num[i] += 5;
            }
        }
        //public static void zhuan(ref double jiage)
        //{
        //    if (jiage >= 100)
        //    {
        //        jiage = jiage - 50;
        //    }

        //}
    }
}
