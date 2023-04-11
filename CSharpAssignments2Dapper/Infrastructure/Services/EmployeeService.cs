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
        public EmployeeService()
        {
            repository = new EmployeeRepository();
        }
        public void AddEmployee()
        {
            Employees e = new Employees();
            Console.WriteLine("Enter First Name of Employee: ");
            e.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name of Employee: ");
            e.LastName = Console.ReadLine();
            Console.WriteLine("Enter Salary:");
            e.Salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter DeptId:");
            e.DeptId = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (repository.Insert(e) > 0)
                {
                    Console.WriteLine("Successfully Inserted");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void DeleteEmployee()
        {
            Console.WriteLine("Enter id of Employee: ");
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

        public void GetAllEmployees()
        {
            var employees = repository.GetAll();
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Id} \t {employee.FirstName} \t {employee.LastName}\t {employee.Salary}\t {employee.DeptId}");
            }
        }

        public Employees GetEmployeeById()
        {
            Console.WriteLine("Enter id of Employee: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Employees employee = repository.GetById(id);
            Console.WriteLine($"{employee.Id} \t {employee.FirstName} \t {employee.LastName}\t {employee.Salary}\t {employee.DeptId}");
            return employee;
        }

        public void UpdateEmployee()
        {
            var e = GetEmployeeById();
            Console.WriteLine("Enter new First Name: ");
            e.FirstName = Console.ReadLine();
            Console.WriteLine("Enter new Last Name: ");
            e.LastName = Console.ReadLine();
            Console.WriteLine("Enter new Salary:");
            e.Salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter DeptId:");
            e.DeptId = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (repository.Update(e) > 0)
                {
                    Console.WriteLine("Successfully Updated");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
