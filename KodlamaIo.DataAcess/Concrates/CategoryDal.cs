using KodlamaIo.DataAcess.Abstracts;
using KodlamaIo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAcess.Concrates
{
    public class CategoryDal : ICategoryDal
    {
        private readonly KodlamaIoContext _context;

        public CategoryDal(KodlamaIoContext context)
        {
            _context = context;
        }


        public void Add(Category entity)
        {
            var addedEntity = _context.Add(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(Category entity)
        {
           var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return _context.Set<Category>().SingleOrDefault(filter);
        }

        public List<Category> GetAll(Expression<Func<Category, bool>>? filter = null)
        {
            return filter == null ? _context.Set<Category>().ToList() : _context.Set<Category>().Where(filter).ToList();
        }

        public void Update(Category entity)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
