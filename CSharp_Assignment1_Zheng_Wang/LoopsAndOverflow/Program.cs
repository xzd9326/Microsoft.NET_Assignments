// What will happen if this code executes?
int max = 100;
// We can add an if statement to check the max
if (max > byte.MaxValue)
{
    Console.WriteLine($"Byte index could not handle max = {max}");
}
else
{
    for (byte i = 0; i < max; i++)
    {
        // This will create an infinite loop, since max value of byte type is 255, and 500 can never be reached
        Console.WriteLine(i);
    }
}
