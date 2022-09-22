using Microsoft.AspNetCore.Mvc;
using DemoNguyenThiNhuQuynhBTH.Modles.Process;


namespace DemoNguyenThiNhuQuynhBTH.Controllers
{
    //khai bao class theo huong doi tuong
    

    public class DemoController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        //tao cac action thuc thi cac nhiem vu
        public IActionResult Index()
        {
            return View();
        }
        //action de nhan du lieu tu view gui len
        [HttpPost]
        public IActionResult Index(string heSoA, string heSoB, string heSoC)
        {
            double a = Convert.ToDouble(heSoA);
            double b = Convert.ToDouble(heSoB);
            double c = Convert.ToDouble(heSoC);

            string thongBao = gpt.GiaiPhuongTrinhBacHai(a,b,c);

            ViewBag.mess = thongBao;
            return View();


        }
    }
}