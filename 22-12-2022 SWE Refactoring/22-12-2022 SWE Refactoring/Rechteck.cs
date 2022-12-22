using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_12_2022_SWE_Refactoring
{
    internal class Rechteck
    {
        private double a;
        private double b;
        private double c;

        public Rechteck(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A
        {
            get{ return a; }
        }
        public double B
        {
            get{ return b; }
        }

        public double C 
        { 
            get{ return a * b ; }
        }
    }
}
