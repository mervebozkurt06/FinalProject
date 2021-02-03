using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id); //product ı category sine göre getiren
        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}
