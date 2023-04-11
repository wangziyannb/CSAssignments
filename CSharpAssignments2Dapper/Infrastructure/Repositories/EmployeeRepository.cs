using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Dapper;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class EmployeeRepository : IRepository<Employees>
    {
        private readonly DapperDbContext _dbContext;

        public EmployeeRepository()
        {
            _dbContext = new DapperDbContext();
        }

        public int DeleteById(int id)
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                // grab attributes from the given object and inject into the sql statement
                return conn.Execute("Delete From Employees Where Id=@Id", new { Id = id });
            }
        }

        public IEnumerable<Employees> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employees GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Employees obj)
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                // grab attributes from the given object and inject into the sql statement
                return conn.Execute("Insert Into Employees Values(@DeptName, @Loc)", obj);
            }
        }

        public int Update(Employees obj)
        {
            throw new NotImplementedException();
        }
    }
}
