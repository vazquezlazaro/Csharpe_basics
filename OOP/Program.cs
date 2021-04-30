using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    enum School
    {
        WhiteOak,
        Croatan
    }
    class Program
    {
         static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
           

            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");
                    
                    newStudent.Grade= Util.Console.AskInt("Student Grade: ");

                    newStudent.school = (School) Util.Console.AskInt("Student School: Type the corresponding number:\n0) White Oak \n1) Croatan\n");
                    
                    newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                    newStudent.Address = Util.Console.Ask("Student Address: ");

                    newStudent.Phone = Util.Console.AskInt("Student Phone Number: ");

                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student Count: {0}", Student.Count);

                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                        adding = false;

                }
                catch(FormatException msg){
                    Console.WriteLine(msg.Message);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Error, Please adding student again.");
                }
                

                foreach (var student in students)
                {
                    Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
                } 
                Export();

                
        }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "birthday", "address", 123456);
            Console.WriteLine(importedStudent.Name);
        }
        static void Export()
        {
            foreach (var student in students)
            {
                switch (student.school)
                {
                    case School.WhiteOak:
                        Console.WriteLine("Exporting to White Oak");
                        break;
                    case School.Croatan:
                        Console.WriteLine("Exporting to Croatan");
                        break;
                }
            }
        }
        
    }

    class Member
    {
        public string Name;
        public string Address;
        protected int phone;

        public int Phone
        {
            set { phone = value; }
        }
    }

    class Student : Member
    {
        static public int Count = 0;

        public int Grade;
        public string Birthday;
        public School school;

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }

    class Teacher : Member
    {
        public string Subject;
    }
}
}
