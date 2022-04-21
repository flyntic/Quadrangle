using System;

namespace Geometric
{
    class Program
    {
        static void Main(string[] args)
        {
            N_angle[] n_angles = new N_angle[]
                 {
                    new Triangle()
                    {
                        Points = new Point[] {new Point {X = 2, Y = 0}, new Point {X = 3, Y = 0}, new Point {X = 4, Y = 10}}
                    },
                    new Quadrangle()
                    {
                        Points = new Point[]
                            {new Point {X = 0, Y = 3}, new Point {X = 3, Y = 3}, new Point {X = 3, Y = 0}, new Point {X = 0, Y = 0}}

                    },
                    new Quadrangle()
                    {
                        Points = new Point[]
                            {new Point {X = 3, Y = -10}, new Point {X = 6, Y = 0}, new Point {X = 3, Y = 10}, new Point {X = 0, Y = 0}}

                    },
                    new Quadrangle()
                    {
                        Points = new Point[]
                            {new Point {X = 6, Y = -20}, new Point {X = 9, Y = -10}, new Point {X = 3, Y = 10}, new Point {X = 0, Y = 0}}

                    },
                    new Quadrangle()
                    {
                        Points = new Point[]
                             {new Point {X = 0, Y = 6}, new Point {X = 3, Y = 6}, new Point {X = 3, Y = 0}, new Point {X = 0, Y = 0}}

                    },
                    new Quadrangle()
                    {
                        Points = new Point[]
                             {new Point {X = 0, Y = 3}, new Point {X = 3, Y = 3}, new Point {X = 6, Y = 0}, new Point {X = 0, Y = 0}}

                    },

                    new Triangle()
                    {
                        Points = new Point[] {new Point {X = 2, Y = 0}, new Point {X = 3, Y = 0}, new Point {X = 4, Y = 10}}

                    }
                 };


            foreach (N_angle n_angle in n_angles)
            {

                if (n_angle as Quadrangle != null)
                {
                    Console.WriteLine(n_angle);

                    if (Square.isSquare((Quadrangle)n_angle))
                    {
                        Square square = (Quadrangle)n_angle;
                        Console.WriteLine(square);
                    }

                    if (Rhomb.isRhomb((Quadrangle)n_angle))
                    {
                        Rhomb rhomb = (Quadrangle)n_angle;
                        Console.WriteLine(rhomb);
                    }

                    if (Parallelogram.isParallelogram((Quadrangle)n_angle))
                    {
                        Parallelogram parallelogram = (Quadrangle)n_angle;
                        Console.WriteLine(parallelogram);
                    }

                    if (Rectangle.isRectangle((Quadrangle)n_angle))
                    {
                        Rectangle rectangle = (Quadrangle)n_angle;
                        Console.WriteLine(rectangle);
                    }

                    if (Trapezoid.isTrapezoid((Quadrangle)n_angle))
                    {
                        Trapezoid trapezoid= (Quadrangle)n_angle;
                        Console.WriteLine(trapezoid);
                    }
                }
            }

        }
    }
}
