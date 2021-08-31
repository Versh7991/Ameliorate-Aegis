using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ameriolize_Aegis.Models
{
    [Table("Pro_Enrollments")]
    public class ProgramEnrollment
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        [ForeignKey(nameof(PupilId))]
        public Pupil Pupil { get; set; }
        public long PupilId { get; set; }
        public ProgramEnrollment()
        {
            CreationTime = DateTime.Now;
        }
    }
}
