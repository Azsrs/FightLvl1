bool playagain = true; //To ensure game runs first time
int cash = 10; //Money created before loop to make it carry over between
Console.WriteLine("Super Gambling KPow pig fighter 4 \nPress ENTER to start"); //title screen
Console.ReadLine();

Console.WriteLine("What is your name, my true gambling warrior?"); //asking for name 
string GoodName = Console.ReadLine();
while (GoodName.Length < 3 || GoodName.Length > 10)
{
    Console.WriteLine("Please enter a name between 3 and 10 characters long"); //if name invalid
    GoodName = Console.ReadLine();
}

while (playagain == true)
{

    int GoodHP = 100; //player HP
    int EvilHP = 100; //CPU HP
    playagain = false;



    Console.WriteLine("Your opponent will be one of three competent warriors");
    List<string> EvilNames = new List<string> { "Osukaru", "Glass Joe", "Frankuraru" }; //Picking opponent from list
    Random rnd = new Random();
    string EvilName = EvilNames[rnd.Next(EvilNames.Count)];

    Console.WriteLine("Osukaru, The Destroyer. \nGlass Joe, The Locked in Geeker \nFrankuraru, Master of Deception\n Press enter to reveal your opponent");
    Console.ReadLine();
    Console.WriteLine($"Your opponent will be {EvilName}");

    while (EvilHP > 0 && GoodHP > 0) //Randomly gen hp loss until someone dies
    {
        Console.WriteLine($"{GoodName} has {GoodHP}HP"); //display hp
        Console.WriteLine($"{EvilName} has {EvilHP}HP");
        Console.ReadLine();
        int GoodDmg = Random.Shared.Next(20); //Randomly generate dmg
        int EvilDmg = Random.Shared.Next(20);
        EvilHP -= GoodDmg; //Apply dmg
        GoodHP -= EvilDmg;
    }

    //Endings
    if (EvilHP == GoodHP) //draw
    {
        Console.WriteLine("Draw! Play again now!! Bet MONEY ON IT!!!!");
        Console.ReadLine();
    }
    else if (EvilHP <= 0) //win
    {
        Console.WriteLine("You win! Now play again!!!");
        Console.ReadLine();
    }
    else if (GoodHP <= 0) //loss
    {
        Console.WriteLine("LOSER!!! HAHA, PLAY AGAIN!!!");
        Console.ReadLine();
    }

    Console.WriteLine("\n \nplay again? Yes or no? \n(your progress will not be saved if you don't replay)"); //Ask if want to replay 
    string YN = Console.ReadLine().ToLower();
    while (YN != "yes" && YN != "no")
    {
        Console.WriteLine("Play again? Yes or No?");
        YN = Console.ReadLine();
    }

    if (YN == "yes")
    {
        playagain = true;
    }

}
Console.WriteLine("Okay then! Thanks for playing!"); //Shuts down game if player doesn't want to play again
Thread.Sleep(1050); //Auto shutdown, enough time to read