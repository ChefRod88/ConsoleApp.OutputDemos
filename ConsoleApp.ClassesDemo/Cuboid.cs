namespace ConsoleApp.ClassesDemo
{
    public class Cuboid : Polygon, I2DShape, I3Dshape
    {
        public Cuboid(double length, double width, double height)
        {
            Length = length;
            Width = (int)width;
            Height = height;
        }
        public double Length { get; set; }

        public double Height { get; set; }

        public override double Area()
        {
            return 2 * (Width * Length) + (Length * Width) + (Length * Width);
        }

        public double Perimeter()
        {
            return 4 * (Length * Width * Length);
        }

        public double Volume()
        {
            return (Length * Width * Height);
        }

        
    }
}


