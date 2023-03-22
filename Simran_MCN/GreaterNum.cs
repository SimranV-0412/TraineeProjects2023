using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class GreaterNum
    {
        public void GreaterNumPro()
        {
            int n1, n2, n3;
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("n1 is greatest.");
            }
            else if (n2 > n3 && n2 > n1)
            {
                Console.WriteLine("n2 is gratest.");
            }
            else
            {
                Console.WriteLine("n3 is gratest.");
            }
        }   
    }

}
