using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class Leavelist
    {
        [Key]
        public string Name { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public int Leave_balance { get; set; }
        public string Leave_type { get; set; }
        public string status { get; set; }
    }
}
