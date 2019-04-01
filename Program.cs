using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string userChoice;
            string userValue;
            double userConverted;
            double result;
            do
            {
                Console.WriteLine("Would you like to do tempretature convertion? Type 'Y' to continue or 'Exit' to close the program");
                userInput = Console.ReadLine();
                if(userInput == "Y" || userInput =="y")
                {
                    Console.WriteLine(" Fahrenheit to Celsius  (Type '1') or  Celsius to Fahrenheit (Type '2') ");
                    userChoice = Console.ReadLine();
                    Console.WriteLine("Please enter the temprature value:");
                    userValue = Console.ReadLine();

                    if (userChoice == "1")
                    {
                        userConverted = Convert.ToDouble(userValue);
                        result = (userConverted - 32) * 5 / 9;
                        Console.WriteLine( userConverted + " Fahrenheit is equal " + result + " Celsius");
                    }
                    else if( userChoice == "2")
                    {
                        userConverted = Convert.ToDouble(userValue);
                        result = (userConverted * 9 / 5) + 32;
                        Console.WriteLine(userConverted + " Celsius is equal " + result + " Fahrenheit");
                    }
                }
        
            } while (userInput != "Exit");
        }
    }
}
