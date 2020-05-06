using OOPAbstractInterface.MailFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInterface.PersonFolder
{
    public class StudentUniv : Student, IMail
    {

        private string classBildingName;
        private string levelName;
        public StudentUniv(int id, string name, int studentID, string schoolName, string classBildingName , string levelName) 
            : base(id, name, studentID, schoolName)
        {
            this.classBildingName = classBildingName;
            this.levelName = levelName;
        }

        public string EMailAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool CheckEMailAddress()
        {
            throw new NotImplementedException();
        }
    }
}
