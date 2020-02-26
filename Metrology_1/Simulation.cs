using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrology_1
{
    ///<summary>
    ///Класс для вероятностного моделирования процесса написания программы программистом
    ///</summary>
    public class Simulation
    {
        public Simulation()
        { }
        ///<summary>
        ///n - длина словаря, exNumber - начальное число экспериментов
        ///</summary>
        public static double[] Sim(int n, double exNumber)
        {
            ///<summary>
            ///kvantil - квантиль равномерного распределения для заданных параметров
            ///result - массив с результатами моделирования
            ///sumQ2 - сумма квадратов переменной q2
            ///random - объект класса Random для проведения симуляции
            ///countSymbols - счётчик длины программы
            ///mas - массив для симуляции
            ///</summary>
            double kvantil = 1.9623391; // a = 95, n = 1000
            double[] result = new double[7];
            double sumQ2 = 0;
            Random random = new Random();
            double countSymbols = 0.0;

            bool[] mas = new bool[n];

            for (int i = 0; i < exNumber; i++) // симуляция написания программы
            {
                int count = n;
                Array.Clear(mas, 0, count);
                int previous = -1;
                double q2 = 0;

                while (count != 0)
                {
                    int r = random.Next(0, n);

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
            result[0] = (double)countSymbols / exNumber; // длины программы (эмпирическая)
            result[1] = (sumQ2 - (countSymbols * countSymbols) / exNumber) / (exNumber - 1); // дисперсия (эмпирическая)
            result[2] = Math.Sqrt(result[1]) / result[0]; // погрешность (эмпирическая)
            result[3] = 0.9 * n * Math.Log(n, 2); // длина программы (смоделированная)
            result[4] = (Math.PI * Math.PI * n * n) / 6.0; // дисперсия (смоделированная)
            result[5] = 1 / (2 * Math.Log(n, 2)); // погрешность (смоделированная)
            result[6] = exNumber; // итоговое число экспериментов

            double N = GetN(kvantil, result[1], 0.1); // расчёт числа реализаций

            if (N < exNumber) return result; // условие проведения новой симуляции
            else return Sim(n, N);
        }
        ///<summary>
        ///Расчёт нового числа реализаций
        ///kvantil - квантиль равномерного распределения для заданных параметров,
        ///dispersion - дисперсия,
        ///epsilon - величина ошибки
        ///</summary>
        static double GetN(double kvantil, double dispersion, double epsilon)
            => (kvantil * kvantil * dispersion / (epsilon * epsilon)) + 1;
    }
}