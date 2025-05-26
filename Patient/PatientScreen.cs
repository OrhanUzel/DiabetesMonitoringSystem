using ProLab3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProLab3
{
    internal partial class PatientScreen : Form
    {
        PatientInfo patient;
        BindingList<BloodSugarMeasure> bloodSugarMeasureList ;
        string connectionString = "Server=ORHANUZEL\\SQLEXPRESS;Database=DiabetesMonitoringSystem;Trusted_Connection=True;";

        public PatientScreen()
        {
            InitializeComponent();
        }
        public PatientScreen(PatientInfo patient)
        {
            this.patient = patient;
            InitializeComponent();
        }

        public PatientScreen(PatientInfo patient, BindingList<BloodSugarMeasure> bloodSugarMeasureList) 
        {
            
            this.bloodSugarMeasureList = bloodSugarMeasureList; 

            this.patient = patient;
            //dataGridViewMeasures.DataSource = bloodSugarMeasureList;
            InitializeComponent();

        }

        private void tabPageAdvises_Click(object sender, EventArgs e)
        {

        }

        private void tabPageBloodSugarData_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            textBoxName.ReadOnly = false;
            textBoxSurname.ReadOnly = false;
            textBoxEmail.ReadOnly = false;
            textBoxPhone.ReadOnly = false;
            dateTimePickerBirthDate.Enabled= true;
            buttonChangeİmage.Visible = true;
            buttonSave.Visible = true;
            buttonRewind.Visible = true;
            buttonUpdate.Visible = false;

        }
        //sekem değiştirme işlemleri
        private void SwitchToTabByName(string tabPageName)
        {
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (tabPage.Name == tabPageName)
                {
                    tabControl.SelectedTab = tabPage;
                    break;
                }
            }
        }
        private void buttonGoAdvises_Click(object sender, EventArgs e)
        {
            SwitchToTabByName("tabPageAdvises");
        }

        private void tabPage_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void buttonGoMeasures_Click(object sender, EventArgs e)
        {
            SwitchToTabByName("tabPageBloodSugarData");
        }
        private string GetDietExerciseInfo()
        {
            return "Diyet Türleri: Az Şekerli (şeker alımını azaltır), Şekersiz (şeker tamamen yasaklı), Dengeli (tüm besin grupları)\n" +
                   "Egzersiz Türleri: Yürüyüş (30 dk), Bisiklet (45 dk), Klinik Egzersiz (doktor kontrolünde)";
        }

        private void PatientScreen_Load(object sender, EventArgs e)
        {
            dataGridViewMeasures.AutoGenerateColumns = false;
            dataGridViewMeasures.RowPostPaint += dataGridViewMeasures_RowPostPaint;
            // GetPatientMeasures(patient.id);
            // BloodSugarMeasure bloodSugarMeasure=new BloodSugarMeasure()
            dataGridViewMeasures.DataSource = bloodSugarMeasureList;
            set_profile_image(patient);
      
            labelAdvises.Text = GetDietExerciseInfo();
            dateTimePickerBirthDate.Value = patient.birth_date;//İşe yarıyor
            textBoxName.Text = patient.name;
            textBoxSurname.Text = patient.surname;
            if (patient.gender == true)
            {
                textBoxGender.Text = "Erkek";

            }
            else
            {
                textBoxGender.Text = "Kadın";
            }
            //dateTimePickerBirthDate.Text = "21.11.2001";//işe yarıyor
            textBoxPhone.Text = patient.phone_number;
            textBoxEmail.Text = patient.email;
            
        }

        private void PatientScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //üst methoda da asenkron luk verilmeliymiş //fotoğrafla alaakalı güncelleme yapılmalı
        private async void buttonSave_Click(object sender, EventArgs e)
        {
            List<byte> profileImageList = null;

            if (pictureBoxProfileImage.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxProfileImage.Image.Save(ms, pictureBoxProfileImage.Image.RawFormat);
                    profileImageList = new List<byte>(ms.ToArray()); // byte[]'i List<byte>'e çevirme
                }
            }
            string name=textBoxName.Text.ToString().Trim();
            string surname=textBoxSurname.Text.ToString().Trim();
            string email=textBoxEmail.Text.ToString().Trim();
            string phone_number=textBoxPhone.Text.ToString().Trim();
            DateTime birth_date =dateTimePickerBirthDate.Value;//düz Value
           
            bool isEditingSuccess = await UpdatePatientAsync(patient.id,name, surname, email, phone_number,birth_date ,profileImageList);

            if (isEditingSuccess)
            {
                MessageBox.Show("Bilgileriniz başarıyla güncellendi!");
                
            }
            else
            {
                MessageBox.Show("Düzenleme İşlemi başarısız!");

            }
            textBoxName.ReadOnly = true;
            textBoxSurname.ReadOnly = true;
            textBoxEmail.ReadOnly = true;
            textBoxPhone.ReadOnly = true;
            dateTimePickerBirthDate.Enabled = false;
            buttonChangeİmage.Visible = false;
            buttonSave.Visible = false;
            buttonRewind.Visible = false;
            buttonUpdate.Visible = true;
        }
        public async Task<bool> UpdatePatientAsync(int id, string name, string surname,string email,string phone_number,DateTime birth_date,List<byte> profile_image)
        {
            
            string query = "UPDATE tbl_patients SET  name = @name, surname = @surname, email=@email, phone_number=@phone_number, birth_date=@birth_date, profile_image=@profile_image WHERE id = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id); // id parametresini ekle
                        cmd.Parameters.AddWithValue("@name", name ?? string.Empty); // Null kontrolü
                        cmd.Parameters.AddWithValue("@surname", surname ?? string.Empty);
                        cmd.Parameters.AddWithValue("@email", email ?? string.Empty);
                        cmd.Parameters.AddWithValue("@phone_number", phone_number ?? string.Empty);
                        cmd.Parameters.AddWithValue("@birth_date", birth_date);
                        // Yeni (Daha Güvenli):
                        if (profile_image != null && profile_image.Count > 0)
                        {
                            cmd.Parameters.Add("@profile_image", SqlDbType.VarBinary, -1).Value = profile_image.ToArray(); // -1 MAX boyutu temsil eder
                        }
                        else
                        {
                            cmd.Parameters.Add("@profile_image", SqlDbType.VarBinary, -1).Value = DBNull.Value;
                        }

                        await conn.OpenAsync();
                        int affectedRows = await cmd.ExecuteNonQueryAsync();

                        return affectedRows > 0;
                    }
                }
            }
            catch(SqlException sqlEx)
            {
                // SQL hatalarını detaylı şekilde yakala
                Console.WriteLine($"SQL Error Number: {sqlEx.Number}");
                Console.WriteLine($"Error Message: {sqlEx.Message}");
                Console.WriteLine($"SQL State: {sqlEx.State}");
                Console.WriteLine($"Error Procedure: {sqlEx.Procedure}");
                Console.WriteLine($"Line Number: {sqlEx.LineNumber}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme hatası: {ex.Message}");
                return false;
            }
        }

       

        private void buttonChangeİmage_Click(object sender, EventArgs e)
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
                        System.Drawing.Image selectedImage = System.Drawing.Image.FromFile(openFileDialog.FileName);
                        pictureBoxProfileImage.Image = selectedImage;

                        // Resmi byte dizisine dönüştür
                        using (MemoryStream ms = new MemoryStream())
                        {
                            selectedImage.Save(ms, selectedImage.RawFormat);
                            patient.profile_image = ms.ToArray();
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

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxVakit.SelectedItem != null)
            {
                string period = comboBoxVakit.SelectedItem.ToString();
                // 1.dateTimePickerDate kontrolünden sadece tarih bileşenini alın.
                // Value özelliği DateTimePicker'dan seçilen tam DateTime nesnesini verir.
                //Date özelliği ise bu DateTime nesnesinin sadece tarih kısmını (saat 00:00:00 olarak) alır.
                DateTime selectedDate = dateTimePickerDate.Value.Date;
                TimeSpan selectedTime = dateTimePickerHour.Value.TimeOfDay;

                // 3. Tarih ve zaman bileşenlerini birleştirerek tek bir DateTime nesnesi oluşturun.
                DateTime date_time = selectedDate.Add(selectedTime);
                int patient_id=patient.id;
                int doctor_id = patient.doctor_id;
                int blood_sugar= (int)numericUpDownBloodSugar.Value;
                // Onay mesajını göster
                DialogResult result = MessageBox.Show(
                "Kan şekeri verinizi kaydetmek istediğinizden emin misiniz?", // Mesaj
                "Kaydetme Onayı",                                          // Başlık
                MessageBoxButtons.YesNo,                                     // Butonlar (Evet ve Hayır)
                MessageBoxIcon.Warning);                                     // İkon (Uyarı ikonu)

                // Kullanıcının seçimine göre işlem yap
                if (result == DialogResult.Yes)
                {
                    if (await InsertIntoPatientMeasuresAsync(date_time, patient_id, doctor_id, period, blood_sugar) ==true)
                    {
                        bloodSugarMeasureList.Add(new BloodSugarMeasure(patient_id,date_time, period, blood_sugar));

                        // Kullanıcı "Evet" dedi, silme işlemini burada gerçekleştir
                        MessageBox.Show("Başarıyla kaydedildi.");
                    }
                    
                }
                else
                {
                    // Kullanıcı "Hayır" dedi veya kapat düğmesine bastı, işlemi iptal et
                    MessageBox.Show("Kayıt iptal edildi.");
                }
            }

        }
        public  bool GetPatientMeasures(int patient_id)
        {

            string connectionString = "Server=ORHANUZEL\\SQLEXPRESS;Database=DiabetesMonitoringSystem;Trusted_Connection=True;";
            string query = "SELECT (id,date_time,period,blood_sugar) FROM tbl_patient_measures WHERE patient_id = @patient_id ORDER BY date_time DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);


                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(reader.GetOrdinal("id"));
                                DateTime dateTime = reader.GetDateTime(reader.GetOrdinal("date_time"));
                                string period_sql = reader.GetString(reader.GetOrdinal("period"));
                                int bloodSugar = reader.GetInt16(reader.GetOrdinal("blood_sugar")); // smallint int16'ya karşılık gelir

                                bloodSugarMeasureList.Add(new BloodSugarMeasure(id, dateTime, period_sql, bloodSugar));

                            }
                        }
                    }
                }
                return true;
            }

            catch (SqlException sqlEx)
            {
                // SQL hatalarını detaylı şekilde yakala
                Console.WriteLine($"SQL Error Number: {sqlEx.Number}");
                Console.WriteLine($"Error Message: {sqlEx.Message}");
                Console.WriteLine($"SQL State: {sqlEx.State}");
                Console.WriteLine($"Error Procedure: {sqlEx.Procedure}");
                Console.WriteLine($"Line Number: {sqlEx.LineNumber}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme hatası: {ex.Message}");
                return false;
            }

    }
                
               
            
            
        


        //güzelce çalışıyor
        public async Task<bool> InsertIntoPatientMeasuresAsync(DateTime date_time,int patient_id,int doctor_id,string period,int blood_sugar)
        {

            string connectionString = "Server=ORHANUZEL\\SQLEXPRESS;Database=DiabetesMonitoringSystem;Trusted_Connection=True;";
            string query = "INSERT INTO tbl_patient_measures (date_time,patient_id,doctor_id,period,blood_sugar)  VALUES (@date_time,@patient_id,@doctor_id,@period,@blood_sugar)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@date_time", date_time); // id parametresini ekle
                        cmd.Parameters.AddWithValue("@patient_id",patient_id ); // Null kontrolü
                        cmd.Parameters.AddWithValue("@doctor_id",doctor_id);
                        cmd.Parameters.AddWithValue("@period", period ?? string.Empty);
                        cmd.Parameters.AddWithValue("@blood_sugar", blood_sugar);
                        //cmd.Parameters.AddWithValue("@birth_date", birth_date);
                        // Yeni (Daha Güvenli):
                        await conn.OpenAsync();
                        int affectedRows = await cmd.ExecuteNonQueryAsync();

                        return affectedRows > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // SQL hatalarını detaylı şekilde yakala
                Console.WriteLine($"SQL Error Number: {sqlEx.Number}");
                Console.WriteLine($"Error Message: {sqlEx.Message}");
                Console.WriteLine($"SQL State: {sqlEx.State}");
                Console.WriteLine($"Error Procedure: {sqlEx.Procedure}");
                Console.WriteLine($"Line Number: {sqlEx.LineNumber}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme hatası: {ex.Message}");
                return false;
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMeasures.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir ölçüm seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen ilk satırı al
            DataGridViewRow selectedRow = dataGridViewMeasures.SelectedRows[0];

            // DataGridView'in veri kaynağındaki BloodSugarMeasure nesnesine eriş (Gizli ID'yi buradan alacağız)
            BloodSugarMeasure selectedMeasurement = selectedRow.DataBoundItem as BloodSugarMeasure;

            if (selectedMeasurement == null)
            {
                MessageBox.Show("Seçilen ölçüm verisi alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Onay mesajı
            DialogResult confirmResult = MessageBox.Show(
                $"Tarih: {selectedMeasurement.date_time.ToShortDateString()}, Vakit: {selectedMeasurement.period}, Değer: {selectedMeasurement.blood_sugar} olan ölçümü silmek istediğinizden emin misiniz?",
                "Ölçüm Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Veritabanından sil
                    bool isDeleted = DeleteMeasurementFromDatabase(selectedMeasurement.id);

                    if (isDeleted)
                    {
                        // BindingList'ten sil (DataGridView otomatik güncellenir)
                        bloodSugarMeasureList.Remove(selectedMeasurement);
                        MessageBox.Show("Ölçüm başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ölçüm silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ölçüm silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool DeleteMeasurementFromDatabase(int measurementId)
        {
            string query = "DELETE FROM tbl_patient_measures WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", measurementId);

                    connection.Open();
                    int affectedRows = command.ExecuteNonQuery();
                    return affectedRows > 0; // Bir satır silindiyse true döner
                }
            }
        }
        private void set_profile_image(PatientInfo currentPatient)
        {
            if (patient.profile_image != null && patient.profile_image.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(patient.profile_image))
                {
                    try
                    {
                        // MemoryStream'den bir Image nesnesi oluştur
                        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                        // Image nesnesini PictureBox'a ata
                        pictureBoxProfileImage.Image = img;

                        // Resmin PictureBox'a nasıl sığacağını belirle
                        pictureBoxProfileImage.SizeMode = PictureBoxSizeMode.AutoSize; // veya StretchImage, Normal, CenterImage
                    }
                    catch (ArgumentException ex)
                    {
                        // Eğer byte dizisi geçerli bir resim formatında değilse bu hata oluşabilir
                        MessageBox.Show("Resim yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pictureBoxProfileImage.Image = null; // Hatalı resimde PictureBox'ı temizle
                    }
                }
            }
            else
            {
                // Varsayılan profil resmi
                if (currentPatient.gender == true)
                {
                    pictureBoxProfileImage.Image = Properties.Resources.profile_image_male_128; // Default bir resim ekleyin
                }
                else
                {
                    pictureBoxProfileImage.Image = Properties.Resources.profile_image_female_128; // Default bir resim ekleyin

                }

            }
        }

        private void dataGridViewMeasures_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Satır numarasını çizmek için metin
            string rowNumber = (e.RowIndex + 1).ToString();

            // Metni ortalamak için dikdörtgen alan: sadece RowHeader kısmını çizer
            var headerBounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                dataGridViewMeasures.RowHeadersWidth,
                e.RowBounds.Height);

            // Metni çiz
            using (var brush = new SolidBrush(dataGridViewMeasures.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(
                    rowNumber,
                    dataGridViewMeasures.Font,
                    brush,
                    headerBounds,
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }
    }
}
