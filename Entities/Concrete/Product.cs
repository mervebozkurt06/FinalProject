using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //public çünkü bussines data acces ürünü kullanabilsin //internal sadece entities erişebilsin demek
    public class Product:IEntity //IEntity görünce Product bir veritabanı tablosudur
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
