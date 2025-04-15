namespace ConsoleApp.ClassesDemo
{
    public class Triangle : Polygon
    {
        public Triangle(int @base, int height)
        {
            Height = height;
            Base = @base;
        }
        public int Height { get; set; }
        public int Base { get; set; }

        public override int Area()
        {
            return (int)(0.5 * Base * Height);
        }
    }
}

