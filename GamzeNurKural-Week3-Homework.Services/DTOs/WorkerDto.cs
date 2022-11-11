using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeNurKural_Week3_Homework.Services.DTOs
{
     public class WorkerDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Department { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}
