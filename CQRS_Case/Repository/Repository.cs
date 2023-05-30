using CQRS_Case.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Case.Repository
{
    public class Repository<T> : IRepository<T> where T : Item
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public T GetById(int id)
        {
            return _entities.Find(id);
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);

            if (entity != null)
            {
                _entities.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
