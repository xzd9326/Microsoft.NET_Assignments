using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppropriateGreeting
{
    public class Greeting
    {
        public string AppopriateGreeting(DateTime currentTime)
        {

            // TimeSpan night = TimeSpan.Parse("0:00");
            TimeSpan morning = TimeSpan.Parse("6:00");
            TimeSpan afternoon = TimeSpan.Parse("12:00");
            TimeSpan evening = TimeSpan.Parse("18:00");
            Console.WriteLine($"Current time is {currentTime}");
            if (currentTime.TimeOfDay >= evening)
            {
                return "Good Evening";
            }
            if (currentTime.TimeOfDay >= afternoon)
            {
                return "Good Afternoon";
            }
            if (currentTime.TimeOfDay >= morning)
            {
                return "Good Morning";
            }
            return "Good Night";
        }
    }
}
