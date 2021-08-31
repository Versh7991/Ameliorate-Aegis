using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ameriolize_Aegis.Models
{
    [Table("ProgressReports")]
    public class ProgressReport
    {
        public long Id { get; set; }
        [ForeignKey(nameof(PupilId))]
        public Pupil Pupil { get; set; }
        public long PupilId { get; set; }
        [ForeignKey(nameof(PeriodId))]
        public Period Period { get; set; }
        public long PeriodId { get; set; }
        [ForeignKey(nameof(ProgramId))]
        public Programme Program { get; set; }
        public long ProgramId { get; set; }
        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; }
        public long TeacherId { get; set; }
        public double Mark { get; set; }
    }
}
