using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInterface.PersonFolder
{
    public class StudentBaseClass : Student
    {
        string teacherName;

        public StudentBaseClass(int id, string name, int studentID, string schoolName, string teacherName) 
            : base(id, name, studentID, schoolName)
        {
            this.teacherName = teacherName;
        }
    }
}
