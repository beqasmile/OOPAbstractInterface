using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInterface.MailFolder
{
    public interface IMail
    {
        string EMailAddress { set; get; }
        bool CheckEMailAddress();

    }
}
