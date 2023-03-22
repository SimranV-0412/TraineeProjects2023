using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class Average
    {
        public void Averagepro()
        {
            int n1, n2, n3;
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            int avg;
            avg = n1 + n2 + n3;
            avg = avg / 3;
            Console.WriteLine(avg);
        }
    }
}
