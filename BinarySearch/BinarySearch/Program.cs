namespace BinarySearch
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 1, 3, 6, 7, 9, 10, 15, 19, 24, 30 };
            int target = 0;
            Console.WriteLine("Input target number: ");
            target = Convert.ToInt32(Console.ReadLine());

            int option = 0;
            do
            {
                Console.WriteLine("Select search method (1 for recursive, 2 for iterative): ");
                option = Convert.ToInt32(Console.ReadLine());
                if (option != 1 && option != 2)
                {
                    Console.WriteLine("Wrong!! Choose again.");
                }
            } while (option != 1 && option != 2);
            int result = 0;
            if (option == 1)
                result = BinarySearchRecursive(arr, target, 0, arr.Length - 1);
            else
                result = BinarySearchIterative(arr, target);
            if (result != -1)
                Console.WriteLine($"Element found at index: {result}");
            else
                Console.WriteLine("Element not found.");
        }

        static int BinarySearchRecursive(int[] arr, int target, int left, int right)
        {
            if (left > right)
                return -1;

            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] > target)
                return BinarySearchRecursive(arr, target, left, mid - 1);
            else
                return BinarySearchRecursive(arr, target, mid + 1, right);
        }
        static int BinarySearchIterative(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] > target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return -1;
        }
    }
}
