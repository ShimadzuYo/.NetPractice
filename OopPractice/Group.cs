using System;
using System.Collections.Generic;

namespace OopPractice
{
    public class Group
    {
        public static int MaxCapacity = 12;
        public List<Student> Class = new();
        public List<Student> GraduatedStudents = new();
        public List<Student> GraduatedWithHonorsStudents = new();
        public List<Student> Failed = new();
        public int Number;
        public int HonorsMark = 400;
        public int GraduationMark = 300;
        public string Time;
        public string Level;


        public Group(string level, string time)
        {
            Level = level;
            Time = time;
        }

        public void CreateAndAddStudent()
        {
            while (true)
            {
                Console.WriteLine("Enter the student's name please: ");
                var studentName = Console.ReadLine();
                var year = DateTime.Now.Year;
                Console.WriteLine("Enter the student's month of entry: ");
                var month = int.Parse(Console.ReadLine() ?? string.Empty);
                Console.WriteLine("Enter the student's day of entry: ");
                var day = int.Parse(Console.ReadLine() ?? string.Empty);
                DateTime studentEntryDate = new DateTime(year, month, day);
                var stud = new Student(studentName, studentEntryDate);
                Class.Add(stud);
                Console.WriteLine("Would you like to continue? Y or N");
                var command = Console.ReadLine()?.ToUpper().Trim();
                if (command == "N")
                {
                    break;
                } 
            }
        }

        public void PrintInfo()
        {
            foreach (var stud in Class)
            {
                Console.WriteLine(
                    $"{stud.name} {stud.StartDate.ToShortDateString()} {stud.EndOfCourse.Date.ToShortDateString()}");
            }

            if (Class.Count == 0)
            {
                Console.WriteLine("This class is currently empty");
            }
        }

        public void RemoveStudent(string name)
        {
            foreach (var student in Class)
            {
                if (name == student.name)
                {
                    Class.Remove(student);
                    break;
                }
            }
        }


        public void OutputResults()
        {
            Console.WriteLine("Honorary graduates:");
            foreach (var honor in GraduatedWithHonorsStudents)
            {
                Console.WriteLine($"{honor.name} {honor.marks}");
            }

            Console.WriteLine("Regular dummies:");
            foreach (var normie in GraduatedStudents)
            {
                Console.WriteLine($"{normie.name} {normie.marks}");
            }
            Console.WriteLine("The actual dumbasses:");
            foreach (var retard in Failed)
            {
                Console.WriteLine($"{retard.name} {retard.marks}");
            }
        }

        public void SimulateResults()
        {
            foreach (var stud in Class)
            {
                stud.SimulateStudent();
                if (stud.marks < GraduationMark)
                {
                    Failed.Add(stud);
                }

                if (stud.marks > GraduationMark && stud.marks < HonorsMark)
                {
                    GraduatedStudents.Add(stud);
                }

                if (stud.marks > HonorsMark)
                {
                    GraduatedWithHonorsStudents.Add(stud);
                }
            }
        }
    }
}