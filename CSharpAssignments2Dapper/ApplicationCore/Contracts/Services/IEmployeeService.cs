using ApplicationCore.Entities;

namespace ApplicationCore.Services.Services
{
    public interface IEmployeeService
    {
        void AddEmployee();
        void DeleteEmployee();
        void GetAllEmployees();
        Employees GetEmployeeById();
        void UpdateEmployee();
    }
}