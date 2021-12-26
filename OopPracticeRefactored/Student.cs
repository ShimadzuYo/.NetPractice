using System;
using Bogus;

namespace OopPracticeRefactored
{
    public class Student
    {
        private readonly Random _random = new();
        public string Name { get; }

        // These are properties, not fields to have getter and setter
        // In this case there is no setter, because once someone creates a Student 
        // They cannot change their StartDate and EndOfCourse, just look at it
        public DateTime StartDate { get; }
        public DateTime EndOfCourse { get; }
        public readonly TimeSpan CourseLength = TimeSpan.FromDays(60);

        // This is the actual marks that your student object works with
        private int _marks;

        // this is basically an interface to the 'world' of Marks
        // Anyone can see the marks, because there is a getter
        // And anyone can edit a student's marks, but there is also a validation inside of it
        // In case of bad input (marks are <= 0) 
        public int Marks
        {
            get => _marks;
            private set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Marks cannot be less than 0");
                _marks = value;
            }
        }

        public Student(string name, DateTime startDate, int marks)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Student name cannot be empty");
            Name = name;
            StartDate = startDate;
            if (marks < 0)
                throw new ArgumentException("Student cannot have marks less than 0", nameof(marks));
            Marks = marks;
            EndOfCourse = startDate + CourseLength;
        }

        public static Student CreateRandomStudent()
        {
            // I have utilized a fun library here called 'Bogus' which allows to create some dummy objects
            // with some 'real' values.
            // you can check it out here:
            // https://github.com/bchavez/Bogus
            // there is an example on that page.
            // In fact, I have not used it before :) I just checked their example and followed it
            // BTW, the reason I cannot do like in the bogus examples, like
            // new Faker<Student>()
            //     .RuleFor(x => x.Name, f => f.FullName())
            //     .Generate();
            // is because it cannot work when there are properties without setters
            // BUT, there is a library AutoBogus, that helps with that issue. I've tried it
            // but for some fucking reason it did not work, so I gave up
            // and decided to create values manually with faker.
            // Anyway, that's an example of a nice library :) 

            var faker = new Faker();
            var randomName = faker.Name.FullName();
            var randomMarks = faker.Random.Int(150, 450);
            var randomStartData = faker.Date.Past();
            var randomStudent = new Student(randomName, randomStartData, randomMarks);
            return randomStudent;
        }

        // You can override this so when someone tries to convert Student as string, this will be called
        // E.g. Console.WriteLine(student) - will result in printing "{student.Name}, marks - {student.Marks}"
        public override string ToString()
        {
            return $"{Name}, marks - {Marks}";
        }
    }
}