using MovieStoreClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBaseAndMethods
{
    public class Methods
    {
        public int numberDate(User user)
        {
            
            if (user.TypeOfSubscription == MovieStoreClasses.Enum.EnumSubscription.Monthly)
            {
                return 30;
            }
            if (user.TypeOfSubscription == MovieStoreClasses.Enum.EnumSubscription.Annually)
            {
                return 365;
            }
            return 30;
        }
        
       public bool RentFromList1(int input, User user)
        {
            if (input > MovieBase.movies.Count - 1)
            {
                return false;

            }
            MovieBase.movies.FirstOrDefault(x => x.MoviceNumber == input).Ranted = true;
            
            foreach (var movie in MovieBase.movies)
            {
                if(movie.MoviceNumber == input)
                {
                    user.Movie.Add(movie);
                }
            }
            return false;
            
        }
        public bool RentFromUserList(int input, User user)
        {   
           
            MovieBase.movies.FirstOrDefault(x => x.MoviceNumber == input).Ranted = false;
           
            var item = user.Movie.Single(x => x.MoviceNumber == input);
            user.Movie.Remove(item);
           
            return false;

        }
        
        public User GetUserMember(string username)
        {
            return MovieBase.Users.FirstOrDefault(x => x.UserName.ToLower() == username.ToLower());


        }
        public User GetUserMemberNumber(string username)
        {
            return MovieBase.Users.FirstOrDefault(x => x.UserName.ToLower() == username.ToLower());


        }
        public Employe GetEmployeMember(string username)
        {
            return MovieBase.Employee.FirstOrDefault(x => x.UserName.ToLower() == username.ToLower());
        }
        public bool passMatch(string pass)
        {

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                if (pass.ToLower() == password.ToLower())
                {
                    return true;
                }

            }
            return false;
        }

        public bool EmployeeChose()
        {
            Console.WriteLine("For Add new user ENTER 1, for DELETE user ENTER 2," +
                   " for SEE ALL RENT MOVIES ENTER 3, FOR SEE ALL MOVIES ENTER 4,\n FOR LOG OUT ENTER 5");
            bool employeeIntParse = int.TryParse(Console.ReadLine(), out int employeeInput);

            if (!employeeIntParse) {
                Console.WriteLine("Please enter number of menu Chose");
                return false;
            };

            if (employeeIntParse)
            {
                if (employeeInput == 3)
                {
                    foreach (var movie in MovieBase.movies)
                    {
                        if (movie.Ranted == false)
                        {
                            Console.WriteLine($"{movie.Title} {movie.Description} {movie.Genre}");
                        }
                    }
                }
                if (employeeInput == 4)
                {
                    foreach (var movie in MovieBase.movies)
                    {
                        Console.WriteLine($"{movie.Title} {movie.Description} {movie.Genre}");
                    }
                }
                if (employeeInput == 2)
                {
                    Console.WriteLine("If you like to delete select number");
                    foreach (var user in MovieBase.Users)
                    {
                        Console.WriteLine($"{user.UserNumber} {user.FirstName} {user.LastName} {user.UserName} ");
                    }
                    bool userInput = int.TryParse(Console.ReadLine(), out int userDeleteInput);
                    if (!userInput)
                    {
                        Console.WriteLine("Please enter right USER NUMBER and try again");
                        return false;
                    }
                    else
                    {
                        MovieBase.Users.RemoveAt(userDeleteInput - 1);
                    }
                    Console.WriteLine("New List");
                    foreach (var user in MovieBase.Users)
                    {
                        Console.WriteLine($"{user.UserNumber} {user.FirstName} {user.LastName} {user.UserName} ");
                    }

                }
                if (employeeInput == 1)
                {
                    foreach (var user in MovieBase.Users)
                    {
                        Console.WriteLine($" User number :{user.UserNumber}, First Name: {user.FirstName}, Last Name: {user.LastName}, User Name: {user.UserName}, Type of subscraption: {user.TypeOfSubscription} ");
                    }
                    Console.WriteLine("Insert First Name");
                    string inputFirstName = Console.ReadLine();
                    if (inputFirstName.Length < 3)
                    {
                        Console.WriteLine("Name must be lenger than 3 caracters, try again");
                        return false;
                    }
                    Console.WriteLine("Insert Last Name");
                    string inputLastName = Console.ReadLine();
                    if (inputLastName.Length < 3)
                    {
                        Console.WriteLine("Last Name must be lenger than 3 caracters, try again");
                        return false;
                    }
                    Console.WriteLine("Insert Password");
                    string inputPassword = Console.ReadLine();

                    Console.WriteLine("Insert User Name");
                    string inputUserName = Console.ReadLine();

                    Console.WriteLine("Insert Phone Number");

                    bool inputPhoneNumber = int.TryParse(Console.ReadLine(), out int inputInputPhoneNumber);
                    if (!inputPhoneNumber)
                    {
                        Console.WriteLine("Enter right Phone Number, try again");
                        return false;
                    }

                    Console.WriteLine("Insert Age");

                    bool inputAge = int.TryParse(Console.ReadLine(), out int inputUserAge);
                    if (!inputAge)
                    {
                        Console.WriteLine("Enter Number for AGE, try again");
                        return false;
                    }
                    Console.WriteLine("Please enter number for subscraption : 1 for mounthly, 2 for annualy");
                    bool userEnumInput = int.TryParse(Console.ReadLine(), out int inputEnumSubscraption);
                    if (!userEnumInput)
                    {
                        Console.WriteLine("You must enter a number");
                        return false;
                    }
                    if (inputEnumSubscraption != 1 && inputEnumSubscraption != 2)
                    {
                        Console.WriteLine("You must enter a number only 1 or 2");
                        return false;
                    }


                    MovieBase.Users.Add(new User {
                        FirstName = inputFirstName,
                        LastName = inputLastName,
                        Password = inputPassword,
                        UserName = inputUserName,
                        PhoneNumber = inputInputPhoneNumber,
                        Age = inputUserAge,
                        UserNumber = MovieBase.Users.Count + 1,
                        TypeOfSubscription = (MovieStoreClasses.Enum.EnumSubscription)inputEnumSubscraption
                    });

                    foreach (var user in MovieBase.Users)
                    {
                        Console.WriteLine($" User number :{user.UserNumber}, First Name: {user.FirstName}, Last Name: {user.LastName}, User Name: {user.UserName}, Type of subscraption: {user.TypeOfSubscription} ");
                    }


                }
                if (employeeInput == 5)
                {

                    return true;

                }

            }

            Console.WriteLine("Whoul you do like to do another operation?? Press any key to fill the list or X to exit ");
            if (Console.ReadLine().ToLower() == "x")
                return true;
            return false;
        }

        /// USER METHODS
        public bool userRegistration() 
        {
           
              
                Console.WriteLine("Insert First Name");
                string inputFirstName = Console.ReadLine();
                if (inputFirstName.Length < 3)
                {
                    Console.WriteLine("Name must be lenger than 3 caracters, try again");
                    return false;
                }
                Console.WriteLine("Insert Last Name");
                string inputLastName = Console.ReadLine();
                if (inputLastName.Length < 3)
                {
                    Console.WriteLine("Last Name must be lenger than 3 caracters, try again");
                    return false;
                }
                Console.WriteLine("Insert Password");
                string inputPassword = Console.ReadLine();

                Console.WriteLine("Insert User Name");
                string inputUserName = Console.ReadLine();

                Console.WriteLine("Insert Phone Number");

                bool inputPhoneNumber = int.TryParse(Console.ReadLine(), out int inputInputPhoneNumber);
                if (!inputPhoneNumber)
                {
                    Console.WriteLine("Enter right Phone Number, try again");
                    return false;
                }

                Console.WriteLine("Insert Age");

                bool inputAge = int.TryParse(Console.ReadLine(), out int inputUserAge);
                if (!inputAge)
                {
                    Console.WriteLine("Enter Number for AGE, try again");
                    return false;
                }
                Console.WriteLine("Please enter number for subscraption : 1 for mounthly, 2 for annualy");
                bool userEnumInput = int.TryParse(Console.ReadLine(), out int inputEnumSubscraption);
                if (!userEnumInput)
                 {
                      Console.WriteLine("You must enter a number");
                      return false;
                 }
                if(inputEnumSubscraption != 1 && inputEnumSubscraption !=2)
                 {
                     Console.WriteLine("You must enter a number only 1 or 2");
                     return false;
                 } 


                MovieBase.Users.Add(new User
                {
                    FirstName = inputFirstName,
                    LastName = inputLastName,
                    Password = inputPassword,
                    UserName = inputUserName,
                    PhoneNumber = inputInputPhoneNumber,
                    Age = inputUserAge,
                    UserNumber = MovieBase.Users.Count + 1,
                    TypeOfSubscription = (MovieStoreClasses.Enum.EnumSubscription)inputEnumSubscraption
                });

            int number = MovieBase.Users.Count - 1;
            Console.WriteLine("Thank you for register your information of user is: ");

            MovieBase.Users[number].DisplayInfo();
             
            Console.WriteLine("Whoul you do like to do another operation?? Press any key to fill the list or X to exit ");
                if (Console.ReadLine().ToLower() == "x")
                    return true;
                return false;
            }

        public bool UserChose(User user)
        {
            Console.WriteLine("FOR RENT MOVIE ENTER 1, FOR SEE RENTED MOVIE IN LIST SELECT 2 , FOR SEE TYPE OF SUBSCRAPTION ENTER 3,\n 4 SEE REST TIME OF REGISTRATION, 5 FOR LOG OUT" );
            bool userIntParse = int.TryParse(Console.ReadLine(), out int userInput);

            if (!userIntParse)
            {
                Console.WriteLine("Please enter number of menu Chose");
                return false;
            };
            if (userInput == 1)
            {
                foreach (var movie in MovieBase.movies)
                {
                    if (movie.Ranted == false)
                    {
                        Console.WriteLine($"Movie Number:{movie.MoviceNumber}, Movie Name: {movie.Title}, Movie Ganre: {movie.Genre}");
                    }

                }
                Console.WriteLine("if you like to Rent some movie select Number of MOVIE or enter any key to cancel");
                bool userMovie = int.TryParse(Console.ReadLine(), out int userMOvieInput);
                if (!userMovie)
                {
                    Console.WriteLine("Please enter NUMBER OF MOVIE");
                    return false;
                };
                RentFromList1(userMOvieInput, user);

            }
            if (userInput == 2)
            {
                foreach (var movie in user.Movie)
                {
                    Console.WriteLine($"Movie Number:{movie.MoviceNumber}, Movie Name: {movie.Title}, Movie Ganre: {movie.Genre}");

                }
                Console.WriteLine("if you like to Un Rent Movie to back, select Number of MOVIE");
                bool userMovie = int.TryParse(Console.ReadLine(), out int userMOvieInput);
                if (!userMovie)
                {
                    Console.WriteLine("Please enter RIGHT MOVIE:");
                    return false;
                };
                RentFromUserList(userMOvieInput, user);
            }
            if (userInput == 3)
            {
                Console.WriteLine($"Date of registration: {user.DateOfRegistration}, Type of Registration: {user.TypeOfSubscription}");
                return false;
            }
            if(userInput == 4)
            {
                int date = numberDate(user);
                DateTime dateOfRegistration = user.DateOfRegistration;
                DateTime expireRegistration = DateTime.Now;
                expireRegistration = dateOfRegistration.AddDays(date);
                string cc;
                Console.WriteLine("=========================================================");
                Console.WriteLine("You have make registration at date: " + dateOfRegistration);
                Console.WriteLine("Your registration expire at: " + expireRegistration);
                Console.WriteLine("=========================================================");
            }
            if (userInput == 5)
            {
                return true;
            }

                return false;
        }





    }
    }

