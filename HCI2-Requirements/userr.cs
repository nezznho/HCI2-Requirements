using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI2_Requirements
{
    public class userr
    {
        // Encapsulated fields
        private string _username;
        private string _password;

        // Public properties with getters/setters
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string confirmPass { get; set; }
        // Parameterless constructor (added so object-initializer works)
        public userr()
        {
        }
        // Constructor
        public userr(string username, string password)
        {
            _username = username;
            _password = password;
        }
    
    }
}
