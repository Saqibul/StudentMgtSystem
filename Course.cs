using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtSystem
{
    class Course
    {
        string courseID, courseName, instructorName;
        int noOfCredits;

        public Course() { 
        
        }

        public Course(string cID, string cName, string intsName, int creds) {
            Course c = new Course();
            c.courseID = cID;
            c.courseName = cName;
            c.instructorName = intsName;
            c.noOfCredits = creds;
        }

        public string CID
        {
            get { return this.courseID; }
            set { this.courseID = value; }
        }        
        public string CName
        {
            get { return this.courseName; }
            set { this.courseName = value; }
        }        
        public string InstrName
        {
            get { return this.instructorName; }
            set { this.instructorName = value; }
        }
        public int Creds
        {
            get { return this.noOfCredits; }
            set { this.noOfCredits = value; }
        }
    }
}
