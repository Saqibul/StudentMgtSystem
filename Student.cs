using System;

namespace StudentMgtSystem
{
    class Student
    {
        int studentId;
        string name;

        public Student(int id,string name) {
            this.studentId = id;
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value;  }
        }
    }
}
