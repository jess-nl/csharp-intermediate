using System;

namespace AccessModifiers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var person = new Person();

            // person._birthdate -> if you try to write person dot and then _birthdate (like person._birthdate), it doesn't work 'cause we've set the _birthdate to private

            person.SetBirthdate(new DateTime(1982, 1, 1)); /* notice that we haven't used person.lowercase like usual 
                                                            * fields that follow a class. this is because it's a property and we use pascal case */
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
