using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ameriolize_Aegis.Data;
using Ameriolize_Aegis.Models;
using Ameriolize_Aegis.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ameriolize_Aegis.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TeacherController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Attendance()
        {
            var lessonPlan = new LessonPlan
            {
                Time = DateTime.Now
            };
            _db.LessonPlans.Add(lessonPlan);
            return View();
        }

        public async Task<IActionResult> Pupils()
        {
            return View(await _db.Pupils.ToListAsync());
        }


        public IActionResult Lessons()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreatePortfolio(PortfolioViewModel modelVM)
        {
            if (ModelState.IsValid)
            {
                var progress = new ProgressReport
                {
                    Mark = modelVM.Progress.Mark,
                    ProgramId = modelVM.Progress.ProgramId,
                    PupilId = modelVM.Progress.PupilId,
                    TeacherId = modelVM.Progress.TeacherId,
                    PeriodId = modelVM.Progress.PeriodId
                };
                _db.Add(progress);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(ViewPortfolio), new { id = modelVM.Progress.PupilId });
            }
            return View(modelVM);
        }

        public async Task<IActionResult> Portfolio()
        {
            return View(await _db.Pupils.ToListAsync());
        }

        public async Task<IActionResult> ViewPortfolio(long id)
        {
            var pupil = await _db.Pupils.Include(x => x.Reports)
                .ThenInclude(e => e.Program)
                .Include(f => f.Reports)
                .ThenInclude(x => x.Period)
                .SingleOrDefaultAsync(x => x.Id == id);

            PortfolioViewModel modelVM = new PortfolioViewModel()
            {
                Pupil = pupil,
                Periods = _db.Periods.ToList(),
                Programmes = _db.Programmes.ToList()
            };
            return View(modelVM);
        }

        public async Task<IActionResult> Reports()
        {
            return View(await _db.Pupils.ToListAsync());
        }

        public IActionResult Schedule()
        {
            return View();
        }
    }
}