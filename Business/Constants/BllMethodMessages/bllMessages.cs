using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants.BllMethodMessages
{
   public static class bllMessages
    {
        public static string productAdded ="Ürün Başarıyla Eklendi";
        public static string productDeleted = "Ürün Başarıyla Silindi";
        public static string productUpdated = "Ürün Başarıyla Güncellendi";
        public static string productNull = "Listede Görüntülenecek Herhangi Bir Ürün Yok !";
        public static string productNotAdded = "Ürün Ekleme Sırasında Bir Hata Meydana Geldi";
        public static string productNotDeleted = "Ürün Silme Sırasında Bir Hata Oluştu. Bu Ürün Başka Bir Kayıtta Kullanılıyor Olabilir !";
        public static string productNotUpdated = "Ürün Güncelleme Sırasında Bir Hata Meydana Geldi !";

        public static string userAdded = "Kullanıcı Başarıyla Kayıt Edildi";
        public static string userDeleted = "Kullanıcı Başarıyla Silindi";
        public static string userUpdated = "Kullanıcı Başarıyla Güncellendi";
        public static string usersListed = "Kullanıcılar Başarıyla Listelendi";
        public static string theUserListed = "Kullanıcı Başarıyla Getirildi";
        public static string categoriesListed="Kategoriler Başarıyla Listelendi";
        public static string notFoundEmail ="Böyle Bir Email Kaydı Bulunamadı";
        public static string wrongPassword = "Girilen Şifre Hatalı !";
        public static string successfullLogin="Sisteme Giriş Başarılı";
        public static string successfullRegister="Kayıt İşlemi Başarılı";
        public static string userNotFound="Aranılan Kullanıcı Bulunanamadı";
        public static string emailAlreadyUsed="Bu Email Zaten Kullanılmaktadır.";
        public static string usernameAlreadyExist="Bu Kullanıcı Adı Zaten Kullanılmaktadır";
        public static string AuthorizationDenied="Bu İşlemi Yapabilmek İçin Yetkiniz Yok !";
    }
}
