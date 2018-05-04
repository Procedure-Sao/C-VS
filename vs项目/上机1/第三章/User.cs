using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三章
{
    public class User
    {
        public string[] name = new string[4];
        public string[] zhanghao = new string[4];
        public double[] cunkuan = new double[4];
        public string[] mima = new string[4];
        public string[] shenfen = new string[4];
        public void chushi()
        {
            
            name[0] = "张四隆";
            zhanghao[0] = "1564681646814685135346846";
            cunkuan[0] = 2000;
            mima[0] = "1111";
            shenfen[0] = "516874516846846648791416846";

            name[1] = "张英灵";
            zhanghao[1] = "1564681646814685135346846";
            cunkuan[1] = 50000;
            mima[1] = "2222";
            shenfen[1] = "516874516846846648791416846";

            name[2] = "曹大刀";
            zhanghao[2] = "1564681646814685135346846";
            cunkuan[2] = 1051546;
            mima[2] = "3333";
            shenfen[2] = "516874516846846648791416846";
        }



    }
}
