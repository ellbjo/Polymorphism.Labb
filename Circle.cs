using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Labb
{
    public class Circle : Geometry
    {
        //Properties for the Circle-objects, pi as a private constant since it wont change
        private const double Pi = 3.14;
        public double Radius { get; set; }

        //Constructor for the circle objects, sets default radius to 3 if nothing is passed to the constructor
        public Circle(double radius = 3)
        {
            this.Radius = radius;
        }

        //Method that calculates the area (overrides the method in the parentclass)
        public override double Area()
        {
            return Math.Round((Radius * Radius) * Pi,2);
        }

    }
}
