using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SocialMedia_Client2
{
    internal class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime createdOn { get; set; }
        public PostStatus status { get; set; }
        public User user { get; set; }


        [JsonConverter(typeof(JsonStringEnumConverter))]
        internal enum PostStatus
        {
            PENDING,
            PUBLISHED,
            REMOVED
        }
    }


}