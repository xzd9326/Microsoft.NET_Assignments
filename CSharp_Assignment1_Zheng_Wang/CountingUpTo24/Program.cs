for (int i = 1; i <= 4; i++)
{
    for (int j = 0; j < 24; j = j + i)
    {
        Console.Write($"{j}, ");
    }
    Console.Write("24\n");
}
