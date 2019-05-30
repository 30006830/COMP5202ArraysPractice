using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreArraysPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("==================================================");
            Console.WriteLine("=================Arrays Exercises=================");
            Console.WriteLine("==================================================\n");

            Console.WriteLine("50 random numbers!!");
            int size = 50;
            int[] nums = new int[size];
            Random rand = new Random();

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 100);
            }
            Display(nums);

            Console.WriteLine($"The value is located at index {FindIndex(nums)}");
            Console.WriteLine("Press enter to continue..");

            Console.ReadLine();

            Console.WriteLine("A deep copy of the nums array!");
            int[] copiedArray = new int[nums.Length];
            Array.Copy(nums, copiedArray, nums.Length);
            Display(copiedArray);

            Array.Sort(copiedArray);
            Console.WriteLine("===Order of Sorts===");
            Display(copiedArray);
            Console.WriteLine("===Order of Reverse===");
            Array.Reverse(copiedArray);
            Display(copiedArray);
        }

        static int FindIndex(int[] arr)
        {
            Console.WriteLine("What value would you like to find?: ");
            int input = int.Parse(Console.ReadLine());
            return Array.IndexOf(arr, input);
        }

        static void Display (int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}");
                if ((i + 1) % 5 == 0)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
