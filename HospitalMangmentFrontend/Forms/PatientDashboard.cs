using HospitalMangmentFrontend.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMangmentFrontend
{
    public partial class PatientDashboard : Form
    {
        public PatientDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthHelper.Logout(this);

        }

        private void btnProfileSettings_Click(object sender, EventArgs e)
        {
            Profile_Settings profile_Settings = new Profile_Settings();
            profile_Settings.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchDoctors searchDoctors = new SearchDoctors();
            searchDoctors.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
