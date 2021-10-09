using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ameriolize_Aegis.Models.ViewModels
{
    public class PupilAttendanceViewModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAttended { get; set; } = false;
    }
}
