using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace 测试分词
{
    public class MailSmtpClient
    {
        /// <summary>
        /// 获取或设置用于 SMTP 事务的主机的名称或 IP 地址
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// 获取或设置用于 SMTP 事务的端口
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// 与凭据关联的用户名
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// 与凭据关联的用户名的密码
        /// </summary>
        public string password { get; set; }

        private SmtpClient client;

        /// <summary>
        /// 初始化 MailUtils 类的新实例，让其使用指定的 SMTP 服务器发送电子邮件
        /// </summary>
        /// <param name="Host"></param>
        /// <param name="Port"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public MailSmtpClient(string Host, int Port, string userName, string password)
        {
            this.Host = Host;
            this.Port = Port;
            this.userName = userName;
            this.password = password;

            client = new SmtpClient(Host, Port);
            client.EnableSsl = true;
            client.Timeout = 30000;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network; //通过网络发送到Smtp服务器
            client.Credentials = new NetworkCredential(userName, password); //通过用户名和密码 认证            
        }

        /// <summary>
        /// 初始化 MailUtils 类的新实例，让其使用指定的 SMTP 服务器和端口发送电子邮件
        /// </summary>
        /// <param name="Host"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public MailSmtpClient(string Host, string userName, string password)
        {
            this.Host = Host;
            this.userName = userName;
            this.password = password;

            client = new SmtpClient(Host);
            client.EnableSsl = true;
            client.Timeout = 30000;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network; //通过网络发送到Smtp服务器
            client.Credentials = new NetworkCredential(userName, password); //通过用户名和密码 认证            
        }

        /// <summary>
        /// 创建指定邮件
        /// </summary>
        /// <param name="FromAddress"></param>
        /// <param name="ToAddress"></param>
        /// <param name="Subject"></param>
        /// <param name="Body"></param>
        /// <returns></returns>
        public MailMessage CreateMailMessage(string FromAddress, string ToAddress, string Subject, string Body, Dictionary<string, string> dict)
        {
            MailMessage mmsg = new MailMessage(new MailAddress(FromAddress), new MailAddress(ToAddress));

            mmsg.Subject = Subject;      //邮件主题
            mmsg.SubjectEncoding = Encoding.UTF8;   //主题编码
            mmsg.Body = Body;         //邮件正文
            mmsg.BodyEncoding = Encoding.UTF8;      //正文编码
            mmsg.IsBodyHtml = true;    //设置为HTML格式           
            mmsg.Priority = MailPriority.High;   //优先级
            if (dict != null && dict.Count > 0)
            {
                foreach (var item in dict)
                {
                    mmsg.Bcc.Add(new MailAddress(item.Key, item.Value, Encoding.GetEncoding("utf-8")));
                }
            }
            return mmsg;
        }

        /// <summary>
        /// 创建指定邮件
        /// </summary>
        /// <param name="FromAddress"></param>
        /// <param name="FromDisplayName"></param>
        /// <param name="ToAddress"></param>
        /// <param name="ToDisplayName"></param>
        /// <param name="Subject"></param>
        /// <param name="Body"></param>
        /// <returns></returns>
        public MailMessage CreateMailMessage(string FromAddress, string FromDisplayName, string ToAddress, string ToDisplayName, string Subject, string Body)
        {
            MailMessage mmsg = new MailMessage(new MailAddress(FromAddress, FromDisplayName, Encoding.UTF8), new MailAddress(ToAddress, ToDisplayName, Encoding.UTF8));

            mmsg.Subject = Subject;      //邮件主题
            mmsg.SubjectEncoding = Encoding.UTF8;   //主题编码
            mmsg.Body = Body;         //邮件正文
            mmsg.BodyEncoding = Encoding.UTF8;      //正文编码
            mmsg.IsBodyHtml = true;    //设置为HTML格式           
            mmsg.Priority = MailPriority.High;   //优先级

            return mmsg;
        }

        /// <summary>
        /// 将指定的邮件发送到 SMTP 服务器以便传递
        /// </summary>
        /// <param name="mmsg"></param>
        public void SendMail(MailMessage mmsg)
        {
            try
            {
                client.Send(mmsg);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
