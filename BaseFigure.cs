using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric
{
    public abstract class Figure
    {
        public double Square { get; set; }
        public double Perimetr { get; set; }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"X:{X} Y:{Y}";
        }

    }

    public interface N_angle
    {
        Point[] Points { get; set; }
        double CountSides();
        int CountPoints();
        double[] Heights();
        double[] Angles();
        double[] LengthSides();
        double[] LengthDiagonales();

    }
}
