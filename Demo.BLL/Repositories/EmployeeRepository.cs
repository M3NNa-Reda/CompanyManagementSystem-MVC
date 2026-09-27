using Demo.BLL.Interfaces;
using Demo.DAL.Data;
using Demo.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BLL.Repositories
{
    public class EmployeeRepository:GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context) : base(context)
        {
        }

        public IQueryable<Employee> GetEmployeesByAddress(string address)
        {
            return _context.Employees.Where(e => e.Address.ToLower().Contains(address.ToLower()));
        }

        public IEnumerable<Employee> GetEmployeeWithDepartment()
        {
            return _context.Set<Employee>()
                .Include(e => e.Department)
                .AsNoTracking()
                .ToList();
        }
    }
}
