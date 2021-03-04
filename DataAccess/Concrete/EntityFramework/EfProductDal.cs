using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NortwindContext context = new NortwindContext()) //Nortwindcontext işi bitince bellekten atılır
            {
                var addedEntity = context.Entry(entity);  //referansı yakala
                addedEntity.State = EntityState.Added; //o eklenecek nesne
                context.SaveChanges(); //işlemleri kaydet
            }
        }

        public void Delete(Product entity)
        {
            using (NortwindContext context = new NortwindContext()) 
            {
                var deletedEntity = context.Entry(entity);  
                deletedEntity.State = EntityState.Deleted; 
                context.SaveChanges(); 
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NortwindContext context = new NortwindContext())
            {
                // filtre null mı ? evetse bu çalışır : hayırsa bu çalışır
                return filter == null 
                    ? context.Set<Product>().ToList() 
                    : context.Set<Product>().Where(filter).ToList(); //Product products tablosuyla ilişkili
                                        //filtre null ile tüm listeyi ToList olarak döndür : filtre null değilse Products tablosunda filter edilen şeyi bul
            }
        }

        public void Update(Product entity)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
