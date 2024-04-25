using System.Collections.Generic;

namespace MethodOverriding
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            //the following was the original with switch case, now got replaced with polymorphism
            //shapes.Add(new Shape { Width = 100, Height = 100, Type = ShapeType.Circle });
            //shapes.Add(new Shape { Width = 100, Height = 30, Type = ShapeType.Rectangle });

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
