using System;
using System.Threading;
namespace CSharpApp
{
    class Program
    {
        static void Main(string[] args) // Main method
        {
            {
                Question(); // Name method
                YesNo(); // Day method
                Tacotopping(); // Taco WIP continuation
                Satisfied(); // Customer Satisfaction
                NewMethod();
            }

            static string Question() // Question Method 
            {
                Console.WriteLine("Hello sir what's your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Your name is " + name + "? That's my cousins name!!(Hit Enter once)");
                return Console.ReadLine();
            }

            static void YesNo() //YesNo method
            { 
                {
                    Console.WriteLine("Was your day Good or Bad? Y/N");
                    string day = Console.ReadLine();
                    if (day == "Y" || day == "y") // || or
                    {
                        Console.WriteLine("That's good to hear!");
                    }
                    else if (day == "N" || day == "n")// || or
                    {
                        Console.WriteLine("That's not good to hear!");
                    }
                    else
                    {
                        Console.WriteLine("Please type Y or N!"); // loops if invalid input
                        YesNo();
                    }
                }
            }

            static string Tacotopping()
            {
                Console.WriteLine("Hello this is taco bell drive through. We currently have a special to make a random taco, would you like this? Y/N:");
                string answer = Console.ReadLine(); //reading the console input 
                string[] tacotoppings = { "Meat", "Salsa", "Beans", "Sour cream", "Guacamole", "Tomatoes", "Lettuce" }; //my array of taco toppings
                //string[] tacotoppings = {"Lettuce", "Lettuce", "Lettuce", "Lettuce", "Lettuce", "Lettuce" }; // Was to test double toppings feature
                Random rand = new Random(); //random selection
                int index = rand.Next(tacotoppings.Length); //randomizer one
                int index2 = rand.Next(tacotoppings.Length); //randomizer two
                if (answer == "Y" || answer == "y")
                {
                    if (tacotoppings[index] == tacotoppings[index2])
                    {
                        Console.WriteLine($"Your taco contains: \n Double {tacotoppings[index]}"); //If you get the same topping you get "double" (comparing strings)
                    }
                    else
                    {
                        Console.WriteLine($"Your taco contains: \n{tacotoppings[index]}\n{tacotoppings[index2]}"); // Normal functional
                    }
                }
                else if (answer == "N" || answer == "n") // loops if invalid input
                {
                    Console.WriteLine("Sorry sir, the only taco available is the special taco.");
                    Tacotopping();
                }
                else
                {
                    Console.WriteLine("Please type Y or N!");
                    Tacotopping(); // loops if no
                }
                return Console.ReadLine(); // makes it so the console is used.
            }
            static void Satisfied()
            {
                Console.WriteLine("We hope you had a great experience with us! If you check your receipt you can get 25% off your order with us! Shop safely!");
            }
            static void NewMethod() // Method Delay test (this is ALPHA feature trying to make it seem like console is talking, in progress
            {
                int ms = 5000; // delay in ms
                Thread.Sleep(ms);
                Console.WriteLine("Test"); // What prints per delay
                Console.ReadLine(); // to pause after, temp
            }
        }
    }
}
