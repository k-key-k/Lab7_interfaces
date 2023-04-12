using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_interfaces
{
    internal class Car : Transport
    {
        public string CarName { get; set; }
        public string CarType { get; set; }
        public double Power { get; set; } // мощность двигателя в л.с.

        public Car(string name, string cartype, double power, double cost)
        {
            CarName = name;
            CarType = cartype;
            Power = power;
            Cost = cost;
        }
        public Car() : this(""," ", 0.0, 0.0) { }
        public double GetNalog()
        {
            double nalog = 0.0;
            if (CarType == "Грузовой")
            {
                if (Power < 100.0)
                {
                    nalog = Cost * (2.5 / 100.0);
                }
                else if (Power >= 100.0 && Power < 150.0)
                {
                    nalog = Cost * (4.0 / 100.0);
                }
                else if (Power >= 150.0 && Power < 200.0)
                {
                    nalog = Cost * (5.0 / 100.0);
                }
                else if (Power >= 200.0 && Power < 250.0)
                {   
                    nalog = Cost * (6.5 / 100.0);
                }
                else
                {
                    nalog = Cost * (8.5 / 100);
                }
            }
            else if (CarType == "Легковой")
            {
                if (Power < 100.0)
                {
                    nalog = Cost * (2.5 / 100.0);
                }
                else if (Power >= 100.0 && Power < 150.0)
                {
                    nalog = Cost * (3.5 / 100.0);
                }
                else if (Power >= 150.0 && Power < 200.0)
                {
                    nalog = Cost * (5.0 / 100.0);
                }
                else if (Power >= 200.0 && Power < 250.0)
                {
                    nalog = Cost * (7.5 / 100.0);
                }
                else if (Power >= 250.0 && Power < 410.0)
                {
                    nalog = Cost * (15 / 100.0);
                }
                else
                {
                    nalog = Cost * (300 / 100);
                }
            }
            else if (CarType == "Мотоцикл")
            {
                if (Power < 20.0)
                {
                    nalog = Cost * (1.0 / 100.0);
                }
                else if (Power >= 20.0 && Power < 35.0)
                {
                    nalog = Cost * (2.0 / 100.0);
                }
                else if (Power >= 35.0 && Power < 150.0)
                {
                    nalog = Cost * (5.0 / 100.0);
                }
                else
                {
                    nalog = Cost * (25.0 / 100);
                }
            }
            if (CarType == "Автобус")
            {              
                if (Power < 200.0)
                {
                    nalog = Cost * (5.0 / 100.0);
                }
                else
                {
                    nalog = Cost * (10.0 / 100);
                }
            }
            if (CarType == "Снегоход")
            {
                if (Power < 50.0)
                {
                    nalog = Cost * (2.5 / 100.0);
                }
                else
                {
                    nalog = Cost * (5.0 / 100);
                }
            }
            return nalog;

        }
    }
}
