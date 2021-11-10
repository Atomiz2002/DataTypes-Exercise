using System;

namespace _06._Triples_of_Latin_Letters {
    class Program {
        static void Main(string[] args) {
            int letters = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < letters; i++) {
                for (int j = 0; j < letters; j++) {
                    for (int k = 0; k < letters; k++) {
                        Console.Write((char) (i + 97));
                        Console.Write((char) (j + 97));
                        Console.WriteLine((char) (k + 97));
                    }
                }
            }
        }
    }
}