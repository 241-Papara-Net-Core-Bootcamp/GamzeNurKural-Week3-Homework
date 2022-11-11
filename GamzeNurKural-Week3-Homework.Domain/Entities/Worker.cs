using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamzeNurKural_Week3_Homework.Domain.Entities
{
    [Table("Workers")]
    public class Worker : BaseEntity
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
