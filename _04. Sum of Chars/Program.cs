using System;

namespace _04._Sum_of_Chars {
    class Program {
        static void Main(string[] args) {
            int nums = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < nums; i++)
                sum += Console.ReadLine()[0];
            
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}