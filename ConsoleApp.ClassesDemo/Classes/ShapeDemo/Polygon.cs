using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo
{
    public abstract partial class Polygon
    {
        public int Width { get; set; }

        public abstract double Area();

        public virtual string GetShapeName()
        {
            throw new NotImplementedException();
        }
    }
}