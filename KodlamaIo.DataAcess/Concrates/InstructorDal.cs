using KodlamaIo.DataAcess.Abstracts;
using KodlamaIo.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KodlamaIo.DataAcess.Concrates
{
    public class InstructorDal : IInstructorDal
    {
        private readonly KodlamaIoContext _context;

        public InstructorDal(KodlamaIoContext context)
        {
            _context = context;
        }


        public void Add(Instructor entity)
        {
            var addedEntity = _context.Add(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(Instructor entity)
        {
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public Instructor Get(Expression<Func<Instructor, bool>> filter)
        {
            return _context.Set<Instructor>().SingleOrDefault(filter);
        }

        public List<Instructor> GetAll(Expression<Func<Instructor, bool>>? filter = null)
        {
            return filter == null ? _context.Set<Instructor>().ToList() : _context.Set<Instructor>().Where(filter).ToList();
        }

        public void Update(Instructor entity)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
