using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviary
{
    class ROResultPair
    {
        public double ROUsed;
        public string Result;

        public ROResultPair(double ro, string result )
        {
            ROUsed = ro;
            Result = result;
        }
    }
}
