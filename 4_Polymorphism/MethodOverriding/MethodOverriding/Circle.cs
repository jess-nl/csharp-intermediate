using System;
namespace MethodOverriding
{
    // it only knows about the concept of circle
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
}
