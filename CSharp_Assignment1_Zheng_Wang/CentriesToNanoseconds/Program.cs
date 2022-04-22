// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please input number of centuries (integer): ");
int centries = int.Parse(Console.ReadLine());
int years = 100 * centries;
int days = (int)(365.2422 * years);
long hours = 24 * days;
long minutes = 60 * hours;
long seconds = 60 * minutes;
long milliseconds = 1000 * seconds;
decimal microseconds = 1000 * milliseconds;
decimal nanoseconds = 1000 * microseconds;
Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                    centries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
