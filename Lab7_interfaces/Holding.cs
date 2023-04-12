using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_interfaces
{
    abstract class Holding
    {
        public Person Owner { get; set; }  // владелец
        public double Cost { get; set; }  // стоимость
        public double AreaCost { get; set; } 
    }
}
