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


                        var selectedSalesEmployee = "";


                        while (selectedSalesEmployee.Length == 0)
                        {

                            var whatIndexPosition = 0; // start counter

                            foreach (var salesEmployee in SalesEmployees)
                            {
                                whatIndexPosition++;

                                Console.WriteLine($"{whatIndexPosition}: {salesEmployee}");
                            }


                            whatIndexPosition = 0; // reset counter


                            var userInputForChosenEmployee = Console.ReadLine();


                            Console.WriteLine("\n");


                            var chosenEmployeeNumberFromMenu = 0;


                            var canConvert = int.TryParse(userInputForChosenEmployee, out chosenEmployeeNumberFromMenu); // returns bool


                            if (canConvert == true && chosenEmployeeNumberFromMenu <= SalesEmployees.Count && chosenEmployeeNumberFromMenu != 0)
                            {

                                selectedSalesEmployee = SalesEmployees[chosenEmployeeNumberFromMenu - 1]; // finds string name by index location inside SalesEmployee List

                                //Console.WriteLine($"You picked {selectedSalesEmployee}.\n");
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid number from the list. \n");
                            }
                        }

                        Console.Clear();
                        Console.WriteLine($"\nSales Employee: {selectedSalesEmployee}");


                        Console.WriteLine($"\nEnter client name.");
                        var clientName = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"\nSales Employee: {selectedSalesEmployee}");
                        Console.WriteLine($"Client: {clientName}");


                        Console.WriteLine("\nEnter the 4-digit client ID number.");
                        var clientIdNumber = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"\nSales Employee: {selectedSalesEmployee}");
                        Console.WriteLine($"Client: {clientName}");
                        Console.WriteLine($"Client ID Number: {clientIdNumber}");


                        Console.WriteLine("\nEnter the total price of the sale.");
                        var totalSalePrice = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"\nSales Employee: {selectedSalesEmployee}");
                        Console.WriteLine($"Client: {clientName}");
                        Console.WriteLine($"Client ID Number: {clientIdNumber}");
                        Console.WriteLine($"Total Sale Price: {totalSalePrice}");


                        Console.WriteLine("\nHow often does this sale reoccur?");
                        var recurringSale = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"\nSales Employee: {selectedSalesEmployee}");
                        Console.WriteLine($"Client: {clientName}");
                        Console.WriteLine($"Client ID Number: {clientIdNumber}");
                        Console.WriteLine($"Total Sale Price: {totalSalePrice}");
                        Console.WriteLine($"Recurring Sale: {recurringSale}");


                        Console.WriteLine("\nWhat's the timeframe for this sale reoccur?");
                        var timeFrameForRecurringSale = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"\nSales Employee: {selectedSalesEmployee}");
                        Console.WriteLine($"Client: {clientName}");
                        Console.WriteLine($"Client ID Number: {clientIdNumber}");
                        Console.WriteLine($"Total Sale Price: {totalSalePrice}");
                        Console.WriteLine($"Recurring Sale: {recurringSale}");
                        Console.WriteLine($"Timeframe: {timeFrameForRecurringSale}");


                        var Sale = new Sale();


                        // what should I call each new sale? Do the names need to be unique? How tho
                        // put all these values into a sale obejct? and then a dictionary or list?




                        /*
                        spit back out the chosen sales employee

                        Sales Agent: Dwight Hyte
                        Client: Carol's Pen Pals
                        ClientID: 2343
                        Sale: $3412
                        Recurring: Monthly
                        Time Frame: 3 months
                        */













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
