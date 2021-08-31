using Ameriolize_Aegis.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ameriolize_Aegis.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<LessonPlan> LessonPlans { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<Centre> Centres { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Programme> Programmes { get; set; }
        public DbSet<ProgramCentre> ProgramCentre { get; set; }
        public DbSet<ProgramEnrollment> ProgramEnrollments{ get; set; }
        public DbSet<ProgressReport> ProgressReports{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
