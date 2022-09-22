using Microsoft.AspNetCore.Mvc;
using NguyenThiNhuQuynhBTH.Models;
 
namespace DemoNguyenThiNhuQuynhBTH.Modles.Process

{
    public class GiaiPhuongTrinh
    {
        //xay dung phuong thuc giai phuong trinh bac nhat
        public string GiaiPhuongTrinhBacNhat(double heSoA, double heSoB)
        {
            
            //truoc tien phai khai bao 1 bien de chua du lieu muon tra ve
            string message="";
            //giai phuong trinh
            //Khai bao 1 bien so de chua gia tri nghiem cua pt
            double x;
            if(heSoA==0){
                if(heSoB==0){
                    message = "Phuong trinh co vo so nghiem";
                }
                else {
                    message = "Phuong trinh vo nghiem";
                }

            }else{
                //tinh nghiem cua pt bac nhat
                x = -heSoB/heSoA;
                message = "Phuong trinh co nghiem x = " + x;
            }
            return message;
        }
        //phuong thuc giai phuong trinh bac 2
          public string GiaiPhuongTrinhBacHai(double a, double b, double c)
        {
            //giai phuong trinh bac 2
            string message = "";
            if(a==0){
                message = GiaiPhuongTrinhBacNhat(b,c);
            }
            else{
                //giai phuong trinh bac 2 khi a!= 0
                //tinh delta
                double delta = b*b - 4*a*c;
                double x1;
                double x2;
                //tinh nghiem
                if(delta > 0)
                {
                    x1 = (double)((-b + Math.Sqrt(delta))/(2*a));
                    x2 = (double)((-b - Math.Sqrt(delta))/(2*a));
                    message = "Phuong trinh co hai nghiem x1 = , x2 = ";
                }
                else if(delta == 0)
                {
                    x1 = x2 = (-b / (2*a));
                    message = "Phuong trinh co nghiem kep x1 = x2 ";
                }
                else{
                    message = "Phuong trinh vo nghiem!";
                }

            }
            return message;
        }
    }
    
}