using System;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HospitalMangmentFrontend.Forms
{
    public partial class Login : Form
    {
        private readonly HttpClient _httpClient;

        public Login()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
               {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Username or Password cannot be empty");
                return;
            }

            var Login = new
            {
                UserName = txtUserName.Text,
                Password = textBoxPassword.Text
            };

            try
            {
                var json = JsonConvert.SerializeObject(Login);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("https://localhost:7185/api/auth/login", content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var jsonResponse = JObject.Parse(responseContent);

                    string token = jsonResponse["token"]?.ToString();
                    if (string.IsNullOrEmpty(token))
                    {
                        MessageBox.Show("Token is missing in the response");
                        return;
                    }

                    MessageBox.Show("Token: " + token);
                    System.Diagnostics.Debug.WriteLine("Token: " + token);

                    string role = jsonResponse["roles"]?[0]?.ToString();
                    if (string.IsNullOrEmpty(role))
                    {
                        MessageBox.Show("Role is missing in the response");
                        return;
                    }
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    MessageBox.Show("Login Successful");

                    Properties.Settings.Default.JwtToken = token;
                    Properties.Settings.Default.Save();
                   

                    NavigateToDashboard(role);
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error: " + errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void NavigateToDashboard(string role)
        {
            Form dashboard = null;

            switch (role.ToLower())
            {
                case "admin":
                    dashboard = new AdminDashboard();
                    break;
                case "doctor":
                    dashboard = new DoctorDashboard();
                    break;
                case "patient":
                    dashboard = new PatientDashboard();
                    break;
                default:
                    MessageBox.Show("Unauthorized role.");
                    return;
            }

            if (dashboard != null)
            {
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
           
         
        }

     
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Passcheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
