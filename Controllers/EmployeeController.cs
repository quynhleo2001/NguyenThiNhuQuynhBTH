using Microsoft.AspNetCore.Mvc;
using NguyenThiNhuQuynhBTH.Models;
namespace NguyenThiNhuQuynhBTH.Controllers
{
  public class EmployeeController : Controller 
  {
    public ActionResult Index()
     {
        List<Employee> StdList= new List<Employee>
        { 
            new Employee { EmployeeID = 1, EmployeeName = "Quynh", Age = 15 },
            new Employee { EmployeeID = 2, EmployeeName = "Hien", Age = 16 },
            new Employee { EmployeeID = 3, EmployeeName = "Ha", Age = 17 },
        };
         ViewBag.SNV = StdList.Count();
            return View();
      }
      [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Employee std)
    {
       ViewBag.thongtinNhanVien = std.EmployeeID+ "-" + std.EmployeeName+ "-" + std.Age;
        return View();
    }
   }
}