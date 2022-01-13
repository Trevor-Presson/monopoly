// See https://aka.ms/new-console-template for more information

//Menu

using monopoly;

Console.WriteLine("Select an Option:");
Console.WriteLine("1: Roll Dice");
var x = new Random();
var y = new Logic();

switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine("1: You rolled dice");
        Console.WriteLine(x.Next(1, 6));
        Console.WriteLine(x.Next(1, 6));
        Console.WriteLine(y.yo());
        break;
}


