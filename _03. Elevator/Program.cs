using System;

namespace _03._Elevator {
    class Program {
        static void Main(string[] args) {
            double people = Convert.ToInt32(Console.ReadLine());
            double capacity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(people / capacity));
        }
    }
}