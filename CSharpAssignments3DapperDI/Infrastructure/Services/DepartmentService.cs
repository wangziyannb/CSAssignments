using ApplicationCore.Entities;
using ApplicationCore.Services.Services;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly DepartmentRepository repository;
        public DepartmentService(DepartmentRepository repository)
        {
            this.repository = repository;
        }

        public void AddDepartment(Departments department)
        {
            if (repository.Insert(department) > 0)
            {
                Console.WriteLine("Successfully Inserted");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        public void DeleteDepartmentById(int id)
        {
            if (repository.DeleteById(id) > 0)
            {
                Console.WriteLine("Successfully Deleted");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        public IEnumerable<Departments> GetAllDepartments()
        {
            return repository.GetAll();
        }

        public Departments GetDepartmentById(int id)
        {
            return repository.GetById(id);
        }

        public void UpdateDepartment(Departments department)
        {
            if (repository.Update(department) > 0)
            {
                Console.WriteLine("Successfully Updated");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
