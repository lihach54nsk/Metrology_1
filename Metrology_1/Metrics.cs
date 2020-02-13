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

        public static double Gilb(int N, int Ca) => (double)Ca / N;
    }
}
