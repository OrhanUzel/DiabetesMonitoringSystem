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
using System.Windows.Forms;

namespace ProLab3
{
    internal partial class PatientDetailInDoctorScreen : Form
    {
        PatientInfo patient;

        private PatientInfo currentPatient = new PatientInfo(); // Initialize if default constructor is used
        private List<string> selectedDiets;
        private List<string> selectedExercises;
        BindingList<BloodSugarMeasure> bloodSugarMeasureList = new BindingList<BloodSugarMeasure>();
        BindingList<BloodSugarMeasure> bloodSugarMeasureListFirstFive = new BindingList<BloodSugarMeasure>();

        //tanımlanmış olmalı ki bir şeyler ekleyebilesin
        private string connection_string = "Server=ORHANUZEL\\SQLEXPRESS;Database=DiabetesMonitoringSystem;Trusted_Connection=True;";
        public PatientDetailInDoctorScreen()
        {
            InitializeComponent();
            this.selectedDiets = new List<string>();
            this.selectedExercises = new List<string>();
            SetupForm(); // This might fail if currentPatient is not properly initialized
            LoadRecommendations();
        }
        public PatientDetailInDoctorScreen(PatientInfo patient)
        {
            this.patient = patient;
            InitializeComponent();
            this.selectedDiets = new List<string>();
            this.selectedExercises = new List<string>();
            SetupForm(); // This might fail if currentPatient is not properly initialized
            LoadRecommendations();
        }

        private void PatientDetailInDoctorScreen_Load(object sender, EventArgs e)
        {
            // labelAdvises.Text = GetDietExerciseInfo();
            dataGridViewPatientAllMeasures.AutoGenerateColumns = false;
            dataGridViewPatientAllMeasures.RowPostPaint += dataGridViewPatientAllMeasures_RowPostPaint;
            
            dataGridViewLastFiveMeasure.AutoGenerateColumns = false;
            dataGridViewLastFiveMeasure.RowPostPaint += dataGridViewPatientAllMeasures_RowPostPaint;
            
            bloodSugarMeasureList =justGetPatientMeasures(patient.id);
            dataGridViewPatientAllMeasures.DataSource = bloodSugarMeasureList;

            foreach (var measure in bloodSugarMeasureList.Take(5)) // İlk 5 elemanı alır
            {
                bloodSugarMeasureListFirstFive.Add(measure);
            }
            dataGridViewLastFiveMeasure.DataSource= bloodSugarMeasureListFirstFive;
            
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
            // pictureBoxProfileImage = new PictureBox();
            pictureBoxProfileImage.SizeMode = PictureBoxSizeMode.Zoom;

            if (patient.profile_image != null && patient.profile_image.Count() > 0)
            {
                using (MemoryStream ms = new MemoryStream(patient.profile_image.ToArray()))
                {
                    pictureBoxProfileImage.Image = Image.FromStream(ms);
                }
            }
            else
            {
                // Varsayılan profil resmi
                if (patient.gender == true)
                {
                    pictureBoxProfileImage.Image = Properties.Resources.profile_image_male_128; // Default bir resim ekleyin
                }
                else
                {
                    pictureBoxProfileImage.Image = Properties.Resources.profile_image_female_128; // Default bir resim ekleyin

                }

            }



        }

        private BindingList<BloodSugarMeasure> justGetPatientMeasures(int patient_id)
        {
            //BloodSugarMeasure bloodSugarMeasure;
            //conn.Open();
            //bloodSugarMeasureList.Clear();
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();


                try
                {
                    string query = "SELECT id, date_time, period, blood_sugar FROM tbl_patient_measures WHERE patient_id=@patient_id ORDER BY date_time DESC";
                    SqlCommand cmd = new SqlCommand(query,conn);
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
                    Console.WriteLine($"Error Number: {ex.Source}");
                    Console.WriteLine($"SQL State: {ex.StackTrace}");
                    Console.WriteLine($"Error Procedure: {ex.HelpLink}");
                    Console.WriteLine($"Line Number: {ex.Data}");

                }
            }


 
            return bloodSugarMeasureList;
        }


        private void tabPageAdvises_Click(object sender, EventArgs e)
        {

        }

