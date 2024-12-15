using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia_Client2
{
    internal class UserItem
    {
        public string DisplayName { get; set; }
        public string Email { get; set; }

        public UserItem(string displayName, string email)
        {
            DisplayName = displayName;
            Email = email;
        }

        // Override ToString to display the name in the CheckedListBox
        public override string ToString()
        {
            return DisplayName;
        }
    }
}
