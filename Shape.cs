using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Shape
    {
        public string Id { get; private set; }
  
        public ShapeColor Color { get; set; }

        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"Id: {Id}, Color: {Color}";
        }
    }
}
