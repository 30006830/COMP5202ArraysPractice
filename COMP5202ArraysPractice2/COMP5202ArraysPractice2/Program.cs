using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP5202ArraysPractice2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("==================================================");
            Console.WriteLine("=================Name Arrays!!!!!=================");
            Console.WriteLine("==================================================");

            string[] names = new string[5];

            for(int i =0; i < names.Length; i++)
            {
                Console.WriteLine("Please Enter a name to be recorded to the array!: \n");
                names[i] = Console.ReadLine();
            }

            int size = 10;
            int[] nums = new int[size];
            Random rand = new Random();
            double total = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 10);
                total += nums[i];
            }
            Console.WriteLine($"The average of the 10 numbers selected is: {total/nums.Length}");
            
            Console.ReadLine();
        }
    }
}
