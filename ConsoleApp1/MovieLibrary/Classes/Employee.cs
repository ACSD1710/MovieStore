using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary.Classes
{
    class Employee : Member
    {
        private double _salary { get; set; }
        public double HoursPerMonth { get; set; }
        public double Bonus { get; set; }

        public double SetBonus()
        {
            if(HoursPerMonth > 160)
            {
                return Bonus = 0.3;
            }if(HoursPerMonth < 160)
            {
                return Bonus = default(int);
            }
            return Bonus;
        }

        public double SetSalary()
        {
           return _salary += (HoursPerMonth * Bonus); 
        }
    }
}
