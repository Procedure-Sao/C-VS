using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTv
{
 public abstract class ChannelBase
    {
        public string ChannelName { get; set; }//频道名称
        public string Path { get; set; }//频道路径
        public List<TvProgram> Tvlist { get; set; }//节目列表

        public abstract void fetch();//获取频道列表
    }
}
