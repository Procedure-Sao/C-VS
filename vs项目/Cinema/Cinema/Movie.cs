using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema;

namespace Cinema
{
      public enum MovieType
    {
        //喜剧
        Comedy,
        //战争
        War,
        //爱情
        Romance,
        //动作
        Action,
        //卡通
        Cartoon,
        //恐怖
        Thriller,
        //冒险
        Adventure
    }

   

    
 public   class Movie
    {

     public Movie()
     {
     }

     public Movie(string movieName, string poster, string director, string actor, MovieType movieType, int price)
     {
         Name = movieName;
         Poster = poster;
         Director = director;
         Actor = actor;
         Type = movieType;
         Price = price;
     }

     public string Name { get; set; }//电影名
     public string Poster { get; set; }//海报名
     public string Director { get; set; }//导演
     public string Actor { get; set; }//主演
     public MovieType Type { get; set; }//电影类型
     public int Price { get; set; }//票价
  
    }
}
