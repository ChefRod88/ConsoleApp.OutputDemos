namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo;

public abstract partial class Polygon

{
    public class Square : Polygon
    {
        public Square(int width)
        {
           Width = width; 
        }

        public int Width { get; }

        //public override double Area()
        //{
            
        //    return (int)Math.Pow(Width, 2);
        //}
    }
}