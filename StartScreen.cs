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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }
        private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();  // Tüm uygulamayı kapatır
        }
        private void btnLogPat_Click(object sender, EventArgs e)
        {
            LogInPatient logInPatient = new LogInPatient(this);
            logInPatient.Show();
            this.Hide();

        }

        private void btnLogDoc_Click(object sender, EventArgs e)
        {
            LogInDoctor logInDoctor = new LogInDoctor(this);

            logInDoctor.Show();
            this.Hide();
        }

    }
}
