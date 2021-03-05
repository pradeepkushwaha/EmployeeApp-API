using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.API.Entities
{
    public class EmployeeForSearch
    {

        public string username { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
    public class EmploymentDate
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
