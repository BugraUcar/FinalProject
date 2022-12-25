using Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic Constraint(kısıt)
    //class : referans tip
    //IEntity:IEntity olabilir veya bunu implemente eden bir class
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);  
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
 
    }
}
