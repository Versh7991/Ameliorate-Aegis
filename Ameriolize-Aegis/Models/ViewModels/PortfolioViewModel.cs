using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ameriolize_Aegis.Models.ViewModels
{
    public class PortfolioViewModel
    {
        public Pupil Pupil { get; set; }
        public IEnumerable<Programme> Programmes { get; set; }
        public IEnumerable<Period> Periods { get; set; }

        public ProgressReport Progress { get; set; }
    }
}
