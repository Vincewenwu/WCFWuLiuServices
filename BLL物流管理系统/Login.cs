using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;//发送邮件用到的命名空间
using System.Threading;//线程用到的命名空间

using System; 
using System.Data;
using System.Configuration;
using System.Web;
using System.Net;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;



namespace BLL物流管理系统
{
    [ServiceContract]
    public class Login
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
         static bool bolStart  ;
        [OperationContract]

        #region 查询用户名
        public DataSet frmLogin_SelectYongHuMing()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "frmLogin_SelectYongHuMing";
            DataTable myDataTable = myDALMethod.QueryDataTable("登录_frmLogin", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion
        [OperationContract]
        #region 验证用户名和密码
        public DataSet frmLogin_JudgeLogin(string YongHuMing, string MiMa)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                         new SqlParameter("@用户名", SqlDbType.Char),
                                         new SqlParameter("@密码", SqlDbType.Char)};
            SQLCMDpas[0].Value = "frmLogin_JudgeLogin";
            SQLCMDpas[1].Value = YongHuMing;
            SQLCMDpas[2].Value = MiMa;
            DataTable myDataTable = myDALMethod.QueryDataTable("登录_frmLogin", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion
        [OperationContract]
        #region 验证用户名和密码
        public DataSet frmLogin_SelectYongHuID(string YongHuMing, string MiMa)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                         new SqlParameter("@用户名", SqlDbType.Char),
                                         new SqlParameter("@密码", SqlDbType.Char)};
            SQLCMDpas[0].Value = "frmLogin_SelectYongHuID";
            SQLCMDpas[1].Value = YongHuMing;
            SQLCMDpas[2].Value = MiMa;
            DataTable myDataTable = myDALMethod.QueryDataTable("登录_frmLogin", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion
        [OperationContract]
        #region 验证用户名和密码
        public DataSet frmLogin_SelectYuanGongByYongHuID(int 用户ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                           new SqlParameter("@用户ID", SqlDbType.Int),
                                            };
            SQLCMDpas[0].Value = "frmLogin_SelectYuanGongByYongHuID";
            SQLCMDpas[1].Value = 用户ID;
            DataTable myDataTable = myDALMethod.QueryDataTable("登录_frmLogin", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion


        #region   发送邮件
        [OperationContract]
        public void FaSongYouJian()
        {
            //方法一：调用线程执行方法，在方法中实现死循环，每个循环Sleep设定时间
            if (bolStart == false)//如果线程为空则实例化线程并执行方法
            {
                //thread = new Thread(new ThreadStart(XunHuanFaSong));
                //thread.Start();//开启线程 
                System.Timers.Timer t = new System.Timers.Timer(3000);//实例化Timer类，设置时间间隔
                t.Elapsed += new System.Timers.ElapsedEventHandler(XunHuanFaSong);//到达时间的时候执行事件
                t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)
                t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件 
                bolStart = true;
            }
        }
        #endregion

        void XunHuanFaSong(object source, System.Timers.ElapsedEventArgs e)
        {            
                try
                {
                    出车登记.FRM_DaoDaDengJi myFRM_DaoDaDengJi = new 出车登记.FRM_DaoDaDengJi();//实例化BLL对象
                    DataTable dt = myFRM_DaoDaDengJi.ShiJianDuanFaSongYouJian();//查询未发送邮件的记录
                    for (int i = 0; i < dt.Rows.Count; i++)//遍历
                    {
                        //给变量赋对应的值
                        string str托运方 = dt.Rows[i]["托运方"].ToString().Trim();
                        string str收货方 = dt.Rows[i]["收货方"].ToString().Trim();
                        string str收货方邮箱 = dt.Rows[i]["收货方邮箱"].ToString().Trim();
                        string str托运方邮箱 = dt.Rows[i]["托运方邮箱"].ToString().Trim();
                        string str网点名称 = dt.Rows[i]["网点名称"].ToString().Trim();
                        string str员工姓名 = dt.Rows[i]["员工姓名"].ToString().Trim();
                        string str生成时间 = dt.Rows[i]["生成时间"].ToString().Trim();
                        string str订单流水号 = dt.Rows[i]["订单流水号"].ToString().Trim();
                        string str操作种类 = dt.Rows[i]["操作种类"].ToString().Trim();
                        string strstr托运方内容 = "尊敬的" + str托运方 + ":\n" + "   您寄的订单编号的为：" + str订单流水号 
                                                  + "的包裹于：" + str生成时间 + "在" + str网点名称 + "由" + str员工姓名 + str操作种类;
                        string strstr收货方内容 = "尊敬的" + str托运方 + ":\n" + "   您的订单编号的为：" + str订单流水号 
                                                  + "的包裹于：" + str生成时间 + "在" + str网点名称 + "由" + str员工姓名 + str操作种类;
                        //执行发送邮件的方法
                        string str = SendMail("qq2873098204@126.com", "广信软件物流管理系统", "qq2873098204@126.com", "物流跟踪提醒", 
                                              strstr托运方内容, "qq2873098204", "Seven1", "smtp.126.com", "");
                        if (str == "send ok")
                        {
                            myFRM_DaoDaDengJi.FaYouJianHouGengXinWuLiuGenZong(dt.Rows[i]["物流跟踪ID"].ToString());
                        }
                    }
                }
                catch { }
        }





        /// <summary> 
        /// 发送邮件程序 
        /// </summary> 
        /// <param name="from">发送人邮件地址</param> 
        /// <param name="fromname">发送人显示名称</param> 
        /// <param name="to">发送给谁（邮件地址）</param> 
        /// <param name="subject">标题</param> 
        /// <param name="body">内容</param> 
        /// <param name="username">邮件登录名</param> 
        /// <param name="password">邮件密码</param> 
        /// <param name="server">邮件服务器</param> 
        /// <param name="fujian">附件</param> 
        /// <returns>send ok</returns> 
        /// 调用方法 SendMail("abc@126.com", "某某人", "cba@126.com", "你好", "我测试下邮件", "邮箱登录名", "邮箱密码", "smtp.126.com", ""); 
        private string SendMail(string from, string fromname, string to, string subject, 
        string body, string username, string password, string server, string fujian)
        {
            try
            {
                //邮件发送类 
                MailMessage mail = new MailMessage();
                //是谁发送的邮件 
                mail.From = new MailAddress(from, fromname);
                //发送给谁 
                mail.To.Add(to);
                //标题 
                mail.Subject = subject;
                //内容编码 
                mail.BodyEncoding = Encoding.Default;
                //发送优先级 
                mail.Priority = MailPriority.High;
                //邮件内容 
                mail.Body = body;
                //是否HTML形式发送 
                mail.IsBodyHtml = true;
                //附件 
                if (fujian.Length > 0)
                {
                    mail.Attachments.Add(new Attachment(fujian));
                }
                //邮件服务器和端口 
                SmtpClient smtp = new SmtpClient(server, 25);
                smtp.UseDefaultCredentials = true;
                //指定发送方式 
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                //指定登录名和密码 
                smtp.Credentials = new System.Net.NetworkCredential(username, password);
                //超时时间 
                smtp.Timeout = 10000;
                smtp.Send(mail);
                return "send ok";
            }
            catch (Exception exp)
            {
                return exp.Message;
            }
        }








    }
}
