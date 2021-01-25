using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathSOAPClient.ServiceReference1;

namespace MathSOAPClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");

            string userInput;
            int result = 0;

            DisplayMenuOptions();
            userInput = Console.ReadLine();

            while (!userInput.Equals("3"))
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Enter an int number:");
                        userInput = Console.ReadLine();

                        try
                        {
                            result = client.SumOfDigits(int.Parse(userInput));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Please enter a valid integer");
                            result = -1;
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter a string");
                        userInput = Console.ReadLine();
                        result = client.VowelCount(userInput);
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input, try again");
                        break;
                }
                Console.WriteLine("Result: {0}\n", result);
                Console.WriteLine("Enter another option or type \'3\' to exit");
                userInput = Console.ReadLine();
            }

        }

        public static void DisplayMenuOptions()
        {
            Console.WriteLine("Welcome to Web Service Demo");
            Console.WriteLine("Select the method you need to invoke");
            Console.WriteLine("\t1. Sum of digits");
            Console.WriteLine("\t2. Vowel Count");
            Console.WriteLine("\t3. Exit\n");
            Console.WriteLine("Enter your option: ...");
        }
    }
}
