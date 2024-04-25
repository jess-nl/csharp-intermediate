using System;

namespace Methods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var number = int.Parse("abc"); // Input string was not in a correct format.

            // a way to see if it parsing works or not. Some developers prefer just using the try/catch error handling with var number = int.Parse("abc"); and it is equivalent
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed."); // this prints
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));

        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                //point.Move(new Point(40, 60));


                /*
                * this will throw a null reference exception error, 
                * so we need to validate or specify the error with ArgumentNullException(). 
                * an even better way is to put it in a try/catch
                */
                point.Move(null);


                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred.");
            }
        }
    }
}
