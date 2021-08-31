using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ameriolize_Aegis.Models
{
    [Table("Parents")]
    public class Parent
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        [ForeignKey(nameof(CentreId))]
        public Centre Centre { get; set; }
        public long CentreId { get; set; }
        public ICollection<Pupil> Pupils { get; set; }

        public Parent()
        {
            CreationTime = DateTime.Now;
        }
    }
}
