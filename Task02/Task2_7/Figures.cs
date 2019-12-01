using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_7
{
    public enum Colours
    {

    }
    public abstract class Figures
    {
        public Colours colour;
        public bool Solid;
        public virtual void ShowInfo()
        {
        }
    }
    public class Point : Figures
    {
        public Point(double x, double y)
        {            
            if (x >= 0) X = x;
            else throw new ArgumentException("Координата не может быть отрицательной");
            if (y >= 0) Y = y;
            else throw new ArgumentException("Координата не может быть отрицательной");
        }        
        public double X { get; }
        public double Y { get; }
        public static bool operator ==(Point a, Point b)
        {
            if ((a.X == b.X) & (a.Y == b.Y))
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(Point a, Point b)
        {
            if ((a.X == b.X) & (a.Y == b.Y))
            {
                return false;
            }
            else return true;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Точка: Координаты точки {0}{1}",X,Y);
        }
    }
    public class Line : Figures
    {
        public Line(Point a, Point b)
        {
            A = a;
            B = b;
            if (A == B) throw new ArgumentException("У отрезка не должны совпадать координаты начала и конца");
        }

        public Point A { get; }
        public Point B { get; }
        public override void ShowInfo()
        {
            Console.WriteLine("Отрезок: Координаты начала {0} {1} Координаты конца {2} {3}", A.X, A.Y, B.X, B.Y);
        }
    }
    public class Rectangle : Figures
    {
        private double sideA;
        private double sideB;
        private Point bottomLeft;
        public Rectangle(double sideA, double sideB, Point bottomLeft)
        {
            if (sideA >= 0) this.sideA = sideA;
            else throw new ArgumentException("Длинна стороны не может быть меньше нуля");
            if (sideB >= 0) this.sideB = sideB;
            else throw new ArgumentException("Длинна стороны не может быть меньше нуля");
            this.bottomLeft = bottomLeft;
        }
        public double SideA { get => sideA; }
        public double SideB { get => sideB; }
        public Point BottomLeft { get => bottomLeft; }
        public Line[] GetLines()
        {
            Point a = bottomLeft;
            Point b = new Point(bottomLeft.X, bottomLeft.Y + sideB);
            Point c = new Point(bottomLeft.X + sideA, bottomLeft.Y + sideB);
            Point d = new Point(bottomLeft.X + sideA, bottomLeft.Y);
            Line[] Lines = new Line[3];
            Lines[0] = new Line(a, b);
            Lines[1] = new Line(b, c);
            Lines[2] = new Line(c, d);
            Lines[3] = new Line(d, a);
            return Lines;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Прямоугольник: Координаты левой нижней точки {0} {1} " +
                "\nСторона А {2} Сторона В {3}", bottomLeft.X, bottomLeft.Y,sideA,sideB);
        }
    }
    public class Circle : Figures
    {
        public Circle(Point center, double radius1)
        {
            Center = center;
            Radius1 = radius1;
        }

        public Point Center { get; }
        public double Radius1 { get; }
        public override void ShowInfo()
        {
            Console.WriteLine("Окружность: Координаты центра {0} {1} " +
                            "\nРадиус {2}", Center.X, Center.Y, Radius1);
        }
    }
    public class Round : Circle
    {
        public Round(Point center, double radius1) : base(center, radius1)
        {
        }
        public double Area => Math.PI * Math.Pow(Radius1, 2);
        public override void ShowInfo()
        {
            Console.WriteLine("Круг: Координаты центра {0} {1} " +
                            "\nРадиус {2} Площадь {3}", Center.X, Center.Y, Radius1,Area);
        }
    }
    public class Ring : Circle
    {
        public Ring(Point center, double radius1, double radius2) : base(center, radius1)
        {
            Radius2 = radius2;
        }
        public double Radius2 { get; }
        public double Area => Math.Abs(Math.PI * Math.Pow(Radius1, 2) - Math.PI * Math.Pow(Radius2, 2));
        public Circle[] GetCircles()
        {
            Circle[] Circles = new Circle[1];
            Circles[0] = new Circle(Center, Radius1);
            Circles[1] = new Circle(Center, Radius2);
            return Circles;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Кольцо: Координаты центра {0} {1} " +
                            "\nРадиус1 {2} Радиус2 {3} Площадь {4}", Center.X, Center.Y, Radius1,Radius2,Area);
        }
    }
}
