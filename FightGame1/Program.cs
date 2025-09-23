int GoodHP = 100; //player HP
int EvilHP = 100; //CPU HP


Console.WriteLine("Super Gambling KPow pig fighter 4 \nPress ENTER to start");
Console.ReadLine();

Console.WriteLine("What is your name, my true gambling warrior?"); //asking for name 
string GoodName = Console.ReadLine();
while (GoodName.Length < 3 || GoodName.Length > 10)
{
    Console.WriteLine("Please enter a name between 3 and 10 characters long"); //if invalid
    GoodName = Console.ReadLine();
}


Console.WriteLine("Your opponent will be one of three competent warriors");
List<string> EvilNames = new List<string> { "Osukaru", "Glass Joe", "Frankuraru" };
Random rnd = new Random();
string EvilName = EvilNames[rnd.Next(EvilNames.Count)];

while (EvilHP > 0 && GoodHP > 0) //Randomly gen hp loss until someone dies
{
    Console.WriteLine($"{GoodName} has {GoodHP}HP");
    Console.WriteLine($"{EvilName} has {EvilHP}HP");
    Console.ReadLine();
    int GoodDmg = Random.Shared.Next(20);
    int EvilDmg = Random.Shared.Next(20);
    EvilHP -= GoodDmg;
    GoodHP -= EvilDmg;
}

//Endings
if (EvilHP == GoodHP)
{
    Console.WriteLine("Draw! Play again now!! Bet MONEY ON IT!!!!");
    Console.ReadLine();
}
else if (EvilHP <= 0)
{
    Console.WriteLine("You win! Now play again!!!");
    Console.ReadLine();
}
else if (GoodHP <= 0)
{
    Console.WriteLine("LOSER!!! HAHA, PLAY AGAIN!!!");
    Console.ReadLine();
}