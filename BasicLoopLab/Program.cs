/*
 string answer = "";

do
{
    Console.WriteLine("Hello World!");
    Console.Write("Would you like to continue? (y/n) ");
    answer = Console.ReadLine();

} while (answer == "y"); 
 */


///////////////End of exercise 1


/*
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
*/


///////////////End of exercise 2

/*
string answer = " ";

while (answer != "13579")
{
    Console.WriteLine("Hello! Please enter the correct door code: ");
    answer = (Console.ReadLine());
    if (answer != "13579")
    {
        Console.WriteLine("Wrong code!\n");
    } else
    {
        Console.WriteLine("Welcome home!");
    }
}
*/


///////////////End of exercise 3


/*
string answer = " ";
int attempts = 0;

while (answer != "13579")
{
    Console.WriteLine("Hello! Please enter the correct door code: ");
    answer = (Console.ReadLine());
    if (answer != "13579")
    {
        Console.WriteLine("Wrong code!\n");
        attempts++;
    }
    else
    {
        Console.WriteLine("Welcome home!");
    }

    if (attempts == 5)
    {
        Console.WriteLine("WARNING: Maximum attempts exceeded.");
        break;
    }
}
*/

///////////////End of exercise 4


///////////////See the Exercise 5 project













Console.ReadLine();