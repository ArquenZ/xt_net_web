using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figures> FigureCollection = new List<Figures>();
            FigureCollection.Add(FigureCreator.CreatePoint(6, 7));
            FigureCollection.Add(FigureCreator.CreateLine(new Point(12, 18), new Point(4, 9)));
            FigureCollection.Add(FigureCreator.CreateRectangle(4, 6, new Point(10, 10)));
            FigureCollection.Add(FigureCreator.CreateCircle(new Point(2,7), 15));
            FigureCollection.Add(FigureCreator.CreateRing(new Point(5, 5), 4, 6));
            foreach (var item in FigureCollection)
            {
                Console.WriteLine(item.GetType().ToString());
                item.ShowInfo();
            }
        }
        public static class FigureCreator
        {            
            public static Point CreatePoint(double x,double y)
            {
                return new Point(x, y);
            }
            public static Line CreateLine (Point a, Point b)
            {
                return new Line(a, b);
            }
            public static Rectangle CreateRectangle(double sideA, double sideB, Point bottomLeft)
            {
                return new Rectangle(sideA, sideB, bottomLeft);
            }
            public static Circle CreateCircle(Point center, double radius1)
            {
                return new Circle(center, radius1);
            }
            public static Round CreateRound (Point center, double radius1)
            {
                return new Round(center, radius1);
            }
            public static Ring CreateRing(Point center, double radius1, double radius2)
            {
                return new Ring(center, radius1, radius2);
            }
        }
    }
}
