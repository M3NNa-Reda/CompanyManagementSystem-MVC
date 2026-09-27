using Demo.BLL.Interfaces;
using Demo.DAL.Data;
using Demo.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BLL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : ModelBase
    {
        private protected readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking().ToList();
        }

        public T GetById(int id)
        {
            return _context.Find<T>(id);
        }

        public int Create(T entity)
        {
            _context.Add(entity);
            return _context.SaveChanges();
        }
        public int Update(T entity)
        {
            _context.Update(entity);
            return _context.SaveChanges();
        }
        public int Delete(T entity)
        {
            _context.Remove(entity);
            return _context.SaveChanges();
        }
    }
}
