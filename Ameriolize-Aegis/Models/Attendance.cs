using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ameriolize_Aegis.Models
{
    [Table("PupilAttendance")]
    public class Attendance
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        [ForeignKey(nameof(PupilId))]
        public Pupil Pupil { get; set; }
        public long PupilId { get; set; }
        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; }
        public long TeacherId { get; set; }

        public Attendance()
        {
            CreationTime = DateTime.Now;
        }
    }
}
