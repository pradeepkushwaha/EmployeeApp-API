using EmployeeApp.API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.API.Data
{
    public class SeedEmployee
    {
        private readonly DataContext _context;
        public SeedEmployee(DataContext context)
        {
            _context = context;
        }

        public void SeedUsers()
        {
            var userData = System.IO.File.ReadAllText("Data/EmployeeSeedData.json");
            var employees = JsonConvert.DeserializeObject<List<Employee>>(userData);
            foreach (var employee in employees)
            {
                 _context.Employees.Add(employee);
            }
            _context.SaveChanges();
        }
    }
}
