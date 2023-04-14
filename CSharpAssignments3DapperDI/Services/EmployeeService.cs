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
    public class EmployeeService : IEmployeeService
    {
        EmployeeRepository repository;
        public EmployeeService(EmployeeRepository repository)
        {
            this.repository = repository;
        }

        public void AddEmployee(Employees employee)
        {
            if (repository.Insert(employee) > 0)
            {
                Console.WriteLine("Successfully Inserted");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        public void DeleteEmployeeById(int id)
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

        public IEnumerable<Employees> GetAllEmployees()
        {
            return repository.GetAll();
        }

        public Employees GetEmployeeById(int id)
        {
            return repository.GetById(id);
        }

        public void UpdateEmployee(Employees employee)
        {
            if (repository.Update(employee) > 0)
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
