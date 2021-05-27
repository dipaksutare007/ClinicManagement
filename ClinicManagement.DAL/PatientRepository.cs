using ClinicManagement.EF;
using ClinicManagement.EF.Entity;
using ClinicManagement.EF.ViewModel;
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

        public async Task<int> AddPatient(Patient patient)
        {
            if(dbcontext!=null)
            {
                 await dbcontext.AddAsync(patient);
                 await dbcontext.SaveChangesAsync();
                return patient.Id;
            }

            return 0;
        }

        public async Task<int> DeletePatient(int? patientid)
        {
            int result = 0;
            if(dbcontext!=null)
            {
                var p = dbcontext.Patients.Where(x => x.Id == patientid).FirstOrDefault();
                if(p!=null)
                {
                    dbcontext.Patients.Remove(p);
                    result= await dbcontext.SaveChangesAsync();
                }

                return result;
               
            }
            return result;
        }

        public async Task<List<City>> GetCities()
        {
            if(dbcontext!=null)
            {
               return await dbcontext.Cities.ToListAsync();
            }
            return null;
        }

        //public async Task<List<Patient>> GetPatients()
        //{
        //   if(dbcontext!=null)
        //    {
        //        return await dbcontext.Patients.ToListAsync();
        //    }
        //    return null;
        //}

        public async Task<PatientViewModel> GetPatients(int? PatientId)
        {
            if (dbcontext != null)
            {
                return await (from p in dbcontext.Patients
                             from c in dbcontext.Cities
                             where p.Id== PatientId
                              select new PatientViewModel
                             {
                                 Id = p.Id,
                                 Token = p.Token,
                                 Name = p.Name,
                                 sex = p.Sex,
                                 BirthDate = p.BirthDate,
                                 Phone = p.Phone,
                                 Address = p.Address,
                                 CityId = p.CityId,
                                 CityName = c.Name,
                                 DateTime = p.DateTime,
                                 Height = p.Height,
                                 Weight = p.Weight,
                                 Age = p.Age
                             }).FirstOrDefaultAsync();
            }
            return null;
        }

        public async Task UpdatePatient(Patient patient)
        {
           if(dbcontext!=null)
            {
                dbcontext.Update(patient);
               await dbcontext.SaveChangesAsync();
            }
        }

       public async Task<List<PatientViewModel>> GetPatients()
        {
            if(dbcontext!=null)
            {
                return await (from p in dbcontext.Patients
                              from c in dbcontext.Cities
                              where c.Id == p.CityId
                              select new PatientViewModel
                              {
                                  Id = p.Id,
                                  Token = p.Token,
                                  Name = p.Name,
                                  sex=p.Sex,
                                  BirthDate = p.BirthDate,
                                  Phone = p.Phone,
                                  Address = p.Address,
                                  CityId = p.CityId,
                                  CityName = c.Name,
                                  DateTime = p.DateTime,
                                  Height = p.Height,
                                  Weight = p.Weight,
                                  Age = p.Age
                              }).ToListAsync();
            }
            return null;
        }
    }
}
