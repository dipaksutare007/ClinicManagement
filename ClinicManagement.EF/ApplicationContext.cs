using ClinicManagement.EF.Entity;
using Microsoft.EntityFrameworkCore;
 
using System;

namespace ClinicManagement.EF
{
    public class ClinicDAL : DbContext
    {
        //public ClinicDAL(DbContextOptions<ClinicDAL> options) : base(options)
        //{

        //}

        public DbSet<Patient> Patients { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-S74O0PP; Database=CDB;User Id=sa; Password=smart@123;");
        }
    }
}
