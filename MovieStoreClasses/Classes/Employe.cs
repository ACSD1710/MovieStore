using MovieStoreClasses.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreClasses.Classes
{
    public class Employe : Member
    {
        private double _salary { get; set; }
        public double HoursPerMonth { get; set; }
        public double Bonus { get; set; }

        public Employe()
        {
            _salary = 300;
            Role = RoleEnum.Employee;
            Bonus = SetBonus();
        }

        public double SetBonus()
        {
            if (HoursPerMonth > 160)
            {
                return Bonus = 0.3;
            }
            if (HoursPerMonth < 160)
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

