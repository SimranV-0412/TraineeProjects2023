using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class PrimeDel
    {
        public delegate void del2(int n);
        public void PrimeNumPro()
        {
            int n, a = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (n % 2 == 0)
                    a++;
            }
            if (a == 2)
            {
                Console.WriteLine("Not a prime number.");
            }
            else
            {
                Console.WriteLine("Prime number.");
            }
        }
        public void main(string[] args)
        {
            PrimeDel object2 = new PrimeDel();
            del2 del2Obj = new del2(object2.PrimeNumPro);
            del2Obj
        }
    }
}
