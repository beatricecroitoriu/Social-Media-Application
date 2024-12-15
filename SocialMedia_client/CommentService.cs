using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SocialMedia_Client2
{
    internal class CommentService
    {
        static HttpClient client = new HttpClient();

        public void createConnection()
        {
            client.BaseAddress = new Uri("http://localhost:8082/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public List<Comment> GetAllComments()
        {
            List<Comment> comments = null;
            HttpResponseMessage response = client.GetAsync("comment").Result;

            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<List<Comment>>(result);
            }
            return null;
        }

        public List<Comment> GetCommentsByKeyword(string keyword)
        {
            List<Comment> comments = this.GetAllComments();
            if (comments != null)
            {
                return comments.Where(c =>
                    c.content.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            return new List<Comment>();
        }

        public void DeleteComment(int commentId)
        {
            HttpResponseMessage response = client.DeleteAsync($"comment/{commentId}").Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Failed to delete comment: " + response.StatusCode);
            }
        }

    }


}
