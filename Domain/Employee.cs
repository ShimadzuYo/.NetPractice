

namespace Domain
{

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }

        public Employee()
        {
        }

        public Employee(string id, string firstName, string lastName, string middleName, string email)
        {
            Id = Convert.ToInt32(id ?? throw new ArgumentNullException(nameof(id)));
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            MiddleName = middleName ?? throw new ArgumentNullException(nameof(middleName));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }
    }
}