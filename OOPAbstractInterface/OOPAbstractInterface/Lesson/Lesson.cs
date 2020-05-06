using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInterface
{
    public class Lesson :IPrintable
    {
        private int lessonID;
        private string lessonName;
        private int lessonHoursLong;

        public Lesson(int lessonID)
        {
            this.lessonID = lessonID;
        }

        public Lesson(int lessonID, string lessonName)
        {
            this.lessonID = lessonID;
            this.lessonName = lessonName;
        }


        public int getPrintPagesCount()
        {
            return lessonHoursLong;
        }

        public void print(MyPrinter myPrinter)
        {
            myPrinter.PrintData(lessonID + " ");
            myPrinter.PrintNewLine();
            myPrinter.PrintData(lessonName);
            myPrinter.PrintNewLine();
            myPrinter.PrintData(lessonHoursLong + " ");
        }
    }
}
