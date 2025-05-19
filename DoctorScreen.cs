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

namespace ProLab3
{
    public partial class DoctorScreen : Form
    {
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
                SqlCommand objCmd1 = new SqlCommand("SELECT * FROM tbl_patients", objConn);
                SqlCommand objCmd2 = new SqlCommand("insert into tblProjectMember(MemberID, ProjectID) values(2, 1)", objConn);
                try
                {
                    SqlDataReader reader = objCmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["id"].ToString());
                        item.SubItems.Add(reader["name"].ToString());
                        item.SubItems.Add(reader["surname"].ToString());
                        item.SubItems.Add(reader["gender"].ToString());
                        item.SubItems.Add(reader["birth_date"].ToString());
                        item.SubItems.Add(reader["email"].ToString());
                        item.SubItems.Add(reader["blood_sugar"].ToString());
                        item.SubItems.Add(reader["phone_number"].ToString());
                       // item.SubItems.Add(reader["surname"].ToString());



                        listViewPatientsInfos.Items.Add(item);
                    }

                    reader.Close();

                    //objCmd1.ExecuteNonQuery();
                    // objCmd2.ExecuteNonQuery(); // Throws exception due to foreign key constraint
                    objTrans.Commit();
                }
                catch (Exception)
                {
                    objTrans.Rollback();
                }
                finally
                {
                    objConn.Close();
                }
            }
        }


        private void listView1_ItemActivate_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedText = listView1.SelectedItems[0].Text;
                MessageBox.Show(selectedText, "Seçili Metin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            AddPatientScreen addPatientScreen = new AddPatientScreen();
            addPatientScreen.Show();
            this.Hide();
        }
    }
}
