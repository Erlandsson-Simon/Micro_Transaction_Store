using System;
using System.IO;
using System.Threading;

bool buying = false;
string doesCustomerBuy;
bool doesCustomerHaveEnought;

string doesCustomerBuyMore;

int money = 100;

bool doesProductExist;

string[] products = File.ReadAllLines(@"shopingList");
string[] productPriceString = File.ReadAllLines(@"productPrices");
int[] productPrice = new int[productPriceString.Length];

for (int i = 0; i < productPriceString.Length; i++)
{
    productPrice[i] = Convert.ToInt32(productPriceString[i]);
}


int productChoosen = 0;
int productCount = 0;

Console.WriteLine("Welcome! If you like to buy something from the store?");
Console.Write("Type ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Y");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("");

doesCustomerBuy = Console.ReadLine();

if (doesCustomerBuy.ToLower() == "y")
{
    buying = true;
}

while (buying)
{
    Console.WriteLine("What whould you like to buy?");

    for (int i = 0; i < products.Length; i++)
    {
        string item = products[i];

        Console.WriteLine($"{i + 1}. {item} {productPrice[i]}:-");
    }

    doesProductExist = false;

    while (doesProductExist == false)
    {
        productChoosen = validAnswer.numberTest();

        if (productChoosen > products.Length)
        {
            Console.WriteLine("That product doesn't exist, try again.");
        }
        else
        {
            doesProductExist = true;
        }
    }


    Console.WriteLine($"How many {products[productChoosen - 1]}s whould you like to buy?");
    doesCustomerHaveEnought = false;

    while (doesCustomerHaveEnought == false)
    {
        productCount = validAnswer.numberTest();

        if (productCount * productPrice[productChoosen - 1] <= money)
        {
            doesCustomerHaveEnought = true;

            money = money - productCount * productPrice[productChoosen - 1];
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You dont have enougt.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"The price of what your trying to buy is {productCount * productPrice[productChoosen - 1]}");
            Console.WriteLine($"And you only have {money}");
            Console.WriteLine($"How many {products[productChoosen - 1]} would you like to buy?");
        }

    }

    Console.WriteLine($"Congratulations you now have {money}:- left.");

    Console.WriteLine("If you like to buy something more?");
    Console.Write("Type ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Y");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("");

    Console.WriteLine("And if you would like to leave.");
    Console.Write("Type ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("N");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("");

    doesCustomerBuyMore = Console.ReadLine();

    if (doesCustomerBuyMore.ToLower() != "y")
    {
        buying = false;
    } 
}
Console.ReadLine();
