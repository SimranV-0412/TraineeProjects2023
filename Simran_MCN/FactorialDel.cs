using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class FactorialDel
    {
        public delegate void dele(int n);
        public void Factorial(int b)
        {
            int a = 1, f = 1;
            
            Console.WriteLine("Factorial");
            while (a <= b)
            {
                f = f * a;
                a++;
                Console.WriteLine(f);
            }
            Console.ReadLine();
        }
        //public static void Main(string[] args)
        //{
        //    FactorialDel objfact = new FactorialDel();
        //    dele dobj = new dele(objfact.Factorial);
        //    Console.WriteLine("Enter The NUmber");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    dobj(num);
        //    Console.ReadLine();
        //}
    }
}
