using Microsoft.AspNetCore.Mvc;
using DemoNguyenThiNhuQuynhBTH.Modles.Process;
using NguyenThiNhuQuynhBTH.Models.Process;

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
        
        StringProcess strPro = new StringProcess(); 
              
        public IActionResult Xulychuoi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Xulychuoi (string strInput)
        {
            string StringProcess = strPro.RemoveRemainingWhiteSpace(strInput);
            ViewBag.a = StringProcess;
            return View();
        }
         StringProcess strPr = new StringProcess();
         public IActionResult Viethoa()
        {
            return View();
        }
        //acction de nhan du loieu gui len
        [HttpPost]
        public IActionResult Viethoa (string strInput )
        {
            string StringProcess = strPr.UpperToLower(strInput);
            ViewBag.b = StringProcess;
    
           return View();
        }
      
        StringProcess strP = new StringProcess();
        public IActionResult Viethoakytudau()
        {
            return View();
        }
        //acction de nhan du lieu gui len
        [HttpPost]
        public IActionResult Viethoakytudau(string strInput )
        {
            string StringProcess= strP.CapitalizeOneFirstCharacter(strInput);
            ViewBag.c = StringProcess;
    
            return View();
        }
        StringProcess str =new StringProcess();
        public IActionResult mem()
        {
            return View();
        }
        //acction de nhan du loieu gui len
        [HttpPost]
        public IActionResult mem(string strInput )
        {
            string StringProcess= str.RemoveVietnameseAccents(strInput);
            ViewBag.d= StringProcess;
    
           return View();
        }
        StringProcess st =new StringProcess();
        public IActionResult memi()
       {
            return View();
       }
    
      //acction de nhan du loieu gui len
       [HttpPost]
       public IActionResult memi(string strInput )
       {
           string StringProcess= strPro.CapitalizeFirstCharacter(strInput);
           ViewBag.e= StringProcess;
    
           return View();
       }
        


    }
    
    
        
    
}