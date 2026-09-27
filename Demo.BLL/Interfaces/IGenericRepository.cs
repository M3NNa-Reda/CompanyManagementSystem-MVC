using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BLL.Interfaces
{
    public interface IGenericRepository<T> where T : ModelBase
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Create(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}
