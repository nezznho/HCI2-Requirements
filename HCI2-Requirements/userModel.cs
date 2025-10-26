using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI2_Requirements
{
    internal class userModel
    {
            // Private fields (Data Hiding - Encapsulation)
            private int _userId;
            private string _name;
            private string _allergies;

            // Public Properties for access
            public int UserID
            {
                get { return _userId; }
                set { _userId = value; }
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public string Allergies
            {
                get { return _allergies; }
                set { _allergies = value; }
            }

            // ... (Add properties for Age and DietaryPreference)
        }
    }
