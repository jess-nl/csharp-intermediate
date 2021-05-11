using System;
namespace AbstractClassesAndMembers
{
    public class Rectangle : Shape
    {
        // before inserting the following, the "public class Rectangle : Shape" class was empty, which in turn, didn't log a rectangle
        // the abstract and override keywords forces the design to be followed everywhere in the code
        // (forces the developer to not forget to add inherited members as shown below)
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
}
