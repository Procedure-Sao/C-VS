using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WebTv
{
  public  class TypeBChannel:ChannelBase
    {
        public override void fetch()
        {
            XmlDocument XD = new XmlDocument();//xml文档对象
            XD.Load("凤凰卫视.xml");
            XmlNode root = XD.DocumentElement;//获取对象
            base.Tvlist = new List<TvProgram>();
            foreach (XmlNode item in root.ChildNodes)//获取第一级子节点
            {
             
                    foreach (XmlNode node in item.ChildNodes)//子节点的子内容
                    {
                        TvProgram tp = new TvProgram();
                        tp.Time = Convert.ToDateTime(node["playTime"].InnerText);
                        tp.Name = node["name"].InnerText;
                        tp.Url = node["path"].InnerText;
                        Tvlist.Add(tp);//赋值到集合
                   
                }
            }
        }
    }
}
