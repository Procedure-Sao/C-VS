using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三章
{
    public class Text
    {
        User user = new User();

        public void startMenu()
        {
            
            user.chushi();
            int num = -1;//用户输入0返回，否则退出
            bool con = false;//标示是否退出系统
            Console.WriteLine("\n欢迎使用“自动银行服务”");
            do
            {//循环菜单，实现相对应内容
                Console.WriteLine("*******************************");
                Console.WriteLine("1.开户");
                Console.WriteLine("2.存款");
                Console.WriteLine("3.取款");
                Console.WriteLine("4.转账");
                Console.WriteLine("5.查询余额");
                Console.WriteLine("6.更改密码");
                Console.WriteLine("7.查看所有信息");
                Console.WriteLine("0.退出");
                Console.WriteLine("*******************************");
                Console.WriteLine("请选择：");
                int sum = int.Parse(Console.ReadLine());
                switch (sum)
                {
                    case 1:
                        Console.WriteLine("***开户***");
                        add();
                        break;
                    case 2:
                        Console.WriteLine("***存款***");
                        cun();
                        break;
                    case 3:
                        Console.WriteLine("***取款***");
                        qu();
                        break;
                    case 4:
                        Console.WriteLine("***转账***");
                        zhuan();
                        break;
                    case 5:
                        Console.WriteLine("***查询余额***");
                        cha();
                        break;
                    case 6:
                        Console.WriteLine("***修改密码***");
                        xiu();
                        break;
                    case 7:
                        Console.WriteLine("***查询所有信息***");
                        display();
                        break;

                    default:
                        con = true;//退出系统
                        break;
                }
                if (!con)
                {
                    Console.WriteLine("输入0返回");
                    num = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            } while (num == 0);
            Console.WriteLine("系统退出！！！！");
        }
        public void display()
        {
            Console.WriteLine("序号\t账户姓名\t账号\t\t\t余额\t密码\t\t身份证号");
            for (int i = 0; i < user.name.Length; i++)
            {
                
                if (user.name[i] != null)
                {
                    Console.WriteLine((i + 1) + "\t" + user.name[i] + "\t" + user.zhanghao[i] + "\t" + user.cunkuan[i] + "\t" + user.mima[i] + "\t" + user.shenfen[i]);
                }
            }
        }
        public bool add()
        {//添加账户
            bool con = false;//记录是否可以添加账户
            for (int i = 0; i < user.name.Length; i++)
            {
                if (user.name[i] == null)
                {//找到一个空位置，添加账户信息
                    con = true;//标示是否成功
                    Console.WriteLine("请输入要加入的姓名");
                    string name = Console.ReadLine();
                    Console.WriteLine("请输入要加入的账号");
                    string zhanghao = Console.ReadLine();
                    Console.WriteLine("请输入存款金额");
                    double cunkuan = double.Parse(Console.ReadLine());
                    Console.WriteLine("请输入密码");
                    string mima = Console.ReadLine();
                    Console.WriteLine("请再次输入密码");
                    string mima1 = Console.ReadLine();
                    Console.WriteLine("请输入身份证号码");
                    string shenfen = Console.ReadLine();
                    if (mima == mima1)
                    {
                        user.name[i] = name;
                        user.zhanghao[i] = zhanghao;
                        user.cunkuan[i] = cunkuan;
                        user.mima[i] = mima;
                        user.shenfen[i] = shenfen;//添加信息
                        Console.WriteLine("添加" + name + "账户成功");
                        break;
                    }
                    else {
                        Console.WriteLine("两次密码输入不同，开户失败！！");

                    }
                   
                }
            }
            if (!con)
            {
                Console.WriteLine("对不起，用户库已满！");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool cun()
        {//存款
            bool con = false;//记录是否可以有此账户
            Console.WriteLine("请输入用户名");
            string names = Console.ReadLine();
            Console.WriteLine("请输入用户密码");
            string mimas = Console.ReadLine();
            for (int i = 0; i < user.name.Length; i++)
            {
                if (names.Equals(user.name[i]) && mimas.Equals(user.mima[i]))
                {
                    con = true;//标示是否成功
                    Console.WriteLine("请输入存入的金额");
                    double money = double.Parse(Console.ReadLine());
                    user.cunkuan[i] += money;
                    Console.WriteLine("存款成功！！！！");
                    break;
                }
            }
            if (!con)
            {
                Console.WriteLine("对不起，没有找到该用户！");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool qu()
        {//取款
            bool con = false;//记录是否可以有此账户
            Console.WriteLine("请输入用户名");
            string names = Console.ReadLine();
            Console.WriteLine("请输入用户密码");
            string mimas = Console.ReadLine();
            for (int i = 0; i < user.name.Length; i++)
            {
                if (names.Equals(user.name[i]) && mimas.Equals(user.mima[i]))
                {
                    con = true;//标示是否成功
                    Console.WriteLine("请输入取走的金额");
                    double money = double.Parse(Console.ReadLine());
                    if (user.cunkuan[i] > money)//判断余额是否大于取款数
                    {
                        user.cunkuan[i] -= money;
                        Console.WriteLine("取款成功！！！！");
                        break;
                    }
                    else {
                        Console.WriteLine("您的余额不足！！！");
                    }
                   
                    
                }
            }
            if (!con)
            {
                Console.WriteLine("对不起，没有找到该用户！");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool zhuan()
        {//转账
            bool con = false;//记录是否可以有此账户
            Console.WriteLine("请输入用户名");
            string names = Console.ReadLine();
            Console.WriteLine("请输入用户密码");
            string mimas = Console.ReadLine();
            for (int i = 0; i < user.name.Length; i++)
            {
                if (names.Equals(user.name[i]) && mimas.Equals(user.mima[i]))
                {
                    con = true;//标示是否成功
                    Console.WriteLine("请输入对方账号");
                    string duizhang = Console.ReadLine();
                    Console.WriteLine("请输入转账的金额");
                    int money = int.Parse(Console.ReadLine());
                   
                    for (int j = 0; j < user.name.Length; j++)
                    {
                        if (duizhang.Equals(user.name[j]))
                        { user.cunkuan[i] -= money;
                            user.cunkuan[j] += money;
                            Console.WriteLine("转账成功！！！！");
                            break;
                        }
                        if (j==3)
                        {
                              Console.WriteLine("对不起，没有找到该用户");
                        }
                    }
                    break;
          
                }
            }
            if (!con)
            {
                Console.WriteLine("对不起，没有找到该用户！");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool cha()
        {//余款
            bool con = false;//记录是否可以有此账户
            Console.WriteLine("请输入用户名");
            string names = Console.ReadLine();
            Console.WriteLine("请输入用户密码");
            string mimas = Console.ReadLine();
            for (int i = 0; i < user.name.Length; i++)
            {
                if (names.Equals(user.name[i]) && mimas.Equals(user.mima[i]))
                {
                    con = true;//标示是否成功
                    string money=string.Format("{0:C2}",user.cunkuan[i]);
                    Console.WriteLine("您的余额为"+money);
                    break;
                }
            }
            if (!con)
            {
                Console.WriteLine("对不起，没有找到该用户！");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool xiu()
        {//修改密码
            bool con = false;//记录是否可以有此账户
            Console.WriteLine("请输入用户名");
            string names = Console.ReadLine();
            Console.WriteLine("请输入用户密码");
            string mimas = Console.ReadLine();
            for (int i = 0; i < user.name.Length; i++)
            {
                if (names.Equals(user.name[i]) && mimas.Equals(user.mima[i]))
                {
                    con = true;//标示是否成功
                    Console.WriteLine("请输入要修改的密码");
                    string mima = Console.ReadLine();
                    Console.WriteLine("请再次输入要修改的密码");
                    string mima1 = Console.ReadLine();
                    if (mima == mima1)
                    {
                        user.mima[i] = mima;
                        Console.WriteLine("修改成功！！！！");
                        break;
                    }
                    else {
                        Console.WriteLine("两次密码输入不同，修改失败");
                        break;
                    }
                   
                }
            }
            if (!con)
            {
                Console.WriteLine("对不起，没有找到该用户！");
                return false;
            }
            else
            {
                return true;
            }
        }
     
    }
}


