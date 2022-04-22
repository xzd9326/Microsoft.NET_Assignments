static void MostFrequentNumber(String nums)
{
    string[] inputList = nums.Split(' ');
    int n = inputList.Length;
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = Convert.ToInt32(inputList[i]);
    }

    int max = 0;
    int argMax = array[0];
    for (int i = 0; i < n; i++)
    {
        int tmp = array[i];
        int count = 0;
        for (int j = 0; j < n; j++)
        {
            if(array[j] == tmp)
            {
                count++;
            }
        }
        if (count > max)
        {
            argMax = tmp;
            max = count;
        }
    }
    Console.WriteLine($"The number {argMax} is the most frequent (occurs {max} times)");
}

//string input = "4 1 1 4 2 3 4 4 1 2 4 9 3";
string input = "7 7 7 0 2 2 2 0 10 10 10";
MostFrequentNumber(input);
