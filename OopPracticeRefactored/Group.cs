using System;
using System.Collections.Generic;
using Bogus;

namespace OopPracticeRefactored
{
    public class Group
    {
        public List<Student> Students { get; } = new();
        public int Number { get; }
        public string Time { get; }
        public string Level { get; }


        public Group(string level, string time, int number)
        {
            if (string.IsNullOrWhiteSpace(level))
                throw new ArgumentNullException(nameof(level), "Level cannot be empty!");
            Level = level;
            if (string.IsNullOrWhiteSpace(time))
                throw new ArgumentNullException(nameof(time), "Time cannot be empty!");
            Time = time;
            if (number <= 0)
                throw new ArgumentException("Group number cannot be less than or equal to 0", nameof(number));
            Number = number;
        }

        public void RemoveStudentByName(string name)
        {
            Students.RemoveAll(student => student.Name == name);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Group #{Number}, level - {Level}, time - {Time}");
            if (Students.Count == 0)
            {
                Console.WriteLine("There are no students in this group!");
                return;
            }
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                Console.WriteLine(
                    $"{student.Name}, " +
                    $"Start date - {student.StartDate.ToShortDateString()}, " +
                    $"End course date -  {student.EndOfCourse.Date.ToShortDateString()}");
            }
        }

        public static Group CreateRandomGroup(int groupNumber)
        {
            var faker = new Faker();
            var randomLevel = faker.Random.ListItem(School.Levels);
            var randomTimeSlot = faker.Random.ListItem(School.TimeSlots);

            return new Group(randomLevel, randomTimeSlot, groupNumber);
        }
    }
}