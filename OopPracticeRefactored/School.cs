using System;
using System.Collections.Generic;
using System.Linq;

namespace OopPracticeRefactored
{
    public class School
    {
        private readonly List<Group> _groupList = new();

        public static readonly List<string> Levels = new()
        {
            "Beginner", "Elementary", "Pre-intermediate", "Intermediate"
        };

        public static readonly List<string> TimeSlots = new()
        {
            "8:30", "10:00", "12:00", "14:30", "16:00"
        };

        private const int HonorsMark = 400;
        private const int GraduationMark = 300;

        public void AddGroup(Group group)
        {
            _groupList.Add(group);
        }

        public int GroupCount()
        {
            return _groupList.Count;
        }

        public void PrintGroupInfo(int groupNumber)
        {
            _groupList[groupNumber - 1].PrintInfo();
        }


        public void PrintGroupsWithStudents()
        {
            foreach (var group in _groupList)
            {
                group.PrintInfo();
                Console.WriteLine();
            }
        }

        public void PrintStudentsResults()
        {
            // This might appear very confusing this SelectMany, but it is pretty simple
            // If you have some list of objects (in this case we have list of groups)
            // and each of this objects holds some other list (each group has list of groups)
            // you can select ALL the students by using SelectMany.
            // It will take all students from each group and flatter them into one list
            var allStudents = _groupList.SelectMany(x => x.Students)
                .ToList();
            var honoraryGraduates = allStudents.Where(IsStudentGraduatedWithHonors).ToList();
            
            if (honoraryGraduates.Count == 0)
                Console.WriteLine("Retarded generation - there are no Honorary graduates!");
            else
            {
                Console.WriteLine("Honorary graduates:");
                foreach (var student in honoraryGraduates)
                {
                    Console.WriteLine(student);
                }
            }

            var graduatedStudents = allStudents.Where(IsStudentGraduated).ToList();
            if (graduatedStudents.Count == 0)
                Console.WriteLine("Braindead generation - no graduates at all!");
            else
            {
                Console.WriteLine("Regular dummies:");
                foreach (var student in graduatedStudents)
                {
                    Console.WriteLine(student);
                }
            }
            
            Console.WriteLine("The actual dumbasses:");
            foreach (var student in allStudents.Where(IsStudentRetard))
            {
                Console.WriteLine(student);   
            }
        }

        private static bool IsStudentGraduatedWithHonors(Student student)
        {
            return student.Marks >= HonorsMark;
        }
        
        private static bool IsStudentGraduated(Student student)
        {
            return student.Marks < HonorsMark && student.Marks >= GraduationMark;
        }

        private static bool IsStudentRetard(Student student)
        {
            return student.Marks < GraduationMark;
        }
        

        // This is a factory method. It must be static because it does not really belong to any
        // single school object, but to all the School objects.
        // And this is a static by a reason that we should be able to call without actually instantiating a 'School'
        // Instead of 'var school = new School()' we can do 'var school = School.CreateWithRandomGroups()'
        // The good thing about this being static is if it is not static that we can do that method with any
        // existing school object which might be not desirable
        // because you could have a valid school like
        // var school = new School();
        // school.CreateWithRandomGroups();
        // do something, modify school
        // but then if still can do school.CreateWithRandomGroups() again which might 'mess' the previous school state
        public static School CreateWithRandomGroups(int groupsCount, int maxNumberOfStudents = 5)
        {
            var random = new Random();
            var school = new School();
            for (var groupNumber = 0; groupNumber < groupsCount; groupNumber++)
            {
                var randomGroup = Group.CreateRandomGroup(groupNumber + 1);
                var studentsCount = random.Next(1, maxNumberOfStudents);
                for (var j = 0; j < studentsCount; j++)
                {
                    var randomStudent = Student.CreateRandomStudent();
                    randomGroup.Students.Add(randomStudent);
                }

                school.AddGroup(randomGroup);
            }

            return school;
        }


        public void AddStudentToGroup(int groupNumber, Student student)
        {
            if (groupNumber < 0 || groupNumber >= _groupList.Count)
                throw new ArgumentException("There is no such group!", nameof(groupNumber));

            _groupList[groupNumber].Students.Add(student);
        }

        public void RemoveStudentFromGroup(int groupNumber, string studentName)
        {
            _groupList[groupNumber].RemoveStudentByName(studentName);
        }
    }
}