using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UdemySiparisUygulamasi.Data.Repository.IRepository;

namespace UdemySiparisUygulamasi.Data.Repository
{
    public class Repository<T> : IRepository<T> where T:class
    {
        //Dependency injection

        private readonly ApplicationDbContext _context;

        //Burada tanımlanan dbsetleri kalıtım alan sınıflar kullanabilsin diye tanımladık.
        internal DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = _dbSet;
            if (filter!=null)
            {
                //Sorgular filterda where id==1
                query = query.Where(filter);
            
            }

            //Birden fazla property giriliyorsa , ile ayırma işlemi yapılır

            //Product,Order ayırır ve ayrı ayrı işlem yapar
            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries))
                {
                    //Her seferinde tabloyu ekliyor
                    query = query.Include(item);
                }
            }
            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
            {
                //Sorgular filterda where id==1
                query = query.Where(filter);

            }
            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    //Her seferinde tabloyu ekliyor
                    query = query.Include(item);
                }
            }
            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
