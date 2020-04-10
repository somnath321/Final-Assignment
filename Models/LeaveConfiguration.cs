using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class LeaveConfiguration
    {
        [Key]
        public string Leave_Name { get; set; }
        public int No_of_Days { get; set; }
    }
}
