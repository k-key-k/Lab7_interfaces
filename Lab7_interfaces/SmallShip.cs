using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_interfaces
{
    // лодка, катер
    internal class SmallShip : Transport
    {
        public string BoatType { get; set; }
        public int Paddle { get; set; } // количество вёсел в лодке
        public double Power { get; set; } // мощность двигателя в л.с.        

        public SmallShip(string boattype, int pad, double power, double cost)
        {
            BoatType = boattype;
            Paddle = pad;
            Power = power;
            Cost = cost;
        }
        public SmallShip() : this("", 0, 0.0, 0.0) { }
        public double GetNalog()
        {
            double nalog = 0.0;
            if (BoatType == "Катер" || BoatType == "Яхта" || BoatType == "Моторная лодка")
            {
                if (Power < 100.0)
                {
                    nalog = Cost * (10.0 / 100.0);
                }
                else if (Power >= 100.0 && Power < 300.0)
                {
                    nalog = Cost * (20.0 / 100.0);
                }                
                else
                {
                    nalog =  Cost * (200.0 / 100);
                }
            }
            else if (BoatType == "Гидроцикл") 
            {
                if (Power < 100.0)
                {
                    nalog = Cost * (25.0 / 100.0);
                }
                else if (Power >= 100.0 && Power < 150.0)
                {
                    nalog = Cost * (50.0 / 100.0);
                }
                else
                {
                    nalog = Cost * (250.0 / 100);
                }
            }
            return nalog;
        }
    }
}
