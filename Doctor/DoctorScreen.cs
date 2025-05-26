using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProLab3
{
    public partial class DoctorScreen : Form
    {
        int doctor_id;
        //key data was integer before //now string and in PatientInfo class
        // internal static Dictionary<string, string> dictSymptoms = new Dictionary<string, string>();
        BindingList<PatientInfo> patient_list = new BindingList<PatientInfo>();
        string connectionString = "Server=ORHANUZEL\\SQLEXPRESS;Database=DiabetesMonitoringSystem;Trusted_Connection=True;"; // Güncelle
        //int selected_patient_id;
        public DoctorScreen()
        {
            InitializeComponent();
        }
        public DoctorScreen(int doctor_id)
        {
            this.doctor_id = doctor_id;
            InitializeComponent();
        }



        private void DoctorScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void createPatientList()
        {

            //  string strConnString = "myconnectionstring"; // get it from Web.config file
            SqlTransaction objTrans = null;

            using (SqlConnection objConn = new SqlConnection(connectionString))
            {
                objConn.Open();
                objTrans = objConn.BeginTransaction();///bir önceki doctor_id si olmadan ki sorgum=SELECT p.id, p.name, p.surname, p.gender, p.birth_date,p.email,p.phone_number,p.blood_sugar, STRING_AGG(s.symptom_id, ', ') AS Symptoms FROM tbl_patients p LEFT JOIN tbl_patient_symptoms s ON p.id = s.patient_id GROUP BY p.id, p.name, p.surname, p.gender, p.birth_date,p.email,p.phone_number,p.blood_sugar;
                SqlCommand sqlCmdLeftJoin = new SqlCommand("SELECT p.id, p.doctor_id, p.name, p.surname, p.gender,p.birth_date, p.email, p.phone_number, p.blood_sugar,p.profile_image, STRING_AGG(s.symptom_id, ',') AS Symptoms FROM tbl_patients p LEFT JOIN tbl_patient_symptoms s ON p.id = s.patient_id WHERE p.doctor_id = 1 GROUP BY p.id, p.doctor_id, p.name, p.surname, p.gender, p.birth_date, p.email, p.phone_number, p.blood_sugar,p.profile_image;", objConn, objTrans);
                SqlCommand objCmd1 = new SqlCommand("SELECT * FROM tbl_patients", objConn, objTrans);
                SqlCommand sqlCmdSymptoms = new SqlCommand("SELECT * FROM tbl_symptoms", objConn, objTrans);
                SqlCommand sqlCommandFullJoin = new SqlCommand("SELECT * FROM tbl_patients FULL OUTER JOIN tbl_patient_symptoms ON tbl_patients.id=tbl_patient_symptoms.patient_id", objConn, objTrans);


                try
                {
                    //int userId = 0;
                    //List<int> idList = new List<int>();
                    using (SqlDataReader readerSymptoms = sqlCmdSymptoms.ExecuteReader())
                    {


                        while (readerSymptoms.Read())
                        {//veri tabanındaki belirtileri buradaki dict şeklindeki belirti listeesinde tutuyoruz...
                            if (!readerSymptoms.IsDBNull(0))
                            {  //id veritabanında tinyint olarak geldiği için sanırım direkt int olmuş olmuyor c# ta     
                                PatientInfo.dictSymptoms.Add(readerSymptoms["id"].ToString(), readerSymptoms["symptom_name"].ToString());
                            }

                        }
                        readerSymptoms.Close();
                    }

                    //sqlCommandFullJoin vardı öncesinde
                    using (SqlDataReader reader = sqlCmdLeftJoin.ExecuteReader())
                    {

                        int i = 0;
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            string name = (string)reader["name"];
                            string surname = (string)reader["surname"];
                            bool gender = (bool)reader["gender"];
                            DateTime birth_date = (DateTime)reader["birth_date"];
                            string email = (string)reader["email"];
                            string phone_number = reader["phone_number"].ToString().Trim();
                            int blood_sugar = Convert.ToInt32(reader["blood_sugar"]);
                            byte[] profile_image = null; // Varsayılan olarak null atayalım

                            if (reader["profile_image"] != DBNull.Value)
                            {
                                profile_image = (byte[])reader["profile_image"];
                            }

                            List<string> symptom_array = new List<string>();
                            string[] symptomArray = reader["Symptoms"].ToString().Trim().Split(',');
                            symptom_array = symptomArray.ToList();
                            // List<int> symptom_array_int = Convert.ToInt64(symptomArray);
                            PatientInfo patient = new PatientInfo(id, name, surname, gender, birth_date, email, blood_sugar, phone_number, symptom_array, profile_image);
                            patient_list.Add(patient);//tüm hastaları hasta listesine kayıt ettim
                            i++;
                            ListViewItem item = new ListViewItem(i.ToString());//reader["id"].ToString()
                            item.SubItems.Add(id.ToString());
                            item.SubItems.Add(name.ToString());
                            item.SubItems.Add(surname.ToString());
                            item.SubItems.Add(gender.ToString());
                            item.SubItems.Add(birth_date.ToString());
                            item.SubItems.Add(email.ToString());
                            item.SubItems.Add(phone_number.ToString());
                            item.SubItems.Add(blood_sugar.ToString());
                            item.SubItems.Add("-");
                            item.SubItems.Add("-");
                            item.SubItems.Add("-");
                            item.SubItems.Add("-");
                            item.SubItems.Add("-");
                            item.SubItems.Add("-");
                            item.SubItems.Add("-");
                            item.SubItems.Add("-"); // Bu, SubItems[8] olur
                            item.Tag = patient;
                            if (symptomArray.Count() != 0)
                            {


                                for (int s = 0; s < symptomArray.Count(); s++)
                                {
                                    string s_id = symptomArray[s];
                                    switch (s_id)
                                    {
                                        case "1":
                                            item.SubItems[9].Text = "+";
                                            break;
                                        case "2":
                                            item.SubItems[10].Text = "+";
                                            break;
                                        case "3":
                                            item.SubItems[11].Text = "+";
                                            break;
                                        case "4":
                                            item.SubItems[12].Text = "+";
                                            break;
                                        case "5":
                                            item.SubItems[13].Text = "+";
                                            break;
                                        case "6":
                                            item.SubItems[14].Text = "+";
                                            break;
                                        case "7":
                                            item.SubItems[15].Text = "+";
                                            break;
                                        case "8":
                                            item.SubItems[16].Text = "+";
                                            break;


                                    }

                                }
                            }
                            // item.SubItems.Add(reader["patient_id"].ToString());
                            //   idList.Add((int)reader["id"]);
                            // item.SubItems.Add(reader["surname"].ToString());



                            listViewPatientsInfos.Items.Add(item);
                        }

                        reader.Close();
                    }

                    //objCmd1.ExecuteNonQuery();
                    // objCmd2.ExecuteNonQuery(); // Throws exception due to foreign key constraint
                    objTrans.Commit();
                }
                catch (SqlException sqlEx)
                {
                    // SQL hatalarını detaylı şekilde yakala
                    Console.WriteLine($"SQL Error Number: {sqlEx.Number}");
                    Console.WriteLine($"Error Message: {sqlEx.Message}");
                    Console.WriteLine($"SQL State: {sqlEx.State}");
                    Console.WriteLine($"Error Procedure: {sqlEx.Procedure}");
                    Console.WriteLine($"Line Number: {sqlEx.LineNumber}");
                    objTrans.Rollback();
                    // Hatayı yeniden fırlat veya işle
                    throw;

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Type: {ex.GetType().Name}");
                    Console.WriteLine($"Error Message: {ex.Message}");
                    Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                    objTrans.Rollback();
                }
                finally
                {
                    objConn.Close();
                }
            }
        }

        private void DoctorScreen_Load(object sender, EventArgs e)
        {
            createPatientList();
        }




        private void button2_Click(object sender, EventArgs e)
        {

        }




        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listViewPatientsInfos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Seçilen öğeyi alın
            if (listViewPatientsInfos.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewPatientsInfos.SelectedItems[0];
                int selectedIndeces = listViewPatientsInfos.SelectedIndices[0];
                //PatientDetailScreenFromDoctorScreen patientDetailScreen = new PatientDetailScreenFromDoctorScreen(patient_list[selectedIndeces]);
                PatientDetailInDoctorScreen patientDetailScreen = new PatientDetailInDoctorScreen(patient_list[selectedIndeces]);

                patientDetailScreen.Show();


            }
        }



        private async void buttonDeletePatient_Click(object sender, EventArgs e)
        {
            if (listViewPatientsInfos.SelectedItems.Count > 0)
            {
                int selectedIndex = listViewPatientsInfos.SelectedItems[0].Index;
                ListViewItem selectedItem = listViewPatientsInfos.SelectedItems[0];

                // Onay mesajı göster
                DialogResult confirmResult = MessageBox.Show(
                    $"Seçilen hastayı silmek istediğinizden emin misiniz? Bu işlem geri alınamaz.",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {

                    PatientInfo patient = (PatientInfo)listViewPatientsInfos.SelectedItems[0].Tag;
                    int p_id = patient.id;

                    bool isDeleted = await DeletePatientFromDatabase(p_id); // Veritabanından sil

                    if (isDeleted)
                    {
                        listViewPatientsInfos.Items.Remove(selectedItem); // ListView'dan görsel olarak sil
                        MessageBox.Show("Hasta başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hasta silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Lütfen silmek istediğiniz hastayı seçiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public async Task<bool> DeletePatientFromDatabase(int patientId)
        {
            string query = "DELETE FROM tbl_patients WHERE id = @patientId"; // id sütun adınızın 'id' olduğunu varsayıyoruz

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);

                    try
                    {
                        await conn.OpenAsync();
                        int affectedRows = await cmd.ExecuteNonQueryAsync(); // Etkilenen satır sayısını alır
                        return affectedRows > 0; // Bir satır silindiyse true döner
                    }
                    catch (SqlException sqlEx)
                    {
                        // SQL hatalarını logla veya kullanıcıya göster
                        Console.WriteLine($"SQL Error while deleting: {sqlEx.Message}");
                        return false;
                    }
                    catch (Exception ex)
                    {
                        // Genel hataları logla veya kullanıcıya göster
                        Console.WriteLine($"Error while deleting: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            AddPatientScreen addPatientScreen = new AddPatientScreen(this,doctor_id);
            addPatientScreen.Show();
            this.Hide();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (listViewPatientsInfos.SelectedItems.Count > 0)
            {
                int selectedIndex = listViewPatientsInfos.SelectedItems[0].Index;
                ListViewItem selectedItem = listViewPatientsInfos.SelectedItems[0];
                PatientDetailInDoctorScreen patientDetailScreen = new PatientDetailInDoctorScreen(patient_list[selectedIndex]);

                patientDetailScreen.Show();
            }
        }

        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            // Mevcut formu gizle
            
            this.Hide();
            PatientInfo.dictSymptoms.Clear();
            // Aynı türden yeni bir form örneği oluştur
            DoctorScreen newForm = new DoctorScreen(doctor_id);

            // Yeni formu göster
            newForm.Show();
            //this.Close();
            //createPatientList();
             
        }
    }
}
