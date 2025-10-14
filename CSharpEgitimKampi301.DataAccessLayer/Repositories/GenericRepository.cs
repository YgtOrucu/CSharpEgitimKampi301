using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        CampContext Context = new CampContext();
        private readonly DbSet<T> _object;
        public GenericRepository()
        {
            _object = Context.Set<T>();
        }

        public void Delete(T entity)
        {
            var deletedentity = Context.Entry(entity);
            deletedentity.State = EntityState.Deleted;
            Context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var addedentity = Context.Entry(entity);
            addedentity.State = EntityState.Added;
            Context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedentity = Context.Entry(entity);
            updatedentity.State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
