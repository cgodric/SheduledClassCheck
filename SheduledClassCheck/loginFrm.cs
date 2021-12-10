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
    public partial class loginFrm : Form
    {
        public loginFrm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            using (DBContext db = new DBContext())
            {
                var Login = db.Users.Where(user => user.Login == textBoxLogin.Text).FirstOrDefault();
                if (Login != null && Login.Password == PassEncrypt(textBoxPassword.Text))
                {
                    this.Hide();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.InboxData = textBoxLogin.Text;
                    if(Login.Role == true)
                    {
                        mainWindow.Width = 665;
                    } 
                    else
                    {
                        mainWindow.Width = 414;
                    }
                    mainWindow.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Логин или пароль не совпадают!", "Ошибка входа");
                }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
