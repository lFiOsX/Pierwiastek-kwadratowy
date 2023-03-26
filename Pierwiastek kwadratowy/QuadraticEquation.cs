using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spr_pierw_kwadrat
{
    public class QuadraticEquation
    {
        public void calculationOfDeltaZeros(int a, int b, int c)
        {
            double delta, x0, x1, x2 = 0;
            delta = b * b - 4 * a * c;

            switch (delta)
            {
                case < 0:
                   
                    Console.WriteLine($"delta = {delta}\n Delta mniejsza od zera, brak miejsc zerowych.");
                    break;

                case 0:
                  
                    x0 = -b / 2 * a;

                    Console.WriteLine($"delta = {delta} \nMiejsce zerowe x0 = {Math.Round(x0, 2)}");
                    break;
                case > 0:
                    
                    x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b + Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine($"delta = {delta} \nMiejsca zerowe to:" +
                        $"\nx1 = {Math.Round(x1, 2)} \nx2 = {Math.Round(x2, 2)}");
                    break;

            }
        }
    }
}

