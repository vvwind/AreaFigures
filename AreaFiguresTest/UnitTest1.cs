using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace AreaFiguresTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AreaFigures.Triangle triangle1 = new AreaFigures.Triangle
            {
                Side_A = 4.5,
                Side_B = 3.89,
                Side_C = 5.23

            };
            Console.WriteLine(triangle1.Area());

            AreaFigures.Triangle triangle2 = new AreaFigures.Triangle
            {
                Side_A = 3,
                Side_B = 4,
                Side_C = 5

            };
            Console.WriteLine(triangle2.Area());


            AreaFigures.Circle circle1 = new AreaFigures.Circle
            {
                Radius = 25
            };

            Console.WriteLine(circle1.Area());
        }
    }
}
