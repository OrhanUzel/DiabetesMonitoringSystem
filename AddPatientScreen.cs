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
        public AddPatientScreen()
        {
            InitializeComponent();
        }

        private void AddPatientScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            int blood_sugar = Int32.Parse(str_blood_sugar);
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
               bool result= sqlProcessForSignUp(connectionString, name, surname, gender, birth_date, tc_no_hash, email, phone_number, blood_sugar, password_hash, salt);
                if(result == true)
                {
                    sendPass(email, password);
                }

            }









        }
        private bool sqlProcessForSignUp(string connectionString,string name,string surname,bool gender,DateTime birth_date,string tc_no_hash,string email, string phone_number,int blood_sugar,string password_hash,string salt)//profil resmi opsiyonel
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
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
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("diyabettakibisistemi@gmail.com"); // Gönderici mail adresi
                mail.To.Add(userEmail); // Alıcının mail adresi
                mail.Subject = "Şifreniz";
                mail.Body = $"Merhaba,\n\nKaydınız başarıyla gerçekleşti. Şifreniz: {userPassword}\n\nLütfen kimseyle paylaşmayınız.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // Gmail SMTP

                string senderPassword = Environment.GetEnvironmentVariable("MAIL_PASSWORD");

                smtp.Credentials = new NetworkCredential("diyabettakibisistemi@gmail.com", senderPassword);
                smtp.EnableSsl = true;

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

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseSymptoms chooseSymptoms=new ChooseSymptoms();
            chooseSymptoms.ShowDialog();

        }
    }
}
