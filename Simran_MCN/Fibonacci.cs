using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class Fibonacci
    {
        public int fib(int n)
        {
            int a = 0, b = 1, res = 0;
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            for (int i = 2; i <= n; i++)
            {
                res = a + b;
                a = b;
                b = res;
            }
            return res;
        }
    }
}
