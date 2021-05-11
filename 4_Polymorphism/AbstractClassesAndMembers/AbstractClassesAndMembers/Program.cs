using System;

namespace AbstractClassesAndMembers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();

            //another useful thing about using the abstract keyword is that you can't instantiate Shape
            //besides, what does Shape really represent? not really anything, it's too abstract. So definitely good it can't be instantiated
            //var shape = new Shape();
        }
    }
}
