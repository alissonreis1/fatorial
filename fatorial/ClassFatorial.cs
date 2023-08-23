using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatorial
{
    public class Fatorial
    {
        public int CalculoFatorial(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            else
                return num * CalculoFatorial(num - 1);
        }
    }

}    
    
