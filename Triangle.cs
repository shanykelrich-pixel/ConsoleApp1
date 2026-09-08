using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Triangle : Shape, ISharpenable
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

       
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA > 0 &&
                sideB > 0 &&
                sideC > 0 &&
                sideA < sideB + sideC &&
                sideB < sideA + sideC &&
                sideC < sideA + sideB)
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
            else
            {
                throw new ArgumentException("Invalid triangle");
            }
        }

        public override double GetArea()
        {
            double s = GetPerimeter() / 2;

            return Math.Sqrt(
                s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Color: {Color}, SideA: {SideA}, SideB: {SideB}, SideC: {SideC}";
        }

        public void Sharpen()
        {
            throw new NotImplementedException();
        }
    }

}
