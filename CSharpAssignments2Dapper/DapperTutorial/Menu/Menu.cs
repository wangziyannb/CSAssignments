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
        DepartmentService s;
        public Menus()
        {
            s = new DepartmentService();

        }

        public void Greeting()
        {
            Console.WriteLine("please input option#");
            Console.WriteLine("1. Add \n2. Delete\n3. Update\n4. GetById\n5. GetAll");
        }

        public void Run()
        {
            Greeting();
            while (true)
            {
                int x = Convert.ToInt32(Console.ReadLine()) - 1;
                Options o = (Options)x;
                Console.Clear();
                switch (o)
                {
                    case Options.Add:
                        s.AddDepartment();
                        break;
                    case Options.Delete:
                        s.DeleteDepartment();
                        break;
                    case Options.Update:
                        s.UpdateDepartment();
                        break;
                    case Options.GetById:
                        s.GetDepartmentById();
                        break;
                    case Options.GetAll:
                        s.GetAllDepartments();
                        break;
                }

                Greeting();

            }
        }

        enum Options
        {
            Add, Delete, Update, GetById, GetAll
        }
    }
}
