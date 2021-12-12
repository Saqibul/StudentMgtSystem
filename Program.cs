using System;
using System.IO;

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

            Student s1 = new Student("S01", "Mohammad", "Saqibul", "Alam", 1, 1);
            Student s2 = new Student("S02", "Mohammad", "Ajmain", "Alam", 2, 1);
            Student s3 = new Student("S03", "Kawser", "Ibna", "Raihan", 3, 1);


            //Show List of students
            Console.WriteLine("The students currently enrolled are ");
            foreach (Student st in Student.allStudents)
            {
                Console.WriteLine(st.First + " " + st.Mid + " " + st.Last + " is pursuing " + st.Deg + " in " + st.Dep);
            }

            Console.WriteLine("\nWhat would you like to do \n1)Add new Student \n2)View Student details \n3)Delete Student");
            string firstChoice = Console.ReadLine();


            //string GuarnteedWritePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //string FilePath = System.IO.Path.GetDirectoryName(GuarnteedWritePath);
            //string pathString = @"D:\AsthaIT\StudentManagementSystem\StudentMgtSystem\file.json";
            //string fileName = "file.json";

            //if (!System.IO.File.Exists(pathString))
            //{
            //    using (System.IO.FileStream fs = System.IO.File.Create(pathString))
            //    {

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("File \"{0}\" already exists.", fileName);
            //    return;
            //}

        }
    }
}
