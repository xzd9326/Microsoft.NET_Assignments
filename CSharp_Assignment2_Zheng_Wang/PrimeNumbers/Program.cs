static int[] FindPrimesInRange(int startNum, int endNum)
{
    // Generate results as a list, then convert it to an array when returning
    List<int> primeNumbers = new List<int>();
    for (int i = startNum; i <= endNum; i++)
    {
        bool isPrime = true;
        for (int j = 2; j <= Math.Sqrt(i + 1); j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime && i > 1)
        {
            primeNumbers.Add(i);
        }
    }
    return primeNumbers.ToArray();

}
int start = 10;
int end = 100;
foreach (int number in FindPrimesInRange(start, end)){
    Console.Write($"{number} ");
}
