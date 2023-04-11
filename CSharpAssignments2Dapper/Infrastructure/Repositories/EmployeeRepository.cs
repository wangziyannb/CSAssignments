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
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                // grab attributes from the given object and inject into the sql statement
                return conn.Query<Employees>("Select Id, FirstName, LastName, Salary, DeptId From Employees");
            }
        }

        public Employees GetById(int id)
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                // grab attributes from the given object and inject into the sql statement
                return conn.QuerySingleOrDefault<Employees>("Select Id, FirstName, LastName, Salary, DeptId From Employees where Id=@Id", new { Id = id });
            }
        }

        public int Insert(Employees obj)
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                // grab attributes from the given object and inject into the sql statement
                return conn.Execute("Insert Into Employees Values(@FirstName, @LastName, @Salary, @DeptId)", obj);
            }
        }

        public int Update(Employees obj)
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                // grab attributes from the given object and inject into the sql statement
                return conn.Execute("Update Employees set FirstName=@FirstName, LastName=@LastName, Salary=@Salary, DeptId=@DeptId where Id=@Id", obj);
            }
        }
    }
}
