using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInterface
{
    public interface IPrintable
    {
        void print(MyPrinter myPrinter);
        int getPrintPagesCount();

    }
}
