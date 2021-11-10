using System;

namespace _02._Sum_Digits {
    class Program {
        static void Main(string[] args) {
            string num = Console.ReadLine();
            int output = 0;

            for (int i = 0; i < num.Length; i++)
                output += Convert.ToInt32(num[i].ToString());

            Console.WriteLine(output);
        }
    }
}