using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheduledClassCheck
{
    public partial class frmAddEmp : Form
    {
        public frmAddEmp()
        {
            InitializeComponent();
            btnAdd.Enabled = false;
            comboBoxClassTime.SelectedIndex = 0;
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void CheckValues()
        {
            if (textBoxNumber.Text != "" && textBoxLogin.Text != "" && comboBoxClassTime.SelectedIndex > -1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (DBContext db = new DBContext())
            {
                DateTime date = calenNewEmp.SelectionStart.Date;
                int num = int.Parse(textBoxNumber.Text);
                var findAud = db.Auditoriums.Where(auditory => auditory.Number == num).FirstOrDefault();
                var findProf = db.Users.Where(prof => prof.Login == textBoxLogin.Text).FirstOrDefault();
                var findClassTime = db.TimesOfClasses.Where(dated => dated.ClassTime == comboBoxClassTime.SelectedItem.ToString()).FirstOrDefault();
                if (findAud == null)
                {
                    MessageBox.Show("Аудитории с таким номером не существует!", "Добавление занятости");
                }
                else if (findProf == null)
                {
                    MessageBox.Show("Пользователя с таким логином не существует!", "Добавление занятости");
                }
                else
                {
                    var findAlreadyEmployed = db.Employments.Where(emp => emp.EmploymentDate == date && emp.Auditorium.Id == findAud.Id && emp.TimeOfClasses.ClassTime == comboBoxClassTime.SelectedItem.ToString()).FirstOrDefault();
                    if (findAlreadyEmployed == null)
                    {
                        Employment newEmp = new Employment();
                        newEmp.EmploymentDate = date;
                        newEmp.Auditorium = findAud;
                        newEmp.Professor = findProf;
                        newEmp.TimeOfClasses = findClassTime;
                        db.Employments.Add(newEmp);
                        db.SaveChanges();
                        MessageBox.Show("Запись о занятости успешно добавлена!", "Добавление занятости");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("В данный период времени аудитория уже занята!", "Добавление занятости");
                    }
                }
            }
        }
    }
}
