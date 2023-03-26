using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierwiastek_kwadratowy
{
    public class QuadraticEquation
    {
        public double x0 { get; set; }
        public double x1 { get; set; }
        public double x2 { get; set; }
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }


        public double calcDelta(int a, int b, int c)
        {
            double delta = 0;
            // obliczanie delty ze wzoru: D = b^2 - 4ac
            delta = b * b - 4 * a * c;

            return delta;

        }

        public void calcDeltaZeros(int a, int b, int c)
        {
            double delta = 0;

            delta = calcDelta(a, b, c);

            // Oblicznie miejsc zerowych dla poszczególnych przypadków.
            switch (delta)
            {
                case < 0:
                    //gdy delta < 0
                    Console.WriteLine($"delta = {delta}\n Delta mniejsza od zera, brak miejsc zerowych.");
                    //Spreparowane dane dla testów
                    x0 = 8;
                    x1 = 16;
                    x2 = 32;
                    break;

                case 0:
                    // gdy delta = 0
                    // x0 = -b/2a
                    x0 = -b / 2 * a;

                    Console.WriteLine($"delta = {delta} \nMiejsce zerowe x0 = {Math.Round(x0, 2)}");
                    break;
                case > 0:
                    // gdy delta > 0
                    // x1 = (-b-pierw(D))/2a
                    // x2 = (-b+pierw(D))/2a
                    x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b + Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine($"delta = {delta} \nMiejsca zerowe to:" +
                        $"\nx1 = {Math.Round(x1, 2)} \nx2 = {Math.Round(x2, 2)}");
                    break;

            }




        }
    }
}

