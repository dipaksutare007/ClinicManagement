using ClinicManagement.EF;
using ClinicManagement.EF.Entity;
using ClinicManagement.IDAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.DAL
{
    public class PatientRepository : IPatientRepository
    {
        ClinicContext dbcontext;
        public PatientRepository(ClinicContext _dbcontext)
        {
            dbcontext = _dbcontext;
        }
        public async Task<List<Patient>> GetPatients()
        {
           if(dbcontext!=null)
            {
                return await dbcontext.Patients.ToListAsync();
            }
            return null;
        }

      
    }
}
