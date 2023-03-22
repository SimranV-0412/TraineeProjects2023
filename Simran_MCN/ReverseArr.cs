using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class ReverseArr
    {
        public void ReverseArrPro() 
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Array.Reverse(arr1);
            Console.WriteLine("ARR1 : ");
            foreach(int i in arr1)
            {
                Console.WriteLine(i);
                Console.WriteLine();
            }
            
        }
    }
}
