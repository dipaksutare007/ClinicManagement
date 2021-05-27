using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicManagement.EF;
using ClinicManagement.EF.Entity;
using ClinicManagement.DAL;
using ClinicManagement.IDAL;
using ClinicManagement.EF.ViewModel;

namespace ClinicManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        IPatientRepository patientRepository;
        public PatientController(IPatientRepository _patientRepository)
        {
            patientRepository = _patientRepository;
        }

        [HttpGet]
        [Route("Getpatients")]
        public async Task<IActionResult> Getpatients()
        {
            try
            {
                var objPatients = await patientRepository.GetPatients();
                if (objPatients == null)
                {
                    return NotFound();
                }
                return Ok(objPatients);
            }
            catch (Exception)
            {

                 return BadRequest();
            }
           
        }

        [HttpGet]
        [Route("Getcities")]
        public async Task<IActionResult> GetCities()
        {
            try
            {
                var objcities = await patientRepository.GetCities();
                if(objcities==null)
                {
                    return NotFound();
                }
                return Ok(objcities);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpGet]
        [Route("getPatient")]
        public async Task<IActionResult> Getpatient(int Patientid)
        {
            try
            {
                var objpatient = await patientRepository.GetPatients(Patientid);
                if(objpatient==null)
                {
                    return NotFound();
                }
                return Ok(objpatient);
            }
            catch (Exception)
            {

                return BadRequest();
                    
            }
        }
        [HttpPost]
        [Route("AddPatient")]
        public async Task<IActionResult> AddPatient([FromBody] Patient patient)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var Patientid = await patientRepository.AddPatient(patient);
                    if(Patientid > 0)
                    {
                        return Ok(Patientid);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("UpdatePatient")]
        public async Task<IActionResult> UpdatePatient([FromBody] Patient patient )
        {
            if(ModelState.IsValid)
            {
                try
                {
                    await patientRepository.UpdatePatient(patient);
                    return Ok();
                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }
            else
            {
                return BadRequest();
            }
        }

        public async Task<IActionResult> DeletePatient([FromBody] int Patientid)
        {
            try
            {
                var cnt = await patientRepository.DeletePatient(Patientid);
                if (cnt > 0)
                {
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {

                return NotFound();
            }
        }

    }
}
