using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading;

namespace CardboardCompanySalesPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cardboard Company Sales Portal!");


            List<string> SalesEmployees = new List<string> { "Dwight Hyte", "Tim Halbert", "Phyllis Leaf" };


            SalesEmployees.Add("Todd");


            var selectedMenuOption = "";


            do
            {
                Console.WriteLine("Pick a number from the menu below.\n");

                Console.WriteLine("1. Enter New Sale");
                Console.WriteLine("2. Generate Report For Accountant");
                Console.WriteLine("3. Add New Sales Employee");
                Console.WriteLine("4. Find a Sale");
                Console.WriteLine("5. Exit\n");


                selectedMenuOption = Console.ReadLine();
                

                switch (selectedMenuOption)
                {
                    case "1":

                        Console.WriteLine("\nWhich sales employee are you? \n");


                        var whatIndexPosition = 0;


                        foreach (var salesEmployee in SalesEmployees) 
                        {
                            whatIndexPosition++;

                            Console.WriteLine($"{whatIndexPosition}: {salesEmployee}");
                        }


                        var userInputForChosenEmployee = Console.ReadLine();


                        var chosenEmployeeNumberFromMenu = 0;


                        var selectedSalesEmployee = "";


                        var canConvert = int.TryParse(userInputForChosenEmployee, out chosenEmployeeNumberFromMenu); // returns bool


                        if (canConvert == true && chosenEmployeeNumberFromMenu <= SalesEmployees.Count && chosenEmployeeNumberFromMenu != 0)
                        {

                            selectedSalesEmployee = SalesEmployees[chosenEmployeeNumberFromMenu - 1]; // finds string name by index location inside SalesEmployee List

                            Console.WriteLine($"You picked {selectedSalesEmployee}.");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number");
                        }


                                        



                        break;





                    case "2":
                        Console.WriteLine("\nYou picked Option 2 \n");
                        break;

                    case "3":
                        Console.WriteLine("\nYou picked Option 3 \n");
                        break;

                    case "4":
                        Console.WriteLine("\nYou picked Option 4 \n");
                        break;

                    default:
                        Console.WriteLine("\n--- Please try again. --- \n");
                        break;
                }
            }
            while (selectedMenuOption != "5");
        }
    }
}
