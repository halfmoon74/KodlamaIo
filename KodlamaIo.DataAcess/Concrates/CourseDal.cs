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
    public class CourseDal : ICourseDal
    {
        private readonly KodlamaIoContext _context;

        public CourseDal(KodlamaIoContext context)
        {
            _context = context;
        }


        public void Add(Course entity)
        {
            var addedEntity = _context.Add(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(Course entity)
        {
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public Course Get(Expression<Func<Course, bool>> filter)
        {
            return _context.Set<Course>().SingleOrDefault(filter);
        }

        public List<Course> GetAll(Expression<Func<Course, bool>>? filter = null)
        {
            return filter == null ? _context.Set<Course>().ToList() : _context.Set<Course>().Where(filter).ToList();
        }

        public void Update(Course entity)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
