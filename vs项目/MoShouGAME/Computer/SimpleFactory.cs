using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
  public  class SimpleFactory
    {
      public static Number sf(string panduan) 
      {
          Number nb = null;
          switch (panduan)
          {
              case "+":
                  nb = new Add();
                  break;
              case "-":
                  nb = new Sub();
                  break;
              case "*":
                  nb = new Mul();
                  break;
              case "/":
                  nb = new Div();
                  break;

          }
          return nb;
      }
    }
}
