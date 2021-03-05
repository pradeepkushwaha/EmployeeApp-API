using EmployeeApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                First_name = "Uncle",
                Last_name = "Bob",
                Job_title = "Solution architect",
                employment_start_date = new DateTime(2017, 04, 25),
                employment_end_date = new DateTime(2020, 04, 25),
                Department ="IT",
                Email = @"uncle.bob@gmail.com",
                Phone_number = "999-888-7777",
                Gender ="male",
                DateOfBirth = new DateTime(1979, 04, 25)

            }, new Employee
            {
                EmployeeId = 2,
                First_name = "Jan",
                Last_name = "Kirsten",
                Job_title = "Solution architect",
                employment_start_date = new DateTime(2016, 04, 25),
                employment_end_date = new DateTime(2019, 04, 25),
                Department = "IT",
                Email = @"jan.kirsten@gmail.com",
                Phone_number = "111-888-7777",
                Gender = "male",
                DateOfBirth = new DateTime(1981, 04, 25)
            }, new Employee
            {
                EmployeeId = 3,
                First_name = "James",
                Last_name = "Smith",
                Job_title = "Technical architect",
                employment_start_date = new DateTime(2018, 04, 25),
                employment_end_date = new DateTime(2021, 01, 25),
                Department = "IT",
                Email = @"James.Smith@gmail.com",
                Phone_number = "111-555-7777",
                Gender = "male",
                DateOfBirth = new DateTime(1982, 04, 25)
            }
            , new Employee
            {
                EmployeeId = 4,
                First_name = "Selina",
                Last_name = "Chun",
                Job_title = "Business Analyst",
                employment_start_date = new DateTime(2018, 04, 25),
                employment_end_date = new DateTime(2021, 01, 25),
                Department = "IT",
                Email = @"Selina.Chun@gmail.com",
                Phone_number = "111-555-5555",
                Gender = "female",
                DateOfBirth = new DateTime(1986, 04, 25)
            },
             new Employee
             {
                 EmployeeId = 5,
                 First_name = "Tracie",
                 Last_name = "Chun",
                 Job_title = "Business Analyst",
                 employment_start_date = new DateTime(2019, 04, 25),
                 employment_end_date = new DateTime(2020, 10, 25),
                 Department = "IT",
                 Email = @"Tracie.Chun@gmail.com",
                 Phone_number = "2222-888-5555",
                 Gender = "female",
                 DateOfBirth = new DateTime(1985, 04, 16)
             }
            );
        }
    }
}
