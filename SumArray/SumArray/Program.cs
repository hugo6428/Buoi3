namespace SumArray
{
    internal class SumArray
    {
        static void Main()
        {
            int n = 10;
            int option = 0;
            do
            {
                Console.WriteLine("Choose calculation method (1 for recursive, 2 for iterative): ");
                option = Convert.ToInt32(Console.ReadLine());
                if(option != 1 && option != 2)
                {
                    Console.WriteLine("Wrong!! Choose again.");
                }   
            } while (option != 1 && option !=2);

            int result = 0;
            if (option == 1)
            {
                result = SumRecursive(n);
                Console.WriteLine($"Sum from 1 to {n} with Recursive = {result}");
            }
            else
            {
                result = SumIterative(n);
                Console.WriteLine($"Sum from 1 to {n} with Iterative = {result}");
            }
        }

        static int SumRecursive(int n)
        {
            if (n <= 1)
                return n;
            int sum = n + SumRecursive(n - 1);
            return sum;
        }
        static int SumIterative(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
