using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SocialMedia_Client2
{
    internal class UserService
    {
        static HttpClient client = new HttpClient();

        public void createConnection()
        {
            client.BaseAddress = new Uri("http://localhost:8082/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        // Create a new user (POST)
        public async Task<User> CreateUserAsync(User user)
        {
            string json = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("user", content);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<User>(result);
            }
            else
            {
                throw new Exception("Failed to create user.");
            }
        }

     
        public List<User> GetAllUsers()
        {
            List<User> users = null;
            HttpResponseMessage response = client.GetAsync("user").Result;

            if (response.IsSuccessStatusCode)
            {
                string result =  response.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<List<User>>(result);
            }
            return null;
        }

        public List<User> GetUsersByKeyword(string keyword)
        {
            List<User> users = this.GetAllUsers();
            if (users != null)
            {
                return users.Where(u =>
                    u.name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    u.email.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            return new List<User>();
        }

        // Update a user (PUT)
        public async Task<User> UpdateUserAsync(int id, User user)
        {
            string json = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PutAsync($"user/{id}", content);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<User>(result);
            }
            else
            {
                throw new Exception("Failed to update user.");
            }
        }

        public void DeleteUser(int id)
        {
            HttpResponseMessage response = client.DeleteAsync($"user/{id}").Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Failed to delete user.");
            }
        }
    }
}
