using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using SocialMedia_Client2;

namespace SocialMedia_Client2
{
    internal class PostService
    {
        static HttpClient client = new HttpClient();

        public void createConnection()
        {
            client.BaseAddress = new Uri("http://localhost:8082/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public List<Post> getAllPosts()
        {
            List<Post> posts = null;
            HttpResponseMessage response = client.GetAsync("post").Result;
            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("received : " + resultString);
                posts = JsonSerializer.Deserialize<List<Post>>(resultString);
                return posts;

            }
            return null;
        }


        public List<User> GetActiveUsers()
        {
            List<Post> posts = this.getAllPosts();
            return posts.Select(p => p.user).Where(u => u != null).DistinctBy(c => c.name).ToList();
        }

        public List<Post> GetPostsByKeyword(string keyword)
        {
            List<Post> posts = this.getAllPosts();
            if (posts != null)
            {
                return posts.Where(p =>
                    p.title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    p.content.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            return new List<Post>();
        }

        public void ApprovePost(int postId)
        {
            var content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync($"post/{postId}/approve", content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Post {postId} approved successfully.");
            }
            else
            {
                MessageBox.Show($"Failed to approve post {postId}: {response.StatusCode}");
            }
        }
   

        public void DeletePost(int postId)
        {
            HttpResponseMessage response = client.DeleteAsync($"post/{postId}").Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Failed to delete post: " + response.StatusCode);
            }
        }

        public List<Post> GetPublishedPostsForUser(int userId)
        {
            List<Post> posts = null;
            HttpResponseMessage response = client.GetAsync($"post/published/{userId}").Result;

            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                posts = JsonSerializer.Deserialize<List<Post>>(resultString);
            }
            else
            {
                Console.WriteLine($"Failed to fetch published posts for user {userId}: {response.StatusCode}");
            }

            return posts;
        }


    }
}