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
            this.listViewPatientsInfos = new System.Windows.Forms.ListView();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBloodSugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSymptom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSymptom3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSymptom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSymptom4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSymptom5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSymptom6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSymptom7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSymptom8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorScreenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorScreenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewPatientsInfos
            // 
            this.listViewPatientsInfos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPatientsInfos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewPatientsInfos.CheckBoxes = true;
            this.listViewPatientsInfos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.listViewPatientsInfos.GridLines = true;
            this.listViewPatientsInfos.HideSelection = false;
            this.listViewPatientsInfos.Location = new System.Drawing.Point(0, 103);
            this.listViewPatientsInfos.Name = "listViewPatientsInfos";
            this.listViewPatientsInfos.Size = new System.Drawing.Size(1210, 230);
            this.listViewPatientsInfos.TabIndex = 1;
            this.listViewPatientsInfos.UseCompatibleStateImageBehavior = false;
            this.listViewPatientsInfos.View = System.Windows.Forms.View.Details;
            this.listViewPatientsInfos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPatientsInfos_MouseDoubleClick);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            this.columnHeaderId.Width = 37;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Ad";
            this.columnHeaderName.Width = 50;
            // 
            // columnHeaderSurName
            // 
            this.columnHeaderSurName.Text = "Soyad";
            this.columnHeaderSurName.Width = 63;
            // 
            // columnHeaderGender
            // 
            this.columnHeaderGender.Text = "Cinsiyet";
            this.columnHeaderGender.Width = 68;
            // 
            // columnHeaderAge
            // 
            this.columnHeaderAge.Text = "Yaş";
            this.columnHeaderAge.Width = 49;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "Telefon";
            this.columnHeaderNumber.Width = 70;
            // 
            // columnHeaderBloodSugar
            // 
            this.columnHeaderBloodSugar.Text = "Kan Şekeri";
            this.columnHeaderBloodSugar.Width = 94;
            // 
            // columnHeaderSymptom1
            // 
            this.columnHeaderSymptom1.Text = "Poliüri";
            this.columnHeaderSymptom1.Width = 57;
            // 
            // columnHeaderSymptom2
            // 
            this.columnHeaderSymptom2.Text = "Polifaji";
            // 
            // columnHeaderSymptom3
            // 
            this.columnHeaderSymptom3.Text = "Polidipsi";
            this.columnHeaderSymptom3.Width = 70;
            // 
            // columnHeaderSymptom4
            // 
            this.columnHeaderSymptom4.Text = "Nöropati";
            this.columnHeaderSymptom4.Width = 72;
            // 
            // columnHeaderSymptom5
            // 
            this.columnHeaderSymptom5.Text = "Kilo Kaybı";
            this.columnHeaderSymptom5.Width = 80;
            // 
            // columnHeaderSymptom6
            // 
            this.columnHeaderSymptom6.Text = "Yorgunluk";
            this.columnHeaderSymptom6.Width = 85;
            // 
            // columnHeaderSymptom7
            // 
            this.columnHeaderSymptom7.Text = "Yavaş Yara İyileşmesi";
            this.columnHeaderSymptom7.Width = 166;
            // 
            // columnHeaderSymptom8
            // 
            this.columnHeaderSymptom8.Text = "Bulanık Görme";
            this.columnHeaderSymptom8.Width = 291;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listViewPatientsInfos);
            this.panel1.Location = new System.Drawing.Point(4, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 336);
            this.panel1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "Id",
            "Kan Seviyesi"});
            this.listBox2.Location = new System.Drawing.Point(8, 32);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(131, 44);
            this.listBox2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(156, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Filtrele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(330, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yeni Hasta Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(379, 12);
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
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnSurname,
            this.ColumnGender,
            this.ColumnAge,
            this.ColumnEmail,
            this.ColumnPhone,
            this.ColumnBloodSugar,
            this.ColumnSymptom1,
            this.ColumnSymptom3,
            this.ColumnSymptom2,
            this.ColumnSymptom4,
            this.ColumnSymptom5,
            this.ColumnSymptom6,
            this.ColumnSymptom7,
            this.ColumnSymptom8});
            this.dataGridView.Location = new System.Drawing.Point(1, 82);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1213, 166);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 8;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 50;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Ad";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 80;
            // 
            // ColumnSurname
            // 
            this.ColumnSurname.HeaderText = "Soyad";
            this.ColumnSurname.MinimumWidth = 8;
            this.ColumnSurname.Name = "ColumnSurname";
            this.ColumnSurname.Width = 150;
            // 
            // ColumnGender
            // 
            this.ColumnGender.HeaderText = "Cinsiyet";
            this.ColumnGender.MinimumWidth = 8;
            this.ColumnGender.Name = "ColumnGender";
            this.ColumnGender.Width = 60;
            // 
            // ColumnAge
            // 
            this.ColumnAge.HeaderText = "Yaş";
            this.ColumnAge.MinimumWidth = 8;
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.Width = 40;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.MinimumWidth = 8;
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.Width = 70;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "Telefon No";
            this.ColumnPhone.MinimumWidth = 8;
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.Width = 150;
            // 
            // ColumnBloodSugar
            // 
            this.ColumnBloodSugar.HeaderText = "Kan Şekeri";
            this.ColumnBloodSugar.MinimumWidth = 8;
            this.ColumnBloodSugar.Name = "ColumnBloodSugar";
            this.ColumnBloodSugar.Width = 80;
            // 
            // ColumnSymptom1
            // 
            this.ColumnSymptom1.HeaderText = "Poliüri";
            this.ColumnSymptom1.MinimumWidth = 8;
            this.ColumnSymptom1.Name = "ColumnSymptom1";
            this.ColumnSymptom1.Width = 60;
            // 
            // ColumnSymptom3
            // 
            this.ColumnSymptom3.HeaderText = "Polifaji";
            this.ColumnSymptom3.MinimumWidth = 8;
            this.ColumnSymptom3.Name = "ColumnSymptom3";
            this.ColumnSymptom3.Width = 60;
            // 
            // ColumnSymptom2
            // 
            this.ColumnSymptom2.HeaderText = "Polidipsi";
            this.ColumnSymptom2.MinimumWidth = 8;
            this.ColumnSymptom2.Name = "ColumnSymptom2";
            this.ColumnSymptom2.Width = 60;
            // 
            // ColumnSymptom4
            // 
            this.ColumnSymptom4.HeaderText = "Nöropati";
            this.ColumnSymptom4.MinimumWidth = 8;
            this.ColumnSymptom4.Name = "ColumnSymptom4";
            this.ColumnSymptom4.Width = 60;
            // 
            // ColumnSymptom5
            // 
            this.ColumnSymptom5.HeaderText = "Kilo Kaybı";
            this.ColumnSymptom5.MinimumWidth = 8;
            this.ColumnSymptom5.Name = "ColumnSymptom5";
            this.ColumnSymptom5.Width = 150;
            // 
            // ColumnSymptom6
            // 
            this.ColumnSymptom6.HeaderText = "Yorgunluk";
            this.ColumnSymptom6.MinimumWidth = 8;
            this.ColumnSymptom6.Name = "ColumnSymptom6";
            this.ColumnSymptom6.Width = 150;
            // 
            // ColumnSymptom7
            // 
            this.ColumnSymptom7.HeaderText = "Yavaş Yara İyileşmesi";
            this.ColumnSymptom7.MinimumWidth = 8;
            this.ColumnSymptom7.Name = "ColumnSymptom7";
            this.ColumnSymptom7.Width = 130;
            // 
            // ColumnSymptom8
            // 
            this.ColumnSymptom8.HeaderText = "Bulanık Görme";
            this.ColumnSymptom8.MinimumWidth = 8;
            this.ColumnSymptom8.Name = "ColumnSymptom8";
            this.ColumnSymptom8.Width = 150;
            // 
            // doctorScreenBindingSource
            // 
            this.doctorScreenBindingSource.DataSource = typeof(ProLab3.DoctorScreen);
            // 
            // DoctorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 590);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DoctorScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorScreen_FormClosing);
            this.Load += new System.EventHandler(this.DoctorScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorScreenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewPatientsInfos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSurName;
        private System.Windows.Forms.ColumnHeader columnHeaderGender;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom1;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom2;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom3;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom4;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom5;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom6;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom7;
        private System.Windows.Forms.ColumnHeader columnHeaderSymptom8;
        private System.Windows.Forms.ColumnHeader columnHeaderAge;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderBloodSugar;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBloodSugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSymptom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSymptom3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSymptom2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSymptom4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSymptom5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSymptom6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSymptom7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSymptom8;
        private System.Windows.Forms.BindingSource doctorScreenBindingSource;
        public System.Windows.Forms.DataGridView dataGridView;
    }
}