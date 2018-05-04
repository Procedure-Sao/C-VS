using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassCount
{
    public class Grade
    {
        public List<Student> list;



     public Dictionary<string, Point> DisplayStudent(Point point) 
     {
         Dictionary<string, Point> newds = new Dictionary<string, Point>();
         for (int i = 0; i < list.Count; i++)
         {
             newds.Add(list[i].Name, point);
         }

         return newds;
     }

     public void AddStudent()
     {
         this.list = new List<Student>()
         {   new Student(){Name="刘二"},
             new Student(){Name="张三"},
             new Student(){Name="李四"},
             new Student(){Name="王五"},
             new Student(){Name="杨六"},
         
         
         };

     }

    }
}
