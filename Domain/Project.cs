using Domain.Enums;

namespace Domain;

public class Project
{
    public int Id { get; }

    public string Name { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public ProjectPriorityEnum Priority { get; set; }

    public string ExecutiveCompanyName { get; set; }
    public string Client { get; set; }

    public Project()
    {
    }

    public Project(int id, string name,
        DateTime startDate,
        DateTime endDate,
        ProjectPriorityEnum priority,
        string executiveCompanyName,
        string client)
    {
        Id = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        StartDate = startDate;
        EndDate = endDate;
        ExecutiveCompanyName = executiveCompanyName ?? throw new ArgumentNullException(nameof(executiveCompanyName));
        Client = client ?? throw new ArgumentNullException(nameof(client));
        Priority = Enum.IsDefined(priority) ? priority : throw new ArgumentOutOfRangeException(nameof(priority));
    }
}