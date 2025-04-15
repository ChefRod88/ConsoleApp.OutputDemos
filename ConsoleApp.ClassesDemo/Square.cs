namespace ConsoleApp.ClassesDemo
{
    public abstract partial class Polygon
    {
        public class Square : Polygon
        {
            public Square(int width)
            {
               Width = width; 
            }
            public override int Area()
            {
                
                return (int)Math.Pow(Width, 2);
            }
        }
    }
}