// Get players name, age, and favorite object, sets isInjured to false
Console.WriteLine("Before we begin, I would like to ask for a few things...");
Console.WriteLine("First your name, please...");
string playerName = Console.ReadLine();
Console.WriteLine("Now your age, if you'd be so kind...");
int playerAge = int.Parse(Console.ReadLine());
Console.WriteLine("Finally, what is your favorite object?...");
string favoriteObject = Console.ReadLine();
Console.WriteLine("Perfect, now we can begin");
bool isInjured = false;

// Player entering the ruins
Console.WriteLine("You've heard rumors of a strange and valuable artifact in some ancient ruins nearby,");
Console.WriteLine("You pack up some tools and other survival items and head out.");
Console.WriteLine("You make your way to these ruins to find that there seems to be no trace of an entrance,");
Console.WriteLine("All you seem to see is two torches, one lit, one extinguished.");
Console.WriteLine("You can do one of two things,");
Console.WriteLine("You can either light the extinguished torch, or extinguish the lit torch.");
Console.WriteLine("What do you do? (light/extinguish)");

// Players choice to light or extinguish a torch
string choiceOne = Console.ReadLine();
if (choiceOne == "light")
{
    // Player lights the other torch
    Console.WriteLine("You light the other torch,");
    Console.WriteLine("Suddenly a bright glowy door appears between the two torches.");
    Console.WriteLine("You enter the door to see a brightly lit corridor.");
    Console.WriteLine("Due to the fact that the corridor is brightly lit,");
    Console.WriteLine("You notice that there are plenty of traps around and can easily navigate around them.");
}
else if (choiceOne == "extinguish")
{
    // Player extinguishes the other torch, gets injured
    Console.WriteLine("You extinguish the other torch,");
    Console.WriteLine("Suddenly a dark gloomy door appears between the two torches.");
    Console.WriteLine("You enter to what seems to be a pitch-black corridor.");
    Console.WriteLine("Due to the fact that the corridor is super dark,");
    Console.WriteLine("You fail to notice all the traps around you and barely make it the end alive.");
    isInjured = true;

}
else
{
    Console.WriteLine("Invalid Option, please select a valid choice.");
}