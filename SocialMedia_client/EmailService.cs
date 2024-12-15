using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SocialMedia_Client2
{
    internal class EmailService
    {
        private readonly HttpClient client;

        public EmailService()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:8082/") 
            };
        }

        public async Task<string> SendEmail(EmailRequest emailRequest)
        {
            try
            {
                string json = JsonSerializer.Serialize(emailRequest);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("email/sendEmail", content);

                if (response.IsSuccessStatusCode)
                {
                    return "Email sent successfully!";
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    return $"Failed to send email: {error}";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }


    }
}
