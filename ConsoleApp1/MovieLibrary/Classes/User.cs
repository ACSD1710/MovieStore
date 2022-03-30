using MovieLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary.Classes
{
    public class User : Member
    {
        public int MemberNumber { get; set; }
        public EnumSubscription TypeOfSubscription { get; set; }
        public string[] Movie { get; set; }

    }
}
