using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danli
{
     public class Dan
    {
         public  Dan(){}
         public Dan(string name,string url) 
         {
             this.name = name;
             this.url = url;
         }

         string name;

         public string Name
         {
             get { return name; }
             set { name = value; }
         }
         string url;

         public string Url
         {
             get { return url; }
             set { url = value; }
         }
    }
}
