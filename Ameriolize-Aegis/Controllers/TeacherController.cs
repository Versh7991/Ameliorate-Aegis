using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ameriolize_Aegis.Data;
using Ameriolize_Aegis.Models;
using Ameriolize_Aegis.Models.ViewModels;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ameriolize_Aegis.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly INotyfService _notyf;
        public TeacherController(ApplicationDbContext db, INotyfService notyf)
        {
            _db = db;
            _notyf = notyf;
        }

        public async Task<IActionResult> Dashboard()
        {
            var pupils = await _db.Pupils.OrderByDescending(x => x.CreationTime).Take(8).ToListAsync();
            var dashboardVM = new DashboardViewModel
            {
                Pupils = pupils,
                PupilCount = await _db.Pupils.CountAsync(),
                ParentCount = await _db.Parents.CountAsync(),
                LessonCount = await _db.LessonPlans.CountAsync()
            };
            return View(dashboardVM);
        }

        public async Task<IActionResult> Attendance()
        {
            // get today's attendance
            var attendance = await _db.Attendances.Where(x => x.CreationTime.Date == DateTime.Now.Date).ToListAsync();

            // get all pupils
            var pupils = await _db.Pupils.ToListAsync();
            List<PupilAttendanceViewModel> pupilAttendance = new List<PupilAttendanceViewModel>();
            pupils.ForEach(p =>
            {
                var pupil = new PupilAttendanceViewModel
                {
                    Id = p.Id,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    IsAttended = attendance.Find(x => x.PupilId == p.Id) != null

                };
                pupilAttendance.Add(pupil);
            });
            return View(pupilAttendance);
        }


        [HttpPost]
        public async Task<IActionResult> UpdateAttendance(bool isChecked, long pupilId)
        {
            if (isChecked)
            {
                var currentAttendance = await _db.Attendances.FirstOrDefaultAsync(x => x.PupilId == pupilId && x.CreationTime.Date == DateTime.Now.Date);
                if (currentAttendance == null)
                {
                    var newRecord = new Attendance
                    {
                        PupilId = pupilId,
                        TeacherId = 1
                    };
                    _db.Add(newRecord);
                    await _db.SaveChangesAsync();
                    _notyf.Success("Updated Successfully", 2);
                    return new JsonResult(new { status = "Success", message = "Updated Successfully" });
                }
            }
            else
            {
                var currentAttendance = await _db.Attendances.FirstOrDefaultAsync(x => x.PupilId == pupilId && x.CreationTime.Date == DateTime.Now.Date);
                if (currentAttendance != null)
                {
                    _db.Remove(currentAttendance);
                    await _db.SaveChangesAsync();
                    _notyf.Success("Updated Successfully", 2);
                    return new JsonResult(new { status = "Success", message = "Updated Successfully" });
                }

            }
            return RedirectToAction(nameof(Attendance));
        }

        public async Task<IActionResult> Pupils()
        {
            return View(await _db.Pupils.ToListAsync());
        }


        public async Task<IActionResult> Lessons()
        {

            var lessonVM = new LessonViewModel
            {
                LessonPlans = await _db.LessonPlans.ToListAsync()
            };
            return View(lessonVM);
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

            //sort progress report by term
            var sortedReports = pupil.Reports.OrderBy(x => x.Period.Name).ToList();
            pupil.Reports = sortedReports;

            PortfolioViewModel modelVM = new PortfolioViewModel()
            {
                Pupil = pupil,
                Periods = _db.Periods.ToList().OrderBy(x => x.Name),
                Programmes = _db.Programmes.ToList()
            };
            return View(modelVM);
        }

        public async Task<IActionResult> Reports()
        {
            return View(await _db.Pupils.ToListAsync());
        }

        public async Task<IActionResult> ViewReport(long id)
        {
            var pupil = await _db.Pupils.Include(x => x.Reports)
                .ThenInclude(e => e.Program)
                .Include(f => f.Reports)
                .ThenInclude(x => x.Period)
                .SingleOrDefaultAsync(x => x.Id == id);

            // Sort Progress According to Term
            var reportVM = new ReportViewModel
            {
                Pupil = pupil,
                Term1 = pupil.Reports.Where(x => x.Period.Name == "Term 1").ToList(),
                Term2 = pupil.Reports.Where(x => x.Period.Name == "Term 2").ToList(),
                Term3 = pupil.Reports.Where(x => x.Period.Name == "Term 3").ToList(),
                Term4 = pupil.Reports.Where(x => x.Period.Name == "Term 4").ToList(),
                TotalAverage = pupil.Reports.Count > 0 ? Math.Round(pupil.Reports.Average(x => x.Mark), 2) : 0
            };
            return View(reportVM);
        }

        public IActionResult Schedule()
        {
            return View();
        }


        // Lessons
        [HttpPost]
        public async Task<IActionResult> CreateLesson(LessonViewModel lessonVm)
        {
            if (ModelState.IsValid)
            {
                var lesson = new LessonPlan
                {
                    Description = lessonVm.Lesson.Description,
                    TeacherId = 1,
                    StartTime = DateTime.Now,
                    Day = lessonVm.Lesson.Day,
                    EndTime = DateTime.Now.AddHours(2)
                };
                _db.Add(lesson);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Lessons));
            }
            return View(lessonVm);
        }
    }
}