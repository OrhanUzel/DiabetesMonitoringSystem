// ProLab3.yeni.cs

using System;
using System.Collections.Generic;
using System.Drawing; // Keep for Color, Font, etc. if used outside InitializeComponent
using System.Linq;
using System.Windows.Forms;

namespace ProLab3
{
    internal partial class yeni : Form // 'partial' is key
    {
        private PatientInfo currentPatient = new PatientInfo(); // Initialize if default constructor is used
        private List<string> selectedDiets;
        private List<string> selectedExercises;

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

        public yeni(PatientInfo patient)
        {
            this.currentPatient = patient;
            this.selectedDiets = new List<string>();
            this.selectedExercises = new List<string>();
            InitializeComponent(); // This now calls the method in the .designer.cs file
            SetupForm();
            LoadRecommendations();
        }

        // It's good practice to ensure currentPatient is not null if this constructor is used.
        // Or, disable/hide UI elements that depend on currentPatient if it's null.
        public yeni()
        {
            // Consider initializing currentPatient with default values or handling its null state
            // this.currentPatient = new PatientInfo(); // Example
            this.selectedDiets = new List<string>();
            this.selectedExercises = new List<string>();
            InitializeComponent(); // This now calls the method in the .designer.cs file
            SetupForm(); // This might fail if currentPatient is not properly initialized
            LoadRecommendations();
        }

        private void SetupForm()
        {
            // Hasta bilgisini göster
            if (currentPatient != null && currentPatient.name != null) // Basic null check
            {
                lblPatientInfo.Text = $"Hasta: {currentPatient.name} {currentPatient.surname} | Kan Şekeri: {currentPatient.blood_sugar} mg/dL";
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

        // Public property'ler seçilen önerilere erişim için
        public List<string> SelectedDiets => new List<string>(selectedDiets); // Returns a copy
        public List<string> SelectedExercises => new List<string>(selectedExercises); // Returns a copy
    }

    // Dummy PatientInfo class for context (ensure you have your actual PatientInfo class)
    // public class PatientInfo
    // {
    // public string name { get; set; }
    // public string surname { get; set; }
    // public string blood_sugar { get; set; } // Or appropriate type
    // public List<string> diet_recommendations { get; set; }
    // public List<string> exercise_recommendations { get; set; }
    //
    //     public PatientInfo()
    //     {
    //         diet_recommendations = new List<string>();
    //         exercise_recommendations = new List<string>();
    //     }
    // }
}