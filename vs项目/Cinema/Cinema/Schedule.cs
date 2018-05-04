using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Cinema
{
 public class Schedule
 {
     public Dictionary<string, ScheduleItem> dis =new Dictionary<string, ScheduleItem>();

     internal Dictionary<string, ScheduleItem> Dis
     {
         get { return dis; }
         set { dis = value; }
     }

     public void ShowMxl()
     {
         XmlDocument myXml = new XmlDocument();
         myXml.Load("ShowList.xml");
         XmlNode root = myXml.DocumentElement;

         foreach (XmlNode item in root.ChildNodes)
         {
             Movie movie = new Movie();
             movie.Name = item["Name"].InnerText;
             movie.Poster = item["Poster"].InnerText;
             movie.Director = item["Director"].InnerText;
             movie.Actor = item["Actor"].InnerText;
             movie.Type = (MovieType)Enum.Parse(typeof(MovieType), item["Type"].InnerText);
             movie.Price = Convert.ToInt32(item["Price"].InnerText);

             foreach (XmlNode item1 in item["Schedule"].ChildNodes)
             {
                 ScheduleItem sItem = new ScheduleItem();
                 sItem.Time = item1.InnerText;
                 sItem.Movies = movie;
                 dis.Add(sItem.Time, sItem);
             }
         }
     }

 }
}
