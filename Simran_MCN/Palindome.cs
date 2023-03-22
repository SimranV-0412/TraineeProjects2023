using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class Palindome
    {
        public void Palindomepro() 
        {
            int n, r, sum = 0, t;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            t = n;
            while(n>0)
            {
                r = n % 10;
                n = n / 10;
                sum= sum*10 + r;
            }
            if(t==sum)
            {
                Console.WriteLine(" palindome ");
            }
            else
            {
                Console.WriteLine(" not palindome");
            }
            
        }
    }
}
