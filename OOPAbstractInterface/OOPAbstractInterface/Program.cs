using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Lesson lesson1 = new Lesson(1, "math");
            Lesson lesson2 = new Lesson(2, "geography");
            Lesson lesson3 = new Lesson(3, "english");


            Person person1 = new Person(1, "moshe");
            Person person2 = new Person(2, "danny");
            Person person3 = new Person(3, "rueven");
            Person person4 = new Person(4, "dana");


            IPrintable printable1 = lesson1;
            IPrintable printable2 = person2;


            List<IPrintable> allPrintables = new List<IPrintable>();

            allPrintables.Add(printable1);
            allPrintables.Add(printable2);
            allPrintables.Add(lesson2);
            allPrintables.Add(lesson2);
            allPrintables.Add(person2);
            allPrintables.Add(person3);
            allPrintables.Add(person4);


            MyPrinter myPrinter = new MyPrinter("http://ddd.com", 1, 1);

            PrinterWork.PrintAll(myPrinter,allPrintables);

        }
    }
}
