using System;
using Microsoft.EntityFrameworkCore;

namespace APIAPPAjaxCRUD.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }

}
