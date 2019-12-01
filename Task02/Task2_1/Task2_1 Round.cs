using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод по умолчанию");
            Round MyRound = new Round();            
            MyRound.ShowInfo();
            Console.WriteLine("Вывод свойства заданы вручную");
            MyRound.Abs = 12;
            MyRound.Ord = 14;
            MyRound.Radius = 5;
            MyRound.ShowInfo();
            Console.WriteLine("Вывод с заданными значениями через конструктор (Две координаты и радиус)");
            MyRound = new Round(3, 4, 4);            
            MyRound.ShowInfo();
            Console.WriteLine("Получение точки из круга с координатами Х = {0}, Y = {1}" +
                "\n________________________________", MyRound.GetCenter().Abs, MyRound.GetCenter().Ord);
            Console.WriteLine("Вывод с заданными значениями через конструктор (Точка и радиус");
            Point point = new Point(15, 22);
            MyRound = new Round(point, 64);
            MyRound.ShowInfo();
        }
        public struct Point
        {
            public int Abs { get; }
            public int Ord { get; }
           
            public Point(int x, int y)
            {
                Abs = x;
                Ord = y;
            }
        }

        public class Round
        {
            protected int abs;
            protected int ord;
            protected double radius;
            protected static double area;
            protected static double circle;            
            public int Abs { get => abs; set => abs = Math.Abs(value); }
            public int Ord { get => ord; set => ord = Math.Abs(value); }
            public double Radius
            {
                get => radius;
                set
                {
                    if (value > 0)
                    {
                        radius = value;
                        area = GetArea();
                        circle = GetCircle();
                    }
                    else Except();
                }
            }
            public double Area {get => area;}
            public double Circle { get => circle; }

            public Round()
            {
                abs = 0;
                ord = 0;
                radius = 1;
                area = GetArea();
                circle = GetCircle();
            }
            public Round(int x, int y, double r)
            {
                abs = x;
                ord = y;
                if (r >= 0) radius = r;
                else Except();
                area = GetArea();
                circle = GetCircle();
            }
            public Round(Point p, double r)
            {
                abs = p.Abs;
                ord = p.Ord;
                if (r >= 0) radius = r;
                else Except();
                area = GetArea();
                circle = GetCircle();
            }
            protected virtual double GetCircle()
            {
                return 2 * Math.PI*radius;
            }
            protected virtual double GetArea ()
            {
                return Math.PI*Math.Pow(radius, 2);
            }
            protected void Except()
            {
                throw new ArgumentException("Радиус должен быть положительным");
            }
            public virtual void ShowInfo()
            {
                Console.WriteLine("Координаты центра Х = {0}, Y = {1}, " +
                    "\nРадиус = {2} " +
                    "\nДлинна окружности = {3}" +
                    "\nПлощадь круга = {4}" +
                    "\n____________________________________", abs, ord, radius,area,circle);
            }
            public Point GetCenter()
            {
                return new Point(abs, ord);
            }
        }
    }
}
