using Grpc.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Mvc;


namespace StudentMgtSystem
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Select a level");
            //string abc = Console.ReadLine();
            //Level myVar = (Level)Convert.ToInt32(abc);
            //Console.WriteLine(myVar);

           
            LoadJson();
            Console.WriteLine("----------------------------------");
            Student s1 = new Student("S01", "Mohammad", "Saqibul", "Alam", 1, 1);
            Student s2 = new Student("S02", "Mohammad", "Ajmain", "Alam", 2, 1);
            //Student s3 = new Student("S03", "Kawser", "Ibna", "Raihan", 3, 1);

            LoadJson();

            Console.WriteLine("\nWhat would you like to do \n1)Add new Student \n2)View Student details \n3)Delete Student");
            string firstChoice = Console.ReadLine();

            if (firstChoice == "1") {
                addStudent();
            }




        }
        public static void addStudent() {
            string fName, mName, lName, sID, jBatch;
            int dept, degree;
            Console.WriteLine("Please write your first name: ");
            fName = Console.ReadLine();
            Console.WriteLine("Please write your middle name: ");
            mName = Console.ReadLine();
            Console.WriteLine("Please write your last name: ");
            lName = Console.ReadLine();
            Console.WriteLine("Please write your student ID: ");
            sID = Console.ReadLine();
            Console.WriteLine("Please write your joining batch: ");
            jBatch = Console.ReadLine();
            Console.WriteLine("Please select the number that corresponds to your department:\n1) Computer Science\n2) BBA\n3) English ");
            dept = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select the number that corresponds to your degree:\n1) BSC\n2) BBA\n3) BS\n4) MSC\n5) MBA\n6) MA ");
            degree = int.Parse(Console.ReadLine());

            Student st = new Student(sID,fName,mName,lName,dept,degree);
        }

        public static void LoadJson() {
            string pathString = @"D:\AsthaIT\StudentManagementSystem\StudentMgtSystem\students.json";
            string fileName = "students.json";
            List<Student> ls = new List<Student>();
            string read = null;
            if (System.IO.File.Exists(pathString))
            {
                StreamReader r = new StreamReader(pathString);
                read = r.ReadToEnd();
                r.Close();
                if (read.Length > 5)
                {
                    //Console.WriteLine("There is already a file");
                    ls = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Student>>(read);
                    Console.WriteLine("The students currently enrolled are ");
                    foreach (Student st in ls)
                    {
                        Console.WriteLine(st.First + " " + st.Mid + " " + st.Last + " is pursuing " + st.Deg + " in " + st.Dep);
                    }
                }
                else
                {
                    Console.WriteLine("No students at the moment");
                    StreamReader r_ = new StreamReader(pathString);
                    read = r_.ReadToEnd();
                    Console.WriteLine(read.Length);
                    r_.Close();
                }
                
            }
            else {
                Console.WriteLine("Created Json File");
                FileStream _r = File.Create(pathString);
                byte[] bdata = Encoding.Default.GetBytes("[]");
                _r.Write(bdata, 0, bdata.Length);
                Console.WriteLine("No students at the moment");
                StreamReader r_ = new StreamReader(pathString);
                read = r_.ReadToEnd();
                Console.WriteLine(read);
                r_.Close();
                _r.Close();
            }
        }
    }
}
