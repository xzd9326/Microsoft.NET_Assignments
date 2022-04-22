static void SumOfKRotations()
{
    Console.WriteLine("Please input an array of n integers, space separated on a single line:");
    string input = Console.ReadLine();
    Console.WriteLine("Please input an integer k");
    int k = Convert.ToInt32(Console.ReadLine());
    string[] inputList = input.Split(' ');
    int n = inputList.Length;
    int[] array = new int[n];
    int[] sum = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = Convert.ToInt32(inputList[i]);
    }

    for (int r = 1; r <= k; r++)
    {
        for (int l = 0; l < n; l++)
        {
            sum[(l + r) % n] += array[l];
        }
    }
    foreach (int num in sum)
    {
        Console.Write($"{num} ");
    }
}

SumOfKRotations();