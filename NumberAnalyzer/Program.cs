using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name here.");
            string name = Console.ReadLine();
            Console.WriteLine($"{name}, please enter an integer between 1 and 100.");
            string input = Console.ReadLine();
            int integer = int.Parse(input);
            string input2 = "y";
            int i = 0;
            {

                if (integer < 1)
                {
                    Console.WriteLine("I'm sorry we only accept positive values.");
                }

                //case of even number
                if (integer % 2 == 0)
                {

                    if (integer >= 2 && integer <= 24)
                    {
                        Console.WriteLine($"{name}, the number {integer} is even and less than 25.");
                    }
                    else if (integer >= 26 && integer <= 60)
                    {
                        Console.WriteLine($"{name} the number {integer} is even and between 26 and 60 inclusive.");
                    }
                    else if (integer > 60)
                    {
                        Console.WriteLine($"{name} the number {integer} is even and greater than 60");
                    }

                }

                //case of odd number
                if (integer % 2 != 0)
                {
                    if (integer < 60)
                    {
                        Console.WriteLine($"{name} the number {integer} is odd and less than 60.");
                    }
                    else if (integer > 60)
                    {
                        Console.WriteLine($"{name} the number {integer} is odd and greater than 60.");

                    }



                    Console.WriteLine($"{name} Would you like to run the application again? y/n");

                    for (i = 0; i < 10; i++)
                    {
                        input2 = Console.ReadLine().ToLower();
                        if (input2 == "y")
                        {
                            break;
                        }
                        else if (input2 != "y")
                            Console.WriteLine("Goodbye!");
                    }
                }
            }
        }
    }
}



                
        
    
    

               





