using Microsoft.EntityFrameworkCore;
 
using System;

namespace ClinicManagement.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        //public DbSet< MyProperty { get; set; }
    }
}
