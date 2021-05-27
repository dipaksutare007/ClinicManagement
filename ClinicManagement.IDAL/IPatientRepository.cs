using ClinicManagement.EF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.IDAL
{
   public interface IPatientRepository
    {
        Task<List<Patient>> GetPatients();
    }
}
