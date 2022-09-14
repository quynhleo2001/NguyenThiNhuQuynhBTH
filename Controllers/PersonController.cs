using Microsoft.AspNetCore.Mvc;
using NguyenThiNhuQuynhBTH.Models;
namespace NguyenThiNhuQuynhBTH.Controllers
{
   public class PersonController : Controller
   {
     public ActionResult Index()
     {
        List<Person> StdList= new List<Person>
        { 
            new Person { Age = 16, Address = "HaNoi", PhoneNumber = "0961218322" },
            new Person { Age = 15, Address = "DongDa", PhoneNumber = "0582303151" },
            new Person { Age = 16, Address = "HaNoi", PhoneNumber = "0986567341" },
        };
         ViewBag.ThongtinSV = StdList.Count();
            return View();
     }
     [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Person std)
    {
       ViewBag.thongtin = std.Age + "-" + std.Address + "-" + std.PhoneNumber;
        return View();
    }
   }
}