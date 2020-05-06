using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractInterface.PersonFolder
{

    public class Student : Person
    {
        private int studentID;
        private string schoolName;

        public Student(int id, string name, int studentID, string schoolName):base ( id,  name)
        {
            this.studentID = studentID;
            this.schoolName = schoolName;
        }
    }
}
