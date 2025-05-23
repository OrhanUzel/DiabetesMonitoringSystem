namespace ProLab3
{
    partial class PatientScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.buttonRewind = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonGoMeasures = new System.Windows.Forms.Button();
            this.buttonGoAdvises = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonChangeİmage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageAdvises = new System.Windows.Forms.TabPage();
            this.labelAdvises = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCompleteExercise = new System.Windows.Forms.Button();
            this.buttonCompleteDiet = new System.Windows.Forms.Button();
            this.dataGridViewAdvises = new System.Windows.Forms.DataGridView();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExercise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDietStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExerciseStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageBloodSugarData = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxVakit = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHour = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownBloodSugar = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewMeasures = new System.Windows.Forms.DataGridView();
            this.ColumnDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVakit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageAdvises.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdvises)).BeginInit();
            this.tabPageBloodSugarData.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBloodSugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeasures)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageInfo);
            this.tabControl.Controls.Add(this.tabPageAdvises);
            this.tabControl.Controls.Add(this.tabPageBloodSugarData);
            this.tabControl.Location = new System.Drawing.Point(1, -2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1239, 596);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPage_Selected);
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.buttonRewind);
            this.tabPageInfo.Controls.Add(this.buttonSave);
            this.tabPageInfo.Controls.Add(this.buttonGoMeasures);
            this.tabPageInfo.Controls.Add(this.buttonGoAdvises);
            this.tabPageInfo.Controls.Add(this.buttonUpdate);
            this.tabPageInfo.Controls.Add(this.buttonChangeİmage);
            this.tabPageInfo.Controls.Add(this.pictureBox1);
            this.tabPageInfo.Controls.Add(this.tableLayoutPanel1);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 29);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(1231, 563);
            this.tabPageInfo.TabIndex = 0;
            this.tabPageInfo.Text = "Bilgilerim";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // buttonRewind
            // 
            this.buttonRewind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRewind.Location = new System.Drawing.Point(1081, 452);
            this.buttonRewind.Name = "buttonRewind";
            this.buttonRewind.Size = new System.Drawing.Size(124, 57);
            this.buttonRewind.TabIndex = 7;
            this.buttonRewind.Text = "Geri Al";
            this.buttonRewind.UseVisualStyleBackColor = true;
            this.buttonRewind.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Location = new System.Drawing.Point(936, 452);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(124, 57);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Kaydet";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            // 
            // buttonGoMeasures
            // 
            this.buttonGoMeasures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoMeasures.Location = new System.Drawing.Point(1036, 16);
            this.buttonGoMeasures.Name = "buttonGoMeasures";
            this.buttonGoMeasures.Size = new System.Drawing.Size(124, 84);
            this.buttonGoMeasures.TabIndex = 5;
            this.buttonGoMeasures.Text = "Ölçüm Ekranına Git";
            this.buttonGoMeasures.UseVisualStyleBackColor = true;
            this.buttonGoMeasures.Click += new System.EventHandler(this.buttonGoMeasures_Click);
            // 
            // buttonGoAdvises
            // 
            this.buttonGoAdvises.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoAdvises.Location = new System.Drawing.Point(895, 16);
            this.buttonGoAdvises.Name = "buttonGoAdvises";
            this.buttonGoAdvises.Size = new System.Drawing.Size(124, 84);
            this.buttonGoAdvises.TabIndex = 4;
            this.buttonGoAdvises.Text = "Doktor Önerileri Ekranına Git";
            this.buttonGoAdvises.UseVisualStyleBackColor = true;
            this.buttonGoAdvises.Click += new System.EventHandler(this.buttonGoAdvises_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.Location = new System.Drawing.Point(995, 326);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(150, 79);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Bilgi Güncelleme";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonChangeİmage
            // 
            this.buttonChangeİmage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeİmage.Location = new System.Drawing.Point(540, 141);
            this.buttonChangeİmage.Name = "buttonChangeİmage";
            this.buttonChangeİmage.Size = new System.Drawing.Size(201, 51);
            this.buttonChangeİmage.TabIndex = 2;
            this.buttonChangeİmage.Text = "Profil Resmini Değiştir";
            this.buttonChangeİmage.UseVisualStyleBackColor = true;
            this.buttonChangeİmage.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(551, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 129);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerBirthDate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEmail, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGender, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSurname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPhone, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(294, 217);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66651F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6661F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66789F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66651F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66651F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66651F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(621, 286);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerBirthDate.Enabled = false;
            this.dateTimePickerBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(189, 148);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(429, 32);
            this.dateTimePickerBirthDate.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxEmail.Location = new System.Drawing.Point(189, 191);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(429, 35);
            this.textBoxEmail.TabIndex = 5;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGender.Enabled = false;
            this.textBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxGender.Location = new System.Drawing.Point(189, 97);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(429, 35);
            this.textBoxGender.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSurname.Enabled = false;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSurname.Location = new System.Drawing.Point(189, 50);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(429, 35);
            this.textBoxSurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 47);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 47);
            this.label5.TabIndex = 4;
            this.label5.Text = "Eposta:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 51);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tel. No:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Enabled = false;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxName.Location = new System.Drawing.Point(189, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(429, 35);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.Enabled = false;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPhone.Location = new System.Drawing.Point(189, 238);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(429, 35);
            this.textBoxPhone.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageAdvises
            // 
            this.tabPageAdvises.Controls.Add(this.labelAdvises);
            this.tabPageAdvises.Controls.Add(this.label11);
            this.tabPageAdvises.Controls.Add(this.buttonCompleteExercise);
            this.tabPageAdvises.Controls.Add(this.buttonCompleteDiet);
            this.tabPageAdvises.Controls.Add(this.dataGridViewAdvises);
            this.tabPageAdvises.Location = new System.Drawing.Point(4, 29);
            this.tabPageAdvises.Name = "tabPageAdvises";
            this.tabPageAdvises.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdvises.Size = new System.Drawing.Size(1231, 563);
            this.tabPageAdvises.TabIndex = 1;
            this.tabPageAdvises.Text = "Doktor Önerileri";
            this.tabPageAdvises.UseVisualStyleBackColor = true;
            this.tabPageAdvises.Click += new System.EventHandler(this.tabPageAdvises_Click);
            // 
            // labelAdvises
            // 
            this.labelAdvises.BackColor = System.Drawing.Color.GreenYellow;
            this.labelAdvises.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdvises.Location = new System.Drawing.Point(34, 457);
            this.labelAdvises.Name = "labelAdvises";
            this.labelAdvises.Size = new System.Drawing.Size(1136, 103);
            this.labelAdvises.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(475, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(284, 29);
            this.label11.TabIndex = 8;
            this.label11.Text = "Diyet ve Egzersiz Bilgileri";
            // 
            // buttonCompleteExercise
            // 
            this.buttonCompleteExercise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCompleteExercise.Location = new System.Drawing.Point(618, 294);
            this.buttonCompleteExercise.Name = "buttonCompleteExercise";
            this.buttonCompleteExercise.Size = new System.Drawing.Size(552, 65);
            this.buttonCompleteExercise.TabIndex = 5;
            this.buttonCompleteExercise.Text = "Egzersizimi Tamamladım";
            this.buttonCompleteExercise.UseVisualStyleBackColor = true;
            // 
            // buttonCompleteDiet
            // 
            this.buttonCompleteDiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCompleteDiet.Location = new System.Drawing.Point(34, 294);
            this.buttonCompleteDiet.Name = "buttonCompleteDiet";
            this.buttonCompleteDiet.Size = new System.Drawing.Size(578, 65);
            this.buttonCompleteDiet.TabIndex = 4;
            this.buttonCompleteDiet.Text = "Diyetimi Tamamladım";
            this.buttonCompleteDiet.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdvises
            // 
            this.dataGridViewAdvises.AllowUserToOrderColumns = true;
            this.dataGridViewAdvises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdvises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDate,
            this.ColumnDiet,
            this.ColumnExercise,
            this.ColumnDietStatus,
            this.ColumnExerciseStatus});
            this.dataGridViewAdvises.Location = new System.Drawing.Point(34, 6);
            this.dataGridViewAdvises.Name = "dataGridViewAdvises";
            this.dataGridViewAdvises.RowHeadersWidth = 30;
            this.dataGridViewAdvises.RowTemplate.Height = 28;
            this.dataGridViewAdvises.Size = new System.Drawing.Size(1136, 282);
            this.dataGridViewAdvises.TabIndex = 0;
            // 
            // ColumnDate
            // 
            this.ColumnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDate.HeaderText = "Tarih";
            this.ColumnDate.MinimumWidth = 8;
            this.ColumnDate.Name = "ColumnDate";
            // 
            // ColumnDiet
            // 
            this.ColumnDiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDiet.HeaderText = "Diyet Önerisi";
            this.ColumnDiet.MinimumWidth = 8;
            this.ColumnDiet.Name = "ColumnDiet";
            // 
            // ColumnExercise
            // 
            this.ColumnExercise.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnExercise.HeaderText = "Egzersiz Önerisi";
            this.ColumnExercise.MinimumWidth = 8;
            this.ColumnExercise.Name = "ColumnExercise";
            // 
            // ColumnDietStatus
            // 
            this.ColumnDietStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDietStatus.HeaderText = "Diyet Durumu";
            this.ColumnDietStatus.MinimumWidth = 8;
            this.ColumnDietStatus.Name = "ColumnDietStatus";
            // 
            // ColumnExerciseStatus
            // 
            this.ColumnExerciseStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnExerciseStatus.HeaderText = "Egzersiz Durumu";
            this.ColumnExerciseStatus.MinimumWidth = 8;
            this.ColumnExerciseStatus.Name = "ColumnExerciseStatus";
            // 
            // tabPageBloodSugarData
            // 
            this.tabPageBloodSugarData.Controls.Add(this.buttonDelete);
            this.tabPageBloodSugarData.Controls.Add(this.buttonAdd);
            this.tabPageBloodSugarData.Controls.Add(this.tableLayoutPanel2);
            this.tabPageBloodSugarData.Controls.Add(this.dataGridViewMeasures);
            this.tabPageBloodSugarData.Location = new System.Drawing.Point(4, 29);
            this.tabPageBloodSugarData.Name = "tabPageBloodSugarData";
            this.tabPageBloodSugarData.Size = new System.Drawing.Size(1231, 563);
            this.tabPageBloodSugarData.TabIndex = 2;
            this.tabPageBloodSugarData.Text = "Ölçümlerim";
            this.tabPageBloodSugarData.UseVisualStyleBackColor = true;
            this.tabPageBloodSugarData.Click += new System.EventHandler(this.tabPageBloodSugarData_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDelete.Location = new System.Drawing.Point(914, 410);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(294, 79);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Sil";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdd.Location = new System.Drawing.Point(608, 410);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(300, 79);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Ekle";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.29353F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.70647F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxVakit, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerHour, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownBloodSugar, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(608, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(603, 381);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 95);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tarih";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 95);
            this.label8.TabIndex = 1;
            this.label8.Text = "Vakit";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(3, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 95);
            this.label9.TabIndex = 2;
            this.label9.Text = "Saat";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(3, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 96);
            this.label10.TabIndex = 3;
            this.label10.Text = "Şeker Ölçüm Değeri";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxVakit
            // 
            this.comboBoxVakit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxVakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxVakit.FormattingEnabled = true;
            this.comboBoxVakit.Location = new System.Drawing.Point(251, 120);
            this.comboBoxVakit.Name = "comboBoxVakit";
            this.comboBoxVakit.Size = new System.Drawing.Size(348, 45);
            this.comboBoxVakit.TabIndex = 2;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(251, 31);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(348, 32);
            this.dateTimePickerDate.TabIndex = 1;
            // 
            // dateTimePickerHour
            // 
            this.dateTimePickerHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerHour.CustomFormat = "HH:mm";
            this.dateTimePickerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerHour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHour.Location = new System.Drawing.Point(251, 221);
            this.dateTimePickerHour.MaxDate = new System.DateTime(2025, 5, 30, 0, 0, 0, 0);
            this.dateTimePickerHour.Name = "dateTimePickerHour";
            this.dateTimePickerHour.ShowUpDown = true;
            this.dateTimePickerHour.Size = new System.Drawing.Size(348, 32);
            this.dateTimePickerHour.TabIndex = 3;
            this.dateTimePickerHour.Value = new System.DateTime(2025, 5, 23, 0, 0, 0, 0);
            // 
            // numericUpDownBloodSugar
            // 
            this.numericUpDownBloodSugar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownBloodSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownBloodSugar.Location = new System.Drawing.Point(251, 311);
            this.numericUpDownBloodSugar.Name = "numericUpDownBloodSugar";
            this.numericUpDownBloodSugar.Size = new System.Drawing.Size(348, 44);
            this.numericUpDownBloodSugar.TabIndex = 4;
            this.numericUpDownBloodSugar.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // dataGridViewMeasures
            // 
            this.dataGridViewMeasures.AllowUserToAddRows = false;
            this.dataGridViewMeasures.AllowUserToDeleteRows = false;
            this.dataGridViewMeasures.AllowUserToOrderColumns = true;
            this.dataGridViewMeasures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMeasures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMeasures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeasures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDate2,
            this.ColumnVakit,
            this.ColumnTime2,
            this.ColumnValue});
            this.dataGridViewMeasures.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMeasures.Name = "dataGridViewMeasures";
            this.dataGridViewMeasures.RowHeadersWidth = 20;
            this.dataGridViewMeasures.RowTemplate.Height = 28;
            this.dataGridViewMeasures.Size = new System.Drawing.Size(602, 536);
            this.dataGridViewMeasures.TabIndex = 0;
            // 
            // ColumnDate2
            // 
            this.ColumnDate2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDate2.HeaderText = "Tarih";
            this.ColumnDate2.MinimumWidth = 8;
            this.ColumnDate2.Name = "ColumnDate2";
            // 
            // ColumnVakit
            // 
            this.ColumnVakit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnVakit.HeaderText = "Vakit";
            this.ColumnVakit.MinimumWidth = 8;
            this.ColumnVakit.Name = "ColumnVakit";
            // 
            // ColumnTime2
            // 
            this.ColumnTime2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTime2.HeaderText = "Saat";
            this.ColumnTime2.MinimumWidth = 8;
            this.ColumnTime2.Name = "ColumnTime2";
            // 
            // ColumnValue
            // 
            this.ColumnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnValue.HeaderText = "Şeker Değeri";
            this.ColumnValue.MinimumWidth = 8;
            this.ColumnValue.Name = "ColumnValue";
            // 
            // PatientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 596);
            this.Controls.Add(this.tabControl);
            this.Name = "PatientScreen";
            this.Text = "Diyabet Kontrol Sistemi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientScreen_FormClosing);
            this.Load += new System.EventHandler(this.PatientScreen_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageAdvises.ResumeLayout(false);
            this.tabPageAdvises.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdvises)).EndInit();
            this.tabPageBloodSugarData.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBloodSugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeasures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TabPage tabPageAdvises;
        private System.Windows.Forms.TabPage tabPageBloodSugarData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonGoMeasures;
        private System.Windows.Forms.Button buttonGoAdvises;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonChangeİmage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRewind;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewAdvises;
        private System.Windows.Forms.Button buttonCompleteExercise;
        private System.Windows.Forms.Button buttonCompleteDiet;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxVakit;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerHour;
        private System.Windows.Forms.NumericUpDown numericUpDownBloodSugar;
        private System.Windows.Forms.DataGridView dataGridViewMeasures;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVakit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExercise;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDietStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExerciseStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelAdvises;
    }
}