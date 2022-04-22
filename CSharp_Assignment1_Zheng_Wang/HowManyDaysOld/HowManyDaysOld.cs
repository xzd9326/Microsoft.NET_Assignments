DateTime birthDate = new DateTime(1996, 1, 19);
DateTime today = DateTime.Today;
int dayDiff = (int)((today - birthDate).TotalDays);
Console.WriteLine($"The person's birthday is {birthDate.ToString("d")}");
Console.WriteLine($"The person is {dayDiff} days old");

int daysToNextAnniversary = 10000 - (dayDiff % 10000);
TimeSpan span = TimeSpan.FromDays(daysToNextAnniversary);
DateTime nextAnniversary = today + span;
Console.WriteLine($"The person's next 10000 day anniversary is on {nextAnniversary.ToString("d")}");
