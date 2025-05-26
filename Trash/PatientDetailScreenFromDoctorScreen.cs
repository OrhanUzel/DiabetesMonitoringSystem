using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab3
{
    

    internal partial class PatientDetailScreenFromDoctorScreen : Form
    {
        ChooseSymptoms chooseSymptoms;
        List<string> pSymptomName=new List<string>();
        private PatientInfo currentPatient;
        private bool isEditMode = false;

        // Form bileşenleri
        private PictureBox pbProfileImage;
        private TextBox txtName, txtSurname, txtEmail, txtPhone;
        private NumericUpDown nudBloodSugar;
        private DateTimePicker dtpBirthDate;
        private ComboBox cmbGender;
        private ListBox lstSymptoms;
        private Button btnEdit, btnSave, btnDelete, btnBack, btnChangeImage,btnSymptomEdit;
        private Label lblId;

        public PatientDetailScreenFromDoctorScreen(PatientInfo patient)
        {
            InitializeComponent();
            InitializeMyComponent();
            this.currentPatient = patient;
            this.Text = "Hasta Detayları";
            this.Size = new Size(600, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            InitializeControls();
            LoadPatientData();
            SetEditMode(false);
        }

        private void InitializeMyComponent()
        {
            // Form bileşenlerini oluşturun
            this.SuspendLayout();

            // Profil resmi
            pbProfileImage = new PictureBox();
            pbProfileImage.Size = new Size(150, 150);
            pbProfileImage.Location = new Point(225, 20);
            pbProfileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfileImage.BorderStyle = BorderStyle.FixedSingle;
            pbProfileImage.BackColor = Color.WhiteSmoke;
            this.Controls.Add(pbProfileImage);

            // Resim değiştirme butonu
            btnChangeImage = new Button();
            btnChangeImage.Text = "Resmi Değiştir";
            btnChangeImage.Size = new Size(150, 30);
            btnChangeImage.Location = new Point(225, 175);
            btnChangeImage.BackColor = Color.LightBlue;
            btnChangeImage.Click += BtnChangeImage_Click;
            this.Controls.Add(btnChangeImage);

            // Hasta ID
            Label lblIdTitle = new Label();
            lblIdTitle.Text = "Hasta ID:";
            lblIdTitle.Location = new Point(50, 230);
            lblIdTitle.AutoSize = true;
            lblIdTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Controls.Add(lblIdTitle);

            lblId = new Label();
            lblId.Location = new Point(200, 230);
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F);
            this.Controls.Add(lblId);

            // Ad
            Label lblName = new Label();
            lblName.Text = "Ad:";
            lblName.Location = new Point(50, 260);
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Controls.Add(lblName);

            txtName = new TextBox();
            txtName.Location = new Point(200, 260);
            txtName.Size = new Size(300, 25);
            this.Controls.Add(txtName);

            // Soyad
            Label lblSurname = new Label();
            lblSurname.Text = "Soyad:";
            lblSurname.Location = new Point(50, 290);
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Controls.Add(lblSurname);

            txtSurname = new TextBox();
            txtSurname.Location = new Point(200, 290);
            txtSurname.Size = new Size(300, 25);
            this.Controls.Add(txtSurname);

            // Cinsiyet
            Label lblGender = new Label();
            lblGender.Text = "Cinsiyet:";
            lblGender.Location = new Point(50, 320);
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Controls.Add(lblGender);

            cmbGender = new ComboBox();
            cmbGender.Location = new Point(200, 320);
            cmbGender.Size = new Size(300, 25);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Items.AddRange(new object[] { "Erkek", "Kadın" });
            this.Controls.Add(cmbGender);

            // Doğum Tarihi
            Label lblBirthDate = new Label();
            lblBirthDate.Text = "Doğum Tarihi:";
            lblBirthDate.Location = new Point(50, 350);
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Controls.Add(lblBirthDate);

            dtpBirthDate = new DateTimePicker();
            dtpBirthDate.Location = new Point(200, 350);
            dtpBirthDate.Size = new Size(300, 25);
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            this.Controls.Add(dtpBirthDate);

            // E-posta
            Label lblEmail = new Label();
            lblEmail.Text = "E-posta:";
            lblEmail.Location = new Point(50, 380);
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Controls.Add(lblEmail);

            txtEmail = new TextBox();
            txtEmail.Location = new Point(200, 380);
            txtEmail.Size = new Size(300, 25);
            this.Controls.Add(txtEmail);

            // Kan Şekeri
            Label lblBloodSugar = new Label();
            lblBloodSugar.Text = "Kan Şekeri:";
            lblBloodSugar.Location = new Point(50, 410);
            lblBloodSugar.AutoSize = true;
            lblBloodSugar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Controls.Add(lblBloodSugar);

            nudBloodSugar = new NumericUpDown();
            nudBloodSugar.Location = new Point(200, 410);
            nudBloodSugar.Size = new Size(300, 25);
            nudBloodSugar.Minimum = 0;
            nudBloodSugar.Maximum = 500;
            this.Controls.Add(nudBloodSugar);

            // Telefon
            Label lblPhone = new Label();
            lblPhone.Text = "Telefon:";
            lblPhone.Location = new Point(50, 440);
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Controls.Add(lblPhone);

            txtPhone = new TextBox();
            txtPhone.Location = new Point(200, 440);
            txtPhone.Size = new Size(300, 25);
            this.Controls.Add(txtPhone);

            // Semptomlar
            Label lblSymptoms = new Label();
            lblSymptoms.Text = "Semptomlar:";
            lblSymptoms.Location = new Point(50, 470);
            lblSymptoms.AutoSize = true;
            lblSymptoms.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Controls.Add(lblSymptoms);

            lstSymptoms = new ListBox();
            lstSymptoms.Location = new Point(200, 470);
            lstSymptoms.Size = new Size(300, 100);
            this.Controls.Add(lstSymptoms);

            // Buttons
            btnEdit = new Button();
            btnEdit.Text = "Düzenle";
            btnEdit.Location = new Point(120, 600);
            btnEdit.Size = new Size(100, 40);
            btnEdit.BackColor = Color.LightBlue;
            btnEdit.Click += BtnEdit_Click;
            this.Controls.Add(btnEdit);

            btnSave = new Button();
            btnSave.Text = "Kaydet";
            btnSave.Location = new Point(230, 600);
            btnSave.Size = new Size(100, 40);
            btnSave.BackColor = Color.LightGreen;
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);

            btnDelete = new Button();
            btnDelete.Text = "Sil";
            btnDelete.Location = new Point(340, 600);
            btnDelete.Size = new Size(100, 40);
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Click += BtnDelete_Click;
            this.Controls.Add(btnDelete);

            btnBack = new Button();
            btnBack.Text = "Geri";
            btnBack.Location = new Point(50, 20);
            btnBack.Size = new Size(80, 30);
            btnBack.BackColor = Color.LightGray;
            btnBack.Click += BtnBack_Click;
            this.Controls.Add(btnBack);

            btnSymptomEdit=new Button();
            btnSymptomEdit.Text = "Belirtileri Düzenle";
            btnSymptomEdit.Location = new Point(230,600);
            btnSymptomEdit.Size = new Size(100, 40);
            btnSymptomEdit.BackColor = Color.DarkRed;
            btnSymptomEdit.Click += btnSymptomEdit_Click;
            this.Controls.Add(btnSymptomEdit);


            this.ResumeLayout(false);
        }

        private void btnSymptomEdit_Click(object sender, EventArgs e)
        {
             chooseSymptoms = new ChooseSymptoms(pSymptomName);
             chooseSymptoms.Show();
             //this.Hide();
        }

        private void InitializeControls()
        {
            // Kontrolleri hazırla
        }

        private void LoadPatientData()
        {
            // Hasta bilgilerini kontrollere yükle
            lblId.Text = currentPatient.id.ToString();
            txtName.Text = currentPatient.name;
            txtSurname.Text = currentPatient.surname;
            cmbGender.SelectedIndex = currentPatient.gender ? 0 : 1; // True = Erkek, False = Kadın varsayıyorum
            dtpBirthDate.Value = currentPatient.birth_date;
            txtEmail.Text = currentPatient.email;
            nudBloodSugar.Value = currentPatient.blood_sugar;
            txtPhone.Text = currentPatient.phone_number;

            // Profil resmi
            if (currentPatient.profile_image != null && currentPatient.profile_image.Count() > 0)
            {
                using (MemoryStream ms = new MemoryStream(currentPatient.profile_image.ToArray()))
                {
                    pbProfileImage.Image = Image.FromStream(ms);
                }
            }
            else
            {
                // Varsayılan profil resmi
                if (currentPatient.gender == true) {
                    pbProfileImage.Image = Properties.Resources.profile_image_male_128; // Default bir resim ekleyin
                }
                else
                {
                    pbProfileImage.Image = Properties.Resources.profile_image_female_128; // Default bir resim ekleyin

                }

            }

            // Semptomları listele
            lstSymptoms.Items.Clear();
            foreach(string s in PatientInfo.dictSymptoms.Keys)
            {
                foreach (string symptom in currentPatient.symptoms)
                {
                    if (s == symptom.Trim())//Trim is important process
                    {
                        pSymptomName.Add(PatientInfo.dictSymptoms[s]);
                        lstSymptoms.Items.Add(PatientInfo.dictSymptoms[s]);
                    }

                    // lstSymptoms.Items.Add(symptom);
                }
            }

            
        }

        private void SetEditMode(bool editMode)
        {
            // Düzenleme modunu ayarla
            isEditMode = editMode;

            txtName.ReadOnly = !editMode;
            txtSurname.ReadOnly = !editMode;
            cmbGender.Enabled = editMode;
            dtpBirthDate.Enabled = editMode;
            txtEmail.ReadOnly = !editMode;
            nudBloodSugar.ReadOnly = !editMode;
            txtPhone.ReadOnly = !editMode;
            lstSymptoms.Enabled = editMode;
            btnChangeImage.Visible = editMode;

            btnSave.Visible = editMode;
            btnEdit.Visible = !editMode;

            btnSymptomEdit.Visible= editMode;
            btnSymptomEdit.Visible = !editMode;
        }

        private void SavePatientData()
        {
            // Hasta bilgilerini güncelle
            currentPatient.name = txtName.Text;
            currentPatient.surname = txtSurname.Text;
            currentPatient.gender = cmbGender.SelectedIndex == 0; // 0 = Erkek, 1 = Kadın
            currentPatient.birth_date = dtpBirthDate.Value;
            currentPatient.email = txtEmail.Text;
            currentPatient.blood_sugar = (int)nudBloodSugar.Value;
            currentPatient.phone_number = txtPhone.Text;

            // Semptomlar listesini güncelle (Bu kısımda kullanıcı arayüzünde semptom ekle/kaldır özelliği eklemeniz gerekebilir)
            // Şu an için sadece var olan semptomları alıyoruz
            currentPatient.symptoms.Clear();
            foreach (string symptom in lstSymptoms.Items)
            {
                currentPatient.symptoms.Add(symptom);
            }

            // Veri tabanında güncelleme işlemi burada yapılmalı
            // UpdatePatientInDatabase(currentPatient);

            MessageBox.Show("Hasta bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeletePatient()
        {
            DialogResult result = MessageBox.Show("Bu hastayı silmek istediğinize emin misiniz?", "Hasta Silme",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Veri tabanından silme işlemi burada yapılmalı
                // DeletePatientFromDatabase(currentPatient.id);

                MessageBox.Show("Hasta başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // Event handlers
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            SetEditMode(true);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SavePatientData();
            SetEditMode(false);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeletePatient();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnChangeImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Profil Resmi Seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Resmi yükle
                        Image selectedImage = Image.FromFile(openFileDialog.FileName);
                        pbProfileImage.Image = selectedImage;

                        // Resmi byte dizisine dönüştür
                        using (MemoryStream ms = new MemoryStream())
                        {
                            selectedImage.Save(ms, selectedImage.RawFormat);
                            currentPatient.profile_image = ms.ToArray();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim yüklenirken hata oluştu: " + ex.Message, "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}