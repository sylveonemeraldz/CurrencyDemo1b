// See https://aka.ms/new-console-template for more inform
int price = 15;
Console.WriteLine("What is your name");
string myName = Console.ReadLine();

Console.WriteLine("Hello " +myName+ " How are you today, would you like my sword? Its only 15 gold, how much do you have?");
int gold = int.Parse(Console.ReadLine());

if (gold < 15)
{
    Console.WriteLine("Sorry, please come again");

}
else if (gold > price) { 
    Console.WriteLine("Do you want the sword? Yes or No?");
    string answer = Console.ReadLine();
    if (answer == "Yes")
    {
        gold = gold - price;
        Console.WriteLine("Thank you! you now have " + gold +  " Gold");
           
            
    }
    else
    {
        Console.WriteLine("Then I'll Be seeing you!");
    }



}
else {
    Console.WriteLine("Please come again later");
}





