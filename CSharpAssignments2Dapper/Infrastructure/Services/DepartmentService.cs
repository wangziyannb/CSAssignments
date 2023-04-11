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
        DepartmentRepository repository;
        public DepartmentService()
        {
            repository = new DepartmentRepository();
        }

        public void AddDepartment()
        {
            Departments d = new Departments();
            Console.WriteLine("Enter name of Department: ");
            d.DeptName = Console.ReadLine();
            Console.WriteLine("Enter location:");
            d.Location = Console.ReadLine();
            if (repository.Insert(d) > 0)
            {
                Console.WriteLine("Successfully Inserted");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        public void DeleteDepartment()
        {
            Console.WriteLine("Enter id of Department: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (repository.DeleteById(id) > 0)
            {
                Console.WriteLine("Successfully Deleted");
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }

        public void UpdateDepartment()
        {
            var deptChanging = GetDepartmentById();
            Console.WriteLine("Enter new Dept name");
            deptChanging.DeptName = Console.ReadLine();
            Console.WriteLine("Enter new Dept location");
            deptChanging.Location = Console.ReadLine();
            if (repository.Update(deptChanging) > 0)
            {
                Console.WriteLine("Successfully Updated");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        public Departments GetDepartmentById()
        {
            Console.WriteLine("Enter id of Department: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Departments department = repository.GetById(id);
            Console.WriteLine($"{department.Id} \t {department.DeptName} \t {department.Location}");
            return department;
        }

        public void GetAllDepartments()
        {
            var departments = repository.GetAll();
            foreach (var department in departments)
            {
                Console.WriteLine($"{department.Id} \t {department.DeptName} \t {department.Location}");
            }
        }
    }
}
