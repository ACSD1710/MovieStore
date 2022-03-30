using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary.Classes
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public RoleEnum Role { get; set; }

        public Member()
        {

        }
        public void DisplayInfo()
        {
            Console.WriteLine(String.Format("{0,10} | {1, 10} ", $"{FirstName} {LastName}", $"Registered on: {DateOfRegistration}"));
        }

    }
}
