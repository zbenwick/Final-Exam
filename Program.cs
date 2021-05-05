/* Zachary Benwick
 * Due: 05/05/2021
 * The purpose of this application is to determine the grand total for a purchase. In doing this the application needs to properly 
 * execute a formatted reciept with the sales tax and processing charge included in the grand total.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace MermaidProcessingLLC
{
    class p
    {

        private static double taxTotal,
            subTotal;
        static public void Main ()
        {

            string partName;
            double itemPrice;
           


            WriteLine("Please enter item name");
            partName = ReadLine();

            WriteLine("Please enter item price");
            itemPrice = double.Parse(ReadLine());

           

            Reciept.DisplayResults(subTotal, taxTotal, itemPrice, partName);
            



        }

    }
}
class Reciept
{
        public static void ListOfPurchasedItems
    {

    }
        public static void DisplayResults(double subTotal, double taxTotal, double itemPrice, string partName)
    {
        Clear();
        WriteLine("Mermaid Processing LLC \n \n");
        WriteLine("{0,-30}{1,12:C}", partName, itemPrice);
        WriteLine("-------------------------------------------");
        WriteLine("Sales Tax: 7.95%");
        WriteLine("{0,-30}{1,12:C2}", "Sub Total: ",  subTotal);

    }

    public double CalculateTax(double taxTotal, double itemPrice)
        {
         taxTotal = itemPrice * .0795;
        return taxTotal;
        }

    public double CalculateSubTotal(double itemPrice, double taxTotal, double subTotal)
    {
        subTotal = taxTotal + itemPrice;
        return subTotal;
    }

    }

class RecieptItem
{
    // Variables

    


    // Constructors
    public RecieptItem()
    {
       

    }

}
           
        


    


/* class reciept
 *  my list management will be in this object


    Add RecieptItem Method
        add items to reciept items  [stored inside this object]


 Finalize/Close Reciept Method
    calling totalItems
    sub total
    Tax Method



 Print Reciept Method
/*
                                      
//------------------------------------------------------------
// class recieptItem

string itemName,
double itemPrice;


/* main
 * static void Main(string iName, double iPrice)
  {
    itemName = iName;
    itemPrice = iPrice; 
}

static string GetName ()
{
    return itemName;
}

static double GetPrice()
{
    return itemPrice;
}
 * 
 * 
 * 
 * 
 *  
 * Store these variables as a reciept item
 * 
 * 
 * 
 * 
 */


/*  var myReceipt = new Receipt();
* 
* *loop until finished ->
* 
* prompt user with instructions
* get item name from command line store into variable myItemName
* get item price from command line store into variable myItemPrice
*
 *  var myItem = new ReceiptItem(myItemName, myItemPrice);
 *  myReceipt.addItem(myItem);
 * 
 * prompt user if they are finished or want to continue?
 * if continue?
 *  repeat loop
 * if finished?
 *   end loop
 *   
 * Finalize receipt - receipt object method should handle calculating tax, subtotals, item counts, processing fee  
 * 
 * Print receipt nicely formatted
 * 
 * 
 * 
 * 
 */

//--------------------------------------------------------------------------------------------

//Allow multiple items to be purchased

// Variables:


// Calculate total amount due once all items are entered

// Allow any number of items to be entered (Name & Price)

// Determine the total amount

// Sales Tax Rate: 7.95% of total purchase

// Processing Charge: (per item)
/*  1  = $10.00
 * 2-4 = $12.00
 * 5-9 = $15.00
 * 10+ = $20.00
 */

// Define a processing class

// Has a single data member

/* Define:
 * Appropriate Constructors
 * Properties
 * Instance methods ("ToString()")
 */

// An Object of the processing class

// Constructed after all purchases are entered

/* An itemized sumary with formatted values for
 * total purchase charge (before add-ons)
 */

// Number of items purchased

// Sales Tax Amount

// Processing Charge

// Grand Total



















