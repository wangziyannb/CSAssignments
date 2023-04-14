using ApplicationCore.Entities;

namespace ApplicationCore.Services.Services
{
    public interface IDepartmentService
    {
        void AddDepartment(Departments department);
        void DeleteDepartmentById(int id);
        IEnumerable<Departments> GetAllDepartments();
        Departments GetDepartmentById(int id);
        void UpdateDepartment(Departments department);
    }
}