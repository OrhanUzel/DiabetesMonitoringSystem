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
    public partial class PatientScreen : Form
    {
        public PatientScreen()
        {
            InitializeComponent();
        }

        private void PatientScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();  // Tüm uygulamayı kapatır

        }
    }
}
