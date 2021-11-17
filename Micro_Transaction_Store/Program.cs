using System;
using System.IO;
using System.Threading;

bool buying = false;
string doesCustomerBuy;
bool doesCustomerHaveEnought;

string doesCustomerBuyMore;

int money = 100;

string[] products = File.ReadAllLines(@"shopingList");
string[] productPriceString = File.ReadAllLines(@"productPrices");
int[] productPrice = new int[productPriceString.Length];

for (int i = 0; i < productPriceString.Length; i++)
{
    productPrice[i] = Convert.ToInt32(productPriceString[i]);
}


int productChoosen = 0;
int productCount = 0;

System.Console.WriteLine("Welcome! Would you like to buy something from the store?");
System.Console.WriteLine("Y or N");

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

    productChoosen = validAnswer.numberTest();

    Console.WriteLine($"How many {products[productChoosen - 1]}s whould you like to buy?");

    doesCustomerHaveEnought = false;

    while (doesCustomerHaveEnought == false)
    {
        productCount = validAnswer.numberTest();

        if (productCount * productPrice[productChoosen - 1] < 100)
        {
            doesCustomerHaveEnought = true;

            money = money - productCount * productPrice[productChoosen - 1];
        } else 
    }

    Console.WriteLine($"Congratulations you now have {money}:- left.");
    Console.WriteLine($"inv");

    Console.WriteLine("Would you like to buy something more?");
    System.Console.WriteLine("Y or N");

    doesCustomerBuyMore = Console.ReadLine();

    if (doesCustomerBuyMore.ToLower() != "y")
    {
        buying = false;
    }
}
Console.ReadLine();
