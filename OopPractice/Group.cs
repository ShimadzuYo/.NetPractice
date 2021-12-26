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
        // I'm not sure about this, but doesn't school dictate the marks thresholds?
        // I think group should not care about which students in group are good or bad
        // I see group as just a container that aggregates students and provide some logic 
        // to add/remove students
        // And then school will make a decision about a group because it defines standards for graduation
        // But that depends on your perspective and I might be wrong
        public int HonorsMark = 400;
        public int GraduationMark = 300;
        public string Time;
        public string Level;


        // FYI
        // Good practice to avoid 'bad' object initialization on the object creation, i.e. in Constructor
        // This will avoid having bad objects to spread in your program
        // You can do it the following way
        // public Group(string level, string time)
        // {
        //     if (string.IsNullOrWhiteSpace(level))
        //         throw new ArgumentNullException(nameof(level), "Level cannot be empty!");
        //     Level = level; 
        //     if (string.IsNullOrWhiteSpace(time))
        //         throw new ArgumentNullException(nameof(time), "Time cannot be empty!");
        //     Time = time;
        // }
        // This way you are sure, that your program will always have valid 'group' objects
        // In case there is an attempt of creating a 'bad' group (like with level = null or '')
        // your program will immediately report this with exception mechanism
        // this may prevent lots of different bugs and errors
        // It is good because you will be sure that whenever you are dealing with any 'Group' object 
        // it is in valid state and will not have side effects
        // e.g. imagine if you you had a group with level=null and somewhere else would try to do something with this
        // like capitalize it (level.ToUpper()) - this would throw NulLReferenceException 
        // since level is 'null' and 'null' does not have 'ToUpper()' method
        public Group(string level, string time)
        {
            Level = level;
            Time = time;
        }

        // Ideally, group should not be aware of how a student is created and be responsible to create it
        // Better to have
        // public void AddStudent(Student student)
        // {
        //     Class.Add(student);
        // }
        // But that's ok here, since the method name reflects its intention 
        
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

        // good
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

        // Better to name it RemoveStudentByName
        // Good
        public void RemoveStudent(string name)
        {
            // FYI
            // Could be rewritten like Class.RemoveAll(student => student.name == name); 
            // but that would remove all students with the same name, so your solution is better in that sense
            // However, if you have 2 "John's", this method will remove only "John" who appears first
            // This is already another problem and up to you how to build this logic.
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
            // this for each loop is repeated 3 times, you could utilize the fact
            // that all 3 lists contain 'Student's and create a helper method to output 
            // students names and marks (see OutputResultsRefactored & PrintStudents below)
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
        
        public void OutputResultsRefactored()
        {
            Console.WriteLine("Honorary graduates:");
            PrintStudents(GraduatedWithHonorsStudents);

            Console.WriteLine("Regular dummies:");
            PrintStudents(GraduatedStudents);
            
            Console.WriteLine("The actual dumbasses:");
            PrintStudents(Failed);
        }

        private void PrintStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.name} {student.marks}");
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