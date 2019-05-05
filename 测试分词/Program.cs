using JiebaNet.Analyser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 测试分词
{
    class Program
    {
        static void Main(string[] args)
        {
            //var text =
            //   "程序员(英文Programmer)是从事程序开发、维护的专业人员。一般将程序员分为程序设计人员和程序编码人员，但两者的界限并不非常清楚，特别是在中国。软件从业人员分为初级程序员、高级程序员、系统分析员和项目经理四大类。";
            //var extractor = new TfidfExtractor();
            //var keywords = extractor.ExtractTags(text);
            //foreach (var keyword in keywords)
            //{
            //    Console.WriteLine(keyword);
            //}


            MailSmtpClient client = new MailSmtpClient("smtp.exmail.qq.com", 25, "alarm@rd.keytop.cn", "Aa123123");
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("zhuzhifeng@superpark.cn", "朱志锋");
            dict.Add("linjinfang@superpark.cn", "林锦芳");
            dict.Add("chenling@superpark.cn", "陈玲");
            //
            //zhuminqing@superpark.cn

            var msg = client.CreateMailMessage("alarm@rd.keytop.cn", "chenweichao@rd.keytop.com.cn", "找零审核", "hello world", null);
            client.SendMail(msg);
            Console.ReadKey();
        }
    }
}
