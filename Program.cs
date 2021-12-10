using System;

namespace StudentMgtSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student(22,"Saqib");
            Console.WriteLine(st.Name);
            Console.WriteLine("Hello World!");
        }
    }
}
