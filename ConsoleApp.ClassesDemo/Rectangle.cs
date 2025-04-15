namespace ConsoleApp.ClassesDemo
{
    public class Rectangle : Polygon
    {
        public Rectangle(int width, int length)
        {
            Length = length;
            Width = width;
        }
        public int Length { get; set; }

        public override int Area()
        {
            return Length * Width;
        }
    }
}