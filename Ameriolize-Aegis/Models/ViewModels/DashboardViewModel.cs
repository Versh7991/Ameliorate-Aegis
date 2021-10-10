using System;
using System.Collections.Generic;

namespace Ameriolize_Aegis.Models.ViewModels
{
    public class DashboardViewModel
    {
        public IEnumerable<Pupil> Pupils { get; set; }
        public int PupilCount { get; set; }
        public int ParentCount { get; set; }
        public int LessonCount { get; set; }
    }
}
