using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();            
            triangle.ShowInfo();
            triangle = new Triangle(2,3,2);
            triangle.A = 3;
            triangle.ShowInfo();
        }
        public class Triangle
        {
            private double a;
            private double b;
            private double c;
            public Triangle()
            {
                a = 1;
                b = 1;
                c = 1;
            }
            public Triangle(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public double A
            {
                get
                {
                    return a;
                }
                set
                {
                    if ((Math.Abs(value) != 0) && (Math.Abs(value) < (b + c)))
                    {
                        a = Math.Abs(value);
                    }
                    else
                    {
                        Except();
                    }
                }
            }
            public double B
            {
                get
                {
                    return b;
                }
                set
                {
                    if ((Math.Abs(value) != 0) && (Math.Abs(value) < (a + c)))
                    {
                        b = Math.Abs(value);
                    }
                    else
                    {
                        Except();
                    }
                }
            }
            public double C
            {
                get
                {
                    return c;
                }
                set
                {
                    if ((Math.Abs(value) != 0) && (Math.Abs(value) < (a + b)))
                    {
                        c = Math.Abs(value);
                    }
                    else
                    {
                        Except();
                    }
                }
            }

            private static void Except()
            {
                throw new ArgumentException("Некорректная длинна");
            }

            public double Perimetr
            {
                get
                {
                    return a + b + c;
                }
            }

            public double Area
            {
                get
                {
                    double p = (a + b + c) / 2;
                    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }
            }

            public void ShowInfo()
            {
                Console.WriteLine("Сторона А = {0}"+
                    "\nСторона B = {1}" +
                    "\nСторона С = {2}" +
                    "\nПериметр = {3}" +
                    "\nПлощадь = {4}",a,b,c,Perimetr,Area);
            }
        }        
    }
}
