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


                        foreach (var salesEmployee in SalesEmployees) // prints list of sales employees to choose from
                        {
                            whatIndexPosition++;

                            Console.WriteLine($"{whatIndexPosition}: {salesEmployee}");
                        }


                        // var indexNumberOfSaleschosenEmployee = int.Parse(Console.ReadLine()) -1;

                        var chosenEmployee = Console.ReadLine(); // should return string

                        var chosenEmployeeNumber = 0;

                        var canConvert = int.TryParse(chosenEmployee, out chosenEmployeeNumber); // returns bool

                        if (canConvert == true && chosenEmployeeNumber - 1 <= SalesEmployees.Count)
                        {
                            Console.WriteLine("this is inside the canConvert if statement");
                            Console.WriteLine($"Confirm you picked {SalesEmployees[chosenEmployeeNumber -1]}");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number");
                        }

                        /*
                         * string numString = "1287543"; //"1287543.0" will return false for a long
                            long number1 = 0;
                            bool canConvert = long.TryParse(numString, out number1);
                            if (canConvert == true)
                              Console.WriteLine("number1 now = {0}", number1);
                            else
                              Console.WriteLine("numString is not a valid long");
                        */


                        //var selectedSalesEmployee = SalesEmployees[indexNumberOfSaleschosenEmployee];


                        Console.WriteLine($"SalesEmployees.Count is: {SalesEmployees.Count}");

                        //Console.WriteLine($"indexNumberOfSaleschosenEmployee is type... {indexNumberOfSaleschosenEmployee.GetType()}"); // int32


                     

                        //while the user's response is not one of the not one of the numbered options in the menu

                        //while (indexNumberOfSaleschosenEmployee !<= SalesEmployees.Count) // infinite loop
                        //{
                        //    Console.WriteLine("Please enter a number from the list (inside the while loop");
                        //}

                        //Console.WriteLine($"Now we're outside the do while loop. Hello, {selectedSalesEmployee}. Let's continue entering a new sale.");

                        // how to handle if the don't pick a valid option (index position) another do/while?
                        // loops through name options in list, and if the entered amount can't be found (find? Contains?) it says to try again. No you're using the numbers to choose
                        // so if they press anything other than an numbered option (ie. 1, 2, 3, 4) it asks again; use counter? or Count method?
                        // if there are 9 options, there will be 9 digits to pick from...



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
