using System;
using AljabarLibraries;

namespace AplikasiKonsolAljabar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Demo Panggil Library Aljabar ---");

            // 1. Panggil AkarPersamaanKuadrat
            Console.WriteLine("\nMenghitung Akar Persamaan Kuadrat x^2 - 3x - 10 = 0");
            double[] persamaanKuadrat = { 1, -3, -10 };
            double[] akar = Aljabar.AkarPersamaanKuadrat(persamaanKuadrat);
            Console.WriteLine($"Input: {{ {string.Join(", ", persamaanKuadrat)} }}");
            if (!double.IsNaN(akar[0])) // Cek apakah akarnya valid (bukan NaN)
            {
                Console.WriteLine($"Output Akar: {{ {akar[0]}, {akar[1]} }}");
            }

            // 2. Panggil HasilKuadrat
            Console.WriteLine("\nMenghitung Hasil Kuadrat dari (2x - 3)^2");
            double[] persamaanLinear = { 2, -3 };
            double[] hasilKuadrat = Aljabar.HasilKuadrat(persamaanLinear);
            Console.WriteLine($"Input: {{ {string.Join(", ", persamaanLinear)} }}");
            // Outputnya koefisien a^2, 2ab, b^2
            Console.WriteLine($"Output Koefisien Hasil Kuadrat: {{ {hasilKuadrat[0]}, {hasilKuadrat[1]}, {hasilKuadrat[2]} }}");
            Console.WriteLine($"Bentuk persamaannya: {hasilKuadrat[0]}x^2 + ({hasilKuadrat[1]})x + ({hasilKuadrat[2]})");


            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}