using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static SocialMedia_Client2.Post;

namespace SocialMedia_Client2
{
    internal class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public UserStatus status { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        internal enum UserStatus
        {
            ACTIVE,
            DELETED
        }
    }
}
