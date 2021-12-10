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
    public partial class frmRemoveAud : Form
    {
        public frmRemoveAud()
        {
            InitializeComponent();
            btnRemove.Enabled = false;
        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            using (DBContext db = new DBContext())
            {
                int num = int.Parse(textBoxNumber.Text);
                var audCheck = db.Auditoriums.Where(audvalid => audvalid.Number == num).FirstOrDefault();
                if (audCheck != null)
                {
                    db.Auditoriums.Remove(audCheck);
                    db.SaveChanges();
                    MessageBox.Show("Аудитория успешно удалена!", "Удаление аудитории");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такой аудитории не существует!", "Удаление аудитории");
                }
                
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

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
