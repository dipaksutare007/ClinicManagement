using ClinicManagement.EF.Entity;
using Microsoft.EntityFrameworkCore;
 
using System;

namespace ClinicManagement.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
