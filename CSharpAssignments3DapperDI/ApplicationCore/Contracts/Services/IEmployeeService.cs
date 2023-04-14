using ApplicationCore.Entities;

namespace ApplicationCore.Services.Services
{
    public interface IEmployeeService
    {
        void AddEmployee(Employees employee);
        void DeleteEmployeeById(int id);
        IEnumerable<Employees> GetAllEmployees();
        Employees GetEmployeeById(int id);
        void UpdateEmployee(Employees employee);
    }
}