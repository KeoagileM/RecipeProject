using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FirstProject
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int numOfSteps;
            String response = "";
            //Promting the user if he\she wants to add an ingredient

            Console.WriteLine("Welcome to the creations of recipes would you like to continue");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Yes\t\t OR \t\tNo");
            while (!response.Contains("yes") || !response.Contains("no"))
            {
                
                response = Console.ReadLine();
                if (response.Contains("yes"))
                {
                    mainMenu();
                    break;
                }
                else if (response.Contains("no"))
                {
                    Console.WriteLine("Thank you for using the console");
                    break;
                }
                else
                {
                    
                    Console.WriteLine("Please Choose the correct thing");
                    Console.WriteLine("Yes\t\t OR \t\tNo");
                }
            }
        }
        
        private static void mainMenu()
        {
            String recipeName;
            String[] recipe;
            int[] qty;
            String[] ingredients;
            double[] measurements;
            int response = 0;
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("**************************");
            Console.WriteLine("1) Add a recipe");
            Console.WriteLine("2) Show recipe");
            Console.WriteLine("3) Exit");

            response = Convert.ToInt32(Console.ReadLine());
            if (response == 1) {
                Console.WriteLine("What is the name of the recipe");
                recipeName = Console.ReadLine();

                Console.WriteLine("How many ingredients are needed");
                int numIngr = Convert.ToInt32(Console.ReadLine());

                ingredients = new String[numIngr];
                measurements = new double[numIngr];
                qty = new int[numIngr]; 
                for (int i = 0; i < numIngr; i++)
                {
                    Console.WriteLine("What is the number " + (i+1) + " ingredient");
                    ingredients[i] = Console.ReadLine();
                    Console.WriteLine("The measurements of " + ingredients[i] );
                    measurements[i] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("How many " + ingredients[i] + " is needed");
                    qty[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("How many steps of the recipe are there?");
                int numSteps = Convert.ToInt32(Console.ReadLine());

                recipe = new String[numSteps];

                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine("Step " + (i + 1));
                    recipe[i] = Console.ReadLine();
                }

                Console.WriteLine("The name of the recipe is " + recipeName);
                Console.WriteLine("***************************************");
                Console.WriteLine("The ingredients are: ");
                for (int i = 0; i < numIngr; i++)
                {
                    Console.WriteLine((i + 1) + ")" + qty[i] + " - " + measurements[i] + " of " + ingredients[i]);
                }

                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine("Step number " + (i+1) + recipe[i]);
                }

                Console.WriteLine("Thank you for using our Application");
                
            }

        }
    }
}

