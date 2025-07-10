using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace HospitalMangmentFrontend
{
    public static class AuthHelper
    {
        public static void Logout(Form currentForm)

        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = null;

            Properties.Settings.Default.JwtToken = "";
            Properties.Settings.Default.Save();
            MessageBox.Show("You have been logged out successfully");
            currentForm.Hide();
            Main main = new Main();
            main.Show();

        }


    }
}
