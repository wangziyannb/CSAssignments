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
    internal class DepartmentRepository : IRepository<Departments>
    {
        private readonly DapperDbContext _dbContext;

        public DepartmentRepository()
        {
            _dbContext = new DapperDbContext();
        }

        public int DeleteById(int id)
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                // grab attributes from the given object and inject into the sql statement
                return conn.Execute("Delete From Departments Where Id=@Id", new { Id = id });
            }
        }

        public IEnumerable<Departments> GetAll()
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                // grab attributes from the given object and inject into the sql statement
                return conn.Query<Departments>("Select Id, DeptName, Location From Departments");
            }
        }

        public Departments GetById(int id)
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                // grab attributes from the given object and inject into the sql statement
                return conn.QuerySingleOrDefault<Departments>("Select Id, DeptName, Location From Departments where Id=@Id", new { Id = id });
            }
        }

        public int Insert(Departments obj)
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                // grab attributes from the given object and inject into the sql statement
                return conn.Execute("Insert Into Departments Values(@DeptName, @Location)", obj);
            }
        }

        public int Update(Departments obj)
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                // grab attributes from the given object and inject into the sql statement
                return conn.Execute("Update Departments set DeptName=@DeptName, Location=@Location where Id=@Id", obj);
            }
        }
    }
}
