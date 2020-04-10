using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class Employee
    {
        [Key]
        public string Name { get; set; }
        public string email { get; set; }
        public DateTime  DOJ { get; set; }
        public DateTime DOB { get; set; }
        
    }
}
