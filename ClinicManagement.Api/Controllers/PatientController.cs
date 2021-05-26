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
        [Route("Getpatient")]
        public async Task<IActionResult> Getpatient()
        {
            var objPatients = await patientRepository.GetPatients();
            if(objPatients==null)
            {
                return NotFound();
            }
            return Ok(objPatients);
        }
    }
}
