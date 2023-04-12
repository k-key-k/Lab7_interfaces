using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_interfaces
{
    internal class Stead : Holding, INalog
    {
        // участокземли
        public double Area { get; set; } // площадь        

        public Stead (double a, double cost)
        {
            Area = a;
            Cost = cost;
        }

        public Stead() : this(0.0, 0.0) { }

        public double GetNalog()
        {
            double nalog = 0.3 / 100;
            return Cost * nalog;
        }
    }
}
