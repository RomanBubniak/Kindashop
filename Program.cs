double yourBalance = 15;
bool inInventory = true;

Console.WriteLine("click Q (balance), W (discount coupon), E (go to store)");

    while(inInventory)
{
    ConsoleKey Key = Console.ReadKey().Key;
    Console.WriteLine();
    switch (Key)
    {
        case ConsoleKey.Q:
        Console.WriteLine($"your balance is: {yourBalance}");
        break;
        case ConsoleKey.W:
        Console.WriteLine("you can discount 15% for fish");
        break;
        case ConsoleKey.E:
        inInventory = false;
        break;
    }
}
Console.Clear();
Console.WriteLine("Welcome to the Shop");
Console.WriteLine("fish: 2.99$ x10. \nchicken: 2.50$ x5. \nbread: 0.99$ x15");
int maxStock = 0;
bool couponAplied = false;
double price = 0;
bool inShop = true;
while (inShop)
{
    Console.WriteLine("enter product name (or 'exit' if you want to leave)");
    string productName = Console.ReadLine().ToLower();
    if (productName == "exit")
    {
        return;
    }
    switch (productName)
    {
        case "fish":
        price = 2.99; 
        maxStock = 10;
        while (inShop)
{
    Console.WriteLine("would you like to apply 15% discount?(y/n)");
bool userChoice = true;

    while(userChoice)
{
    ConsoleKey Key = Console.ReadKey().Key;
    Console.WriteLine();
    switch (Key)
    {
        case ConsoleKey.N:
        couponAplied = false;
        price = 2.99;
        break;
        case ConsoleKey.Y:
        Console.WriteLine("the discount has been aplied!");
        couponAplied = true;
        price = 2.99 * 0.85;
        break;
        default:
        Console.WriteLine("please click Y or N");
continue;
    }
    userChoice = false;
}
inShop = false;
}
        break;
        case "chicken":
        price = 2.50;
        maxStock = 5;
        break;
        case "bread":
        price = 0.99;
        maxStock = 15;
        break;
        default:
        Console.WriteLine("invalid name"); 
        continue;
    }
inShop = false;
}
    int quantity;
    while(true)
{
   Console.WriteLine("enter the quantity");
   string input = Console.ReadLine();
   if (!int.TryParse(input, out quantity))
    {
        Console.WriteLine($"error: you have to write a number from 1 to {maxStock}");
        continue;
    }
    if (quantity <= 0 || maxStock < quantity)
    {
        Console.WriteLine($"error: you have to write a number from 1 to {maxStock}");
        continue;
    }
    else
    {
        break;
    }
}
double finalPrice = Math.Round(quantity * price, 2); 
if (couponAplied == true)
{
    Console.WriteLine("you've aplied the 15% discount for fish!");  
}
double rest = Math.Round(finalPrice - yourBalance, 2);
if (finalPrice > yourBalance)
    {
        Console.WriteLine($"you are short by {rest} ");
    }
    else {Console.WriteLine($"final Price is: {finalPrice}"); }
Console.ReadKey();
