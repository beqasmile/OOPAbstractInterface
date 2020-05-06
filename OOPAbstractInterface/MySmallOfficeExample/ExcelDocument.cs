using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySmallOfficeExample
{
    public class ExcelDocument : IMail
    {
        private string excelName;
        private int numOfSheets;
        private List<string> sheetsArray;

        public bool CheckMYMail()
        {
            if (numOfSheets > 0 && excelName != "")
            {
                return true;
            }
            else return false;
        }

        public void SendMail()
        {
            Console.WriteLine("Sending Mail");
            foreach (String sheet in  sheetsArray)
            {
                Console.WriteLine(sheet);
            }
        }
            
    }
}
