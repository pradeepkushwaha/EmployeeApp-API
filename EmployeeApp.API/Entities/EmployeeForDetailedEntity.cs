using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.API.Entities
{
    public class EmployeeForDetailedEntity
    {
        public long EmployeeId { get; set; }
        public string First_name { get; set; }
        public string Full_name { get; set; }
        public string Last_name { get; set; }
        public string Job_title { get; set; }
        public DateTime employment_start_date { get; set; }
        public DateTime employment_end_date { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Phone_number { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
