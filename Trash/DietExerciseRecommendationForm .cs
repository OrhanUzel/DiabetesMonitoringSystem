using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProLab3
{
    internal partial class DietExerciseRecommendationForm : Form
    {
        private PatientInfo currentPatient=new PatientInfo();
        private List<string> selectedDiets;
        private List<string> selectedExercises;

        // Form bileşenleri
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblPatientInfo;

        private GroupBox gbDiets;
        private GroupBox gbExercises;
        private GroupBox gbSelectedRecommendations;

        private ListBox lstAvailableDiets;
        private ListBox lstAvailableExercises;
        private ListBox lstSelectedDiets;
        private ListBox lstSelectedExercises;

        private Button btnAddDiet;
        private Button btnRemoveDiet;
        private Button btnAddExercise;
        private Button btnRemoveExercise;
        private Button btnSaveRecommendations;
        private Button btnCancel;

        private RichTextBox rtbDietDetails;
        private RichTextBox rtbExerciseDetails;

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

        public DietExerciseRecommendationForm(PatientInfo patient)
        {
            this.currentPatient = patient;
            this.selectedDiets = new List<string>();
            this.selectedExercises = new List<string>();
            InitializeComponent();
            InitializedComponent();
            SetupForm();
            LoadRecommendations();
        }
        public DietExerciseRecommendationForm()
        {
            //this.currentPatient = patient;
            this.selectedDiets = new List<string>();
            this.selectedExercises = new List<string>();
            InitializeComponent();
            InitializedComponent();
            SetupForm();
            LoadRecommendations();
        }

        private void InitializedComponent()
        {
            this.SuspendLayout();

            // Form ayarları
            this.Text = "Diyet ve Egzersiz Önerileri";
            this.Size = new Size(1000, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(240, 248, 255);

            // Header Panel
            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;
            pnlHeader.BackColor = Color.FromArgb(70, 130, 180);
            this.Controls.Add(pnlHeader);

            // Title Label
            lblTitle = new Label();
            lblTitle.Text = "Hasta Diyet ve Egzersiz Önerileri";
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 15);
            pnlHeader.Controls.Add(lblTitle);

            // Patient Info Label
            lblPatientInfo = new Label();
            lblPatientInfo.Font = new Font("Segoe UI", 10F);
            lblPatientInfo.ForeColor = Color.White;
            lblPatientInfo.AutoSize = true;
            lblPatientInfo.Location = new Point(20, 45);
            pnlHeader.Controls.Add(lblPatientInfo);

            // Diyet GroupBox
            gbDiets = new GroupBox();
            gbDiets.Text = "Diyet Türleri";
            gbDiets.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbDiets.ForeColor = Color.FromArgb(70, 130, 180);
            gbDiets.Location = new Point(20, 100);
            gbDiets.Size = new Size(450, 280);
            gbDiets.BackColor = Color.White;
            this.Controls.Add(gbDiets);

            // Available Diets ListBox
            lstAvailableDiets = new ListBox();
            lstAvailableDiets.Location = new Point(15, 30);
            lstAvailableDiets.Size = new Size(200, 120);
            lstAvailableDiets.Font = new Font("Segoe UI", 9F);
            lstAvailableDiets.SelectedIndexChanged += LstAvailableDiets_SelectedIndexChanged;
            gbDiets.Controls.Add(lstAvailableDiets);

            // Diet Details RichTextBox
            rtbDietDetails = new RichTextBox();
            rtbDietDetails.Location = new Point(15, 160);
            rtbDietDetails.Size = new Size(420, 80);
            rtbDietDetails.Font = new Font("Segoe UI", 9F);
            rtbDietDetails.ReadOnly = true;
            rtbDietDetails.BackColor = Color.FromArgb(245, 245, 245);
            gbDiets.Controls.Add(rtbDietDetails);

            // Add Diet Button
            btnAddDiet = new Button();
            btnAddDiet.Text = "Diyet Ekle →";
            btnAddDiet.Location = new Point(230, 50);
            btnAddDiet.Size = new Size(100, 35);
            btnAddDiet.BackColor = Color.FromArgb(60, 179, 113);
            btnAddDiet.ForeColor = Color.White;
            btnAddDiet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddDiet.FlatStyle = FlatStyle.Flat;
            btnAddDiet.Click += BtnAddDiet_Click;
            gbDiets.Controls.Add(btnAddDiet);

            // Remove Diet Button
            btnRemoveDiet = new Button();
            btnRemoveDiet.Text = "← Diyet Çıkar";
            btnRemoveDiet.Location = new Point(230, 95);
            btnRemoveDiet.Size = new Size(100, 35);
            btnRemoveDiet.BackColor = Color.FromArgb(220, 20, 60);
            btnRemoveDiet.ForeColor = Color.White;
            btnRemoveDiet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoveDiet.FlatStyle = FlatStyle.Flat;
            btnRemoveDiet.Click += BtnRemoveDiet_Click;
            gbDiets.Controls.Add(btnRemoveDiet);

            // Egzersiz GroupBox
            gbExercises = new GroupBox();
            gbExercises.Text = "Egzersiz Türleri";
            gbExercises.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbExercises.ForeColor = Color.FromArgb(70, 130, 180);
            gbExercises.Location = new Point(490, 100);
            gbExercises.Size = new Size(450, 280);
            gbExercises.BackColor = Color.White;
            this.Controls.Add(gbExercises);

            // Available Exercises ListBox
            lstAvailableExercises = new ListBox();
            lstAvailableExercises.Location = new Point(15, 30);
            lstAvailableExercises.Size = new Size(200, 120);
            lstAvailableExercises.Font = new Font("Segoe UI", 9F);
            lstAvailableExercises.SelectedIndexChanged += LstAvailableExercises_SelectedIndexChanged;
            gbExercises.Controls.Add(lstAvailableExercises);

            // Exercise Details RichTextBox
            rtbExerciseDetails = new RichTextBox();
            rtbExerciseDetails.Location = new Point(15, 160);
            rtbExerciseDetails.Size = new Size(420, 80);
            rtbExerciseDetails.Font = new Font("Segoe UI", 9F);
            rtbExerciseDetails.ReadOnly = true;
            rtbExerciseDetails.BackColor = Color.FromArgb(245, 245, 245);
            gbExercises.Controls.Add(rtbExerciseDetails);

            // Add Exercise Button
            btnAddExercise = new Button();
            btnAddExercise.Text = "Egzersiz Ekle →";
            btnAddExercise.Location = new Point(230, 50);
            btnAddExercise.Size = new Size(100, 35);
            btnAddExercise.BackColor = Color.FromArgb(60, 179, 113);
            btnAddExercise.ForeColor = Color.White;
            btnAddExercise.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddExercise.FlatStyle = FlatStyle.Flat;
            btnAddExercise.Click += BtnAddExercise_Click;
            gbExercises.Controls.Add(btnAddExercise);

            // Remove Exercise Button
            btnRemoveExercise = new Button();
            btnRemoveExercise.Text = "← Egzersiz Çıkar";
            btnRemoveExercise.Location = new Point(230, 95);
            btnRemoveExercise.Size = new Size(100, 35);
            btnRemoveExercise.BackColor = Color.FromArgb(220, 20, 60);
            btnRemoveExercise.ForeColor = Color.White;
            btnRemoveExercise.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoveExercise.FlatStyle = FlatStyle.Flat;
            btnRemoveExercise.Click += BtnRemoveExercise_Click;
            gbExercises.Controls.Add(btnRemoveExercise);

            // Selected Recommendations GroupBox
            gbSelectedRecommendations = new GroupBox();
            gbSelectedRecommendations.Text = "Seçilen Öneriler";
            gbSelectedRecommendations.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbSelectedRecommendations.ForeColor = Color.FromArgb(70, 130, 180);
            gbSelectedRecommendations.Location = new Point(20, 400);
            gbSelectedRecommendations.Size = new Size(920, 200);
            gbSelectedRecommendations.BackColor = Color.White;
            this.Controls.Add(gbSelectedRecommendations);

            // Selected Diets Label
            Label lblSelectedDiets = new Label();
            lblSelectedDiets.Text = "Seçilen Diyetler:";
            lblSelectedDiets.Location = new Point(15, 30);
            lblSelectedDiets.AutoSize = true;
            lblSelectedDiets.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbSelectedRecommendations.Controls.Add(lblSelectedDiets);

            // Selected Diets ListBox
            lstSelectedDiets = new ListBox();
            lstSelectedDiets.Location = new Point(15, 55);
            lstSelectedDiets.Size = new Size(420, 120);
            lstSelectedDiets.Font = new Font("Segoe UI", 9F);
            lstSelectedDiets.BackColor = Color.FromArgb(240, 255, 240);
            gbSelectedRecommendations.Controls.Add(lstSelectedDiets);

            // Selected Exercises Label
            Label lblSelectedExercises = new Label();
            lblSelectedExercises.Text = "Seçilen Egzersizler:";
            lblSelectedExercises.Location = new Point(460, 30);
            lblSelectedExercises.AutoSize = true;
            lblSelectedExercises.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbSelectedRecommendations.Controls.Add(lblSelectedExercises);

            // Selected Exercises ListBox
            lstSelectedExercises = new ListBox();
            lstSelectedExercises.Location = new Point(460, 55);
            lstSelectedExercises.Size = new Size(420, 120);
            lstSelectedExercises.Font = new Font("Segoe UI", 9F);
            lstSelectedExercises.BackColor = Color.FromArgb(240, 248, 255);
            gbSelectedRecommendations.Controls.Add(lstSelectedExercises);

            // Save Button
            btnSaveRecommendations = new Button();
            btnSaveRecommendations.Text = "Önerileri Kaydet";
            btnSaveRecommendations.Location = new Point(720, 620);
            btnSaveRecommendations.Size = new Size(120, 40);
            btnSaveRecommendations.BackColor = Color.FromArgb(70, 130, 180);
            btnSaveRecommendations.ForeColor = Color.White;
            btnSaveRecommendations.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSaveRecommendations.FlatStyle = FlatStyle.Flat;
            btnSaveRecommendations.Click += BtnSaveRecommendations_Click;
            this.Controls.Add(btnSaveRecommendations);

            // Cancel Button
            btnCancel = new Button();
            btnCancel.Text = "İptal";
            btnCancel.Location = new Point(860, 620);
            btnCancel.Size = new Size(80, 40);
            btnCancel.BackColor = Color.FromArgb(128, 128, 128);
            btnCancel.ForeColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Click += BtnCancel_Click;
            this.Controls.Add(btnCancel);

            this.ResumeLayout(false);
        }

        private void SetupForm()
        {
            // Hasta bilgisini göster
            lblPatientInfo.Text = $"Hasta: {currentPatient.name} {currentPatient.surname} | Kan Şekeri: {currentPatient.blood_sugar} mg/dL";

            // Diyet türlerini listele
            foreach (string diet in dietTypes.Keys)
            {
                lstAvailableDiets.Items.Add(diet);
            }

            // Egzersiz türlerini listele
            foreach (string exercise in exerciseTypes.Keys)
            {
                lstAvailableExercises.Items.Add(exercise);
            }
        }

        private void LoadRecommendations()
        {
            // Mevcut önerileri yükle (eğer varsa)
            // Bu kısım PatientInfo sınıfına diet_recommendations ve exercise_recommendations listesi eklendikten sonra kullanılabilir
        }

        private void LstAvailableDiets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAvailableDiets.SelectedItem != null)
            {
                string selectedDiet = lstAvailableDiets.SelectedItem.ToString();
                rtbDietDetails.Text = dietTypes[selectedDiet];
            }
        }

        private void LstAvailableExercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAvailableExercises.SelectedItem != null)
            {
                string selectedExercise = lstAvailableExercises.SelectedItem.ToString();
                rtbExerciseDetails.Text = exerciseTypes[selectedExercise];
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

            // Önerileri PatientInfo'ya kaydetme işlemi
            // Bu kısım PatientInfo sınıfına uygun property'ler eklendikten sonra aktif hale getirilebilir
            /*
            currentPatient.diet_recommendations = new List<string>(selectedDiets);
            currentPatient.exercise_recommendations = new List<string>(selectedExercises);
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
        public List<string> SelectedDiets => new List<string>(selectedDiets);
        public List<string> SelectedExercises => new List<string>(selectedExercises);
    }
}