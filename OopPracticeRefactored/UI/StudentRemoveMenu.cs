using System;

namespace OopPracticeRefactored.UI
{
    public class StudentRemoveMenu
    {
        public static void Start(School school, int groupNumber)
        {
            Console.WriteLine(
                "Please enter the name of the unfortunate sap you are trying to boot from your class:");
            var studentNameToDelete = Console.ReadLine();
            school.RemoveStudentFromGroup(groupNumber - 1, studentNameToDelete);
            Console.WriteLine($"Student {studentNameToDelete} has been kicked out");
        }
    }
}