using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name here.");
            string name = Console.ReadLine();


            //string input = Console.ReadLine();
            int integer = 0;
            string input2 = "y";
            bool runAgain = true;
            while (runAgain == true)
            {

                {
                    while (true)
                    {
                        Console.WriteLine($"{name}, please enter an integer between 1 and 100.");
                        int userInput = int.Parse(Console.ReadLine());
                        integer = userInput;
                        if (integer >= 1 && integer <= 100)
                        {


                            Console.WriteLine($"Ok, {name} your number is {integer}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sorry this number is not between 1 and 100.");
                        }
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
                    }

                        while (true)
                        {
                            Console.WriteLine($"{name} Would you like to run the application again? y/n");
                            string userResponse = Console.ReadLine();
                            if (userResponse == "y")
                            {
                                break;
                            }
                            else if (userResponse == "n")
                            {
                                Console.WriteLine("Goodbye!");
                                runAgain = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("I'm sorry I don't understand please enter y or n.");
                            }
                        }

                    
                }
            }
        }
    }
}



                
        
    
    

               





