using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab3
{
    internal partial class PatientScreen : Form
    {
        PatientInfo patient;
        public PatientScreen()
        {
            InitializeComponent();
        }
        public PatientScreen(PatientInfo patient)
        {
            this.patient = patient;
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
            textBoxName.Enabled = true;
            textBoxSurname.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxPhone.Enabled = true;
            dateTimePickerBirthDate.Enabled = true;
            buttonChangeİmage.Visible = true;
            buttonSave.Visible = true;
            buttonRewind.Visible = true;
            buttonUpdate.Visible = false;

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

        private void PatientScreen_Load(object sender, EventArgs e)
        {
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
    }
}
