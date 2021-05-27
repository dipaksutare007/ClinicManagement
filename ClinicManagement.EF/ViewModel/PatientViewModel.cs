using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.EF.ViewModel
{
    public class PatientViewModel
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string Name { get; set; }
        public int Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public byte CityId { get; set; }
        public string CityName { get; set; }
        public DateTime DateTime { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }

        public int Age
        {
            get; set;
            //get
            //{
            //    var now = DateTime.Today;
            //    var age = now.Year - BirthDate.Year;
            //    if (BirthDate > now.AddYears(-age)) age--;
            //    return age;
            //}

        }
    }
}
