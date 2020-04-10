using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class LeaveType
    {
        [Key]
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Leave_type { get; set; }
        
    }
}
