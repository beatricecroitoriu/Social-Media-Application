using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia_Client2
{
    internal class EmailRequest
    {
        public string[] recipients { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
    }
}
