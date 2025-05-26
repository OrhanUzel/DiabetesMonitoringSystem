namespace ProLab3
{
    partial class DoctorScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewPatientsInfos = new System.Windows.Forms.ListView();
            this.columnHeaderRow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSurName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBloodSugar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.doctorScreenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonRefreshList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorScreenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(464, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doktor Ekranı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProLab3.Properties.Resources.profile_user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // listViewPatientsInfos
            // 
            this.listViewPatientsInfos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listViewPatientsInfos.CheckBoxes = true;
            this.listViewPatientsInfos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderRow,
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderSurName,
            this.columnHeaderGender,
            this.columnHeaderAge,
            this.columnHeaderEmail,
            this.columnHeaderNumber,
            this.columnHeaderBloodSugar,
            this.columnHeaderSymptom1,
            this.columnHeaderSymptom2,
            this.columnHeaderSymptom3,
            this.columnHeaderSymptom4,
            this.columnHeaderSymptom5,
            this.columnHeaderSymptom6,
            this.columnHeaderSymptom7,
            this.columnHeaderSymptom8});
            this.listViewPatientsInfos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewPatientsInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewPatientsInfos.FullRowSelect = true;
            this.listViewPatientsInfos.GridLines = true;
            this.listViewPatientsInfos.HideSelection = false;
            this.listViewPatientsInfos.Location = new System.Drawing.Point(2, 195);
            this.listViewPatientsInfos.Name = "listViewPatientsInfos";
            this.listViewPatientsInfos.Size = new System.Drawing.Size(1225, 402);
            this.listViewPatientsInfos.TabIndex = 1;
            this.listViewPatientsInfos.UseCompatibleStateImageBehavior = false;
            this.listViewPatientsInfos.View = System.Windows.Forms.View.Details;
            this.listViewPatientsInfos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPatientsInfos_MouseDoubleClick);
            // 
            // columnHeaderRow
            // 
            this.columnHeaderRow.Text = "#";
            this.columnHeaderRow.Width = 34;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            this.columnHeaderId.Width = 37;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Ad";
            this.columnHeaderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderName.Width = 88;
            // 
            // columnHeaderSurName
            // 
            this.columnHeaderSurName.Text = "Soyad";
            this.columnHeaderSurName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSurName.Width = 93;
            // 
            // columnHeaderGender
            // 
            this.columnHeaderGender.Text = "Cinsiyet";
            this.columnHeaderGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderGender.Width = 95;
            // 
            // columnHeaderAge
            // 
            this.columnHeaderAge.Text = "Yaş";
            this.columnHeaderAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderAge.Width = 81;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderEmail.Width = 87;
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "Telefon";
            this.columnHeaderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderNumber.Width = 104;
            // 
            // columnHeaderBloodSugar
            // 
            this.columnHeaderBloodSugar.Text = "Kan Şekeri";
            this.columnHeaderBloodSugar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBloodSugar.Width = 121;
            // 
            // columnHeaderSymptom1
            // 
            this.columnHeaderSymptom1.Text = "Poliüri";
            this.columnHeaderSymptom1.Width = 77;
            // 
            // columnHeaderSymptom2
            // 
            this.columnHeaderSymptom2.Text = "Polifaji";
            this.columnHeaderSymptom2.Width = 83;
            // 
            // columnHeaderSymptom3
            // 
            this.columnHeaderSymptom3.Text = "Polidipsi";
            this.columnHeaderSymptom3.Width = 102;
            // 
            // columnHeaderSymptom4
            // 
            this.columnHeaderSymptom4.Text = "Nöropati";
            this.columnHeaderSymptom4.Width = 100;
            // 
            // columnHeaderSymptom5
            // 
            this.columnHeaderSymptom5.Text = "Kilo Kaybı";
            this.columnHeaderSymptom5.Width = 110;
            // 
            // columnHeaderSymptom6
            // 
            this.columnHeaderSymptom6.Text = "Yorgunluk";
            this.columnHeaderSymptom6.Width = 122;
            // 
            // columnHeaderSymptom7
            // 
            this.columnHeaderSymptom7.Text = "Yavaş Yara İyileşmesi";
            this.columnHeaderSymptom7.Width = 234;
            // 
            // columnHeaderSymptom8
            // 
            this.columnHeaderSymptom8.Text = "Bulanık Görme";
            this.columnHeaderSymptom8.Width = 180;
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddPatient.Location = new System.Drawing.Point(467, 111);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(233, 64);
            this.buttonAddPatient.TabIndex = 2;
            this.buttonAddPatient.Text = "Yeni Hasta Ekle";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(308, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "Filtrele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "Id",
            "Kan Seviyesi"});
            this.listBox2.Location = new System.Drawing.Point(201, 111);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(101, 64);
            this.listBox2.TabIndex = 4;
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeletePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDeletePatient.Location = new System.Drawing.Point(706, 111);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(250, 64);
            this.buttonDeletePatient.TabIndex = 5;
            this.buttonDeletePatient.Text = "Seçilen Hastayı Sil";
            this.buttonDeletePatient.UseVisualStyleBackColor = true;
            this.buttonDeletePatient.Click += new System.EventHandler(this.buttonDeletePatient_Click);
            // 
            // buttonDetail
            // 
            this.buttonDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDetail.Location = new System.Drawing.Point(962, 111);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(255, 64);
            this.buttonDetail.TabIndex = 8;
            this.buttonDetail.Text = "Hasta Bilgilerine Git";
            this.buttonDetail.UseVisualStyleBackColor = true;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // doctorScreenBindingSource
            // 
            this.doctorScreenBindingSource.DataSource = typeof(ProLab3.DoctorScreen);
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRefreshList.Location = new System.Drawing.Point(2, 111);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(177, 64);
            this.buttonRefreshList.TabIndex = 9;
            this.buttonRefreshList.Text = "Listeyi Yenile";
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.buttonRefreshList_Click);
            // 
            // DoctorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 594);
            this.Controls.Add(this.buttonRefreshList);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.listViewPatientsInfos);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonDeletePatient);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddPatient);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DoctorScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorScreen_FormClosing);
            this.Load += new System.EventHandler(this.DoctorScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorScreenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource doctorScreenBindingSource;
        private System.Windows.Forms.ListView listViewPatientsInfos;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSurName;
        private System.Windows.Forms.ColumnHeader columnHeaderGender;
        private System.Windows.Forms.ColumnHeader columnHeaderAge;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderBloodSugar;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom1;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom2;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom3;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom4;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom5;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom6;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom7;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom8;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonDeletePatient;
        private System.Windows.Forms.ColumnHeader columnHeaderRow;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.Button buttonRefreshList;
    }
}