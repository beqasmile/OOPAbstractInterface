using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInterface.MailFolder
{
    public class MailServer
    {
        public static void SendMail(List<IMail> mails)
        {
            foreach (IMail item in mails)
            {
               if (item.CheckEMailAddress())
                {
                    Console.WriteLine(item.EMailAddress);
                }
            }

        }
    }
}
