using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIDemo2.Models
{
    public class Employee
    {
        [Key]
        public string Eid { get; set; }
        public string Ename { get; set; }
        public DateTime? JoinDate { get; set; }
        public string Designation { get; set; }

        public decimal? Salary { get; set; }


    }
}
