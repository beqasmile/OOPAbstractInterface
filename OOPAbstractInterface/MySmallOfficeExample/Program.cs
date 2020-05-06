using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySmallOfficeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelDocument excelDocument = new ExcelDocument();
            WordDocument wordDocument = new WordDocument();
            List<IMail> allMails = new List<IMail>();
            allMails.Add(excelDocument);
            allMails.Add(wordDocument);

            

        }
    }
}
