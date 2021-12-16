
using Grpc.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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


            string x = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            Console.WriteLine(x);

            var toAdd = "";

            if (System.IO.File.Exists(pathString)) // check if there is a students.json file.
            {
                StreamReader r = new StreamReader(pathString);
                read = r.ReadToEnd();
                Console.WriteLine("Reading :  "+read);
                r.Close();
                //Console.WriteLine("There is already a file");
                if (read.Length > 2)
                {
                    lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Student>>(read);
                    foreach (Student i in lst)
                    {
                        if (obj.ID == i.ID)
                        {
                            Console.WriteLine("User with the same ID already exists");
                            return;
                        }
                    }
                    toAdd = read.Substring(0 , read.Length - 1)  + "," + x + "]"; // string to be contatenated
                    Console.WriteLine(toAdd + " This is to be added");
                }
                else {
                    toAdd = read.Substring(0 , read.Length - 1) + x + "]"; // string to be contatenated
                    Console.WriteLine(toAdd + " This is to be added");
                }

                

                //string data = File.ReadAllText(pathString);
                //Console.WriteLine(data);
            }

            Console.WriteLine("Adding " + toAdd);
            StreamWriter fs = new StreamWriter(pathString);
            fs.Write(toAdd);
            fs.Close();
            
            //if (!System.IO.File.Exists(pathString))
            //{

            //StreamWriter fs = new StreamWriter(pathString,true);
            //lst.Add(obj);
            //string myString = JsonConvert.SerializeObject(obj);
            ////string myString = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            //fs.WriteLine(myString);
            //fs.Close();


            //}
            //else
            //{
            //    StreamReader r = new StreamReader("file.json");
            //    var read = r.ReadToEnd();
            //    lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Student>>(read);
            //    r.Close();
            //}

            


            //FileStream r_ = File.Create(pathString);
            //byte[] bdata = Encoding.Default.GetBytes(toAdd);
            //r_.Write(bdata, 0, bdata.Length);
            //r_.Close();


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
            get { return this.studentId; }
            set { this.studentId = value; }
        }
        public string First
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string Mid
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }
        public string Last
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public int Dept
        {
            get { return this.depart; }
            set { this.depart = value; }
        }
        public int Degree
        {
            get { return this.deg; }
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
