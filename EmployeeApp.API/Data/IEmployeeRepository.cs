using EmployeeApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.API.Data
{
   public interface IEmployeeRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
       
        Task<bool> SaveAll();
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);

        Task<IEnumerable<Employee>> GetEmployee(string name);
        Task<IEnumerable<Employee>> GetEmployee(DateTime FromDate, DateTime ToDate);

    }
}
