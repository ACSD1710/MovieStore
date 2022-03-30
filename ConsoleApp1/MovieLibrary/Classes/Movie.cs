using MovieLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary.Classes
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }

        public GenreMovie Genre {get; set;}

        private double _price { get; set; }

        public double SetPrice()
        {
            if(Year < 2000)
            {
                return _price = new Random().Next(100, 200);
            }else if(Year >= 2000 && Year <= 2010)
            {
                return _price = new Random().Next(200, 300);
            }else
            {
                return _price = new Random().Next(300, 500);
            }
        }


    }
}
