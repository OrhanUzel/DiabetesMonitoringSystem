using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProLab3
{
    public partial class AddPatientScreen : Form
    {
        DoctorScreen dc_screen;
        ChooseSymptoms chooseSymptoms2 = new ChooseSymptoms();
        public AddPatientScreen()
        {
            InitializeComponent();
        }
        public AddPatientScreen(DoctorScreen dc_screen)
        {
            this.dc_screen = dc_screen;
            InitializeComponent();
        }

        private void AddPatientScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            dc_screen.Show();
            //chooseSymptoms2.Close();
            //Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void AddPatientScreen_Load(object sender, EventArgs e)
        {
            PatientInfo.PatientSymptoms.Clear();
            textBoxBloodSugar.ForeColor = Color.Gray;

        }

        private void textBoxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamlar ve silme tuşu (Backspace) kabul edilir
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Girişi iptal eder
                toolTipDigitWarn.Show("Sadece rakam girebilirsiniz.", textBoxTC, 0, 0, 1000); // 2 saniye görünür


            }

        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
           
            //MessageBox.Show("telefon numarası:" + maskedTextBoxPhone.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string name = textBoxName.Text.Trim();
            string surname=textBoxSurName.Text.Trim();
            //string birth_date=maskedTextBoxBirthDate.Text.Trim();
            DateTime birth_date = dateTimePickerBirthDay.Value.Date;
            bool gender;
            if (radioButtonMan.Checked == true)
            {
                gender = true;
            }
            else 
            {
                gender=false;
            }

            string email = textBoxEmail.Text.Trim();
            string tc_no=textBoxTC.Text.Trim();//hashlenecek 
            string phone_number=maskedTextBoxPhoneNumber.Text.Trim();
            string password = textBoxPassword.Text;
            string password_repetition = textBoxPasswordRepetition.Text;
            string str_blood_sugar = textBoxBloodSugar.Text.Trim();
            int blood_sugar=0;//default sıfır değeri atan mıyormuymuş ???
            if (!string.IsNullOrWhiteSpace(str_blood_sugar)) // boş ya da sadece boşluk değilse
            {
                if (!int.TryParse(str_blood_sugar, out blood_sugar))
                {
                    MessageBox.Show("Kan şekeri değeri geçerli bir sayı olmalıdır.");
                    return; // işlem iptal
                }
            }

            string tc_no_hash = Encryption.encryptWithSHA512(tc_no);
            string salt = Encryption.createRandomSalt();
            string password_hash = Encryption.encryptWithSHA512(password+salt);

            if (radioButtonMan.Checked == false && radioButtonWomen.Checked == false)
            {
                MessageBox.Show("Lütfen cinsiyet seçimin yapınız!");
            }
            else if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(phone_number) || string.IsNullOrWhiteSpace(str_blood_sugar) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(password_repetition) || string.IsNullOrWhiteSpace(tc_no))
            {
                MessageBox.Show("Lütfen tüm kutucukları doldurunuz.");
            }
            else if (password != password_repetition)
            {
                MessageBox.Show("Lütfen şifre tekrarını doğru şekilde giriniz");
            }
            else {
               string connectionString = "Server=ORHANUZEL\\SQLEXPRESS;Database=DiabetesMonitoringSystem;Trusted_Connection=True;"; // Güncelle
               bool result= sqlProcessForSignUpWithTransaction(connectionString, name, surname, gender, birth_date, tc_no_hash, email, phone_number, blood_sugar, password_hash, salt);
                if (result == true)
                {
                    MessageBox.Show("Kayıt Başarılı!");
                    sendPass(email, password);
                }
                else
                {
                    MessageBox.Show("Başarısız Kayıt!");
                }

            }









        }           //Transaction Ya hep Ya hiç

        private bool sqlProcessForSignUpWithTransaction(string connectionString, string name, string surname, bool gender, DateTime birth_date, string tc_no_hash, string email, string phone_number, int blood_sugar, string password_hash, string salt)
        {
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Transaction başlatma
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // İlk tabloya ekleme yapma
                    using (SqlCommand addPatientInfoCmd = new SqlCommand(
                        "INSERT INTO tbl_patients (name, surname, gender, birth_date, tc_no_hash, email, phone_number, blood_sugar, password_hash, salt) VALUES (@name, @surname, @gender, @birth_date, @tc_no_hash, @email, @phone_number, @blood_sugar, @password_hash, @salt); SELECT SCOPE_IDENTITY()",
                        connection, transaction))
                    {
                        addPatientInfoCmd.Parameters.AddWithValue("@name", name);
                        addPatientInfoCmd.Parameters.AddWithValue("@surname", surname);
                        addPatientInfoCmd.Parameters.AddWithValue("@gender", gender);
                        addPatientInfoCmd.Parameters.AddWithValue("@birth_date", birth_date);
                        addPatientInfoCmd.Parameters.AddWithValue("@tc_no_hash", tc_no_hash);
                        addPatientInfoCmd.Parameters.AddWithValue("@email", email);
                        addPatientInfoCmd.Parameters.AddWithValue("@phone_number", phone_number);
                        addPatientInfoCmd.Parameters.AddWithValue("@blood_sugar", blood_sugar);
                        addPatientInfoCmd.Parameters.AddWithValue("@password_hash", password_hash);
                        addPatientInfoCmd.Parameters.AddWithValue("@salt", salt);

                        // Yeni eklenen hastanın ID'sini alma
                        int patientId = Convert.ToInt32(addPatientInfoCmd.ExecuteScalar());
                        List<int> symptom_id_list = new List<int>();
                        
                        // SQL sorgusunu oluştur
                        StringBuilder queryBuilder = new StringBuilder();
                        queryBuilder.Append("SELECT id FROM tbl_symptoms WHERE symptom_name IN (");

                        // Parametre listesi oluştur
                        for (int i = 0; i < PatientInfo.PatientSymptoms.Count; i++)
                        {
                            string paramName = $"@p{i}";
                            queryBuilder.Append(i > 0 ? ", " : "").Append(paramName);
                        }
                        queryBuilder.Append(")");

                        using (SqlCommand commandForSymptomId = new SqlCommand(queryBuilder.ToString(), connection,transaction))
                        {
                            // Parametreleri ekle
                            for (int i = 0; i < PatientInfo.PatientSymptoms.Count; i++)
                            {
                                //var paramValue = PatientInfo.PatientSymptoms[i];
                                commandForSymptomId.Parameters.Add(new SqlParameter($"@p{i}", SqlDbType.NVarChar) { Value = PatientInfo.PatientSymptoms[i] });
                            }
                            // commandForSymptomId.ExecuteNonQuery();
                            // Sorguyu çalıştır ve sonuçları oku
                            using (SqlDataReader reader = commandForSymptomId.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // GetInt32() yerine daha güvenli bir dönüşüm yöntemi kullanın
                                    if (!reader.IsDBNull(0))
                                    {
                                        // tinyint için GetByte() kullanmak daha uygun olabilir
                                        byte idAsByte = reader.GetByte(0);
                                        int id = (int)idAsByte; // Sonra int'e dönüştürün
                                        symptom_id_list.Add(id);
                                    }
                                }
                            }
                        }
                        //elimizde symptomnların id bilgileri var o id bilgilerine göre
                        //hastamızın idsini kullanarak belirtileri
                        //belirti tablomuza ekleyeceğizz
                        addSymptomsToPatient(patientId, symptom_id_list, connection, transaction);

                        // Tüm işlemler başarılıysa commit et
                        transaction.Commit();
                        Console.WriteLine("Tüm tablolardaki işlemler başarıyla tamamlandı.");
                        return true;
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

                    // Hatayı yeniden fırlat veya işle
                    //throw;
                    return false;
                }
                catch (Exception ex)
                {
                    // Hata durumunda rollback yap
                    transaction.Rollback();
                   // Console.WriteLine($"Hata oluştu, işlemler geri alındı: {ex.Message}");
                    // Genel hataları yakala
                    Console.WriteLine($"Error Type: {ex.GetType().Name}");
                    Console.WriteLine($"Error Message: {ex.Message}");
                    Console.WriteLine($"Stack Trace: {ex.StackTrace}");

                    return false;

                }
            }
        }
        // Belirtileri hastaya ekleyen method
        public void addSymptomsToPatient(int patientId, List<int> symptomIdList,SqlConnection connection,SqlTransaction transaction)
        {
                foreach (var symptomId in symptomIdList)
                {
                    using (SqlCommand command = new SqlCommand("INSERT INTO tbl_patient_symptoms (patient_id, symptom_id) VALUES (@p_id, @p_symptom)"
                        , connection, transaction))
                    {
                        command.Parameters.AddWithValue("@p_id", patientId);
                        command.Parameters.AddWithValue("@p_symptom", symptomId);
                        

                        command.ExecuteNonQuery();
                    }
                }
        }



        private bool sqlProcessForSignUp(string connectionString,string name,string surname,bool gender,DateTime birth_date,string tc_no_hash,string email, string phone_number,int blood_sugar,string password_hash,string salt)//profil resmi opsiyonel
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();//sql bağlantısına sahibiz şu anda 
                string query_for_get_symptom_names = "SELECT id FROM tbl_symptoms WHERE symptom_name = ";
                string query_for_symptoms_save = "INSERT INTO tbl_patient_symptoms (patient_id, symptom_id) VALUES () ";
                string query = "INSERT INTO tbl_patients (name, surname, gender, birth_date, tc_no_hash, email, phone_number, blood_sugar, password_hash, salt) VALUES (@name, @surname, @gender, @birth_date, @tc_no_hash, @email, @phone_number, @blood_sugar, @password_hash, @salt)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@birth_date", birth_date);
                    cmd.Parameters.AddWithValue("@tc_no_hash", tc_no_hash);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone_number", phone_number);
                    cmd.Parameters.AddWithValue("@blood_sugar", blood_sugar);
                    cmd.Parameters.AddWithValue("@password_hash", password_hash);
                    cmd.Parameters.AddWithValue("@salt", salt);
                    
                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt başarılı!");
                        return true;                 
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız.");
                        return false;
                    }
                }
            }
        }
        public void sendPass(string userEmail, string userPassword)
        {
            try
            {

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; // Doğru SMTP sunucusu
                smtp.Port = 465; // Doğru port (Gmail için 587 veya 465)

                string senderPassword = Environment.GetEnvironmentVariable("MAIL_PASSWORD");

                smtp.Credentials = new NetworkCredential("diyabettakibisistemi@gmail.com", senderPassword);
                smtp.EnableSsl = true;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("diyabettakibisistemi@gmail.com"); // Gönderici mail adresi
                mail.To.Add(userEmail); // Alıcının mail adresi
                mail.Subject = "Şifreniz";
                mail.Body = $"Merhaba,\n\nKaydınız başarıyla gerçekleşti. Şifreniz: {userPassword}\n\nLütfen kimseyle paylaşmayınız.";


                smtp.Send(mail);

                MessageBox.Show("Şifre başarıyla e-posta adresine gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderme hatası: " + ex.Message);
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(textBoxEmail.Text)&& textBoxEmail.Text.Length!=0)
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi girin.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
            }
        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(textBoxEmail.Text))
            {
                errorProvider1.SetError(textBoxEmail, "Geçersiz e-posta adresi");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBoxEmail, "");
            }
        }

        private void textBoxBloodSugar_Enter(object sender, EventArgs e)
        {
            textBoxBloodSugar.ForeColor = Color.Black;
            if (textBoxBloodSugar.Text == "(mg/dL cinsinden)")
            {
                textBoxBloodSugar.Text = "";
                
            }
        }

        private void textBoxBloodSugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamlar ve silme tuşu (Backspace) kabul edilir
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Girişi iptal eder
                toolTipDigitWarn.Show("Lütfen şeker ölçümünü mg/dL cinsinden sayı olarak giriniz!", textBoxBloodSugar, 0, 0, 1000); // 2 saniye görünür


            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void buttonChooseSymptoms_Click(object sender, EventArgs e)
        {
            
            chooseSymptoms2.ShowDialog();
            if (PatientInfo.PatientSymptoms.Count > 0)
            {
                buttonChooseSymptoms.Text = "Belirti seçimi tamamlandı!";
                buttonChooseSymptoms.BackColor = Color.Green;
            }
            else
            {
                buttonChooseSymptoms.Text = "Belirti seçilmedi!";
                buttonChooseSymptoms.BackColor = Color.Red;
            }
        }
        private Size originalSize;
        private Point originalLocation;
        private void buttonChooseSymptoms_MouseEnter(object sender, EventArgs e)
        {


            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            originalSize = btn.Size;
            originalLocation = btn.Location;

            // Hafif büyütme
            btn.Size = new Size(btn.Width + 6, btn.Height + 6);
            btn.Location = new Point(btn.Location.X - 3, btn.Location.Y - 3);
        }

        private void buttonChooseSymptoms_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            btn.Size = originalSize;
            btn.Location = originalLocation;
        }
    }
}
