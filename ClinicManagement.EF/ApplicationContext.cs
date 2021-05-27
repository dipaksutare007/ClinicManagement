using ClinicManagement.EF.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace ClinicManagement.EF
{
    public class ClinicContext : DbContext
    {
        public ClinicContext(DbContextOptions<ClinicContext> options) : base(options)
        {

        }
        public ClinicContext()
        {

        }

        public    DbSet<Patient> Patients { get; set; }
        public   DbSet<City> Cities { get; set; }
    }
}
