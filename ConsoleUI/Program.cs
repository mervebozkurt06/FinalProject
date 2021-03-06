using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle(Yaptığın yazılıma yeni bir özellik ekliyorsan mevcuttaki hiçbir koda dokunamazsın EFProductDal)
    class Program
    {
        static void Main(string[] args)
        {
              ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categorymanager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categorymanager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}
