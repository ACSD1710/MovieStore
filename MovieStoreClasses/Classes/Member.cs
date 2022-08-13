using MovieStoreClasses.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreClasses.Classes
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

            DateOfRegistration = DateTime.Now;

        }


        public virtual void DisplayInfo()
        {
            Console.WriteLine(String.Format("{0,10} | {1, 10} ", $"{FirstName} {LastName}", $"Registered on: {DateOfRegistration} "));
        }

    }
}
