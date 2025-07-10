using Hospital_Appointment_Management_System.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HospitalMangmentFrontend.Forms
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }
        private async Task<List<string>> GetSpecialtiesAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7185/api/");

                var response = await client.GetAsync("Admin/specialties");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<string>>(content);
                }
                else
                {
                    MessageBox.Show("Error fetching specialties");
                    return null;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BoxSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private async Task bookbtn_ClickAsync(object sender, EventArgs e)
        {
            /*if (SchedulesGrid.SelectedRows.Count > 0)
            {var selectedAppointment = (Schedule)SchedulesGrid.SelectedRows[0].DataBoundItem;
                var result = await BookAppointmentAsync(selectedAppointment.Id);

                if (result == "Appointment booked successfully.")
                {
                    MessageBox.Show("Appointment booked successfully!");
                }
                else
                {
                    MessageBox.Show($"Error: {result}");
                }
            }
            else
            {
                MessageBox.Show("Please select a schedule first.");
            }*/
        }

     /*   private async Task<string> BookAppointmentAsync(int scheduleId)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7185/api/Patient/");

                    //var patientIdClaim = User.("UserId"); 
                   /* if (patientIdClaim == null)
                    {
                        return "User ID not found in the token.";
                    }

                    var patientId = int.Parse(patientIdClaim.Value); 
                    HttpResponseMessage response = await client.PostAsJsonAsync($"book", new { scheduleId, patientId });

                    if (response.IsSuccessStatusCode)
                    {
                        return "Appointment booked successfully.";
                    }
                    else
                    {
                        return "Failed to book the appointment.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        */



        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
           
            try
            {
                var specialties = await GetSpecialtiesAsync();
                if (specialties != null)
                {
                    BoxSpecialty.DataSource = specialties;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private async Task<List<Schedule>> GetAvailableSchedulesAsync(string specialty, DateTime appointmentDate)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7185/api/Admin");

                    HttpResponseMessage response = await client.GetAsync($"available-schedules?specialty={specialty}&appointmentDate={appointmentDate:yyyy-MM-ddTHH:mm:ss}");
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    var schedules = JsonConvert.DeserializeObject<List<Schedule>>(responseBody);

                    return schedules;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = DatePicker.Value;
                string selectedSpecialty = BoxSpecialty.SelectedItem.ToString();

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7185/api/Admin/");
                    string formattedDate = selectedDate.ToString("yyyy-MM-ddTHH:mm:ss");

                    HttpResponseMessage response = await client.GetAsync($"available-schedules?specialty={selectedSpecialty}&appointmentDate={formattedDate}");

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        var schedules = JsonConvert.DeserializeObject<List<dynamic>>(result);
                        var displayData = schedules.Select(s => new
                        {
                            s.DoctorName, 
                            s.StartTime,
                            s.EndTime
                        }).ToList();

                        SchedulesGrid.DataSource = schedules;
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
