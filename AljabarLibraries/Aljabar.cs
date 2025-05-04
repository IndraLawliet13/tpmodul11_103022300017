using System;
namespace AljabarLibraries
{
    public static class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            // persamaan[0] = a, persamaan[1] = b, persamaan[2] = c
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            // Hitung diskriminan
            double diskriminan = (b * b) - (4 * a * c);
            double[] akar = new double[2];

            if (diskriminan >= 0)
            {
                akar[0] = (-b + Math.Sqrt(diskriminan)) / (2 * a);
                akar[1] = (-b - Math.Sqrt(diskriminan)) / (2 * a);
            }
            else
            {
                akar[0] = double.NaN;
                akar[1] = double.NaN;
                Console.WriteLine("Akar imajiner tidak dihitung.");
            }
            return akar;
        }

        // Fungsi hitung hasil kuadrat (ax + b)^2 = a^2x^2 + 2abx + b^2
        public static double[] HasilKuadrat(double[] persamaan)
        {
            // persamaan[0] = a, persamaan[1] = b
            double a = persamaan[0];
            double b = persamaan[1];

            double[] hasil = new double[3];
            hasil[0] = a * a;       // a^2
            hasil[1] = 2 * a * b;   // 2ab
            hasil[2] = b * b;       // b^2

            return hasil;
        }
    }
}
