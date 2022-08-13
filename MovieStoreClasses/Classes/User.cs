using MovieStoreClasses.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreClasses.Classes
{
    public class User : Member
    {
        public int UserNumber { get; set; }
        public EnumSubscription TypeOfSubscription { get; set; }
        public List<Movie> Movie { get; set; }
        public User()
        {

            Role = RoleEnum.Member;

            Movie = new List<Movie>();

        }
        public override void DisplayInfo()
        {
            Console.WriteLine(String.Format("{0,10} | {1, 10} ", $"User Number: {UserNumber} First Name:{FirstName},  Last Name: {LastName}, User Number: {UserNumber} ", $"Registered on: {DateOfRegistration}, Type of subscription:{TypeOfSubscription} "));
        }


    }
}
