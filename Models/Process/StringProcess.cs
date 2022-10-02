using Microsoft.AspNetCore.Mvc;
using DemoNguyenThiNhuQuynhBTH.Modles.Process;


namespace NguyenThiNhuQuynhBTH.Models.Process 
{
    public class StringProcess 
  
    {
        public string RemoveRemainingWhiteSpace (string strInput)
        {
            string strResult = "";
            //viet code xu ly cac ki tu trang con thua
            //xoa bo ki tu trang o dau va cuoi chuoi
            strInput = strInput.Trim();
            //xoa bo cac ki tu trang con thua o giua chuoi
            int Index = strInput.IndexOf(" ");
            while(strInput.IndexOf("  ")>0){
                strInput = strInput.Replace("  ", " ");
            }
            strResult = strInput;
            return strResult ;
      
        }
        public string UpperToLower (string strInput)
        {
            string strResult = "";
            strInput = strInput.ToLower();
             strResult = strInput;
            return strResult ;

        }
        
        public string CapitalizeOneFirstCharacter (string strInput)
           {
             string StrResult="";
            string  FirstCharacter =strInput.Substring(0,1).ToUpper();
            StrResult= FirstCharacter + strInput.Substring(1);
            return StrResult;
           }

        public string RemoveVietnameseAccents (string strInput)
        {
             string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",  
            "đ",  
            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",  
            "í","ì","ỉ","ĩ","ị",  
           "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",  
           "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",  
           "ý","ỳ","ỷ","ỹ","ỵ",};  
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",  
           "d",  
           "e","e","e","e","e","e","e","e","e","e","e",  
            "i","i","i","i","i",  
           "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",  
          "u","u","u","u","u","u","u","u","u","u","u",  
          "y","y","y","y","y",};  
           for (int i = 0; i < arr1.Length; i++)  
        {  
            strInput = strInput.Replace(arr1[i], arr2[i]);  
            strInput = strInput.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());  
        }  
            return strInput; 
        }
        public string  CapitalizeFirstCharacter (string strInput)
        { 
            strInput = strInput.ToLower();
            char[] array =strInput.ToCharArray();  
             if (array.Length >= 1)
        {
             if (char.IsLower(array[0]))
        {
            array[0] = char.ToUpper(array[0]);
        }
        }  
  
            for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == ' ')
        {
            if (char.IsLower(array[i]))
            {
                array[i] = char.ToUpper(array[i]);
            }
        }
        }
            return new string(array);
        }
    

    }
}