using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SheduledClassCheck
{
    public class DBContext : DbContext
    {
        public DBContext()
            : base("DbConnection")
        { }

        public DbSet<Auditorium> Auditoriums { get; set; }
        public DbSet<User> Users { get; set; } 
        public DbSet<TimeOfClasses> TimesOfClasses { get; set; }
        public DbSet<Employment> Employments { get; set; }
    }
}
