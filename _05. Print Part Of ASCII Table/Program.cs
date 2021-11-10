using System;

namespace _05._Print_Part_Of_ASCII_Table {
    class Program {
        static void Main(string[] args) {
            int start = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= end - start; i++)
                Console.Write((char) (start + i) + " ");
        }
    }
}