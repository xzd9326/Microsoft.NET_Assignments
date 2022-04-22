using AppropriateGreeting;
DateTime now;
//now = new DateTime(2022, 2, 5, 18, 25, 16);
now = DateTime.Now;
Greeting currentGreeting = new Greeting();
Console.WriteLine(currentGreeting.AppopriateGreeting(now));


