using ApplicationCore.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignments3DapperDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger,
            IDepartmentService departmentService,
            IEmployeeService employeeService
            )
        {
            _logger = logger;
            _departmentService = departmentService;
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Department()
        {
            return View();
        }

        public IActionResult AddDepartment(ApplicationCore.Entities.Departments d)
        {
            _departmentService.AddDepartment(d);
            return View("Department");
        }
        public IActionResult DeleteDepartmentById(ApplicationCore.Entities.Departments d)
        {
            _departmentService.DeleteDepartmentById(d.Id);
            return View("Department");
        }
        public IActionResult UpdateDepartment(ApplicationCore.Entities.Departments d)
        {
            _departmentService.UpdateDepartment(d);
            return View("Department");
        }
        public IActionResult GetDepartmentById(ApplicationCore.Entities.Departments d)
        {
            ViewBag.DepartmentById = _departmentService.GetDepartmentById(d.Id);
            return View("Department");
        }
        public IActionResult GetAllDepartments()
        {
            var ds = _departmentService.GetAllDepartments();
            ViewBag.Departments = ds;
            return View("Department");
        }
        public IActionResult Employee()
        {
            return View();
        }
        public IActionResult AddEmployee(ApplicationCore.Entities.Employees d)
        {
            _employeeService.AddEmployee(d);
            return View("Employee");
        }
        public IActionResult DeleteEmployeeById(ApplicationCore.Entities.Employees d)
        {
            _employeeService.DeleteEmployeeById(d.Id);
            return View("Employee");
        }
        public IActionResult UpdateEmployee(ApplicationCore.Entities.Employees d)
        {
            _employeeService.UpdateEmployee(d);
            return View("Employee");
        }
        public IActionResult GetEmployeeById(ApplicationCore.Entities.Employees d)
        {
            ViewBag.EmployeeById = _employeeService.GetEmployeeById(d.Id);
            return View("Employee");
        }
        public IActionResult GetAllEmployees()
        {
            var es = _employeeService.GetAllEmployees();
            ViewBag.Employees = es;
            return View("Employee");
        }
    }
}
