using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMangmentFrontend.Forms
{
    public partial class SearchDoctors : Form
    {
        private readonly HttpClient _httpClient;

        public SearchDoctors()
        {
            InitializeComponent();
            _httpClient = new HttpClient();

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string specialty = txtSpecialty.Text.Trim();


            try
            {
                var doctors = await SearchhDoctors(specialty);
                var doctorList = doctors.Select(d => new
                {
                    d.Name,
                    d.Specialty,

                }).ToList();
                DoctorsGrid.DataSource = doctorList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<List<DoctorDto>> SearchhDoctors(string specialty)
        {            string apiUrl = $"https://localhost:7185/api/Doctor/Search?specialty={specialty}";



            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<DoctorDto>>(jsonString);
                }
                else
                {
                    throw new Exception("Doctor not found");
                }
            }
        }

        private void SearchDoctors_Load(object sender, EventArgs e)
        {

        }
    }
    public class DoctorDto
        {
            public string Name { get; set; }
            public string Specialty { get; set; }
            public bool IsAvailable { get; set; }
        }
    
    
}
