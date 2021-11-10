using System;

namespace _07._Water_Overflow {
    class Program {
        static void Main(string[] args) {
            int capacity = 255;
            int pours = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < pours; i++) {
                int pour = Convert.ToInt32(Console.ReadLine());

                if (pour > capacity)
                    Console.WriteLine("Insufficient capacity!");
                else
                    capacity -= pour;
            }

            Console.WriteLine(255 - capacity);
        }
    }
}