// Write a program that generates a random number between 1 and 3 and asks the user to guess what the number is.
int correctNumber = new Random().Next(3) + 1;
Console.WriteLine("Please guess a number between 1 and 3:");
int guessedNumber = int.Parse(Console.ReadLine());

while (guessedNumber != correctNumber)
{
    if (guessedNumber > 3 || guessedNumber < 1)
    {
        Console.WriteLine("The number is between 1 and 3, inclusive");
    }
    else if (guessedNumber < correctNumber)
    {
        Console.WriteLine("Guess is low, please guess a higher number");
    }
    else if (guessedNumber > correctNumber)
    {
        Console.WriteLine("Guess is high, please guess a lower number");
    }
    Console.WriteLine("Please guess again:");
    guessedNumber = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Congratulations, you just got the correct answer, which is {correctNumber}!");