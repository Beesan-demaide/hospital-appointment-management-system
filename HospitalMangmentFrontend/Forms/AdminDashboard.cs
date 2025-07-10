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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthHelper.Logout(this);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_New_Doctor add_New_Doctor = new Add_New_Doctor();
            add_New_Doctor.Show();
            this.Hide();
        }
    }
}
