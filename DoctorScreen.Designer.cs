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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Eğer bir öğeye tıklanınca büyütülmüş şekilde görüntülenmesini istiyorsanız, Messa" +
        "geBox ile bunu yapabilirsiniz:");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Az Şekerli Diyet: Şekerli gıdalar sınırlanır, kompleks karbonhidratlara öncelik",
            "naber müfür"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Şekersiz Diyet: Rafine şeker ve şeker katkılı tüm ürünler tamamen dışlanır.");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Dengeli Beslenme: Diyabetli bireylerin yaşam tarzına uygun, dengeli ve");
            this.listView1 = new System.Windows.Forms.ListView();
            this.listViewPatientsInfos = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSurName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSymptom8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(557, 1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(282, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate_1);
            // 
            // listViewPatientsInfos
            // 
            this.listViewPatientsInfos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPatientsInfos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewPatientsInfos.CheckBoxes = true;
            this.listViewPatientsInfos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderSurName,
            this.columnHeaderGender,
            this.columnHeaderAge,
            this.columnHeaderNumber,
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
            this.listViewPatientsInfos.Location = new System.Drawing.Point(3, 103);
            this.listViewPatientsInfos.Name = "listViewPatientsInfos";
            this.listViewPatientsInfos.Size = new System.Drawing.Size(1006, 200);
            this.listViewPatientsInfos.TabIndex = 1;
            this.listViewPatientsInfos.UseCompatibleStateImageBehavior = false;
            this.listViewPatientsInfos.View = System.Windows.Forms.View.Details;
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
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "Telefon";
            this.columnHeaderNumber.Width = 70;
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
            this.columnHeaderSymptom6.Width = 87;
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
            // listView3
            // 
            this.listView3.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView3.HideSelection = false;
            listViewItem2.ToolTipText = "Az Şekerli Diyet";
            this.listView3.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView3.Location = new System.Drawing.Point(4, 71);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(282, 109);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 277;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(116, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Diyet Türleri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Az Şekerli Diyet: Şekerli gıdalar sınırlanır, kompleks karbonhidratlara öncelik",
            "Şekersiz Diyet: Rafine şeker ve şeker katkılı tüm ürünler tamamen dışlanır."});
            this.listBox1.Location = new System.Drawing.Point(292, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 84);
            this.listBox1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listViewPatientsInfos);
            this.panel1.Location = new System.Drawing.Point(4, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 306);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(189, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(8, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yeni Hasta Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProLab3.Properties.Resources.profile_user;
            this.pictureBox1.Location = new System.Drawing.Point(4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DoctorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView1);
            this.Name = "DoctorScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorScreen_FormClosing);
            this.Load += new System.EventHandler(this.DoctorScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listViewPatientsInfos;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListBox listBox1;
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
    }
}