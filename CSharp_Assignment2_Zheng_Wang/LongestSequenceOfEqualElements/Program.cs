static void LongestEqualSequence()
{
    Console.WriteLine("Please input an array of n integers, space separated on a single line:");
    string input = Console.ReadLine();
    string[] inputList = input.Split(' ');
    int n = inputList.Length;
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = Convert.ToInt32(inputList[i]);
    }

    int count = 0;
    int max = 1;
    int argMax = array[0];
    int curr = array[0];

    for (int i = 0; i < n; i++)
    {
        if (array[i] == curr)
        {
            count++;
            if (count > max)
            {
                max = count;
                argMax = curr;
            }
        }
        else
        {
            curr = array[i];
            count = 1;
        }
    }
    Console.WriteLine("Longest sequence of equal elements is:");
    for (int i = 0; i < max; i++)
    {
        Console.Write($"{argMax} ");
    }
}

LongestEqualSequence();
