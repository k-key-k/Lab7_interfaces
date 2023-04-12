using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_interfaces
{
    // гужевой транспорт (лошадь)
    internal class Horse : Transport
    {
        public string Name { get; set; }    
        public int Age { get; set; }
        public double Weight { get; set; }

        public Horse(string name, int age, double weight, double cost)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Cost = cost;
        }
        public Horse() : this("", 0, 0.0, 0.0) { }
    }
}
