using System;

namespace ConstructorsAndInheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var car = new Car("XYZ1234");
            /* output: 
             * Vehicle is being initialized. XYZ1234
             * Car is being initialized. XYZ1234
             */
        }
    }
}
