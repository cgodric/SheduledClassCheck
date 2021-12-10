using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheduledClassCheck
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (DBContext db = new DBContext())
            //{
            //    Auditorium a101 = new Auditorium { Number = 101, Floor = 1, Type = "Лекционная", Employment = false };
            //    Auditorium a102 = new Auditorium { Number = 102, Floor = 1, Type = "Компьютерная", Employment = true };

            //    db.Auditoriums.Add(a101);
            //    db.Auditoriums.Add(a102);
            //    db.SaveChanges();

            //    Professor professor = new Professor { Name = "Грицкевич Евгений Владимирович", NumberOfAuditoriums = 0, Login = "GricEW", Password = "GricEW" };

            //    db.Professors.Add(professor);
            //    db.SaveChanges();
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginFrm());
        }
    }
}
