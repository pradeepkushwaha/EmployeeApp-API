using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.API.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EmployeeId { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Job_title { get; set; }
        public DateTime employment_start_date { get; set; }
        public DateTime employment_end_date { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
