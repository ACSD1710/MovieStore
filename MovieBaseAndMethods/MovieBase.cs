using MovieStoreClasses.Classes;
using MovieStoreClasses.Enum;

namespace MovieBaseAndMethods
{
    public static class MovieBase
    {
        public static List<User> Users = new List<User>
            {
                new User(){UserNumber = 1, FirstName = "User1", LastName = "LastName1", Age = 18, UserName = "user1", Password = "123", PhoneNumber = 078123456, TypeOfSubscription = EnumSubscription.Annually, Movie = new List<Movie>(){ }, DateOfRegistration = new DateTime(2021, 11, 5)},
                new User(){UserNumber = 2, FirstName = "User2", LastName = "LastName2", Age = 19, UserName = "user2", Password = "123", PhoneNumber = 078223456, TypeOfSubscription = EnumSubscription.Annually, Movie = new List<Movie>(){ }, DateOfRegistration = new DateTime(2021, 10, 5) },
                new User(){UserNumber = 3, FirstName = "User3", LastName = "LastName3", Age = 20, UserName = "user3", Password = "123", PhoneNumber = 078323456, TypeOfSubscription = EnumSubscription.Monthly, Movie = new List<Movie>(){ }, DateOfRegistration = new DateTime(2022, 04, 5) },
                new User(){UserNumber = 4, FirstName = "User4", LastName = "LastName4", Age = 21, UserName = "user4", Password = "123", PhoneNumber = 078423456, TypeOfSubscription = EnumSubscription.Monthly, Movie = new List<Movie>(){ }, DateOfRegistration = new DateTime(2022, 04, 5) }
            };

        public static List<Employe> Employee = new List<Employe>()
            {
                new Employe() {FirstName = "Employee1", LastName = "Employee1", Age = 29, UserName = "employee1", Password = "123", PhoneNumber = 078456789, HoursPerMonth = 180 },
                new Employe(){FirstName = "Employee2", LastName = "Employee2", Age = 35, UserName = "employee2", Password = "123", PhoneNumber = 078987654, HoursPerMonth = 200 },
                new Employe(){FirstName = "Employee3", LastName = "Employee3", Age = 34, UserName = "employee3", Password = "123", PhoneNumber = 078525252, HoursPerMonth = 170 },
            };

        public static List<Movie> movies = new List<Movie>
            {
                new Movie() {MoviceNumber = 1, Title = "Title1", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Horror, Year = 1999, Ranted = true},
                new Movie() {MoviceNumber = 2, Title = "Title2", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Action, Year = 2005, Ranted = true},
                new Movie() {MoviceNumber = 3, Title = "Title3", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Drama, Year = 2010, Ranted = false},
                new Movie() {MoviceNumber = 4, Title = "Title4", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Comedy, Year = 2019, Ranted = false},
                new Movie() {MoviceNumber = 5, Title = "Title5", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.SciFi, Year = 2021, Ranted = false},
                new Movie() {MoviceNumber = 6, Title = "Title6", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Horror, Year = 2018, Ranted = false},
                new Movie() {MoviceNumber = 7, Title = "Title7", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Action, Year = 2017, Ranted = false},
                new Movie() {MoviceNumber = 8, Title = "Title8", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.SciFi, Year = 2014, Ranted = false},
                new Movie() {MoviceNumber = 9, Title = "Title9", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Drama, Year = 1987, Ranted = false},
                new Movie() {MoviceNumber = 10, Title = "Title10", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Action, Year = 2004, Ranted = false},
                new Movie() {MoviceNumber = 11, Title = "Title11", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Comedy, Year = 2013, Ranted = false},
                new Movie() {MoviceNumber = 12, Title = "Title12", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Horror, Year = 1997, Ranted = false},
                new Movie() {MoviceNumber = 13, Title = "Title13", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Comedy, Year = 2016, Ranted = false},
                new Movie() {MoviceNumber = 14, Title = "Title14", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.SciFi, Year = 2019, Ranted = false},
                new Movie() {MoviceNumber = 15, Title = "Title15", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Comedy, Year = 2004, Ranted = false}
            };
    }
}
