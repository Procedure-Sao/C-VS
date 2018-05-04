using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13
{
    class Program
    {
        static void Main(string[] args)
        {
            Message ms = new Message();
            //ms.Login();
            DBhlper db = new DBhlper();
            db.GetStudentLinst();

            Console.ReadLine();
         
        }
    }
}
