
using System;

namespace Geometric
{
   
    public class Triangle : Figure, N_angle
    {

        private const int countPoints = 3;
        public Point[] Points { get; set; }
        Point[] N_angle.Points { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int CountPoints()
        {
            return countPoints;
        }

        public double Perimetr()
        {
            double[] sides = LengthSides();
            double perimetr = 0;
            foreach (var s in sides)
                perimetr += s;
            return perimetr;
        }

        public double Square()
        {
            double[] sides = LengthSides();
            double poluperimetr = Perimetr()/2;

            foreach (var s in sides)
                poluperimetr *= (poluperimetr-s);

            return Math.Sqrt(poluperimetr);
        }

        public double[] Heights()
        {
            double[] sides = LengthSides();
            double S = Square();
            double[] heights = new double[countPoints];

            for (int i=0;i<countPoints;i++)
            {
                heights[i] = 2 * S / sides[i];
            }

            return heights;
        }

 
        public double[] Angles()
        {
            double[] sides = LengthSides();
            double[] diagonales = LengthDiagonales();

            double[] angles = new double[countPoints];
            angles[0] =
              Math.Round((Math.Acos((sides[2] * sides[2] + sides[0] * sides[0] - diagonales[1] * diagonales[1]) / (2 * sides[0] * sides[2]))) * 180 / Math.PI);

            angles[1] =
               Math.Round((Math.Acos((sides[0] * sides[0] + sides[1] * sides[1] - diagonales[2] * diagonales[2]) / (2 * sides[1] * sides[0]))) * 180 / Math.PI);

            angles[2] =
               Math.Round((Math.Acos((sides[1] * sides[1] + sides[2] * sides[2] - diagonales[0] * diagonales[0]) / (2 * sides[2] * sides[1]))) * 180 / Math.PI);

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
            return LengthSides();
        } 

        public override string ToString()
        {
            return $"\nТреугольник \nВершина: {Points[0].X},{Points[0].Y}\n" +
                $"Вершина: {Points[1].X},{Points[1].Y}\n" +
                $"Вершина: {Points[2].X},{Points[2].Y}" ;
        }

        int N_angle.CountPoints()
        {
            throw new NotImplementedException();
        }

  
    
    }

    
}