using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ameriolize_Aegis.Models
{
    [Table("Pupils")]
    public class Pupil
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        [ForeignKey(nameof(ParentId))]
        public Parent Parent { get; set; }
        public long ParentId { get; set; }
        [ForeignKey(nameof(CentreId))]
        public Centre Centre { get; set; }
        public long CentreId { get; set; }
        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; }
        public long? TeacherId { get; set; }
        public ICollection<ProgramEnrollment> Enrollments { get; set; }

        public Pupil()
        {
            CreationTime = DateTime.Now;
        }
    }
}
