using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnApi.Models
{
    public class Employee
    {
        public string Eid { get; set; }
        public string Ename { get; set; }
        public DateTime? JoinDate { get; set; }
        public string Designation { get; set; }
        public decimal? Salary { get; set; }

    }
}
