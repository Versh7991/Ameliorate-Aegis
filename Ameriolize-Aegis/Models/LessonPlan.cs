using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ameriolize_Aegis.Models
{
    [Table("LessonPlans")]
    public class LessonPlan
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public LessonPlanStatus Status { get; set; }
        public string Description { get; set; }
        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; }
        public long TeacherId { get; set; }

    }
}
