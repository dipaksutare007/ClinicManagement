using ClinicManagement.EF.Entity;
using ClinicManagement.EF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.IDAL
{
   public interface IPatientRepository
    {
        Task<List<PatientViewModel>> GetPatients();
        Task<List<City>> GetCities();

        Task<PatientViewModel> GetPatients(int? PatientId);

        Task<int> AddPatient(Patient patient);

        Task<int> DeletePatient(int? patientid);

        Task UpdatePatient(Patient patient);
    }
}
