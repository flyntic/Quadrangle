using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric
{
    public class Quadrangle : Figure, N_angle
    {

        private const int countPoints = 4;
        public Point[] Points { get; set; }

        public int CountPoints()
        {
            return countPoints;
        }

        public double[] Heights()
        {
            double[] heights = new double[countPoints];
            double S = Square();
            double[] sides = LengthSides();

            for (int i = 0; i < countPoints; i++)
                heights[i] = S / sides[i];

            return heights;

        }

        public double Perimetr()
        {
            double[] sides = LengthSides();
            double perimetr = 0;

            foreach (var s in sides)
            {
                perimetr += s;
            }
            return perimetr;
        }

        public double Square()
        {
            double[] diagonales = LengthDiagonales();
            double angleDiagonal = AngleDiagonal();


            return (diagonales[0] * diagonales[1] * Math.Sin(AngleDiagonal() * Math.PI / 180));

        }

        public double AngleDiagonal()
        {
            double cos_a = ((Points[0].X - Points[2].X) * (Points[1].X - Points[3].X) + (Points[0].Y - Points[2].Y) * (Points[1].Y - Points[3].Y)) /
                         (Math.Sqrt(((Points[0].X - Points[2].X) * (Points[0].X - Points[2].X) +
                                     (Points[0].Y - Points[2].Y) * (Points[0].Y - Points[2].Y)) *
                                     ((Points[1].X - Points[3].X) * (Points[1].X - Points[3].X)
                                     + (Points[1].Y - Points[3].Y) * (Points[1].Y - Points[3].Y))));

            double a_radian = Math.Acos(cos_a);

            return Math.Round(a_radian * 180 / Math.PI);

        }

        public double[] Angles()
        {
            double[] sides = LengthSides();
            double[] diagonales = LengthDiagonales();

            double[] angles = new double[countPoints];
            angles[0] =
              Math.Round((Math.Acos((sides[3] * sides[3] + sides[0] * sides[0] - diagonales[1] * diagonales[1]) / (2 * sides[0] * sides[3]))) * 180 / Math.PI);

            angles[1] =
               Math.Round((Math.Acos((sides[0] * sides[0] + sides[1] * sides[1] - diagonales[2] * diagonales[2]) / (2 * sides[1] * sides[0]))) * 180 / Math.PI);

            angles[2] =
              Math.Round((Math.Acos((sides[1] * sides[1] + sides[2] * sides[2] - diagonales[3] * diagonales[3]) / (2 * sides[2] * sides[1]))) * 180 / Math.PI);

            angles[3] =
              Math.Round((Math.Acos((sides[2] * sides[2] + sides[3] * sides[3] - diagonales[0] * diagonales[0]) / (2 * sides[3] * sides[2]))) * 180 / Math.PI);

            return angles;
        }

        public double CountSides()
        {
            return countPoints;
        }

        public double[] LengthSides()
        {
            double[] sides = new double[countPoints];

            for (int i = 0; i < countPoints; i++)
            {
                int i1 = (i + 1 < countPoints) ? i + 1 : 0;
                sides[i] = Math.Sqrt((Points[i].X - Points[i1].X) * (Points[i].X - Points[i1].X)
                                   + (Points[i].Y - Points[i1].Y) * (Points[i].Y - Points[i1].Y));
            }

            return sides;
        }

        public double[] LengthDiagonales()
        {
            double[] diagonales = new double[countPoints];

            for (int i = 0; i < countPoints; i++)
            {
                int i1 = (i + 2 < countPoints) ? i + 2 : i - 2;
                diagonales[i] = Math.Sqrt((Points[i].X - Points[i1].X) * (Points[i].X - Points[i1].X)
                                   + (Points[i].Y - Points[i1].Y) * (Points[i].Y - Points[i1].Y));
            }

            return diagonales;
        }

        public override string ToString()
        {
            double[] sides = LengthSides();
            double[] diagonales = LengthDiagonales();
            double[] angles = Angles();
            double[] heights = Heights();
            double angleDiagonal = AngleDiagonal();

            return $"\nЧетырехугольник \nВершина: {Points[0].X},{Points[0].Y}\n" +
                $"Вершина: {Points[1].X},{Points[1].Y}\n" +
                $"Вершина: {Points[2].X},{Points[2].Y}\n" +
                $"Вершина: {Points[3].X},{Points[3].Y}\n" +
                $"Периметр:{Perimetr()}\n" +
                $"Площадь:{Square()}\n" +
                $"Стороны:{sides[0]},{sides[1]},{sides[2]},{sides[3]}\n" +
                $"Высоты:{heights[0]},{heights[1]},{heights[2]},{heights[3]}\n" +
                $"Диагонали:{diagonales[0]},{diagonales[1]},{diagonales[2]},{diagonales[3]}\n" +
                $"Углы:{angles[0]},{angles[1]},{angles[2]},{angles[3]}\n" +
                $"Угол между диагоналями:{angleDiagonal}";
        }

    }

}
