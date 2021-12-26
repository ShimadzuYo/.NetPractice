using System;
using OopPracticeRefactored.Helpers;

namespace OopPracticeRefactored.UI
{
    public static class StudentAddMenu
    {
        public static void Start(School school, int groupNumber)
        {
            var currentYear = DateTime.Now.Year;
            while (true)
            {
                Console.WriteLine("Enter the student's name please: ");
                var studentName = Console.ReadLine();

                Console.WriteLine("Enter the student's month of entry: ");
                var couldParseMonth = int.TryParse(Console.ReadLine(), out var month);
                if (!couldParseMonth)
                {
                    Console.WriteLine("Invalid month, failed to create a student");
                    return;
                }

                Console.WriteLine("Enter the student's day of entry:");
                var couldParseEntryDay = int.TryParse(Console.ReadLine(), out var dayOfEntry);
                if (!couldParseEntryDay)
                {
                    Console.WriteLine("Invalid entry day, failed to create a student");
                    return;
                }

                var studentEntryDate = new DateTime(currentYear, month, dayOfEntry);

                Console.WriteLine("Enter the student's marks:");
                var couldParseMarks = int.TryParse(Console.ReadLine(), out var marks);
                if (!couldParseMarks)
                {
                    Console.WriteLine("Invalid marks, failed to create a student");
                    return;
                }
                
                try
                {
                    var student = new Student(studentName, studentEntryDate, marks);
                    school.AddStudentToGroup(groupNumber - 1, student);
                    Console.WriteLine($"Student {studentName} has been successfully enrolled!");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Failed to create a student. Reason - {e.Message}");
                }

                Console.WriteLine("Y - add another student, any other input will stop adding students");
                var command = Console.ReadLine().NormalizeInput();
                if (command != "y")
                {
                    break;
                }
            }
        }
    }
}