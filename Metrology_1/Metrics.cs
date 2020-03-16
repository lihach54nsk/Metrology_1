using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrology_1
{
    public class Metrics
    {
        public Metrics()
        { }

        public static int MacKeib(int E, int N, int p) => E - N + p;

        public static double Gilb(double N, double Ca) => Math.Round(Ca / N, 2);

        public static double GlobalVarUse(int P, int A) => (double)A / P;

        public static double Chepin(int P, int M, int C, int T) => Math.Round(P + 2 * M + 3 * C + 0.5 * T, 2);

        public static double Comments(double Ncom, double Nlength) => Math.Round(Ncom / Nlength, 2);

        public static double Mills(int m, int n, int M)
        {
            double C_self, C_fake;
            double N = Math.Round(((double)n * M) / m); // всего ошибок в коде

            if (n > N) return 1;
            else
            {
                C_fake = P(M, m - 1);
                C_self = P(M + (int)N + 1, m + (int)N);

                return (double)(C_fake / C_self);
            }
        }

        public static double N(int m, int n, int M) => Math.Round(((double)n * M) / m);

        public static double HabrMills(int m, int n, int M)
        {
            double N = ((double)n * M) / m; // всего ошибок в коде

            if (n > N) return 1;
            return ((double)M / (M + N + 1));
        }

        static double P(int a, int b) => (double)(Factorial(a)) / (Factorial(b) * (Factorial(a - b)));

        static int Factorial(int number)
        {
            int result = number;
            if (number == 0) return 1;

            for (int i = number - 1; i != 0; i--)
                result *= i;
            return result;
        }
        public static string Span(string input)
        {
            string[] parsed = input.Split(new char[] { ' ', '\0' }, StringSplitOptions.RemoveEmptyEntries);

            int[] spans = new int[parsed.Length];
            double sum = 0;

            for (int i = 0; i < spans.Length; i++)
                spans[i] = Convert.ToInt32(parsed[i]);

            foreach (var a in spans)
                sum += a;

            return (Math.Round(sum / spans.Length, 2)).ToString();
        }
    }
}