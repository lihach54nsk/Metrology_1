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

        public static double Sim(int n1, int n2, int exNumber)
        {
            Random random = new Random();
            int countSymbols = 0;

            for (int i = 0; i < exNumber; i++)
            {
                int count = n1 + n2;
                bool[] mas = new bool[count];
                int previous = -1;

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
                }
            }
            return (double)countSymbols / exNumber;
        }
    }
}