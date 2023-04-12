using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_interfaces
{
    // транспортное средство
    internal class Transport : Holding
    {
        public string Name { get; set; }  // название
        public double Capacity { get; set; } // грузоподъемность
}
}
