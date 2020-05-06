using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySmallOfficeExample
{
    public class WordDocument : IMail
    {
        private String documentName;
        private String authorName;
        private String officeText;

        public bool CheckMYMail()
        {
            if (officeText != "")
            {
                return true;
            }
            else return false;
        }

        public void SendMail()
        {
            Console.WriteLine("Sending word mail");
            Console.WriteLine(documentName);
            Console.WriteLine(authorName);

            Console.WriteLine(officeText);
        }
    }
}
