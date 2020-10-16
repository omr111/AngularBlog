using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Constants.ValidationMessages
{
   public   class validateMessages
    {
        
        public static string maxLengthMessage(int length) { return $"En Fazla {length} Karakter Olması Gerekli"; }
        public static string minLengthMessage(int length) { return $"En Az {length} Karakter Olması Gerekli"; }
        public static string fieldRequired (){ return "Bu Alan Boş Geçilemez";}
        public static string emailFormat() { return "Geçersiz Email Formatı"; }
        public static string matchPassword() { return "Şifreniz Eşleşmiyor"; }
       
    }
}
