

namespace _4._Students
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] inputParameters = command.Split();
                string firstName = inputParameters[0];
                string lastName = inputParameters[1];
                int age = int.Parse(inputParameters[2]);
                string homeTown = inputParameters[3];

                Student student = studentsList.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

                if(student != null)
                {
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    student = new Student(firstName, lastName, age, homeTown);
                    studentsList.Add(student);
                }                
            }

            string cityName = Console.ReadLine();

            List<Student> filteredStudentsList = studentsList
                .Where(student => student.HomeTown == cityName)
                .ToList();

            foreach (Student student in filteredStudentsList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
