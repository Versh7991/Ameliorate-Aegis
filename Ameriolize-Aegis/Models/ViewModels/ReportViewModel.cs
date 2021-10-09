﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ameriolize_Aegis.Models.ViewModels
{
    public class ReportViewModel
    {
        public Pupil Pupil { get; set; }
        public IEnumerable<ProgressReport> Term1 { get; set; }
        public IEnumerable<ProgressReport> Term2 { get; set; }
        public IEnumerable<ProgressReport> Term3 { get; set; }
        public IEnumerable<ProgressReport> Term4 { get; set; }
    }
}