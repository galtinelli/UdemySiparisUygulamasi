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
        T GetFirstOrDefault(Expression<Func<T,bool>> filter, string? includeProperties=null);
    }
}
