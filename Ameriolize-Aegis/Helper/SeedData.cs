using Ameriolize_Aegis.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ameriolize_Aegis.Helper
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Centre>().HasData(
               new Centre { Id = 1, Name = "Kabega", AddressLine1 = "123 John Newton SW", AddressLine2 = "Newton Park" },
               new Centre { Id = 2, Name = "Sol Futi", AddressLine1 = "237 John Newton SW", AddressLine2 = "New Brighton" },
               new Centre { Id = 3, Name = "Daku", AddressLine1 = "123 John Newton SW", AddressLine2 = "Newton Park" }
               );

            modelBuilder.Entity<Parent>().HasData(
                new Parent { Id = 1, FirstName = "Jane", LastName = "Pope", DoB = DateTime.Now.AddYears(-27), CentreId = 1 },
                new Parent { Id = 2, FirstName = "Thembeka", LastName = "Qweba", DoB = DateTime.Now.AddYears(-33), CentreId = 2 },
                new Parent { Id = 3, FirstName = "Jane", LastName = "Doe", DoB = DateTime.Now.AddYears(-45), CentreId = 3 },
                new Parent { Id = 4, FirstName = "Jon", LastName = "Doe", DoB = DateTime.Now.AddYears(-54), CentreId = 2 },
                new Parent { Id = 5, FirstName = "Joshua", LastName = "Doe", DoB = DateTime.Now.AddYears(-29), CentreId = 1 },
                new Parent { Id = 6, FirstName = "Thandi", LastName = "Newton", DoB = DateTime.Now.AddYears(-49), CentreId = 3 },
                new Parent { Id = 7, FirstName = "Amanda", LastName = "Qweba", DoB = DateTime.Now.AddYears(-25), CentreId = 2 },
                new Parent { Id = 8, FirstName = "Amyoli", LastName = "Soze", DoB = DateTime.Now.AddYears(-21), CentreId = 3 },
                new Parent { Id = 9, FirstName = "Jongokhaya", LastName = "Khwili", DoB = DateTime.Now.AddYears(-30), CentreId = 1 },
                new Parent { Id = 10, FirstName = "Thandeka", LastName = "Khehle", DoB = DateTime.Now.AddYears(-32), CentreId = 3 }
                );

            modelBuilder.Entity<Period>().HasData(
              new Period { Id = 1, Name = "Term 1" },
              new Period { Id = 2, Name = "Term 2" },
              new Period { Id = 3, Name = "Term 3" },
              new Period { Id = 4, Name = "Term 4" }
              );

            modelBuilder.Entity<Teacher>().HasData(
             new Teacher { Id = 1, FirstName = "Margaret", LastName = "Van Hum", DoB = DateTime.Now.AddYears(-45), Qualification = "Bachelor Of Education In Child Development" }
             );

            modelBuilder.Entity<Pupil>().HasData(
            new Pupil { Id = 1, FirstName = "Peter", LastName = "Pope", DoB = DateTime.Now.AddYears(-5), CentreId = 1, ParentId = 1, TeacherId = 1 },
            new Pupil { Id = 2, FirstName = "Amahle", LastName = "Qweba", DoB = DateTime.Now.AddYears(-4), CentreId = 2, ParentId = 2, TeacherId = 1 },
            new Pupil { Id = 3, FirstName = "Junior", LastName = "Doe", DoB = DateTime.Now.AddYears(-5), CentreId = 3, ParentId = 3, TeacherId = 1 },
            new Pupil { Id = 4, FirstName = "Jerry", LastName = "Doe", DoB = DateTime.Now.AddYears(-4), CentreId = 2, ParentId = 4, TeacherId = 1 },
            new Pupil { Id = 5, FirstName = "JJ", LastName = "Doe", DoB = DateTime.Now.AddYears(-6), CentreId = 1, ParentId = 5, TeacherId = 1 },
            new Pupil { Id = 6, FirstName = "Mihle", LastName = "Newton", DoB = DateTime.Now.AddYears(-4), CentreId = 3, ParentId = 6, TeacherId = 1 },
            new Pupil { Id = 7, FirstName = "Sinazo", LastName = "Qweba", DoB = DateTime.Now.AddYears(-5), CentreId = 2, ParentId = 7, TeacherId = 1 },
            new Pupil { Id = 8, FirstName = "Buhle", LastName = "Soze", DoB = DateTime.Now.AddYears(-6), CentreId = 3, ParentId = 8, TeacherId = 1 },
            new Pupil { Id = 9, FirstName = "Khaya", LastName = "Khwili", DoB = DateTime.Now.AddYears(-4), CentreId = 1, ParentId = 9, TeacherId = 1 },
            new Pupil { Id = 10, FirstName = "Kubeka", LastName = "Khehle", DoB = DateTime.Now.AddYears(-5), CentreId = 3, ParentId = 10, TeacherId = 1 }
            );

            modelBuilder.Entity<Programme>().HasData(
            new Programme { Id = 1, Name = "Literacy Development", CentreId = 1 },
            new Programme { Id = 2, Name = "Math And Science", CentreId = 2 },
            new Programme { Id = 3, Name = "Song And Music", CentreId = 1 },
            new Programme { Id = 4, Name = "Art And Music", CentreId = 1 },
            new Programme { Id = 5, Name = "Language And Speech", CentreId = 3 }
            );

        }
    }
}
