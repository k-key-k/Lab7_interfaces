using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_interfaces
{
    // здания, сооружения
    internal class Building : Holding, INalog
    {
        public string Address { get; set; } // адрес

        public Building(string address, double cost)
        {
            this.Address = address;
            Cost = cost;
        }
        public Building() : this("", 0.0) { }
        public double GetNalog()
        {
            double nalog = 0.1 / 100;
            return Cost * nalog;
        }

    }
}
