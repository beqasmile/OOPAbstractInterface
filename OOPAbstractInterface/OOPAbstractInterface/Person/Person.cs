using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInterface 
{
    public class Person : IPrintable
    {
        private int id;
        private string name;
        private string surname;
        private string address;
        private string phone;

        public Person(int id)
        {
            this.id = id;
        }
        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string GetFullPersonName()
        {
            return this.surname + " " + this.name;
        }

        public int getPrintPagesCount()
        {
            return 1;
        }

        public void print(MyPrinter myPrinter)
        {
            myPrinter.PrintData("PersonData");
            myPrinter.PrintNewLine();
            myPrinter.PrintData(id + " ");
            myPrinter.PrintNewLine();

            myPrinter.PrintData(this.name + " " + this.surname);
            myPrinter.PrintNewLine();
            myPrinter.PrintData(this.address );
            myPrinter.PrintNewLine();
            myPrinter.PrintData(this.phone);


        }
    }
}
