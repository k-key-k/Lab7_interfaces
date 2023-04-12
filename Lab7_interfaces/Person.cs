using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_interfaces
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        private char gender; 
        public char Gender { get{ return gender; } set{ if (value == 'ж') gender = value; else gender = 'м'; } }
            
        public Person() : this( "noname", "", new DateTime(), 'м') { }
        public Person(string fn, string sn, DateTime d, char s)
        {
            FirstName = fn;
            LastName = sn;
            BirthDay = d;
            Gender = s;
        }
        // расчет возраста
        public int Age()
        {
            int a = DateTime.Today.Year - BirthDay.Year;
            if (BirthDay.Month > DateTime.Today.Month || (BirthDay.Month == DateTime.Today.Month && BirthDay.Day > DateTime.Today.Day))
                a--;
            return a;
        }
    }
}
