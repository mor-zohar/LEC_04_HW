// See https://aka.ms/new-console-template for more information

Console.WriteLine("--------------------------------------------");
Console.WriteLine("---------------- LEC_04_HW: ----------------");
Console.WriteLine("--------------------------------------------\n");

Console.WriteLine("------------- EX 1: -------------");
Console.WriteLine("---------------------------------\n");

Console.WriteLine("How Much Units You Want To Buy?");
int units = int.Parse(Console.ReadLine());

// A)

if(units > 1)
{
    Console.WriteLine("Do You Want To Duplicate The Amount For 100 ILS?\nYES = 1\nNO = 0");
    int choice = int.Parse(Console.ReadLine());
    if (choice == 1)
    {
        Console.WriteLine("Great Thank You !!");
        Console.WriteLine("Your Current Amount is: {0}",units*2);
    }
    else
    {
        Console.WriteLine("Has You Wish :)");
        Console.WriteLine("You chose To Buy {0} Units", units);
    }
    
}

// B)
else if(units == 1)
{
    Console.WriteLine("Do You Want To Buy Another Unit For 5 ILS?\nYES = 1\nNO = 0");
    int choice2=int.Parse(Console.ReadLine());
    if (choice2 == 1)
    {
        Console.WriteLine("Glad To Hear !!");
        Console.WriteLine("Your Current Amount is: {0}", units +1);
    }
    else
    {
        Console.WriteLine("Has You Wish :)");
    }
}

// C)
else if (units == 0)
{
    Console.WriteLine("Thank You For Visiting Our Website");
}
