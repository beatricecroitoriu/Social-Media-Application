using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia_Client2
{
    internal class Comment
    {
        public int id { get; set; }
        public string content { get; set; }
        public DateTime createdOn { get; set; }
        public Post Post { get; set; }
        public User User { get; set; }
    }
}
