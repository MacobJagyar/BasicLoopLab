string answer = " ";
int attempts = 0;
string password = "13579";
do
{
    Console.WriteLine("Hello! Please enter the correct door code: ");
    answer = (Console.ReadLine());


    if (answer != password)
    {
        Console.WriteLine("Wrong Code! Please try again\n");
        attempts++;
    }

    if (attempts == 5)
    {
        Console.WriteLine("\nWrong code!\nWARNING: Maximum attempts exceeded.");
        break;
    }

    if (answer == password)
    {
        Console.WriteLine("Welcome Home!");
    }

} while (answer != password);


Console.ReadKey();