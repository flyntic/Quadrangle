using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric
{


    public class Square
    {
        public Point[] Points { get; set; }
        public static bool isSquare(Quadrangle S)
        {
            double[] sides = S.LengthSides();
            if ((sides[0] == sides[1]) && (sides[0] == sides[2]) && (sides[0] == sides[3])
                && (S.Angles()[0] == 90))
                return true;

            return false;
        }

        public static implicit operator Square(Quadrangle S)
        {
            return new Square() { Points = S.Points };
        }


        public override string ToString()
        {
            return "Квадрат";
        }

    }

    public class Rhomb
    {
        public Point[] Points { get; set; }
        public static bool isRhomb(Quadrangle S)
        {
            double[] sides = S.LengthSides();
            if ((sides[0] == sides[1]) && (sides[0] == sides[2]) && (sides[0] == sides[3])
                && (S.Angles()[0] != 90))
                return true;
            return false;
        }

        public static implicit operator Rhomb(Quadrangle S)
        {
            return new Rhomb() { Points = S.Points };
        }

        public override string ToString()
        {
            return "Ромб";
        }
    }

    public class Rectangle
    {
        public Point[] Points { get; set; }
        public static bool isRectangle(Quadrangle S)
        {
            double[] sides = S.LengthSides();
            if ((sides[0] == sides[2]) && (sides[1] == sides[3]) && (sides[0] != sides[3])
                && (S.Angles()[0] == 90))
                return true;
            return false;
        }

        public static implicit operator Rectangle(Quadrangle S)
        {
            return new Rectangle() { Points = S.Points };
        }



        public override string ToString()
        {
            return "Прямоугольник";
        }
    }
    public class Parallelogram
    {
        public Point[] Points { get; set; }
        public static bool isParallelogram(Quadrangle S)
        {
            double[] sides = S.LengthSides();
            if ((sides[0] == sides[2]) && (sides[1] == sides[3]) && (sides[0] != sides[1])
               && (S.Angles()[0] != 90))
                return true;
            return false;
        }

        public static implicit operator Parallelogram(Quadrangle S)
        {
            return new Parallelogram() { Points = S.Points };
        }


        public override string ToString()
        {
            return "Параллелограм";
        }
    }
    public class Trapezoid
    {
        public Point[] Points { get; set; }
        public static bool isTrapezoid(Quadrangle S)
        {
            double[] heights = S.Heights();
            double[] sides = S.LengthSides();
            if (((heights[0] == heights[1])&&(sides[0]!=sides[2])) || ((heights[1] == heights[2])&& (sides[1] != sides[3]))||
                ((heights[2] == heights[3]) && (sides[2] != sides[0])) || ((heights[3] == heights[0]) && (sides[3] != sides[1]))
                )
                return true;
            return false;
        }

        public static implicit operator Trapezoid(Quadrangle S)
        {
            return new Trapezoid() { Points = S.Points };
        }



        public override string ToString()
        {
            return "Трапеция";
        }
    }
}
