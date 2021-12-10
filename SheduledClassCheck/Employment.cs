using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SheduledClassCheck
{
    public class Employment
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime EmploymentDate { get; set; }

        public User Professor { get; set; }

        public Auditorium Auditorium { get; set; }

        public TimeOfClasses TimeOfClasses { get; set; }
    }
}
