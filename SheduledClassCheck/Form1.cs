using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace SheduledClassCheck
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            ComboBoxTime.SelectedIndex = 0;
            ComboBoxAud.SelectedIndex = 0;
            ComboBoxFloor.SelectedIndex = 0;
            this.ComboBoxFloor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFloor_SelectedIndexChanged);
            this.ComboBoxAud.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAud_SelectedIndexChanged);
            this.ComboBoxTime.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTime_SelectedIndexChanged);
            FindInfoDB();
        }

        public string InboxData = String.Empty;

        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            addProfessorFrm addProf = new addProfessorFrm();
            addProf.ShowDialog();
        }

        private void btnAddAuditorium_Click(object sender, EventArgs e)
        {
            addAuditoryFrm addAud = new addAuditoryFrm();
            addAud.ShowDialog();
            FindInfoDB();
        }

        private void FindInfoDB()
        {
            string AudType = "";
            if (ComboBoxAud.SelectedIndex == 1)
            {
                AudType = "Lecture";
            }
            else if (ComboBoxAud.SelectedIndex == 2)
            {
                AudType = "Computer";
            }
            else if (ComboBoxAud.SelectedIndex == 3)
            {
                AudType = "Seminar";
            }
            using (DBContext db = new DBContext())
            {
                if (ComboBoxAud.SelectedIndex == 0)
                {
                    int i = 0;
                    int Flor = int.Parse(ComboBoxFloor.SelectedItem.ToString());
                    var showedAud = db.Auditoriums.Where(auditory => auditory.Floor == Flor).ToList();
                    foreach (var auditory in showedAud)
                    {
                        CreateBtn(auditory, i);
                        i++;
                    }
                }
                else
                {
                    int i = 0;
                    int Flor = int.Parse(ComboBoxFloor.SelectedItem.ToString());
                    var showedAud = db.Auditoriums.Where(auditory => auditory.Floor == Flor && auditory.Type == AudType).ToList();
                    foreach (var aud in showedAud)
                    {
                        CreateBtn(aud, i);
                        i++;
                    }
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            using (DBContext db = new DBContext())
            {
                Employment newEmp = new Employment();
                newEmp.EmploymentDate = DateTime.Now.Date;
                var par = sender as Button;
                int num = int.Parse(par.Text);
                var findAud = db.Auditoriums.Where(auditory => auditory.Number == num).FirstOrDefault();
                newEmp.Auditorium = findAud;
                var findUser = db.Users.Where(user => user.Login == InboxData).FirstOrDefault();
                newEmp.Professor = findUser;
                var findTime = db.TimesOfClasses.Where(time => time.ClassTime == ComboBoxTime.SelectedItem.ToString()).FirstOrDefault();
                newEmp.TimeOfClasses = findTime;
                db.Employments.Add(newEmp);
                db.SaveChanges();
                MessageBox.Show("Аудитория успешно занята!", "Бронирование аудитории");
            }
        }

        private void CreateBtn(Auditorium auditory, int i)
        {
            using (DBContext db = new DBContext())
            {
                Button btn = new Button();
                btn.Text = auditory.Number.ToString();
                btn.Width = 40;
                btn.Height = 20;
                if (i * 40 <= panelBtnAud.Width)
                    btn.Location = new Point(i * 40, 0);
                else
                    btn.Location = new Point(i * 40, i * 1);
                DateTime today = DateTime.Now.Date;
                var checkAud = db.Employments.Where(checkaud => checkaud.EmploymentDate == today && checkaud.TimeOfClasses.ClassTime == ComboBoxTime.SelectedItem.ToString() && checkaud.Auditorium.Id == auditory.Id).FirstOrDefault();
                if (checkAud != null)
                {
                    btn.BackColor = Color.Red;
                }
                else
                {
                    btn.BackColor = Color.Green;
                    btn.Click += new System.EventHandler(this.btn_Click);
                }
                panelBtnAud.Controls.Add(btn);
            }
        }

        private void ComboBoxFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelBtnAud.Controls.Clear();
            FindInfoDB();
        }

        private void ComboBoxAud_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelBtnAud.Controls.Clear();
            FindInfoDB();
        }

        private void ComboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelBtnAud.Controls.Clear();
            FindInfoDB();
        }

        private void MainWindow_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRemoveAud_Click(object sender, EventArgs e)
        {
            frmRemoveAud rmvAud = new frmRemoveAud();
            rmvAud.ShowDialog();
            FindInfoDB();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            frmRemoveUser rmvUser = new frmRemoveUser();
            rmvUser.ShowDialog();
        }

        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            frmRemoveEmp rmvEmp = new frmRemoveEmp();
            rmvEmp.ShowDialog();
            FindInfoDB();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            frmAddEmp addEmp = new frmAddEmp();
            addEmp.ShowDialog();
            FindInfoDB();
        }
    }
}
