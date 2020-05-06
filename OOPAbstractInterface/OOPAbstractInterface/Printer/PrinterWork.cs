using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInterface
{
    public class PrinterWork
    {
        public static void PrintAll(MyPrinter myPrinter, List<IPrintable> objectsToPrint)
        {
            foreach (IPrintable item in objectsToPrint)
            {
                item.print(myPrinter);
            }
        }
    }
}
