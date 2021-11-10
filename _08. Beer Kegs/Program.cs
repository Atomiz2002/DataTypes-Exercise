using System;

namespace _08._Beer_Kegs {
    class Program {
        static void Main(string[] args) {
            int loops = Convert.ToInt32(Console.ReadLine());
            string topModel = "";
            double topVolume = 0;

            for (int i = 0; i < loops; i++) {
                string model = Console.ReadLine();
                double radius = Convert.ToDouble(Console.ReadLine());
                int height = Convert.ToInt32(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > topVolume) {
                    topModel = model;
                    topVolume = volume;
                }
            }

            Console.WriteLine(topModel);
        }
    }
}