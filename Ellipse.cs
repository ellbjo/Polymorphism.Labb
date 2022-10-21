using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Labb
{
    
    public class Ellipse : Geometry
    { 
        //Properties for the Circle-objects, pi as a private constant since it wont change
        private const double Pi = 3.14;
        public double Radius1 { get; set; }
        public double Radius2 { get; set; }

        //Constructor for the ellipse objects, sets default radius to 3 if nothing is passed to the constructor
        public Ellipse(double radius1 = 4, double radius2 = 5)
        {
            this.Radius1 = radius1;
            this.Radius2 = radius2;

        }
        //Method that calculates the area (overrides the method in the parentclass)
        public override double Area()
        {
            return Math.Round(Radius1 * Radius2 * Pi, 2);
        }
    }
}
