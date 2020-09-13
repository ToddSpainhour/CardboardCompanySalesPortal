using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading;
using CardboardCompanySalesPortal;
using System.Linq;

namespace CardboardCompanySalesPortal
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Cardboard Company Sales Portal!");



            List<string> SalesEmployees = new List<string> { "Dwight Hyte", "Tim Halbert", "Phyllis Leaf" };
            

            
            SalesEmployees.Add("Todd Spainhour");
            


            List<Sale> AllSales = new List<Sale>();

            var Sale1 = new Sale("Todd Spainhour", "Bobby's", "0003", "1234", "monthly", "3 months");
            var Sale2 = new Sale("Todd Spainhour", "Cindy's", "0004", "1234", "monthly", "3 months");
            var Sale3 = new Sale("Dwight Hyte", "Lacey's", "0005  ", "1234", "monthly", "3 months");

            AllSales.Add(Sale1);
            AllSales.Add(Sale2);
            AllSales.Add(Sale3);


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
                        Console.WriteLine($"Timeframe: {timeFrameForRecurringSale}\n");


                        var Sale = new Sale(selectedSalesEmployee, clientName, clientIdNumber, totalSalePrice, recurringSale, timeFrameForRecurringSale);
                        AllSales.Add(Sale);
                        Console.WriteLine($"Your new entry has been added which brings the total number of sales to {AllSales.Count}.\n");

                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;





                    case "2":
                        Console.WriteLine("\nYou picked Option 2 \n");

                        // give users list of accountants to pick from this is hard coded
                    
                        string selectedAccountant = "";

                        do
                        {
                            Console.WriteLine("Which sales accountant is this report being generated for? ");

                            Console.WriteLine("1. Angela Kinsey");
                            Console.WriteLine("2. Oscar Nunez");
                            Console.WriteLine("3. Kevin Malone");

                            var accountantMenuSelectedNumber = Console.ReadLine();
                            switch (accountantMenuSelectedNumber)
                            {
                                case "1":
                                    selectedAccountant = "Angela Kinsey";
                                    //Console.WriteLine($"You selected {selectedAccountant}");
                                    break;


                                case "2":
                                    selectedAccountant = "Oscar Nunez";
                                    //Console.WriteLine($"You selected {selectedAccountant}");
                                    break;

                                case "3":
                                    selectedAccountant = "Kevin Malone";
                                    //Console.WriteLine($"You selected {selectedAccountant}");
                                    break;

                                default:
                                    Console.WriteLine("Please pick a number option from the menu.");
                                    break;
                            }

                        } while (selectedAccountant == "");



                        Console.WriteLine("\nMonthly Sales Report");
                        Console.WriteLine($"For: {selectedAccountant}\n");



                        var salesReport =
                            from SalesEmployee in AllSales
                            select SalesEmployee;


                        // don't repeat sales agents
                        // only show clients from that sales agent

                        foreach (Sale name in salesReport)
                        {
                            Console.WriteLine($"Sales Agent: {name.SelectedSalesEmployee}");
                            Console.WriteLine("Clients:");
                                
                            
                 
                                foreach (Sale client in salesReport)
                                {
                                    Console.WriteLine(client.ClientName);
                                }
                                Console.WriteLine("\n");
                        }

               
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey(true);
                        Console.Clear();

                        break;




                    case "3":

                        Console.WriteLine("\nPlease enter a name to add a new sales employee. \n");
                        var newSalesEmployee = Console.ReadLine();
                        SalesEmployees.Add(newSalesEmployee);
                        Console.WriteLine($"\n{newSalesEmployee} has been added to the list of sales employees.");

                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;





                    case "4":
                        Console.WriteLine("\nYou picked Option 4 \n");


                        // this adds some dummy sales to the AllSales list
                        if (AllSales.Count == 0)
                        {
                            var firstSale = new Sale("Dwight Hyte", "Scout's Print Shop", "0001", "1000", "yes", "monthly");
                            var secondSale = new Sale("Dwight Hyte", "Jimbo's Print Shop", "0002", "9999", "yes", "monthly");
                            var thirdSale = new Sale("Dwight Hyte", "Scout's Print Shop", "0001", "9999", "yes", "monthly");


                            AllSales.Add(firstSale);
                            AllSales.Add(secondSale);
                            AllSales.Add(thirdSale);


                        }


                        Console.WriteLine("Enter the client Id for find a sale.");
                        var chosenClientId = Console.ReadLine();
                        Console.WriteLine($"\nBelow you will see all sales for Client Id: {chosenClientId}\n");

                        foreach (var sale in AllSales)
                        {
                            if (chosenClientId == sale.ClientIdNumber)
                            {
                                Console.WriteLine($"Sales Employee: {sale.SelectedSalesEmployee}");
                                Console.WriteLine($"Client Name: {sale.ClientName}");
                                Console.WriteLine($"ClientId: {sale.ClientIdNumber}");
                                Console.WriteLine($"Total Price: {sale.TotalSalePrice}");
                                Console.WriteLine($"Recurring Sale: {sale.RecurringSale}");
                                Console.WriteLine($"Timeframe: {sale.TimeFrameForRecurringSale}\n");    
                            }
                        }

                        
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey(true);
                        Console.Clear();

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
