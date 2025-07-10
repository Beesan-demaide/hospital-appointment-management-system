using System;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using HospitalMangmentFrontend.Forms;
using Newtonsoft.Json;


namespace HospitalMangmentFrontend
{
    public partial class Profile_Settings : Form
    {
        private readonly HttpClient _httpClient;

        public Profile_Settings()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            string token = Properties.Settings.Default.JwtToken;

            if (!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }


        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var profileSetting = new
                {
                    UserName = txtUserName.Text,
                    Email = txtEmail.Text,
                    OldPassword = txtOldPassword.Text,
                    NewPassword = txtNewPassword.Text

                };

                var json = JsonConvert.SerializeObject(profileSetting);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                string token = Properties.Settings.Default.JwtToken;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                MessageBox.Show("Token being sent: " + token);


                var response = await _httpClient.PutAsync("https://localhost:7185/api/Patient/edit", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Profile Update successfully");
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

        private void Profile_Settings_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}