using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrology_1
{
    public class Simulation
    {
        public Simulation()
        { }

        public static double[] Sim(int n1, int n2, int exNumber)
        {
            double[] result = new double[6];
            double sumQ2 = 0;
            Random random = new Random();
            int countSymbols = 0;

            bool[] mas = new bool[n1 + n2];

            for (int i = 0; i < exNumber; i++)
            {
                int count = n1 + n2;
                Array.Clear(mas, 0, count);
                int previous = -1;
                double q2 = 0;

                while (count != 0)
                {
                    int r = random.Next(0, n1 + n2);

                    if (r == previous)
                        continue;

                    previous = r;

                    if (mas[r] == false)
                    {
                        mas[r] = true;
                        count--;
                    }
                    countSymbols++;
                    q2++;
                }
                sumQ2 += q2 * q2;
            }
            double mathT = 0.9 * (n1 + n2) * Math.Log(n1 + n2, 2);
            double dispT = Math.PI * Math.PI * (n1 + n2) * (n1 + n2) / 6;
            double errorT = 1 / (2 * Math.Log(n1 + n2, 2));
            result[0] = (double)countSymbols / exNumber;
            result[1] = (sumQ2 - result[0]) / (exNumber * (n1 + n2 - 1));
            result[2] = Math.Sqrt(result[1] / result[0]);
            result[3] = mathT;
            result[4] = dispT;
            result[5] = errorT;

            return result;
        }
    }
}