using System;
using System.Collections.Generic;

namespace StudentMgtSystem
{
    class Student
    {
        string firstName, middleName, lastName, studentId;

        enum dept { 
            ComputerScience,
            BBA,
            English
        }
        
        enum degree { 
            BSC,
            BBA,
            BA,
            MSC,
            MBA,
            MA
        }

        List<string> semestersAttended;

        List<string> coursesPerSem;

        //public Student(int id,string name) {
        //    this.studentId = id;
        //    this.name = name;
        //}

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value;  }
        //}
    }
}
