
using Grpc.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;


namespace StudentMgtSystem
{
    class Student
    {
        string firstName, middleName, lastName, studentId, joiningBatch;

        int depart, deg;

        public enum dept { 
            ComputerScience = 1,
            BBA,
            English
        }
        
        public enum degree { 
            BSC = 1,
            BBA,
            BA,
            MSC,
            MBA,
            MA
        }

        List<string> semestersAttended;

        List<string> coursesPerSem;

        public static List<Student> allStudents = new List<Student>();

        
        public void addToJson(Student obj)
        {
            string pathString = @"D:\AsthaIT\StudentManagementSystem\StudentMgtSystem\students.json";
            string fileName = "students.json";
            List<Student> lst = new List<Student>();
            string read = null;
            if (System.IO.File.Exists(pathString))
            { 
                StreamReader r = new StreamReader(pathString);
                read = r.ReadToEnd();
                //Console.WriteLine("There is already a file");
                //lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Student>>(read);
                r.Close();
            }
            else {
                //Console.WriteLine("Created Json File");
                FileStream r = File.Create(pathString);
                r.Close();
            }


            //if (!System.IO.File.Exists(pathString))
            //{

            StreamWriter fs = new StreamWriter(pathString,true);
            lst.Add(obj);
            string myString = JsonConvert.SerializeObject(obj);
            //string myString = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            fs.WriteLine(myString);
            fs.Close();


            //}
            //else
            //{
            //    StreamReader r = new StreamReader("file.json");
            //    var read = r.ReadToEnd();
            //    lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Student>>(read);
            //    r.Close();
            //}
            //if (lst == null)
            //{
            //    List<Student> _data = new List<Student>();
            //    _data.Add(obj);
            //    String json = Newtonsoft.Json.JsonConvert.SerializeObject(_data.ToArray());
            //    /*System.IO.File.WriteAllText("file.json", json);*/
            //    StreamWriter sw = File.AppendText("file.json");
            //    sw.WriteLine(json);
            //}
            //else
            //{
            //    lst.Add(obj);
            //    String json = Newtonsoft.Json.JsonConvert.SerializeObject(lst);
            //    //System.IO.File.WriteAllText("file.json", json);
            //    StreamWriter sw = File.AppendText("file.json");
            //    sw.WriteLine(json);

            //}
        }

        public Student()
        {

        }
        public Student(string id, string first, string middle, string last,int dep, int degree_)
        {
            Student st = new Student();
            st.studentId = id;
            st.firstName = first;
            st.middleName = middle;
            st.lastName = last;
            st.depart = dep;
            st.deg = degree_;
            addToJson(st);
            allStudents.Add(st);
        }

        public string ID
        {
            get { return studentId; }
            set { this.studentId = value; }
        }
        public string First
        {
            get { return firstName; }
            set { this.firstName = value; }
        }
        public string Mid
        {
            get { return middleName; }
            set { this.middleName = value; }
        }
        public string Last
        {
            get { return lastName; }
            set { this.lastName = value; }
        }
        public int Dept
        {
            get { return depart; }
            set { this.depart = value; }
        }
        public int Degree
        {
            get { return deg; }
            set { this.deg = value; }
        }
        public degree Deg
        {
            get { return (degree)deg; }
        }
        public dept Dep
        {
            get { return (dept)depart; }
        }
    }
}
