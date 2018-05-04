using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice1
{
    public class SE
    {
        private string id;//编号

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;//姓名

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string age;//年龄

        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        private string ping;//评价

        public string Ping
        {
            get { return ping; }
            set { ping = value; }
        }
        private string defen;//得分

        public string Defen
        {
            get { return defen; }
            set { defen = value; }
        }
    }
}
