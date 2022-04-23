namespace Fibonacci
{
    public class FibonacciNumber
    {
        static int Fibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }


        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }

}