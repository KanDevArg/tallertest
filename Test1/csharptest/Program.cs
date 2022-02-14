using System;
using System.Linq;

namespace csharptest
{
    public class Program
    {
        
        public static long sumN1AndReversedN2(long num1, long num2)
        {
            var n2Reversed = string.Join("", num2.ToString().Reverse());

            return num1 + Convert.ToInt64(n2Reversed);
        }    
        static void Main(string[] args)
        {
            var input = string.Empty;
            
            Console.WriteLine("Input #1 (long): ");
            input = Console.ReadLine();
            if (!long.TryParse(input, out var input1))
            {
                Console.WriteLine("Input 1 not valid");
                return;
            }
            
            Console.WriteLine("Input #2 (long): ");
            input = Console.ReadLine();
            if (!long.TryParse(input, out var input2))
            {
                Console.WriteLine("Input 2 not valid");
                return;
            }
            
            Console.WriteLine($"Result is : {sumN1AndReversedN2(input1, input2)}");
        }
    }
}

