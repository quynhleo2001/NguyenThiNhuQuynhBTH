using Microsoft.AspNetCore.Mvc;
using NguyenThiNhuQuynhBTH.Models;
namespace NguyenThiNhuQuynhBTH.Controllers
{
    public class StudentController : Controller 
    {
        //viet cac phuong thuc thao tac CRUD
        // lay du lieu cua doi tuong Student
        public IActionResult Index()
        {
            //khởi tạo list Student
            List<Student> StdList = new List<Student>()
            {
                new Student{ StudentID=1, StudentName="Nguyen Van A", Age=18},
                new Student{ StudentID=2, StudentName="Nguyen Van A", Age=18},
                new Student{ StudentID=3, StudentName="Nguyen Van A", Age=18},
                new Student{ StudentID=4, StudentName="Nguyen Van A", Age=18},

            };
            ViewData["Student"] = StdList;
            return View(StdList);

        }
    }

}