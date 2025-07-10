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
using System.IdentityModel.Tokens.Jwt;

namespace HospitalMangmentFrontend
{
    public partial class Set_Availability : Form
    {
        private readonly HttpClient _httpClient;

        public Set_Availability()
        {
            InitializeComponent();
            _httpClient = new HttpClient();


        }
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string token = Properties.Settings.Default.JwtToken;
                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadJwtToken(token);

                var userId = jwtToken.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;

                if (userId == null)
                {
                    MessageBox.Show("User ID not found in token");
                    return;
                }

                var startTime = StartTime.Value;
                var endTime = EndTime.Value;
                var isAvailable = Available.Checked;

                if (startTime >= endTime)
                {
                    MessageBox.Show("Start time must be before end time");
                    return;
                }
                var data = new
                {
                    StartTime = startTime.ToString("yyyy-MM-ddTHH:mm"),
                    EndTime = endTime.ToString("yyyy-MM-ddTHH:mm"),
                    IsAvailable = isAvailable
                };

                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                string url = "https://localhost:7185/api/Doctor/SetSchedule"; 
                MessageBox.Show("URL: " + url);

                var response = await _httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Availability set successfully");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }

}
