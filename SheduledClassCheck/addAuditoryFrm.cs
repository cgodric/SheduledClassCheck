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
    public partial class addAuditoryFrm : Form
    {
        public addAuditoryFrm()
        {
            InitializeComponent();
            btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (DBContext db = new DBContext())
            {
                int num = int.Parse(textBoxNumber.Text);
                var audCheck = db.Auditoriums.Where(audvalid => audvalid.Number == num).FirstOrDefault();
                if (audCheck == null)
                {
                    string type;
                    if (cmbBoxType.SelectedIndex == 0)
                    {
                        type = "Lecture";
                    }
                    else if (cmbBoxType.SelectedIndex == 1)
                    {
                        type = "Computer";
                    }
                    else
                    {
                        type = "Seminar";
                    }
                    Auditorium auditory = new Auditorium();
                    auditory.Number = int.Parse(textBoxNumber.Text);
                    auditory.Floor = int.Parse(textBoxFloor.Text);
                    auditory.Type = type;
                    db.Auditoriums.Add(auditory);
                    db.SaveChanges();
                    MessageBox.Show("Аудитория успешно создана!", "Создание аудитории");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Аудитория с таким номером уже существует!", "Ошибка создания аудитории");
                }
            }
        }

        private void CheckValues()
        {
            if (textBoxNumber.Text != "" && textBoxFloor.Text != "" && cmbBoxType.SelectedIndex > -1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void textBoxFloor_TextChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void cmbBoxType_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
