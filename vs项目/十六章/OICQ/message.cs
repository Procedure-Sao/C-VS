using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICQ
{
    class message
    {
        DBHlper db = new DBHlper();

        #region 登录
        public void chauser()
        {
            int num = 0;
            do
            {
                Console.WriteLine("请输入用户名");
                string name = Console.ReadLine();
                Console.WriteLine("请输入用户密码");
                string pwd = Console.ReadLine();
                // 返回的结果信息
                string msg = string.Empty;
                // 它的定义和初始化等价于 string str = null/str = "";
                // 创建DBhlper对象

                // 获取值
                bool isReact = db.chauser(name, pwd, ref msg);// msg 返回db中接收异常
                // 判断
                if (isReact)
                {
                    Console.WriteLine("登录成功！");
                    ShowMenu();
                    break;

                }
                else
                {
                    Console.WriteLine("登录失败!!!" + msg);
                    num++;



                }
            } while (num < 3);
           if(num==3)
           {
               Console.WriteLine("错误三次，请稍后再试");
           }
           


        }
        #endregion


        #region 菜单
        public void ShowMenu()
        {
            string pan;
            do
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("------欢迎登录qq用户信息管理系统-----");
                Console.WriteLine("1.显示用户清单");
                Console.WriteLine("2.更新在线天数");
                Console.WriteLine("3.添加用户新纪录");
                Console.WriteLine("4.更新用户等级");
                Console.WriteLine("5.删除用户记录");
                Console.WriteLine("0.退出");
                Console.WriteLine("=====================================");
                Console.WriteLine("请选择数字：");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        db.lookstu();
                        break;

                    case "2":
                         db.lookstu();
                         update();
                        break;

                    case "3":
                        xin();
                        break;

                    case "4":
                        ren();
                        break;

                    case "5":
                        delete();
                        break;

                    case "0":
                        Console.WriteLine("系统退出！！！");
                        break;
                    default:
                        Console.WriteLine("输入的数字不正确！");
                        break;
                }
                Console.WriteLine("还继续吗(y/n)");
                pan = Console.ReadLine();
                
            } while (pan.Equals("y"));
            Console.WriteLine("感谢你的使用");

        }

        #endregion



        #region 修改信息
        public void update()
        {
            Console.WriteLine("请输入要修改的用户编号");
            string name = Console.ReadLine();
            Console.WriteLine("请输入新的用户在线天数");
            string ui = Console.ReadLine();
            int nu = db.update(name, ui);
            if (nu == -1)
            {
                Console.WriteLine("出现异常");
            }
            else
            {
                Console.WriteLine("修改成功");
            }
        }
        #endregion

        #region 添加新信息
        public void xin()
        {
            
            Console.WriteLine("请输入你要插入的名称");
            string nian = Console.ReadLine();
            Console.WriteLine("请输入你要插入的密码");
            string pwd = Console.ReadLine();
            int nu = db.xin(nian,pwd);
            if (nu == -1)
            {
                Console.WriteLine("出现异常");
            }
            else
            {
                Console.WriteLine("插入成功");

            }

        }
        #endregion


        #region 升级人数判断
        public void ren()
        {
            int sa = db.upup();
            if (sa == -1)
            {
                Console.WriteLine("查询失败");
            }
            else
            {
                Console.WriteLine("学生总人数为:" + db.upup());
            }
        }
        #endregion

        #region 删除信息
        public void delete()
        {
            Console.WriteLine("请输入要删除的学生序号");
            string chu = Console.ReadLine();
            int nu = db.delete(chu);
            if (nu == -1)
            {
                Console.WriteLine("出现异常");
            }
            else
            {
                Console.WriteLine("删除成功");
            }

        }
        #endregion

    }
}
