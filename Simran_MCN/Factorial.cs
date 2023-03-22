using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class Factorial
    {
        public void FactorialPro()
        {
            int a = 1, f = 1;
            int b = 5;
            Console.WriteLine("Factorial");
            while (a <= b)
            {
                f = f * a;
                a++;
                Console.WriteLine(f);
            }
            Console.ReadLine();
        }

    }
}
