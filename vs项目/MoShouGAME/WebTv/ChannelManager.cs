using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WebTv
{
 public   class ChannelManager
    {
        public Dictionary<string, ChannelBase> fullChannel = new Dictionary<string, ChannelBase>();
      

        public void LoadAllChannel()
        {
            XmlDocument XD = new XmlDocument();//xml文档对象
            XD.Load("FullChannels.xml");
            XmlNode root = XD.DocumentElement;//获取对象
            foreach (XmlNode item in root.ChildNodes)//获取第一级子节点
            {
                ChannelBase channel = ChannelFactory.GC(item["channelType"].InnerText);//工厂创建相对应对象
                foreach (XmlNode node in item.ChildNodes)//子节点的子内容
                {
                    switch (node.Name)
                    {
                        case "tvChannel"://名字
                            channel.ChannelName = node.InnerText;
                            break;
                        case "path"://地址
                            channel.Path = node.InnerText;
                            break;
                    }
                }
                fullChannel.Add(channel.ChannelName, channel);//赋值到集合
            }


        }

    }
}
