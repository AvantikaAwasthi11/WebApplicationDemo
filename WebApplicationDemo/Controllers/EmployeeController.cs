using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> employees = null;
        public EmployeeController() {

            if (employees == null)
            {
                employees = new List<Employee>()
                {
                    new Employee() { Id = 1, Name = "Ajay", Dept = "hr", Salary = 150 },

                    new Employee() { Id = 2, Name = "Rakhi", Dept = "CSE", Salary = 500 },

                    new Employee() { Id = 3, Name = "Nupoor", Dept = "Manager", Salary = 300 },

                    new Employee() { Id = 4, Name = "Avantika", Dept = "hr", Salary = 150 }
                };
            }
        }
       
        public IActionResult Index()
        {
            
           
            return View(employees.ToList());
        }
    }
}
