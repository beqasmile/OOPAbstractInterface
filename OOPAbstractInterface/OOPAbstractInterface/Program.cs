using OOPAbstractInterface.Clear;
using OOPAbstractInterface.LessonFolder;
using OOPAbstractInterface.MailFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInterface.PersonFolder
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



            Student student1 = new Student(5, "moshe student", 222, "ironi hey");
            StudentUniv studentUniv = new StudentUniv(6, "student ununv 1", 333, "Bar Ilan", "Bilding 1", "First");
            Person person5 = new StudentUniv(7, "student ununv 2", 555, "Bar Ilan", "Bilding 1", "First");

            IPrintable printable1 = lesson1;
            IClearable clearable1 = lesson1;


            IPrintable printable2 = person2;
            IClearable clearable2 = lesson2;


            IPrintable printable3 = student1;
            IClearable clearable3 = student1;


            clearable1.Clear();
           

            List<IPrintable> allPrintables = new List<IPrintable>();

            allPrintables.Add(printable1);
            allPrintables.Add(printable2);
            allPrintables.Add(lesson2);
            allPrintables.Add(lesson2);
            allPrintables.Add(person2);
            allPrintables.Add(person3);
            allPrintables.Add(person4);
            allPrintables.Add(student1);


            MyPrinter myPrinter = new MyPrinter("http://ddd.com", 1, 1);

            PrinterWork.PrintAll(myPrinter,allPrintables);


            List<IMail> mailsList = new List<IMail>();
            mailsList.Add((IMail)studentUniv);
            mailsList.Add((IMail)person5);


            if (person1.CompareTo(person2)>0)
            {

            }

        }
    }
}
