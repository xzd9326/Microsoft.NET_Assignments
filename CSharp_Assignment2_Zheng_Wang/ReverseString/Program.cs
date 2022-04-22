static void ReverseString1()
{
    // Convert the string to char array, reverse it, then convert it to string again
    Console.WriteLine("Please input a string to be reversed:");
    string input = Console.ReadLine();
    char[] charArr = input.ToCharArray();
    Array.Reverse(charArr);
    Console.WriteLine($"{string.Concat(charArr)}");
}

static void ReverseString2()
{
    // Convert the string to char array, reverse it, then convert it to string again
    Console.WriteLine("Please input a string to be reversed:");
    string input = Console.ReadLine();
    for (int i = input.Length - 1; i >= 0 ; i--)
    {
        Console.Write($"{input[i]}");
    }
}

ReverseString1();
ReverseString2();