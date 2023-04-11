using ApplicationCore.Entities;

namespace ApplicationCore.Services.Services
{
    public interface IDepartmentService
    {
        void AddDepartment();
        void DeleteDepartment();
        void GetAllDepartments();
        Departments GetDepartmentById();
        void UpdateDepartment();
    }
}