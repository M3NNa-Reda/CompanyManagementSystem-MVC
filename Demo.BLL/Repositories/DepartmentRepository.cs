using Demo.BLL.Interfaces;
using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Demo.DAL.Data;

namespace Demo.BLL.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>,IDepartmentRepository
    {

        public DepartmentRepository(AppDbContext context) : base(context)
        {
        }

    }
}
