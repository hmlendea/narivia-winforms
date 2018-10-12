using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Narivia
{
    public class MinMax
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int Average { get { return (Min + Max) / 2; } }
        public int Random
        {
            get
            {
                Random rnd = new Random();
                return rnd.Next(Min, Max + 1);
            }
        }
        public int Total { get { return Min + Max; } }

        public MinMax(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }
}
