using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicManagement.EF;
using ClinicManagement.EF.Entity;
using ClinicManagement.DAL;

namespace ClinicManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly ClinicDAL _DAL = null;
        public PatientController()
        {
            //this._DAL = new ClinicDAL();
        }
         

       // [HttpGet]
        //public async Task<IEnumerable<Patient>> Get()
        //{
           
           
        //}
    }
}
