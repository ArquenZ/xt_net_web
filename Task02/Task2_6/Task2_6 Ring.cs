using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task2_1.Program;

namespace Task2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод по умолчанию");
            Ring MyRing = new Ring();
            //MyRing.Radius2 = 12;
            //MyRing.Radius = 12;
            MyRing.ShowInfo();
        }
        public class Ring: Round
        {
            private double radius2;
            public double Radius2
            {
                get => radius2;
                set
                {
                    if (value > 0)
                    {
                        radius2 = value;
                        area = GetArea();
                        circle = GetCircle();
                    }
                    else Except();
                }
            }
            public Ring():base()
            {                
                radius2 = 2;
                area = GetArea();
                circle = GetCircle();
            }
            public Ring(int x, int y, double r, double r2):base(x,y,r)
            {                
                if (r2 >= 0) radius2 = r2;
                else Except();
                area = GetArea();
                circle = GetCircle();
            }
            public Ring(Point p, double r, double r2):base(p, r)
            {
                if (r2 >= 0) radius2 = r2;
                else Except();
                area = GetArea();
                circle = GetCircle();
            }
            protected override double GetCircle()
            {
                return (2 * Math.PI * (radius))+ (2 * Math.PI * (radius2));
            }
            protected override double GetArea()
            {
                return Math.Abs(Math.PI * Math.Pow(radius, 2)-Math.PI* Math.Pow(radius2, 2));
            }
            public override void ShowInfo()
            {
                Console.WriteLine("Координаты центра Х = {0}, Y = {1}, " +
                    "\nРадиус1 = {2}" +
                    "\nРадиус2 = {3}" +
                    "\nДлинна окружностей = {4}" +
                    "\nПлощадь кольца = {5}" +
                    "\n____________________________________", abs, ord, radius, radius2, circle, area);
            }
        }
    }
}
