using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hinaliA2QA
{
  public  class TriangleSolver
    {
        
        public string Analyze(int int1, int int2, int int3)
        {
            if (int1 == int2 && int2 == int3)
            {
                return "Equilateral";
            }
            else if (int1 == int2 || int1 == int3|| int2 == int3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
        public TriangleSolver()
        {

        }
    }

}
   