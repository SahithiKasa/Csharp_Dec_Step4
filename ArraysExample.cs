using System;
namespace ArraysExample
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 40, 10, 30, 20, 30, 50 };

            Console.WriteLine("Original Array:");
            Print(numbers);

            // 1. Sort
            Array.Sort(numbers);
            Console.WriteLine("\n1. After Sort:");
            Print(numbers);

            // 2. Reverse
            Array.Reverse(numbers);
            Console.WriteLine("\n2. After Reverse:");
            Print(numbers);

            // 3. IndexOf
            int index1 = Array.IndexOf(numbers, 30);
            Console.WriteLine($"\n3. First index of 30: {index1}");

            // 4. LastIndexOf
            int index2 = Array.LastIndexOf(numbers, 30);
            Console.WriteLine($"4. Last index of 30: {index2}");

            // 5. Resize (increase array size)
            Array.Resize(ref numbers, 8);
            Console.WriteLine("\n5. After Resize to length 8:");
            Print(numbers);

            // 6. Copy
            int[] copyArray = new int[5];
            Array.Copy(numbers, copyArray, 5);
            Console.WriteLine("\n6. Copied first 5 elements:");
            Print(copyArray);

            // 7. Clear
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("\n7. After Clear first 2 elements:");
            Print(numbers);

            // 8. Find
            int firstAbove25 = Array.Find(numbers, x => x > 25);
            Console.WriteLine($"\n8. First number > 25: {firstAbove25}");

            // 9. FindAll
            int[] above20 = Array.FindAll(numbers, x => x > 20);
            Console.WriteLine("\n9. All numbers > 20:");
            Print(above20);

            // 10. Exists
            bool exists = Array.Exists(numbers, x => x == 50);
            Console.WriteLine($"\n10. Is 50 present in array? {exists}");

            int[] nums = { 10, 20, 30 };
            int[] copy = (int[])nums.Clone();
            Console.WriteLine(copy);
            Print(nums);
        }

        static void Print(int[] arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}