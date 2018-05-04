using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktv
{

      public enum SongPlay{
        //未，播，重，切,在播,标记
        unplay,play,again,cut,ing,biaoji
     }
    public class bofang
    {
        public string SongName;  //歌曲名称
        public string Singer;  //歌手名称
        public string SongURL;//歌曲地址
        public SongPlay playState = SongPlay.unplay;//歌曲播放状态


        public void SetSongPlayed() {//已播放

            this.playState = SongPlay.play;
        }
        public void SetSongAgain()//重播
        {
            this.playState = SongPlay.again;
        }
        public void SetSongCut()//切歌
        {
            this.playState = SongPlay.cut;
        }
        public void SetSonging()//正在播放
        {
            this.playState = SongPlay.ing;
        }
        
    }
}
