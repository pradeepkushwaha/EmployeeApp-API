using EmployeeApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.API.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
         
        public async Task<Employee> GetEmployee(int id)
        {
            
            var employee = await _context.Employees.FirstOrDefaultAsync(u => u.EmployeeId == id);
            return employee;
        }


        public async Task<IEnumerable<Employee>> GetEmployee(string name)
        {
            var employee = await _context.Employees.Where(p => p.First_name.Contains(name.Trim()) || p.Last_name.Contains(name.Trim())).ToListAsync();
            return employee;
        }
        public async Task<IEnumerable<Employee>> GetEmployee(DateTime FromDate,DateTime ToDate)
        {
            var employee = await _context.Employees.Where(x => x.employment_start_date >= FromDate).Where(x => x.employment_end_date <= ToDate).ToListAsync();
            return employee;
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var employees = await _context.Employees.ToListAsync();

            return employees;
        }
        
        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        

    }
}
