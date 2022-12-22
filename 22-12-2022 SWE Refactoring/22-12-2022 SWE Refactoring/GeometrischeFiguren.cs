using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_12_2022_SWE_Refactoring
{
    internal class GeometrischeFiguren
    {
        //Rename variable

        protected double a;
        protected double b;
        protected double c;


        protected GeometrischeFiguren(double a)
        {
            this.a = a;
        }
        protected GeometrischeFiguren(double a, double b): this(a)
        {
            this.a = a;
            this.b = b;
        }
        protected GeometrischeFiguren(double a, double b, double c) : this(a, b)
        {
            this.a = a;
            this.b = b;
            this.c = c; 
        }

        public double A
        {   
            get { return a; }
        }
        public double B
        {
            get { return b; }
        }

        public double OberflaecheRechnen(int a, int b)
        {
            int oberflaeche = a * b;
            return oberflaeche;
        }

    }
}
