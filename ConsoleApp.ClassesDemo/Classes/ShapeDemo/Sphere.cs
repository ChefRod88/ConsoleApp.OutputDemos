﻿using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo
{
    public class Sphere : ICircularShape, I3Dshape
    {
        public Sphere(double r)
        {
            Radius = r;
        }
        public double Radius { get; set; }

        public double Circumference()
        {
            return 4 * Math.PI * Math.Pow(Radius, 3);
        }

        public double Volume()
        {
            return (4/3) * Math.PI * Radius;
        }
    }
}


