using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class EfRepositoryDal<T, TContext> : IRepositoryDal<T> where T : class where TContext  : DbContext, new()
    {
        public T Create(T entity)
        {
            using (var db = new TContext())
            {
                var data = db.Set<T>().Add(entity);
                db.SaveChanges();
                return data.Entity;
            }
        }

        public T Delete(T entity)
        {
            using (var db = new TContext())
            {
                var data = db.Set<T>().Remove(entity);
                db.SaveChanges();
                return data.Entity;
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (var db = new TContext())
            {
                return filter == null
                    ? db.Set<T>().ToList()
                    : db.Set<T>().Where(filter).ToList();
            }
        }
        public T GetById(int id)
        {
            using (var db = new TContext())
            {
                var find = db.Set<T>().Find(id);
               
                return find;
            }
        }
        public T Update(T entity)
        {
            using (var db = new TContext())
            {
                var data = db.Set<T>().Update(entity);
                db.SaveChanges();
                return data.Entity;

            }
        }
    }
}
