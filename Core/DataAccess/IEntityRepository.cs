using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint = generic kısıt
    //class : referans tip olabilir(class olabbilr değil)
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : newlenebilir olmalı(IEntity olamaz çünkü interface newlenemez)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //interface methodları default publictir
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filter null olabilir yani null olursa tüm kayıtları getir
        T Get(Expression<Func<T, bool>> filter); // filter olmak zorunda çünkü tek kayıt 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
