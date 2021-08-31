using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ameriolize_Aegis.Data;
using Ameriolize_Aegis.Models;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Lessons()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Reports()
        {
            return View();
        }

        public IActionResult Schedule()
        {
            return View();
        }
    }
}