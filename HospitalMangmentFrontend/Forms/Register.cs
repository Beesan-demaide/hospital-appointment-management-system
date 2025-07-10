using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json;


namespace HospitalMangmentFrontend.Forms
{
    public partial class Register : Form
    {
        private readonly HttpClient _httpClient;
        public Register()
        {
            InitializeComponent();
            _httpClient = new HttpClient();

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (!ValidatePassword(txtPassword.Text))
            {
                MessageBox.Show("password must at least 8 characters and contain uppercase,lowercase,and digit");
                return;
            }

            var userDto = new
            {
                UserName = txtUserName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Role = cmbRoles.SelectedItem.ToString()
            };
            try
            {
                var json = JsonConvert.SerializeObject(userDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");


                var response = await _httpClient.PostAsync("https://localhost:7185/api/auth/register", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User registered Successfully");
                    txtUserName.Text = "";
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    cmbRoles.SelectedIndex = -1;

                }
                else
                {
                    MessageBox.Show("Error: " + await response.Content.ReadAsStringAsync());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Register_Load(object sender, EventArgs e)
        {

            try
            {
                txtPassword.UseSystemPasswordChar = true; 
                var response = await _httpClient.GetAsync("https://localhost:7185/api/Admin/roles");
                if (response.IsSuccessStatusCode)
                {
                    var roles = JsonConvert.DeserializeObject<List<string>>(await response.Content.ReadAsStringAsync());
                    cmbRoles.DataSource = roles;
                }
                else
                {
                    MessageBox.Show("Failed to load roles");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private bool ValidatePassword(string password)
        {
            if (password.Length < 8)
                return false;
            if (!password.Any(char.IsUpper))
                return false;
            if (!password.Any(char.IsLower))
                return false;
            if (!password.Any(char.IsDigit))
                return false;

            return true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox.Checked;

        }
    }
}
