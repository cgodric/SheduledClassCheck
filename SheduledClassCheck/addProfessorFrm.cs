using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SheduledClassCheck
{
    public partial class addProfessorFrm : Form
    {
        public addProfessorFrm()
        {
            InitializeComponent();
            buttonAdd.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    var userCheck = db.Users.Where(uservalid => uservalid.Login == textBoxLogin.Text).FirstOrDefault();
                    if (userCheck == null)
                    {
                        User user = new User();
                        user.Name = textBoxName.Text;
                        user.NumberOfAuditoriums = 0;
                        user.Login = textBoxLogin.Text;
                        user.Password = PassEncrypt(textBoxPassword.Text);
                        user.Role = chkBoxAdmin.Checked;
                        db.Users.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("Профиль успешно создан!", "Создание профиля");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Профиль с таким логином уже существует!", "Ошибка создания профиля");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Ошибка в записи!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void CheckTextBoxes()
        {
            if (textBoxName.Text != "" && textBoxLogin.Text != "" && textBoxPassword.Text != "")
            {
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonAdd.Enabled = false;
            }
        }
        
        private static string PassEncrypt(string password)
        {
            string salt = "BestWishesGEV";
            byte[] tmpSource;
            byte[] tmpHash;

            password += salt;

            tmpSource = Encoding.Unicode.GetBytes(password);
            tmpHash = new SHA256CryptoServiceProvider().ComputeHash(tmpSource);

            StringBuilder sOutput = new StringBuilder(tmpHash.Length);
            for (int i = 0; i < tmpHash.Length; i++)
            {
                sOutput.Append(tmpHash[i].ToString("X2"));
            }
            return sOutput.ToString();
        }
    }
}
