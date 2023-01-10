using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
    {
        class Program
        {
        static void Main(string[] args)
        {
            // String interpolation = allows us to insert variable into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders

            String firstName = "Hazim";
            String lastName = "Aiman";
            int age = 24;

            /* Console.WriteLine("Hello" + firstName + "" + lastName + ".");
             Console.WriteLine("You are " + age + "years old");*/

            Console.WriteLine($" Hello {firstName} {lastName}.");
            Console.WriteLine($" you are {age} years old");

            Console.WriteLine($" you are {age,10} years old");

            Console.ReadKey();
        }
        
    }
    }





   
