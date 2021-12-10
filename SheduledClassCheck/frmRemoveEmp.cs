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
    public partial class frmRemoveEmp : Form
    {
        public frmRemoveEmp()
        {
            InitializeComponent();
            btnRemove.Enabled = false;
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
            if (textBoxNumber.Text != "")
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            using (DBContext db = new DBContext())
            {
                DateTime date = calendarEmp.SelectionStart.Date;
                int num = int.Parse(textBoxNumber.Text);
                var findAud = db.Auditoriums.Where(auditory => auditory.Number == num).FirstOrDefault();
                var findEmp = db.Employments.Where(emp => emp.EmploymentDate == date && emp.Auditorium.Id == findAud.Id && emp.TimeOfClasses.ClassTime == comboBoxClassTime.SelectedItem.ToString()).FirstOrDefault();
                if (findEmp != null)
                {
                    db.Employments.Remove(findEmp);
                    db.SaveChanges();
                    MessageBox.Show("Запись о занятости успешно удалена!", "Удаление занятости");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такой записи не существует!", "Удаление занятости");
                }
            }
        }
    }
}
