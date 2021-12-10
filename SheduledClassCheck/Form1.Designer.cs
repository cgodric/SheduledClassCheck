
namespace SheduledClassCheck
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ComboBoxFloor = new System.Windows.Forms.ComboBox();
            this.ComboBoxTime = new System.Windows.Forms.ComboBox();
            this.ComboBoxAud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProfessor = new System.Windows.Forms.Button();
            this.btnAddAuditorium = new System.Windows.Forms.Button();
            this.panelBtnAud = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveAud = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnRemoveEmp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxFloor
            // 
            this.ComboBoxFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFloor.FormattingEnabled = true;
            this.ComboBoxFloor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBoxFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.ComboBoxFloor.Location = new System.Drawing.Point(12, 24);
            this.ComboBoxFloor.Name = "ComboBoxFloor";
            this.ComboBoxFloor.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxFloor.TabIndex = 1;
            // 
            // ComboBoxTime
            // 
            this.ComboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTime.FormattingEnabled = true;
            this.ComboBoxTime.Items.AddRange(new object[] {
            "8.30 - 10.00",
            "10.15 - 11.45",
            "12.00 - 13.30",
            "14.00 - 15.30",
            "15.45 - 17.15",
            "17.30 - 19.00",
            "19.15 - 20.45",
            "21.00 - 22.30"});
            this.ComboBoxTime.Location = new System.Drawing.Point(139, 24);
            this.ComboBoxTime.Name = "ComboBoxTime";
            this.ComboBoxTime.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxTime.TabIndex = 2;
            // 
            // ComboBoxAud
            // 
            this.ComboBoxAud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAud.FormattingEnabled = true;
            this.ComboBoxAud.Items.AddRange(new object[] {
            "-Все-",
            "-Лекционные-",
            "-Компьютерные-",
            "-Семинарные-"});
            this.ComboBoxAud.Location = new System.Drawing.Point(266, 24);
            this.ComboBoxAud.Name = "ComboBoxAud";
            this.ComboBoxAud.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxAud.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Этаж:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип аудитории:";
            // 
            // btnAddProfessor
            // 
            this.btnAddProfessor.Location = new System.Drawing.Point(7, 30);
            this.btnAddProfessor.Name = "btnAddProfessor";
            this.btnAddProfessor.Size = new System.Drawing.Size(100, 40);
            this.btnAddProfessor.TabIndex = 7;
            this.btnAddProfessor.Text = "Добавить пользователя";
            this.btnAddProfessor.UseVisualStyleBackColor = true;
            this.btnAddProfessor.Click += new System.EventHandler(this.btnAddProfessor_Click);
            // 
            // btnAddAuditorium
            // 
            this.btnAddAuditorium.Location = new System.Drawing.Point(6, 30);
            this.btnAddAuditorium.Name = "btnAddAuditorium";
            this.btnAddAuditorium.Size = new System.Drawing.Size(100, 40);
            this.btnAddAuditorium.TabIndex = 8;
            this.btnAddAuditorium.Text = "Добавить аудиторию";
            this.btnAddAuditorium.UseVisualStyleBackColor = true;
            this.btnAddAuditorium.Click += new System.EventHandler(this.btnAddAuditorium_Click);
            // 
            // panelBtnAud
            // 
            this.panelBtnAud.AutoScroll = true;
            this.panelBtnAud.Location = new System.Drawing.Point(12, 51);
            this.panelBtnAud.Name = "panelBtnAud";
            this.panelBtnAud.Size = new System.Drawing.Size(375, 154);
            this.panelBtnAud.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveAud);
            this.groupBox1.Controls.Add(this.btnAddAuditorium);
            this.groupBox1.Location = new System.Drawing.Point(410, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 118);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия с аудиториями";
            // 
            // btnRemoveAud
            // 
            this.btnRemoveAud.Location = new System.Drawing.Point(6, 76);
            this.btnRemoveAud.Name = "btnRemoveAud";
            this.btnRemoveAud.Size = new System.Drawing.Size(100, 36);
            this.btnRemoveAud.TabIndex = 9;
            this.btnRemoveAud.Text = "Удалить аудиторию";
            this.btnRemoveAud.UseVisualStyleBackColor = true;
            this.btnRemoveAud.Click += new System.EventHandler(this.btnRemoveAud_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveUser);
            this.groupBox2.Controls.Add(this.btnAddProfessor);
            this.groupBox2.Location = new System.Drawing.Point(528, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 118);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия с пользователями";
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(7, 76);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(100, 36);
            this.btnRemoveUser.TabIndex = 8;
            this.btnRemoveUser.Text = "Удалить пользователя";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddEmp);
            this.groupBox3.Controls.Add(this.btnRemoveEmp);
            this.groupBox3.Location = new System.Drawing.Point(410, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 56);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Действия с занятостью";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(6, 14);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(100, 36);
            this.btnAddEmp.TabIndex = 2;
            this.btnAddEmp.Text = "Добавить занятость";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnRemoveEmp
            // 
            this.btnRemoveEmp.Location = new System.Drawing.Point(125, 14);
            this.btnRemoveEmp.Name = "btnRemoveEmp";
            this.btnRemoveEmp.Size = new System.Drawing.Size(99, 36);
            this.btnRemoveEmp.TabIndex = 1;
            this.btnRemoveEmp.Text = "Удалить занятость";
            this.btnRemoveEmp.UseVisualStyleBackColor = true;
            this.btnRemoveEmp.Click += new System.EventHandler(this.btnRemoveEmp_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 211);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelBtnAud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxAud);
            this.Controls.Add(this.ComboBoxTime);
            this.Controls.Add(this.ComboBoxFloor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Занятость аудиторий";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_Closed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxFloor;
        private System.Windows.Forms.ComboBox ComboBoxTime;
        private System.Windows.Forms.ComboBox ComboBoxAud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddProfessor;
        private System.Windows.Forms.Button btnAddAuditorium;
        private System.Windows.Forms.Panel panelBtnAud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRemoveAud;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnRemoveEmp;
        private System.Windows.Forms.Button btnAddEmp;
    }
}

