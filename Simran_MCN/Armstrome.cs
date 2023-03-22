using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
     public class Armstrome
    {
        public void ArmPro()
        {
            int num, rem, t, sum = 0;
            Console.WriteLine("enter any num");
            num = Convert.ToInt32(Console.ReadLine());
            t = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }
            if(t==sum)
            {
                Console.WriteLine("Armstrong");
            }
            else
            {
                Console.WriteLine("not armstrong");
            }
            Console.ReadLine();
        }
    }
}
