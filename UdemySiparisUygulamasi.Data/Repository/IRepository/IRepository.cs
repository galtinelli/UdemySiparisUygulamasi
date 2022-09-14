using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UdemySiparisUygulamasi.Data.Repository.IRepository
{
    //Generic hale getirilir. T classı temsil eder
    public interface IRepository<T> where T :class
    {
        //Linq sorguları için Expression eklenir
        //Productın Idsine göre sorgulama gibi bu sorgudan yapılır. Tek bir kayıt döner.

        //Read
        T GetFirstOrDefault(Expression<Func<T,bool>> filter, string? includeProperties=null);
        IEnumerable<T> GetAll(Expression<Func<T,bool>> filter, string? includeProperties=null);

        //CREATE
        void Add(T entity);

        //Update
        void Update(T entity);

        //Delete
        void Remove(T entity);

        //Bütün tablonun silinmesini sağlayabiliriz
        void RemoveRange(IEnumerable<T> entities);
    }
}
