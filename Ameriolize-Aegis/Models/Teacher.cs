using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ameriolize_Aegis.Models
{
    [Table("Teachers")]
    public class Teacher
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string Qualification { get; set; }
        public ICollection<Pupil> Pupils { get; set; }

        public Teacher()
        {
            CreationTime = DateTime.Now;
        }
    }
}
