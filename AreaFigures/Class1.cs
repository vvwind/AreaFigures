using System;

namespace AreaFigures
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Triangle : Shape
    {
        public double Side_A { get; set; }
        public double Side_B { get; set; }
        public double Side_C { get; set; }


        public override double Area()
        {

            var sides_array = new double[] { Side_A, Side_B, Side_C };
            Array.Sort(sides_array);
            var gerone = (Side_A + Side_B + Side_C) / 2;

            if ((Math.Pow(sides_array[0], 2) + Math.Pow(sides_array[1], 2)) == (Math.Pow(sides_array[2], 2)))
            {
                Console.WriteLine("This is a Right Triangle");
                return Math.Round((sides_array[0] * sides_array[1]) / 2,2);
            }
            else
            {
                return Math.Round(Math.Sqrt(gerone * (gerone - Side_A) * (gerone - Side_B) * (gerone - Side_C)),2);
            }

        }
    }


    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {

            return Math.Round((Math.Pow(Radius, 2) * Math.PI),2);
        }
    }
}




