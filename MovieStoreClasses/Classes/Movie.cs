using MovieStoreClasses.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreClasses.Classes
{
    public class Movie : Member
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }

        public GenreMovie Genre { get; set; }
        public int MoviceNumber { get; set; }   

        private double _price { get; set; }
        public bool Ranted { get; set; }

        public Movie()
        {
            _price = SetPrice();

        }
        public double SetPrice()
        {
            if (Year < 2000)
            {
                return _price = new Random().Next(100, 200);
            }
            else if (Year >= 2000 && Year <= 2010)
            {
                return _price = new Random().Next(200, 300);
            }
            else
            {
                return _price = new Random().Next(300, 500);
            }
        }
        public override void DisplayInfo()
        {

            Console.WriteLine(String.Format("{0,10} | {1, 10} ", $"Title: {Title} Genre: {Genre} ", $"Description: {Description}, Year: {Year}, Price: {_price}, Ranted: {Ranted}$"));
        }

    }
}
