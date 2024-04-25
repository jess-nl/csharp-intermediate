using System;

namespace Properties
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var person = new Person(new DateTime(1982, 1, 1));
            //person.Birthdate = new DateTime(1982, 1, 1); // version without private set;
            Console.WriteLine(person.Age);
        }
    }
}
