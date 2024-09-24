// See https://aka.ms/new-console-template for more inform
//WHAT THE FUCK DO YOU MEAN SYNTAX ERROR
//I AM SO FUCKING MAD

int puzzlenumber = 0;
Console.WriteLine("What is your name?");
string myName = Console.ReadLine();

Console.WriteLine("Hello " + myName + ", it is time to solve puzzles! Every number up to 5 presents a new puzzle.");

Console.WriteLine("Choose a puzzle number (1-5):");
puzzlenumber = int.Parse(Console.ReadLine());

if (puzzlenumber == 1)
{
    Console.WriteLine("Complete the sequence: 1, 2, 4, 8, 16, ?");
    string answer = Console.ReadLine();

    if (answer == "32")
    {
        Console.WriteLine("Puzzle 1 complete!");
    }
    else
    {
        Console.WriteLine("Wrong answer. Try again!");
    }
}
else if (puzzlenumber == 2)
{
    Console.WriteLine("What is the username of the repository you got the game from?");
    string answer = Console.ReadLine();

    if (answer == "sylveonemeraldz")
    {
        Console.WriteLine("Congrats");
    }
    else
    {
        Console.WriteLine("Wrong answer. Try again!");
    }
}
else
{
    Console.WriteLine("Sorry, that puzzle is not available.");
}
    
}





