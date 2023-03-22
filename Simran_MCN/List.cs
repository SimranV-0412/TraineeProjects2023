using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class List
    {
        public void ListPro()
        {
            List<string> name = new List<string>() { "red", "black", "blue" };
            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.ReadLine();
        }
    }
}
