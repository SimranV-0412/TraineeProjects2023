using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class AmstomeDel
    {
        public delegate void del(int n);
        public void A(int n)
        {
            int r, sum = 0, t;

            t = n;
            while (n > 0)
            {
                r = n % 10;
                n = n / 10;
                sum = sum * 10 + r;
            }
            if (t == sum)
            {
                Console.WriteLine(" Armstome ");
            }
            else
            {
                Console.WriteLine(" not Armstome");
            }

        }
        //public static void Main(string[] args)
        //{
        //    AmstomeDel obj = new AmstomeDel();
        //    del delObj = new del(obj.A);
        //    Console.WriteLine("enter a number");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    delObj(n);
        //    Console.ReadLine();
        //}
    }
}

