using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class PalindomeDel
    {
        public delegate void del(int n);
        public void Palindome(int n)
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
                Console.WriteLine(" palindome ");
            }
            else
            {
                Console.WriteLine(" not palindome");
            }

        }
        //public static void Main(string[] args)
        //{
        //    PalindomeDel obj = new PalindomeDel();
        //    del delObj = new del(obj.Palindome);
        //    Console.WriteLine("enter a number");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    delObj(n);
        //    Console.ReadLine();
        //}
    }
}
