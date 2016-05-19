using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_app2
{
    public class HolidayRandomiser
    {
        private Random randGen;
        private Holiday[] holidays;
        private int random;

        public HolidayRandomiser()
        {
            holidays = new Holiday[3];
            randGen = new Random();

            holidays[0] = new Holiday("Queens Birthday", new DateTime(2016, 06, 06), "/queens.jpg");
            holidays[1] = new Holiday("Halloween", new DateTime(2016, 10, 31), "/halloween.jpeg");
            holidays[2] = new Holiday("Boxing Day", new DateTime(2016, 12, 26), "/boxingday.jpg");
            
        }

        //randomly returns a holiday
        public Holiday GetHoliday()
        {
            random = randGen.Next(holidays.Length);
            return holidays[random];
        }
    }
}