using ProLab3.Model;
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
        PatientInfo patient;
        BindingList<BloodSugarMeasure> bloodSugarMeasureList=new BindingList<BloodSugarMeasure>();

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
                SqlCommand cmd = new SqlCommand("SELECT id,doctor_id,name,surname,gender,birth_date,email,phone_number,profile_image,password_hash,salt FROM tbl_patients WHERE tc_no_hash = @Username", conn);
                cmd.Parameters.AddWithValue("@Username", tc_no_hash);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string storedHash = reader["password_hash"].ToString();//get password_hash
                    string salt = reader["salt"].ToString();//get salt from database //kaçıncı kolonda olduğunu yazacağız 

                    string inputHash = Encryption.encryptWithSHA512(password + salt);

                    if (storedHash == inputHash)
                    {
                        int id =Convert.ToInt32(reader["id"]);
                        int doctor_id = Convert.ToInt32(reader["doctor_id"]);
                        string name=reader["name"].ToString().Trim();
                        string surname = reader["surname"].ToString().Trim();
                        bool gender = (bool)reader["gender"];
                        DateTime birth_date = Convert.ToDateTime(reader["birth_date"]);
                        string email=reader["email"].ToString().Trim();
                        string phone_number = reader["phone_number"].ToString().Trim();
                        byte[] profile_image = (byte[])reader["profile_image"] ?? null;
                        //riskli

                        PatientInfo patient = new PatientInfo(id,doctor_id,name,surname,gender,birth_date,email,phone_number,profile_image);

                        MessageBox.Show("Giriş başarılı!");
                        PatientScreen patientScreen = new PatientScreen(patient);
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
        private void buttonLogInTikla(object sender, EventArgs e)
        {
            string tc_no = textBoxUserName.Text.Trim();//boşluk vs almamak için trim işlemi 
            string tc_no_hash = Encryption.encryptWithSHA512(tc_no); //veri tabanındaki tc hashiyle aynı hashddeki veri bulunacak mı
            string password = textBoxPassword.Text;
            using (SqlConnection conn = new SqlConnection("Server=ORHANUZEL\\SQLEXPRESS;Database=DiabetesMonitoringSystem;Trusted_Connection=True;"))
            {
                conn.Open();
                logInTransaction(conn,tc_no_hash,password);
            }
        }
        private void logInTransaction(SqlConnection connection,string tc_no_hash,string password)
        {
            int patient_id;

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        patient_id=justLogIn(connection, transaction, tc_no_hash, password);
                        bloodSugarMeasureList= justGetPatientMeasures(connection, transaction,patient_id);
                        // Perform transactional operations here
                        transaction.Commit();
                        
                        MessageBox.Show("Giriş başarılı!");
                        this.Hide();
                        PatientScreen patientScreen = new PatientScreen(patient,bloodSugarMeasureList);
                        patientScreen.Show();
                        
                    }
                    catch (SqlException ex)//rollback yapılırken sadece sql ile akalı catchlerde yapılmasında özen gösterilmeili 
                    {

                    if (transaction != null && connection.State == ConnectionState.Open)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception rollbackEx)
                        {
                            MessageBox.Show("İşlem geri alınırken bir hata oluştu: " + rollbackEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    MessageBox.Show("Giriş işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                    finally
                    {
                      //  connection.Close();
                    }
                }
                
            }
        

        private BindingList<BloodSugarMeasure> justGetPatientMeasures (SqlConnection connection, SqlTransaction transaction, int patient_id)
        {
            //BloodSugarMeasure bloodSugarMeasure;
            //conn.Open();
            try
            {
                string query = "SELECT id, date_time, period, blood_sugar FROM tbl_patient_measures WHERE patient_id=@patient_id ORDER BY date_time DESC";
                SqlCommand cmd = new SqlCommand(query, connection, transaction);
                cmd.Parameters.AddWithValue("@patient_id", patient_id);
                //cmd.Parameters.AddWithValue("@Username", tc_no_hash);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        i++;
                        int id = reader.GetInt32(reader.GetOrdinal("id"));
                        DateTime dateTime = reader.GetDateTime(reader.GetOrdinal("date_time"));
                        string period_sql = reader.GetString(reader.GetOrdinal("period"));
                        int bloodSugar = reader.GetInt16(reader.GetOrdinal("blood_sugar")); // smallint int16'ya karşılık gelir

                        bloodSugarMeasureList.Add(new BloodSugarMeasure(id, dateTime, period_sql, bloodSugar));

                    }
                    
                    reader.Close();
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme hatası: {ex.Message}");
                
            }

           
            return bloodSugarMeasureList;
        }

        private int justLogIn(SqlConnection conn, SqlTransaction transaction,string tc_no_hash,string password)
        {
            
            int id=0;
            //conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT id,doctor_id,name,surname,gender,birth_date,email,phone_number,profile_image,password_hash,salt FROM tbl_patients WHERE tc_no_hash = @Username", conn, transaction);
                cmd.Parameters.AddWithValue("@Username", tc_no_hash);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        string storedHash = reader["password_hash"].ToString();//get password_hash
                        string salt = reader["salt"].ToString();//get salt from database //kaçıncı kolonda olduğunu yazacağız 

                        string inputHash = Encryption.encryptWithSHA512(password + salt);

                        if (storedHash == inputHash)
                        {
                            id = Convert.ToInt32(reader["id"]);
                            int doctor_id = Convert.ToInt32(reader["doctor_id"]);
                            string name = reader["name"].ToString().Trim();
                            string surname = reader["surname"].ToString().Trim();
                            bool gender = (bool)reader["gender"];
                            DateTime birth_date = Convert.ToDateTime(reader["birth_date"]);
                            string email = reader["email"].ToString().Trim();
                            string phone_number = reader["phone_number"].ToString().Trim();
                            byte[] profile_image;
                            if (reader["profile_image"] != DBNull.Value)
                            {
                                // Eğer NULL değilse, byte[]'e dönüştür
                                profile_image = (byte[])reader["profile_image"];
                                // Bu profileImageBytes'ı şimdi kullanabilirsiniz.
                            }
                            else
                            {
                                // Eğer NULL ise, değişkeni null olarak ayarla
                                profile_image = null;
                                // Veya varsayılan bir boş resim byte dizisi atayabilirsiniz.
                            }

                            //riskli
                            //PatientInfo olarak burda tanımlıydı önceden sonra üste almak zorunda kalıdm
                            patient = new PatientInfo(id, doctor_id, name, surname, gender, birth_date, email, phone_number, profile_image);


                        }
                        else
                        {
                            MessageBox.Show("Şifre yanlış.");
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı.");
                    }
                    reader.Close();
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
                throw;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Type: {ex.GetType().Name}");
                Console.WriteLine($"Error Message: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                
            }
           

            return id;
            
        }


    }
}
