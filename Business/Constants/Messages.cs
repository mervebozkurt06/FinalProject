using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages //sabit olduğu için ve new lememek için static yapıldı
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime = "Sistem bakımda";
        internal static string ProductsListed = "Ürünler listelendi";
    }
}
