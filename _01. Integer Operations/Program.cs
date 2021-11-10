using System;

namespace _01._Integer_Operations {
    class Program {
        static void Main(string[] args) {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((num1 + num2) / num3 * num4);
        }
    }
}