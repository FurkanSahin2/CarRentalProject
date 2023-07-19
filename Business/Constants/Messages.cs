using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameOrPriceInvalid = "Araba adı veya fiyatı geçersiz bir değer";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string MaintenanceTime = "Sistem bakıma alındı";
        public static string CarsListed = "Arabalar listelendi";
        public static string BrandsListed = "Markalar listelendi";
        public static string ColorsListed = "Renkler listelendi";
        public static string RentalsListed = "Kiralanmalar listelendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string RentalDateisNull = "Arabanın kiralanması için teslim edilmiş olması gereklidir";
        public static string RentalAdded = "Araba kiralama işlemi başarıyla gerçekleşti";
    }
}
