using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十六章2
{
    class Class1
    {
        private const string strConn = "Data Source=.;Initial Catalog=QQDB;User ID=sa;Password=825516949";
        Class2 db = new Class2();

        //登录  
        public void login()
        {
            int count = 0;
            do
            {
                count++;
                string strUserName = string.Empty;
                string strPwd = string.Empty;
                Console.WriteLine("请输入用户名:");
                strUserName = Console.ReadLine();
                Console.WriteLine("请输入密码:");
                strPwd = Console.ReadLine();
                if (strUserName.Equals(string.Empty) || strPwd.Equals(string.Empty))
                {
                    Console.WriteLine("输入错误，请重新输入！\n");
                    continue;
                }
                else
                {
                    string strMsg = string.Empty;

                    bool bRet = CheckAdminInfo(strUserName, strPwd, ref strMsg);
                    if (bRet)
                    {
                        Console.WriteLine("登录成功！");
                        ShowMenu();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("登录失败：" + strMsg + "\n");
                        continue;
                    }
                }
            } while (count < 3);
            if (count == 3)
            {
                Console.WriteLine("\n连续三次登录失败，退出本系统！\n");
            }
        }









        //检查用户信息是否存在  
        public bool CheckAdminInfo(string strUserName, string strPwd, ref string strMsg)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("SELECT");
                sb.AppendLine("      [LoginId]");
                sb.AppendLine("      ,[LoginPwd]");
                sb.AppendLine("FROM");
                sb.AppendLine("      Admin");
                SqlCommand comm = new SqlCommand(sb.ToString(), conn);

                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    strUserName = (string)reader["LoginId"];
                    strPwd = (string)reader["LoginPwd"];
                }

                reader.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        //是否退出  
        private bool IsExit()
        {
            Console.WriteLine("是否退出？（Y/N）");
            string strRet = Console.ReadLine();
            strRet = strRet.Trim().ToUpper();
            if (strRet.Equals("Y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //显示菜单  
        private void ShowMenu()
        {
            string option = "";
            do
            {
                Console.WriteLine("");
                Console.WriteLine("=======欢迎登录QQ用户信息管理系统======");
                Console.WriteLine("----------------请选择菜单项----------");
                Console.WriteLine("1、显示用户清单");
                Console.WriteLine("2、更新在线天数");
                Console.WriteLine("3、添加用户新记录");
                Console.WriteLine("4、更新用户等级");
                Console.WriteLine("5、删除用户记录");
                Console.WriteLine("0、退出");
                Console.WriteLine("=======================================");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1"://显示用户信息  
                        db.ShowUserInfo();
                        continue;
                    case "2"://更新在线天数  
                        UpdateOnlineDay();
                        continue;
                    case "3"://添加用户  
                        InsertUserInfo();
                        continue;
                    case "4"://更新用户等级  
                        UpdateUserLevel();
                        continue;
                    case "5"://删除用户  
                        DeleteUserInfo();
                        continue;
                    case "0":

                        break;//退出  


                    default:
                        continue;
                }

                break;
            } while (true);

        }

        //更改在线天数  
        public void UpdateOnlineDay()
        {
            try
            {
                Console.WriteLine("请输入用户编号：");
                string strUserId = Console.ReadLine();
                int iUserId = Convert.ToInt32(strUserId);
                Console.WriteLine("请输入新的在线天数");
                string strNewOnlineDay = Console.ReadLine();
                double iNewOnlineDay = Convert.ToDouble(strNewOnlineDay);
                int iRet = db.UpdateOnlineDay(iUserId, iNewOnlineDay);
                if (iRet == -1)
                    Console.WriteLine("发生异常");
                else if (iRet == 0)
                {
                    Console.WriteLine("用户记录不存在");
                }
                else
                {
                    Console.WriteLine("修改成功！");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //插入用户信息  
        private void InsertUserInfo()
        {
            Console.WriteLine("请输入用户昵称：");
            string strUserName = Console.ReadLine();
            Console.WriteLine("请输入用户密码：");
            string strUserPwd = Console.ReadLine();
            Console.WriteLine("请输入用户邮箱地址：");
            string strUserEmail = Console.ReadLine();

            int iRet = Convert.ToInt32(db.InsertUserInfo(strUserName, strUserPwd, strUserEmail));
            if (iRet == -1)
            {
                Console.WriteLine("存在异常");
            }
            else if (iRet == 0)
            {
                Console.WriteLine("用户记录不存在");
            }
            else
            {
                Console.WriteLine("插入成功！用户编号是：" + iRet);
            }
        }

        //根据天数确认等级  
        private int JudgeLevelByOnLineDay(double iOnlineDay)
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


        //用户等级更新  
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
                iLevelId = JudgeLevelByOnLineDay(iLineDay);
                db.UpdateUserLevel(iUserId, iLevelId);
                count++;
            }
            Console.WriteLine("本次共更新用户记录数：" + count);
            Console.WriteLine("更新成功！");

        }

        //显示个人用户信息  
        private void DisplayUserInfo(SqlDataReader reader)
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("编号\t昵称\t\t等级\t\t邮箱\t\t在线天数");
            Console.WriteLine("--------------------------------------------------------------------------------");
            while (reader.Read())
            {
                Console.Write(reader["UserId"] + "\t");
                Console.Write(reader["UserName"] + "\t");
                Console.Write(reader["LevelName"] + "\t\t");
                Console.Write(reader["Email"] + "\t");
                Console.WriteLine(reader["OnLineDay"]);
            }
            Console.WriteLine("--------------------------------------------------------------------------------");

        }

        //删除指定用户信息  
        public void DeleteUserInfo()
        {
            try
            {

                Console.WriteLine("请输入删除的用户编号：");
                string strUserId = Console.ReadLine();
                int iUserId = Convert.ToInt32(strUserId);

                Console.WriteLine("将要删除的用户信息是：");
                SqlDataReader reader = db.GetUserByID(iUserId);

                if (reader == null)
                {
                    Console.WriteLine("发生异常");
                    return;
                }
                DisplayUserInfo(reader);
                Console.WriteLine("要删除该用户记录吗？（Y/N）");
                if (Console.ReadLine().Trim().ToUpper() != "Y")
                {
                    Console.WriteLine("退出删除操作！");
                    return;
                }

                int iRet = db.DeleteUserInfo(iUserId);
                if (iRet == -1)
                {
                    Console.WriteLine("发生异常");
                }
                else
                {
                    Console.WriteLine("删除成功！");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("删除失败：" + ex.Message);
            }
        }





    }
}
