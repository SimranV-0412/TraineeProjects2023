using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simran_MCN
{
    public class ReverseStr
    {
        public string reversestrpro(string str)
        {
            char[] str1 = str.ToCharArray();
            char[] res = new char[str1.Length];  
            for(int i =0,j=str.Length-1; i<str.Length ;i++,j--)
            {
                res[i] = str1[j];
            }
            return new string (res);
        }
    }
}