        private void tabPageBloodSugarData_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            textBoxName.Enabled = true;
            textBoxSurname.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxPhone.Enabled = true;
            dateTimePickerBirthDate.Enabled = true;
           

        }
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


        private void DoctorScreen2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        /////////////// Doktor önerileri ile alakalı ekran 
        // Diyet türleri ve açıklamaları
        private Dictionary<string, string> dietTypes = new Dictionary<string, string>
        {
            ["Az Şekerli Diyet"] = "Şekerli gıdalar sınırlanır, kompleks karbonhidratlara öncelik verilir. Lifli gıdalar ve düşük glisemik indeksli besinler tercih edilir.",
            ["Şekersiz Diyet"] = "Rafine şeker ve şeker katkılı tüm ürünler tamamen dışlanır. Hiperglisemi riski taşıyan bireylerde önerilir.",
            ["Dengeli Beslenme"] = "Diyabetli bireylerin yaşam tarzına uygun, dengeli ve sürdürülebilir bir diyet yaklaşımıdır. Tüm besin gruplarından yeterli miktarda alınır; porsiyon kontrolü, mevsimsel taze ürünler ve su tüketimi temel unsurlardır."
        };

        // Egzersiz türleri ve açıklamaları
        private Dictionary<string, string> exerciseTypes = new Dictionary<string, string>
        {
            ["Yürüyüş"] = "Hafif tempolu, günlük yapılabilecek bir egzersizdir. Kardiyovasküler sağlığı destekler ve kan şekerini düzenlemeye yardımcı olur.",
            ["Bisiklet"] = "Alt vücut kaslarını çalıştırır ve dış mekanda veya sabit bisikletle uygulanabilir. Düşük etkili bir kardiyo egzersizidir.",
            ["Klinik Egzersiz"] = "Doktor tarafından verilen belirli hareketleri içeren planlı egzersizlerdir. Stresi azaltılması ve hareket kabiliyetinin artırılması amaçlanır."
        };
        private void SetupForm()
        {
            // Hasta bilgisini göster
            if (patient != null && patient.name != null) // Basic null check
            {
                lblPatientInfo.Text = $"Hasta: {patient.name} {patient.surname} | Kan Şekeri: {currentPatient.blood_sugar} mg/dL";
            }
            else
            {
                lblPatientInfo.Text = "Hasta bilgisi bulunmuyor.";
            }


            // Diyet türlerini listele
            lstAvailableDiets.Items.Clear(); // Clear existing items before adding
            foreach (string diet in dietTypes.Keys)
            {
                lstAvailableDiets.Items.Add(diet);
            }

            // Egzersiz türlerini listele
            lstAvailableExercises.Items.Clear(); // Clear existing items
            foreach (string exercise in exerciseTypes.Keys)
            {
                lstAvailableExercises.Items.Add(exercise);
            }
        }
        private void LstAvailableDiets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAvailableDiets.SelectedItem != null)
            {
                string selectedDiet = lstAvailableDiets.SelectedItem.ToString();
                if (dietTypes.ContainsKey(selectedDiet))
                {
                    rtbDietDetails.Text = dietTypes[selectedDiet];
                }
            }
            else
            {
                rtbDietDetails.Clear();
            }
        }

        private void LstAvailableExercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAvailableExercises.SelectedItem != null)
            {
                string selectedExercise = lstAvailableExercises.SelectedItem.ToString();
                if (exerciseTypes.ContainsKey(selectedExercise))
                {
                    rtbExerciseDetails.Text = exerciseTypes[selectedExercise];
                }
            }
            else
            {
                rtbExerciseDetails.Clear();
            }
        }

        private void BtnAddDiet_Click(object sender, EventArgs e)
        {
            if (lstAvailableDiets.SelectedItem != null)
            {
                string selectedDiet = lstAvailableDiets.SelectedItem.ToString();
                if (!selectedDiets.Contains(selectedDiet))
                {
                    selectedDiets.Add(selectedDiet);
                    lstSelectedDiets.Items.Add(selectedDiet);
                }
                else
                {
                    MessageBox.Show("Bu diyet zaten eklenmiş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen eklemek istediğiniz diyeti seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRemoveDiet_Click(object sender, EventArgs e)
        {
            if (lstSelectedDiets.SelectedItem != null)
            {
                string selectedDiet = lstSelectedDiets.SelectedItem.ToString();
                selectedDiets.Remove(selectedDiet);
                lstSelectedDiets.Items.Remove(selectedDiet);
            }
            else
            {
                MessageBox.Show("Lütfen çıkarmak istediğiniz diyeti seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAddExercise_Click(object sender, EventArgs e)
        {
            if (lstAvailableExercises.SelectedItem != null)
            {
                string selectedExercise = lstAvailableExercises.SelectedItem.ToString();
                if (!selectedExercises.Contains(selectedExercise))
                {
                    selectedExercises.Add(selectedExercise);
                    lstSelectedExercises.Items.Add(selectedExercise);
                }
                else
                {
                    MessageBox.Show("Bu egzersiz zaten eklenmiş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen eklemek istediğiniz egzersizi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRemoveExercise_Click(object sender, EventArgs e)
        {
            if (lstSelectedExercises.SelectedItem != null)
            {
                string selectedExercise = lstSelectedExercises.SelectedItem.ToString();
                selectedExercises.Remove(selectedExercise);
                lstSelectedExercises.Items.Remove(selectedExercise);
            }
            else
            {
                MessageBox.Show("Lütfen çıkarmak istediğiniz egzersizi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSaveRecommendations_Click(object sender, EventArgs e)
        {
            if (selectedDiets.Count == 0 && selectedExercises.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir diyet veya egzersiz önerisi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Önerileri PatientInfo'ya kaydetme işlemi (varsayımsal PatientInfo yapısı)
            /*
            if (currentPatient != null)
            {
                 currentPatient.diet_recommendations = new List<string>(selectedDiets); // Assuming PatientInfo has these properties
                 currentPatient.exercise_recommendations = new List<string>(selectedExercises);
            }
            */

            string message = "Seçilen öneriler:\n\n";

            if (selectedDiets.Count > 0)
            {
                message += "Diyetler:\n";
                foreach (string diet in selectedDiets)
                {
                    message += $"• {diet}\n";
                }
                message += "\n";
            }

            if (selectedExercises.Count > 0)
            {
                message += "Egzersizler:\n";
                foreach (string exercise in selectedExercises)
                {
                    message += $"• {exercise}\n";
                }
            }

            message += "\nÖneriler başarıyla kaydedildi!";

            MessageBox.Show(message, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void LoadRecommendations()
        {
            // Mevcut önerileri yükle (eğer varsa)
            // Bu kısım PatientInfo sınıfına diet_recommendations ve exercise_recommendations listesi eklendikten sonra kullanılabilir
            // Example:
            // if (currentPatient != null && currentPatient.diet_recommendations != null)
            // {
            //     selectedDiets.AddRange(currentPatient.diet_recommendations);
            //     foreach(var diet in selectedDiets) lstSelectedDiets.Items.Add(diet);
            // }
            // if (currentPatient != null && currentPatient.exercise_recommendations != null)
            // {
            //     selectedExercises.AddRange(currentPatient.exercise_recommendations);
            //     foreach(var exercise in selectedExercises) lstSelectedExercises.Items.Add(exercise);
            // }
        }

        // Public property'ler seçilen önerilere erişim için
        public List<string> SelectedDiets => new List<string>(selectedDiets); // Returns a copy
        public List<string> SelectedExercises => new List<string>(selectedExercises); // Returns a copy

        private void dataGridViewPatientAllMeasures_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Satır numarasını çizmek için metin
            string rowNumber = (e.RowIndex + 1).ToString();

            // Metni ortalamak için dikdörtgen alan: sadece RowHeader kısmını çizer
            var headerBounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                dataGridViewPatientAllMeasures.RowHeadersWidth,
                e.RowBounds.Height);

            // Metni çiz
            using (var brush = new SolidBrush(dataGridViewPatientAllMeasures.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(
                    rowNumber,
                    dataGridViewPatientAllMeasures.Font,
                    brush,
                    headerBounds,
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }

        private void dataGridViewLastFiveMeasure_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Satır numarasını çizmek için metin
            string rowNumber = (e.RowIndex + 1).ToString();

            // Metni ortalamak için dikdörtgen alan: sadece RowHeader kısmını çizer
            var headerBounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                dataGridViewLastFiveMeasure.RowHeadersWidth,
                e.RowBounds.Height);

            // Metni çiz
            using (var brush = new SolidBrush(dataGridViewLastFiveMeasure.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(
                    rowNumber,
                    dataGridViewLastFiveMeasure.Font,
                    brush,
                    headerBounds,
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }

        private void lblSelectedExercises_Click(object sender, EventArgs e)
        {

        }

        private void rtbDietDetails_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
