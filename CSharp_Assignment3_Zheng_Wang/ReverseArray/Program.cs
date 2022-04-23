namespace ReverseArray
{
    public class ArrayReversal
    {
        static int[] GenerateNumbers(int n)
        {
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i;
            }
            Console.WriteLine($"Array of length {n} has been created");
            return numbers;
        }

        static void Reverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = tmp;
            }
            Console.WriteLine("Array has been reversed.");
        }

        static void PrintNumbers(int[] array)
        {
            Console.WriteLine("Print the array:");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }


        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(10);
            Reverse(numbers);
            PrintNumbers(numbers);
        }
    }

}
