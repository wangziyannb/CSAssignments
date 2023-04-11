using ApplicationCore.Entities;
using Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial.Menu
{
    public class Menus
    {
        DepartmentService d;
        EmployeeService e;
        public Menus()
        {
            d = new DepartmentService();
            e = new EmployeeService();
        }


        public void Run()
        {
            while (true)
            {
                Console.WriteLine("please input option#");
                Console.WriteLine("1. Departments \n2. Employees");
                int x = Convert.ToInt32(Console.ReadLine()) - 1;
                OptionsServices mode = (OptionsServices)x;
                switch (mode)
                {
                    case OptionsServices.Departments:
                        RunOptionsDepartments();
                        break;
                    case OptionsServices.Employees:
                        RunOptionsEmployees();
                        break;
                }
            }
        }

        public void RunOptionsDepartments()
        {
            while (true)
            {
                Console.WriteLine("You are accessing Departments");
                Console.WriteLine("Please input option#");
                Console.WriteLine("1. Add \n2. Delete\n3. Update\n4. GetById\n5. GetAll\n6.Return to top level");
                int x = Convert.ToInt32(Console.ReadLine()) - 1;
                OptionsDepartments od = (OptionsDepartments)x;
                Console.Clear();
                switch (od)
                {
                    case OptionsDepartments.Add:
                        d.AddDepartment();
                        break;
                    case OptionsDepartments.Delete:
                        d.DeleteDepartment();
                        break;
                    case OptionsDepartments.Update:
                        d.UpdateDepartment();
                        break;
                    case OptionsDepartments.GetById:
                        d.GetDepartmentById();
                        break;
                    case OptionsDepartments.GetAll:
                        d.GetAllDepartments();
                        break;
                    case OptionsDepartments.Exit:
                        Console.Clear();
                        return;
                }
            }
        }
        public void RunOptionsEmployees()
        {
            while (true)
            {
                Console.WriteLine("You are accessing Employees");
                Console.WriteLine("Please input option#");
                Console.WriteLine("1. Add \n2. Delete\n3. Update\n4. GetById\n5. GetAll\n6. Return to top level");
                int x = Convert.ToInt32(Console.ReadLine()) - 1;
                OptionsEmployees oe = (OptionsEmployees)x;
                Console.Clear();
                switch (oe)
                {
                    case OptionsEmployees.Add:
                        e.AddEmployee();
                        break;
                    case OptionsEmployees.Delete:
                        e.DeleteEmployee();
                        break;
                    case OptionsEmployees.Update:
                        e.UpdateEmployee();
                        break;
                    case OptionsEmployees.GetById:
                        e.GetEmployeeById();
                        break;
                    case OptionsEmployees.GetAll:
                        e.GetAllEmployees();
                        break;
                    case OptionsEmployees.Exit:
                        Console.Clear();
                        return;
                }
            }
        }
        enum OptionsServices
        {
            Departments, Employees
        }

        enum OptionsDepartments
        {
            Add, Delete, Update, GetById, GetAll, Exit
        }

        enum OptionsEmployees
        {
            Add, Delete, Update, GetById, GetAll, Exit
        }
    }
}
