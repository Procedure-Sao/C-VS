using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十四章
{
    class SchoolManger{
        DbOperation db = new DbOperation();



        #region 菜单
        public void Login()
        {
            Console.WriteLine("请输入用户名：");
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string pwd = Console.ReadLine();
            string strMsg = string.Empty;
            //string strMsg = null;
            bool surMsg = db.ChenkUserInfo(username, pwd, ref strMsg);
            if (surMsg)
            {
                Console.WriteLine("登陆成功！！");
                Console.WriteLine("================");
                Console.WriteLine("1.统计学生人数");
                Console.WriteLine("2.查看学生名单");
                Console.WriteLine("3.按学号查询学生姓名");
                Console.WriteLine("4.按姓名查询学生信息");
                Console.WriteLine("5.修改学生出生日期");
                Console.WriteLine("6.删除学生记录");
                Console.WriteLine("7.新增年纪记录");
                Console.WriteLine("8.退出");
                Console.WriteLine("================");
                Console.WriteLine("请选择数字：");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        GetStudentCount();
                        break;

                    case "2":
                        ShowStudent();
                  
                        break;

                    case "3":
                        showstudentname();
                        break;

                    case "4":
                        ShowStudentInfoByName();
                        break;

                    case "5":
                        Insertupdate();
                        break;

                    case "6":
                        InsertDelete();
                        break;

                    case "7":
                        InsertGrade();
                        break;


                    case "8":
                        Console.WriteLine("系统退出！！！");
                        break;


                    default:
                        Console.WriteLine("输入的数字不正确！");
                        break;
                }


            }
            else
            {
                Console.WriteLine("登录失败！");
            }
        }
#endregion
        #region 按照学号查询学生姓名
        public void showstudentname(){
        Console.WriteLine("请输入学生学号");
        string stuNo = Console.ReadLine();
        string stuName = db.GetStudentNameByNo(stuNo);
        if (stuName.Equals(string.Empty))
        {
            Console.WriteLine("出现异常");
        }
        else {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("学号是{0}的学生姓名为：{1}", stuNo, stuName);
            Console.WriteLine(sb);
        }
        }
     #endregion
        #region 按照学生姓名查询
        public void ShowStudentInfoByName()
        {
            //创建StrinngBuilder类对象
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("请输入学生姓名：");
            string stuName = Console.ReadLine();
            DbOperation db = new DbOperation();
            //创建DataReader对象读取数据库中的值
            SqlDataReader reader = db.GetStudentInfoByName(stuName);
            if (reader == null)
            {
                Console.WriteLine("出现异常！");
                return;
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("学号\t姓名\t性别\t年级\t联系电话\t地址\t\t出生日期\t\t邮箱");
            //循环读取拿到的数据,并格式化输出
            while (reader.Read())
            {
                sb.AppendFormat("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", reader["StudentNo"], reader["StudentName"], reader["Sex"],
                    reader["GradeName"], reader["Phone"], reader["Address"], reader["BornDate"], reader["Email"]);
                Console.WriteLine(sb.ToString());
                sb.Length = 0;
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            reader.Close();
        }
        #endregion
        #region 登录方法

        public void Login1()
        {
            Console.WriteLine("请输入用户名：");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string password = Console.ReadLine();
            // 返回的结果信息
            string msg = string.Empty;
            // 它的定义和初始化等价于 string str = null/str = "";
            // 创建DBhlper对象
            DbOperation c1 = new DbOperation();
            // 获取值
            bool isReact = c1.ChenkUserInfo(userName, password, ref msg);
            // 判断
            if (isReact)
            {
                Console.WriteLine("登录成功！");
            }
            else
            {
                Console.WriteLine("登录失败!!!" + msg);
            }

        }
        #endregion
        #region 查看学生名单
        public void ShowStudent()
        {
              DbOperation _dbOper = new DbOperation();
            //调用Class1类的方法
            SqlDataReader reader = null;
            reader = _dbOper.GetStudentListReturn();
            if (reader == null)
            {
                Console.WriteLine("出现异常了，额。。。");
                return;
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("学号\t         姓名");
            Console.WriteLine("-------------------------------");
            //创建StringBuilder的对象
            StringBuilder sb = new StringBuilder();
            //循环读取DataReader
            while (reader.Read())
            {
                sb.AppendFormat("{0}\t\t{1}", reader["StudentNo"], reader["StudentName"]);
                Console.WriteLine(sb);
                sb.Length = 0;
            }
            Console.WriteLine("-------------------------------");
            //关闭DataReader对象
            reader.Close();

        }
        #endregion
        #region 查询总人数
        public void GetStudentCount() {
            int iter = db.GetStudentCount();
            if (iter < 0)
            {
                Console.WriteLine("查询出错！！！");
            }
            else {
                Console.WriteLine("学生总人数"+iter);
            }
        }
        #endregion
        #region 新增年级信息
        public void  InsertGrade()
        {
            Console.WriteLine("请输入需要插入的年级名称");
            string greadName = Console.ReadLine();
            int iret = db.InsertGrade(greadName);
            if (iret ==-1)
            {
                Console.WriteLine("出现异常，录入失败！！");
            }
            else {

                Console.WriteLine("插入成功！！！");
            }
        }
        #endregion
        #region 删除年级信息
        public void InsertDelete()
        {
            Console.WriteLine("请输入需要删除的年级名称");
            string greadName = Console.ReadLine();
            int iret = db.InsertDelete(greadName);
            if (iret<=0)
            {
                Console.WriteLine("出现异常，删除失败！！");
            }
            else
            {

                Console.WriteLine("删除成功！！！");
            }
        }
        #endregion
        #region 修改年级信息
        public void Insertupdate()
        {
            Console.WriteLine("请输入需要修改的用户名称");
            string greadName = Console.ReadLine();
            Console.WriteLine("请输入用户的新密码");
            string greadpwd = Console.ReadLine();
            int iret = db.Insertupdate(greadName,greadpwd);
            if (iret <=0)
            {
                Console.WriteLine("出现异常，修改失败！！");
            }
            else
            {

                Console.WriteLine("修改成功！！！");
            }
        }
        #endregion
    }
}
