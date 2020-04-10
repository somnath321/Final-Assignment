using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Models;

namespace LeaveManagement.Data
{
    public class LeaveManagementContext : DbContext
    {
        public LeaveManagementContext (DbContextOptions<LeaveManagementContext> options)
            : base(options)
        {
        }

        public DbSet<LeaveManagement.Models.Admin> Admin { get; set; }

        public DbSet<LeaveManagement.Models.Employee> Employee { get; set; }

        public DbSet<LeaveManagement.Models.LeaveConfiguration> LeaveConfiguration { get; set; }

        public DbSet<LeaveManagement.Models.Leavelist> Leavelist { get; set; }

        public DbSet<LeaveManagement.Models.LeaveType> LeaveType { get; set; }
    }
}
