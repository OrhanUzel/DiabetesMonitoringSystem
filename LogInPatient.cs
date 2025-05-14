using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab3
{
    public partial class LogInPatient : Form
    {
        public LogInPatient()
        {
        }
        private void LogInDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();  // Tüm uygulamayı kapatır
        }
        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamlar ve silme tuşu (Backspace) kabul edilir
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Girişi iptal eder
                toolTipDigitWarn.Show("Sadece rakam girebilirsiniz.", textBoxPassword, 0, -40, 2000); // 2 saniye görünür


            }
            //if (textBoxUserName.Text.Length == 11)
            //{
            //    e.Handled = false;
            //}
        }




        public LogInPatient(StartScreen startScreen)
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // this.Close();//önce kapatırsam aşağıdaki işlemleri yapamam 
            StartScreen startScreen = new StartScreen();
            startScreen.Show(this);
            this.Hide();//close düzgün çalışmadı
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Bisque; // Hafif renk değişimi
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent; // Eski haline geri döndür
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string tc_no = textBoxUserName.Text.Trim();//boşluk vs almamak için trim işlemi 
            string tc_no_hash= Encryption.encryptWithSHA512(tc_no); //veri tabanındaki tc hashiyle aynı hashddeki veri bulunacak mı
            string password = textBoxPassword.Text;

            using (SqlConnection conn = new SqlConnection("Server=ORHANUZEL\\SQLEXPRESS;Database=DiabetesMonitoringSystem;Trusted_Connection=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT password_hash, salt FROM tbl_patients WHERE tc_no_hash = @Username", conn);
                cmd.Parameters.AddWithValue("@Username", tc_no_hash);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string storedHash = reader["password_hash"].ToString();//get password_hash
                    string salt = reader["salt"].ToString();//get salt from database //kaçıncı kolonda olduğunu yazacağız 

                    string inputHash = Encryption.encryptWithSHA512(password + salt);

                    if (storedHash == inputHash)
                    {
                        MessageBox.Show("Giriş başarılı!");
                        PatientScreen patientScreen = new PatientScreen();
                        patientScreen.Show(this);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Şifre yanlış.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.");
                }

                reader.Close();
            }

        }


    }
}
