using ClinicManagement.EF.Entity;
using Microsoft.EntityFrameworkCore;
 
using System;

namespace ClinicManagement.EF
{
    public class ClinicDAL : DbContext
    {
        public ClinicDAL(DbContextOptions<ClinicDAL> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
