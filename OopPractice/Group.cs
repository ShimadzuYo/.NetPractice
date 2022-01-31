using System;
using System.Collections.Generic;
using System.Linq;

namespace OopPractice
{
    public class Group
    {
        private static int MaxCapacity = 12;
        private List<Student> Class = new();
        private List<Graduated> GraduatedStudents = new();
        private List<Student> GraduatedWithHonorsStudents = new();
        private List<Student> Failed = new();
        public int Number;
        public string Time;
        public string Level;

        private static readonly List<string> LevelsMath = new()
        {
            "beginner", "intermediate", "advanced"
        };
        
        private static readonly List<string> LevelsEng = new()
        {
            "beginner", "elementary", "pre-intermediate", "intermediate"
        };

        

        private static readonly List<string> TimeSlots = new()
        {
            "8:30", "10:00", "12:00", "14:30", "16:00"
        };
        
        


        public Group()
        {
            
        }


        public void WorkWithGroupRefactored()
        {
            Console.WriteLine("What would you like to do?\n Class commands:\n" +
                              "'info' = print out all the info on a group\n" +
                              "'add' = add a student\n" +
                              "'edit' = edit info on a certain student\n" +
                              "'exit' = exit");
            Console.WriteLine($"You have chosen group number {Number} {Level} {Time}");
            var command = Console.ReadLine()!.Trim();
            while (command != "exit")
            {
                switch (command)
                {
                    case "add":
                        CreateAndAddStudent();
                        break;

                    case "simulate":
                        GraduatedStudents.Clear();
                        Failed.Clear();
                        GraduatedWithHonorsStudents.Clear();
                        foreach (var stud in Class)
                        {
                            stud.SimulateStudent();
                            switch (stud.status)
                            {
                                case "Graduated":
                                {
                                    var graduatedStudent = new Graduated(stud.name, stud.surname, stud.StartDate,
                                        stud.Marks);
                                    GraduatedStudents.Add(graduatedStudent);
                                    break;
                                }
                                case "Honors":
                                    GraduatedWithHonorsStudents.Add(stud);
                                    break;
                                case "Failed":
                                    Failed.Add(stud);
                                    break;
                            }
                        }

                        break;
                    case "results":
                        OutputResultsRefactored();
                        break;
                    case "info":
                        PrintInfo();
                        break;
                    case "edit":
                        Console.WriteLine("Enter student`s name please:");
                        var name = Console.ReadLine()?.Trim();
                        Console.WriteLine("Enter student`s surname please:");
                        var surname = Console.ReadLine()?.Trim();

                        foreach (var editCandidate in Class.Where(stud => stud.name == name && stud.surname == surname))
                        {
                            editCandidate.EditStudentRefactored();
                        }

                        break;
                    case "remove":
                        RemoveStudentByFullName();
                        break;

                    case "exit":
                        break;
                }

                Console.WriteLine("What next?");
                command = Console.ReadLine()!.Trim();
            }
        }

        private void CreateAndAddStudent()
        {
            while (true)
            {
                Console.WriteLine("Enter the student's name please: ");
                var studentName = Console.ReadLine();
                Console.WriteLine("Enter the student`s surname please:");
                var studentSurname = Console.ReadLine();
                var year = DateTime.Now.Year;
                Console.WriteLine("Enter the student's month of entry: ");
                var month = int.Parse(Console.ReadLine() ?? string.Empty);
                Console.WriteLine("Enter the student's day of entry: ");
                var day = int.Parse(Console.ReadLine() ?? string.Empty);
                DateTime studentEntryDate = new DateTime(year, month, day);
                var stud = new Student(studentName, studentSurname, studentEntryDate);
                Class.Add(stud);
                Console.WriteLine("Would you like to continue? Y or N");
                var command = Console.ReadLine()?.ToUpper().Trim();
                if (command == "N" || Class.Count > MaxCapacity)
                {
                    break;
                }
            }
        }

        private void PrintInfo()
        {
            foreach (var stud in Class)
            {
                Console.WriteLine(
                    $"{stud.name} {stud.surname} {stud.StartDate.ToShortDateString()} {stud.EndOfCourse.Date.ToShortDateString()}");
            }

            if (Class.Count == 0)
            {
                Console.WriteLine("This class is currently empty");
            }
        }

        private void RemoveStudentByFullName()
        {
            Console.WriteLine("Enter their name please: ");
            var name = Console.ReadLine();
            Console.WriteLine("Now their surname please:");
            var surname = Console.ReadLine();
            foreach (var student in Class)
            {
                if (name == student.name && surname == student.surname)
                {
                    Class.Remove(student);

                    Failed.Remove(student);
                    GraduatedWithHonorsStudents.Remove(student);
                    break;
                }
            }
        }


        // public void OutputResults()
        // {
        //     Console.WriteLine("Honorary graduates:");
        //     // this for each loop is repeated 3 times, you could utilize the fact
        //     // that all 3 lists contain 'Student's and create a helper method to output 
        //     // students names and marks (see OutputResultsRefactored & PrintStudents below)
        //     foreach (var honor in GraduatedWithHonorsStudents)
        //     {
        //         Console.WriteLine($"{honor.name} {honor.marks}");
        //     }
        //
        //     Console.WriteLine("Regular dummies:");
        //     foreach (var normie in GraduatedStudents)
        //     {
        //         Console.WriteLine($"{normie.name} {normie.marks}");
        //     }
        //
        //     Console.WriteLine("The actual dumbasses:");
        //     foreach (var retard in Failed)
        //     {
        //         Console.WriteLine($"{retard.name} {retard.marks}");
        //     }
        // }

        private void OutputResultsRefactored()
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
                Console.WriteLine($"{student.name} {student.surname} {student.Marks}");
            }
        }

        private void PrintStudents(List<Graduated> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.name} {student.surname} {student.Marks}");
            }
        }

        public void GenerateRandomEngGroup()
        { 
                // Random object is generated on each loop iteration, better to move it outside the loop
                // so it is created once
                var rand = new Random();
                var die = rand.Next(0, LevelsEng.Count);

                for (var j = 0; j < LevelsEng.Count; j++)
                {
                    if (j == die)
                    {
                        Level = LevelsEng[j];
                    }
                }

                for (var k = 0; k < LevelsEng.Count; k++)
                {
                    if (k == die)
                    {
                        Time = TimeSlots[k];
                    }
                }
        }
        public void GenerateRandomMathGroup()
        { 
            // Random object is generated on each loop iteration, better to move it outside the loop
            // so it is created once
            var rand = new Random();
            var die = rand.Next(0, LevelsMath.Count);

            for (var j = 0; j < LevelsMath.Count; j++)
            {
                if (j == die)
                {
                    Level = LevelsMath[j];
                }
            }

            for (var k = 0; k < TimeSlots.Count; k++)
            {
                if (k == die)
                {
                    Time = TimeSlots[k];
                }
            }
        }
    }
}