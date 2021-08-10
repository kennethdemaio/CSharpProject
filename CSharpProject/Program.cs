using System;
namespace CSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Your name is " + name + "? So is mine!");
                YesNo();
            }
            static void YesNo()
            {
                {
                    Console.WriteLine("Was your day Good or Bad? Y/N");
                    string day = Console.ReadLine();
                    if (day == "Y")
                    {
                        Console.WriteLine("That's good to hear!");
                    }
                    else if (day == "N")
                    {
                        Console.WriteLine("That's not good to hear!");
                    }
                    else
                    {
                        Console.WriteLine("Please type Y or N!");
                        YesNo();
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}



