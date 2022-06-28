/* string answer = "";

do
{
    Console.WriteLine("Hello World!");
    Console.Write("Would you like to continue? (y/n) ");
    answer = Console.ReadLine();

} while (answer == "y"); */


///////////////End of exercise 1


string answer = " ";

do
{
    Console.Write("Enter a number: ");
    int input = int.Parse(Console.ReadLine());

    for (int i = input; i >= 0; i--)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine(" ");

    for (int i = 0; i <= input; i++)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine(" ");

    Console.WriteLine("Would you like to continue? (y/n)");
    answer = Console.ReadLine();
} while (answer == "y"); 

if (answer == "n")
{
    Console.WriteLine("Goodbye!");
}


///////////////End of exercise 2


















Console.ReadLine();