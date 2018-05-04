using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ktv
{
    public partial class music : Form
    {
        public music()
        {
            InitializeComponent();
        }
        public bofang CurrentSong;   //定义当前播放歌曲

        //public bofang song;//当前播放歌曲
        
        private void music_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CurrentSong==null)
            {
                PlaySong();

            }
            if (CurrentSong != null&&zhazha.playState == WMPLib.WMPPlayState.wmppsStopped)//判断歌曲的播放状态是否为快要停止
            {
                    CurrentSong.playState = SongPlay.play; //将该歌曲状态改成已播放   
                    CurrentSong = null;
                    Playlist.ChargeInde();  //Playlist中定义的方法
            }
             if (CurrentSong != null && this.CurrentSong.playState == SongPlay.cut)//切歌
                {
                 this.zhazha.URL="";
                    CurrentSong = null;
                }
             if (CurrentSong != null && this.CurrentSong.playState == SongPlay.again)//重播
             {
                 this.PlaySong();
             }
        }
    
        home hm = new home();
        MainMenu mm = new MainMenu();
        //获得当前播放的歌曲
        public void PlaySong()
        {
            CurrentSong = Playlist.GetPlaySong();//事先定义的类里的方法
            if (CurrentSong != null)
            {
                AddSongCount(CurrentSong.SongName);//次数加一
                CurrentSong.playState = SongPlay.ing; //将歌曲改成正在播放状态
                zhazha.URL = hm.song + CurrentSong.SongURL;   //获得歌曲的路径 
            }
        }

        //每次点击歌曲后都在数据库中将该歌曲的点击次数增加1
        public void AddSongCount(string song_name)
        {
            SqlConnection con = new SqlConnection(home.con);
            string sql = "update song_info set song_play_count=song_play_count+1 where song_name='" + song_name + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
