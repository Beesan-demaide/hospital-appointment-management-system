using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Hospital_Appointment_Management_System.Models.Entities;
using Hospital_Appointment_Management_System.Dto;

namespace HospitalMangmentFrontend.Forms
{
    public partial class Add_New_Doctor : Form
    {
        private readonly HttpClient _httpClient;

        public Add_New_Doctor()
        {
            InitializeComponent();
            _httpClient = new HttpClient();

        }

        private void Add_New_Doctor_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var doctorData = new DoctorRegistrationDTO
                {
                    Doctor = new Doctor
                    {
                        Name = txtName.Text,
                        Specialty = txtSpecialty.Text
                    },
                    Password = txtPassword.Text
                };

                var json = JsonConvert.SerializeObject(doctorData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                string token = Properties.Settings.Default.JwtToken;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.PostAsync("https://localhost:7185/api/Admin/AddNew-doctor", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Doctor added successfully");
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error: " + response.StatusCode + " - " + errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

