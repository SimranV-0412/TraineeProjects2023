using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class DtoB
    {
        public void DecimalBinary()
        {
            int n, i;
            int[]a=new int[10];
            Console.WriteLine("enter number");
            n=Convert.ToInt32(Console.ReadLine());
            for( i=0;n>0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.WriteLine("binary");
            for(i=i-1;i>=0;i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
