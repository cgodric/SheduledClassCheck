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
    public partial class frmRemoveUser : Form
    {
        public frmRemoveUser()
        {
            InitializeComponent();
            btnRemove.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            using (DBContext db = new DBContext())
            {
                var userRemove = db.Users.Where(userFind => userFind.Login == textBoxLogin.Text).FirstOrDefault();
                if (userRemove != null)
                {
                    db.Users.Remove(userRemove);
                    db.SaveChanges();
                    MessageBox.Show("Пользователь успешно удалён!", "Удаление пользователя");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует!", "Удаление пользователя");
                }
            }
        }

        private void CheckValues()
        {
            if (textBoxLogin.Text != "")
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

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            CheckValues();
        }
    }
}
