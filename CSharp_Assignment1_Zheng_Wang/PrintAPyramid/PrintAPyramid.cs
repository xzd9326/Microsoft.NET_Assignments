Console.WriteLine("Please input the height of pyramid as a positive integer:");
int level = int.Parse(Console.ReadLine());
while (level <= 0)
{
    Console.WriteLine("Please input a positive integer:");
    level = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Here is your pyramid with height {level}:\n");
// Determines how many stars to print
for (int i = 0; i < level; i++)
{
    int numOfStars = (i + 1) * 2 - 1;
    int numOfSpaces = level - i - 1;
    for (int j = 0; j < numOfSpaces; j++)
    {
        Console.Write(' ');
    }
    for (int k = 0; k < numOfStars; k++)
    {
        Console.Write('*');
    }
    for (int j = 0; j < numOfSpaces; j++)
    {
        Console.Write(' ');
    }
    Console.Write('\n');
}