Console.WriteLine("Compare Two Strings App\n");

string stringOne;
string stringTwo;

Console.WriteLine("Please enter the first String: ");
stringOne = Console.ReadLine();

Console.WriteLine("\nPlease enter the second String: ");
stringTwo = Console.ReadLine();

if (stringOne == stringTwo)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nThese two Strings are equal.");
} 
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nThese two Strings are different.");
}

Thread.Sleep(2000);

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\nPlease press any key to quit the program.");
Console.ReadKey();
Environment.Exit(0);
