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
        //key data was integer before //now string and in PatientInfo class
      // internal static Dictionary<string, string> dictSymptoms = new Dictionary<string, string>();
        BindingList<PatientInfo> patient_list = new BindingList<PatientInfo>();
       
        public DoctorScreen()
        {
            InitializeComponent();
        }

       

        private void DoctorScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorScreen_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=ORHANUZEL\\SQLEXPRESS;Database=DiabetesMonitoringSystem;Trusted_Connection=True;"; // Güncelle

          //  string strConnString = "myconnectionstring"; // get it from Web.config file
            SqlTransaction objTrans = null;

            using (SqlConnection objConn = new SqlConnection(connectionString))
            {
                objConn.Open();
                objTrans = objConn.BeginTransaction();
                SqlCommand sqlCmdLeftJoin = new SqlCommand("SELECT p.id, p.name, p.surname, p.gender, p.birth_date,p.email,p.phone_number,p.blood_sugar, STRING_AGG(s.symptom_id, ', ') AS Symptoms FROM tbl_patients p LEFT JOIN tbl_patient_symptoms s ON p.id = s.patient_id GROUP BY p.id, p.name, p.surname, p.gender, p.birth_date,p.email,p.phone_number,p.blood_sugar;", objConn, objTrans);
                SqlCommand objCmd1 = new SqlCommand("SELECT * FROM tbl_patients", objConn,objTrans);
                SqlCommand sqlCmdSymptoms = new SqlCommand("SELECT * FROM tbl_symptoms", objConn,objTrans);
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
                                PatientInfo.dictSymptoms.Add(readerSymptoms["id"].ToString(),readerSymptoms["symptom_name"].ToString());
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
                            string email= (string)reader["email"];
                            string phone_number = reader["phone_number"].ToString().Trim();
                            int blood_sugar = Convert.ToInt32(reader["blood_sugar"]);
                           // byte[] profile_image = null; // Varsayılan olarak null atayalım
                            //List<byte> profile_image = new List<byte>();
                            //if (reader["profile_image"] != null)
                            //{
                            //    profile_image = (List<byte>)reader["profile_image"];
                            //}
                           
                            List<string> symptom_array = new List<string>();
                            string[] symptomArray = reader["Symptoms"].ToString().Trim().Split(',');
                            symptom_array = symptomArray.ToList();
                           // List<int> symptom_array_int = Convert.ToInt64(symptomArray);
                            PatientInfo patient=new PatientInfo(id,name,surname,gender,birth_date,email,blood_sugar,phone_number,symptom_array);
                            patient_list.Add(patient);//tüm hastaları hasta listesine kayıt ettim
                            i++;
                            ListViewItem item = new ListViewItem(i.ToString());//reader["id"].ToString()
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
                            
                            if (symptomArray.Count() != 0)
                            {


                                for (int s = 0; s < symptomArray.Count(); s++)
                                {
                                    string s_id = symptomArray[s];
                                    switch (s_id)
                                    {
                                        case "1":
                                            item.SubItems[8].Text = "+";
                                            break;
                                        case "2":
                                            item.SubItems[9].Text = "+";
                                            break;
                                        case "3":
                                            item.SubItems[10].Text = "+";
                                            break;
                                        case "4":
                                            item.SubItems[11].Text = "+";
                                            break;
                                        case "5":
                                            item.SubItems[12].Text = "+";
                                            break;
                                        case "6":
                                            item.SubItems[13].Text = "+";
                                            break;
                                        case "7":
                                            item.SubItems[14].Text = "+";
                                            break;
                                        case "8":
                                            item.SubItems[15].Text = "+";
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
            //dataGridView.Columns.Add("Name", "İsim");
              //dataGridView.AutoGenerateColumns = true;
                                 //dataGridView.DataSource = patient_list;//neden işe yaramadı
            // AutoGenerateColumns özelliğinin true olduğundan emin olun
            

            // Eğer tablonun güncellenme sorunu varsa Refresh() çağırın
            //dataGridView.Refresh();
        }


       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            AddPatientScreen addPatientScreen = new AddPatientScreen(this);
            addPatientScreen.Show();
            this.Hide();
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
                int selectedIndeces=listViewPatientsInfos.SelectedIndices[0];
                PatientDetailScreenFromDoctorScreen patientDetailScreen = new PatientDetailScreenFromDoctorScreen(patient_list[selectedIndeces]);
                patientDetailScreen.Show();
                
             //  for (int i=0;i<patient_list.Count();i++)
              //  {
                    //if (patient_list[i].id == listViewPatientsInfos.SelectedIndices[0])
                    //{
                    //    MessageBox.Show("Naber Müdür!");
                    //}
                //}
               // selectedItem.SubItems["columnHeaderId"]
              //  PatientInfo selectedPatient = (Patient)selectedItem.Tag;

                // Yeni formu açın ve seçilen hastayı gönderin
                //OpenPatientDetailsForm(selectedPatient);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
