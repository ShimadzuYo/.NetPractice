using Domain;


namespace Application.Interfaces
{

    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        void UpdateEmployee(int id, Employee employee);
        void DeleteEmployee(int id);
    }
}