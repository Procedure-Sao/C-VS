using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十六章
{
    class Userqq
    {
        DBqq db = new DBqq();

        #region 登录
        public void Login()
        {
            Console.WriteLine("请输入用户名：");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string password = Console.ReadLine();
            // 创建DBhlper对象

            // 获取值
            bool isReact = db.CheckAdmin(userName, password);
            // 判断
            if (isReact)
            {
                Console.WriteLine("登录成功！");
                ShowMenu();
            }
            else
            {
                Console.WriteLine("登录失败!!!" );
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
                        ShowStudent();
                        break;

                    case "2":
                        update();

                        break;

                    case "3":
                        xin();
                        break;

                    case "4":
                        UpdateUserLevel();
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

        }
          
        #endregion

        #region 查看学生名单
        public void ShowStudent()
        {
            //调用Class1类的方法
            SqlDataReader reader = null;
            reader = db.GetUser();
            if (reader == null)
            {
                Console.WriteLine("出现异常!");
                return;
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("编号\t 昵称\t\t 等级\t\t \t 邮箱\t\t在线天数");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            //创建StringBuilder的对象
            StringBuilder sb = new StringBuilder();
            //循环读取DataReader
            while (reader.Read())
            {
                sb.AppendFormat("{0}\t{1}\t{2}\t\t {3}\t\t\t{4}", reader["UserId"], reader["UserName"], reader["LevelName"], reader["Email"], reader["OnLineDay"]);
                Console.WriteLine(sb);
                sb.Length = 0;
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            //关闭DataReader对象
            reader.Close();

        }
        #endregion

        #region 更新在线天数
        public void update()
        {
            Console.WriteLine("请输入要修改的用户编号");
            string name = Console.ReadLine();
            Console.WriteLine("请输入新的用户在线天数");
            string ui = Console.ReadLine();
            int nu = db.update(name, ui);
            if (nu <=0)
            {
                Console.WriteLine("出现异常");
            }
            else
            {
                Console.WriteLine("修改成功");
            }
        }
        #endregion

        #region  添加用户新记录
        public void xin()
        {

            Console.WriteLine("请输入你要插入的名称");
            string nian = Console.ReadLine();
            Console.WriteLine("请输入你要插入的密码");
            string pwd = Console.ReadLine();
            Console.WriteLine("请输入你要插入的邮箱");
            string email = Console.ReadLine();
            int nu = db.InsertUser(nian, pwd, email);
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

        #region 更新用户等级
      
        private void UpdateUserLevel()
        {

            SqlDataReader reader = db.GetUserIdAndOnlineDay();
            if (reader == null)
            {
                Console.WriteLine("存在异常");
                return;
            }


            int iUserId = 0;
            double iLineDay = 0;
            int iLevelId = 0;
            int count = 0;

            while (reader.Read())
            {
                iUserId = Convert.ToInt32(reader["UserId"]);
                iLineDay = Convert.ToDouble(reader["OnLineDay"]);
                iLevelId = gai(iLineDay);
                db.UpdateUserLevel(iUserId, iLevelId);
                count++;
            }
            Console.WriteLine("本次共更新用户记录数：" + count);
            Console.WriteLine("更新成功！");

        }


        #endregion

        #region  天数改符号

        public int gai(double iOnlineDay)
        {
            const int LEVEL1 = 5;
            const int LEVEL2 = 32;
            const int LEVEL3 = 320;

            int iNewLevel = 0;

            if (iOnlineDay >= LEVEL1 && iOnlineDay < LEVEL2)
            {
                iNewLevel = 2;
            }
            else if (iOnlineDay >= LEVEL2 && iOnlineDay < LEVEL3)
            {
                iNewLevel = 3;
            }
            else if (iOnlineDay >= LEVEL3)
            {
                iNewLevel = 4;
            }
            else
            {
                iNewLevel = 1;
            }
            return iNewLevel;

        }
        #endregion

        #region 删除信息
        public void delete()
        {
            Console.WriteLine("请输入要删除的学生序号");
            string chu = Console.ReadLine();
            int nu = db.DeleteUserInfo(chu);
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
