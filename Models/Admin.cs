using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class Admin
    {
        [Key]
        public string Name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

    }
}
