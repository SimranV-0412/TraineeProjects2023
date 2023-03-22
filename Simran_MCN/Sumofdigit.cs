using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class Sumofdigit
    {
        public void SumofdigitPro() 
        {
            int[] arr = { 1, 2, 3, };
            int sum = 0;
            Array.ForEach(arr, i => sum = sum + i);
            Console.WriteLine(sum);
            Console.ReadLine();        
        }
    }
}
