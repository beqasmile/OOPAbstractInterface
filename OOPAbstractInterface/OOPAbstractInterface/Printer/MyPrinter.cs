using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInterface
{
    public class MyPrinter
    {
        private int blackOrColor; // 1 = black 2 = color
        private int landscaprOrPortratit; //1 = landscape, 2 = portrait;
        private string printerURL;

        public MyPrinter(string printerURL, int blackOrColor, int landscapeOrPortrait)
        {
            this.blackOrColor = blackOrColor;
            this.landscaprOrPortratit = landscapeOrPortrait;
            this.printerURL = printerURL;
        }
        public void PrintData(String data)
        {
            Console.Write(data);
        }
        public void PrintNewLine()
        {
            Console.WriteLine();
        }


    }
}
