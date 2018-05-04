using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktv
{
   public class Playlist
    {
        public static bofang[] songlist = new bofang[100];  //定义一个歌曲数组
        public static int SongIndex = 0;        //当前播放歌曲在数组中的索引
        public static string NextSongName = "";    //下一首歌曲
        public static string zhuangtai = "";    //保存是切歌还是重播

        public static bool AddSong(bofang song)//添加歌曲
        {
            bool Result = false;    //记录歌曲是否添加成功
            for (int i = 0; i < songlist.Length; i++)
            {
                if (songlist[i] == null)
                {
                    songlist[i] = song;
                    Result = true;
                    break;
                }
            }
            return Result;
        }



        //切歌
        public static void CutSong()
        {
            //获取到当前播放的歌曲改变播放状态
            if (songlist[SongIndex] != null)
            {
                songlist[SongIndex].playState = SongPlay.cut;
                ChargeInde();   //改变歌曲索引,播放下一首
            }

        }
        //重唱
        public static void ListenAgain()
        {
            if (songlist[SongIndex] != null)
            {
                songlist[SongIndex].playState = SongPlay.again;   //改变歌曲播放状态

            }
        }
       

        //获得当前播放的歌曲
        public static bofang GetPlaySong()
        {
            if (songlist[SongIndex] != null)
            {

                return songlist[SongIndex];
            }
            else
            {
                return null;
            }
        }

        //播放下一首
        public static void ChargeInde()
        {
            SongIndex++;
        }
        //点击重播时根据歌曲名称查找该歌曲在歌曲列表中的位置并改变其状态
        public static void SelectFromSongName(string name)
        {
            for (int i = 0; i < songlist.Length; i++)
            {
                if (songlist[i] != null)
                {
                    if (songlist[i].SongName.Equals(name))
                    {
                        if (zhuangtai.Equals("重播"))
                        {
                            songlist[i].playState = SongPlay.again;   //将该歌曲状态修改成重播
                            break;
                        }
                        else
                        {

                            if (songlist[i + 1] != null && songlist[i].playState == SongPlay.ing)
                            {
                                songlist[i].playState = SongPlay.cut;   //将该歌曲状态修改成切歌
                                songlist[i + 1].playState = SongPlay.ing; //将下一首歌状态改成正在播放
                            }
                           
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }
        //public static bool isRight = false;      //记录当isRight等于true时就播放选中歌曲
        ////点击已点列表中的播放时,根据歌曲名找到索引
        //public static void SelectIndexBySongName(string name)
        //{

        //    for (int i = 0; i < songlist.Length; i++)
        //    {
        //        if (songlist[i] != null)
        //        {
        //            if (songlist[i].SongName.Equals(name))
        //            {
        //                songlist[i].playState = SongPlay.biaoji;       //为选中歌曲做一个标记
        //                songlist[SongIndex].playState = SongPlay.ing;   //将当前播放歌曲改为已播状态
        //                SongIndex = i;     //将歌曲索引改变为所选中的歌曲
        //                isRight = true;
        //                break;
        //            }
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //}


        public static string PlayingSongName()
        {
            string songName = ""; // 歌曲名称
            if (SongIndex < songlist.Length)
            {
                if (songlist[SongIndex] != null)
                {
                    songName = songlist[SongIndex].SongName;
                }
            }
            return songName;
        }


        public static string NextSongName1()
        {
            string songName = ""; // 歌曲名称
            if (SongIndex + 1 < songlist.Length)
            {
                if (songlist[SongIndex + 1] != null)
                {
                    songName = songlist[SongIndex + 1].SongName;
                }
            }
            return songName;
        }

    }
}
