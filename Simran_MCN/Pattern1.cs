using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class Pattern1
    {
        public void Pattern1pro()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
